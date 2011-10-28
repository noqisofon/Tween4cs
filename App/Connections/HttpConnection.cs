using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;


namespace Tween.Connections {


    /**
     * 
     */
    public class HttpConnection {
        /**
         * 通信クラスの初期化処理です。タイムアウト値とプロキシを設定します。
         */
        public static void InitializeConnection( int timeout,
                                                 ProxyType proxy_type,
                                                 string proxy_address,
                                                 int proxy_port,
                                                 string proxy_user,
                                                 string proxy_password) {
            __is_initialized = true;
            ServicePointManager.Expect100Continue = false;
            DefaultTimeout = timeout * 1000;  // 秒を㍉秒に変換しておきます。

            switch ( proxy_type ) {
                case ProxyType.None:
                    __web_proxy = null;
                    break;

                case ProxyType.Specified:
                    __web_proxy = new WebProxy( string.Format( "http://{0}:{1}", proxy_address, proxy_port ) );
                    if ( string.IsNullOrEmpty( proxy_user ) || !string.IsNullOrEmpty( proxy_password ) )
                        __web_proxy.Credentials = new NetworkCredential( proxy_user, proxy_password );
                    break;

                case ProxyType.IE:
                    // IE(システム設定)はデフォルト値なので、処理しません。
                    break;
            }
            __proxy_kind = proxy_type;
#if _WINDOWS
            WIN32API.SetProxy( proxy_type, proxy_address, proxy_port, proxy_user, proxy_password );
#else
            WebProxy.SetProxy( proxy_type, proxy_address, proxy_port, proxy_user, proxy_password );
#endif
        }


        /**
         * 通信タイムアウト時間(ms)を取得、設定します。10〜120 秒の範囲で指定し、値が範囲外になった場合は 20 秒に固定されます。
         */
        protected int InstanceTimeout {
            get { return this.timeout_; }
            set {
                const int TimeoutMinValue = 10000;
                const int TimeoutMaxValue = 120000;

                if ( value < TimeoutMinValue || value > TimeoutMaxValue ) {
                    throw new ArgumentOutOfRangeException( string.Format( "instanceTimeout({0} - {1}) put: {2}", TimeoutMinValue, TimeoutMaxValue, value ) );
                }
                this.timeout_ = value;
            }
        }


        /**
         * 通信タイムアウト時間(ms)を取得、設定します。10〜120 秒の範囲で指定し、値が範囲外になった場合は 20 秒に固定されます。
         */
        protected static int DefaultTimeout {
            get { return __timeout; }
            set {
                const int TimeoutMinValue = 10000;
                const int TimeoutMaxValue = 120000;
                const int TimeoutDefaultValue = 20000;

                if ( value < TimeoutMinValue || value > TimeoutMaxValue )
                    __timeout = TimeoutDefaultValue;
                else
                    __timeout = value;
            }
        }

        
        /**
         * HttpWebRequest オブジェクトを作成して返します。パラメータは GET/HEAD/DELETE ではクエリに、POST/PUT ではエンティティボディに変換されます。
         * <p>
         * 追加で必要となる HTTP ヘッダや通信オプションなどは呼び出し元で付加するようにしてください。
         * (Timeout, AutomaticDecompression, AllowAutoRedirect, UserAgent, ContentType, HttpReqestHeader, Authorization, それ以外のカスタムヘッダ)
         * POST/PUT でクエリが必要な場合は、request_uri に含めるようにしてください。
         * </p>
         * @param  method      HTTP 通信メソッドの種類(POST/PUT)。
         * @param  request_uri 通信先 URI 。
         * @param  param       GET 時のクエリ、または POST 時のエンティティボディ。
         * @param  with_cookie 通信に cookie を使用するかどうか。
         *
         * @return 指定された内容を反映した HttpWebRequest オブジェクト。
         */
        protected HttpWebRequest CreateRequest(string method, Uri request_uri, IDictionary<string, string> param, bool with_cookie) {
            if ( __is_initialized )
                throw new Exception( "Sequence error(not initialized)" );
            /* 
             * GET メソッドの場合はクエリと url を結合しておきます。
             */
            UriBuilder uri_builder = new UriBuilder( request_uri.AbsoluteUri );
            if ( param != null && (method == PostMethod || method == GetMethod || method == HeadMethod) ) {
                uri_builder.Query = CreateQueryString( param );
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create( uri_builder.Uri );
            request.ReadWriteTimeout = 90 * 1000;  // Stream の読み込みは 90 秒でタイムアウトすることにします(デフォルトは 5 分です)。
            /*
             * プロキシ設定を行います。
             */
            if ( __proxy_kind != ProxyType.IE )
                request.Proxy = __web_proxy;

            request.Method = method;
            if ( method == PostMethod || method == PutMethod ) {
                request.ContentType = "application/x-www--form-urlencoded";
                // POST/PUT メソッドの場合は、ボディデータとしてクエリ構成して書き込みします。
                using ( StreamWriter writer = new StreamWriter( request.GetRequestStream() ) ) {
                    writer.Write( CreateQueryString( param ) );
                }
            }
            // クッキーの設定です。
            if ( with_cookie )
                request.CookieContainer = this.__cookie_container;
            // タイムアウトの設定です。
            if ( this.InstanceTimeout > 0 )
                request.Timeout = this.InstanceTimeout;
            else
                request.Timeout = this.DefaultTimeout;

            return request;
        }
        /**
         * HttpWebRequest オブジェクトを作成して返します。multipart でのバイナリアップデート用です。
         * @param  method            HTTP 通信メソッドの種類(POST/PUT)。
         * @param  request_uri       通信先 URI 。
         * @param  param             form-data で指定する名前と文字列の連想配列。
         * @param  binary_file_info  form-data で指定する名前とバイナリファイル情報のリスト。
         * @param  with_cookie       通信に cookie を使用するかどうか。
         *
         * @return 指定された内容を反映した HttpWebRequest オブジェクト。
         */
        protected HttpWebRequest CreateRequest( string method,
                                                Uri request_uri,
                                                IDictionary<string, string> param,
                                                IList<KeyValuePair<string, FileInfo>> binary_file_info,
                                                bool with_cookie ) {
            if ( __is_initialized )
                throw new Exception( "Sequence error(not initialized)" );

            // method は POST, PUT のみ許可します。
            UriBuilder uri_builder = new UriBuilder( request_uri.AbsoluteUri );
            if ( method == GetMethod || method == DeleteMethod || method == HeadMethod )
                throw new ArgumentException( "Method must be `POST' or `PUT'" );
            if ( (param == null || param.Count == 0) && (binary_file_info == null || binary_file_info.Count == 0) )
                throw new ArgumentException( "Data is empty" );

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create( uri_builder.Uri );
            // プロキシの設定を行います。
            if ( __proxy_kind != ProxyType.IE )
                request.Proxy = proxy;
            request.Method = method;

            if ( method == PostMethod || method == PutMethod ) {
                int boundary = Environment.TickCount;

                request.ContentType = string.Format( "multipart/form-data; boundary={0}", boundary );
                using ( Stream request_stream = request.GetRequestStream() ) {
                    StreamWriter writer = new StreamWriter( request_stream, Encoding.UTF8 );
                    writer.NewLine = "\r\n";
                    // POST 送信する文字列データを作成します。
                    if ( param != null ) {
                        foreach ( KeyValuePair<string, string> pair in param ) {
                            writer.WriteFormat( "--{0}", boundary ).WriteLine();
                            writer.WriteFormat( "Content-Diposition: form-data; name=\"{0}\"", pair.Key ).WriteLine().WriteLine();
                            writer.Write( pair.Value ).WriteLine();
                        }
                        writer.Flush();
                    }
                    // POST 送信するバイナリデータを作成します。
                    if ( binary_file_info != null ) {
                        foreach ( KeyValuePair<string, FileInfo> pair in binary_file_info ) {
                            string mime = ContentType.ValueOf( pair.Value.Extension ).ToString();

                            writer.WriteFormat( "--{0}", boundary );
                            writer.WriteLine();
                            writer.WriteFormat( "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\";", pair.Key, pair.Value );
                            writer.WriteLine();
                            writer.WriteFormat( "Content-Type: {0}", mime );
                            writer.WriteLine();
                            if ( mime == "application/octet-stream" ) {
                                writer.Write( "Content-Transfer-Encoding: binary" );
                                writer.WriteLine();
                            }
                            writer.WriteLine();

                            // ファイルを読みだして、HTTP のストリームに書き込みます。
                            using ( FileStream read_stream = new FileStream( pair.Value.FullName, FileMode.Open, FileAccess.Read ) ) {
                                int read_size = 0;
                                byte[] read_bytes = new byte[ 0x1000 ];

                                while ( true ) {
                                    read_size = read_stream.Read( read_bytes, 0, read_bytes.Length );
                                    if ( read_size == 0 )
                                        break;

                                    request_stream.Write( read_bytes, 0, read_bytes.Length );
                                }
                                //read_stream.Close();  // 要らない気がするけど、とりあえず。
                            }  // using ( FileStream read_stream = new FileStream( pair.Value.FullName, FileMode.Open, FileAccess.Read ) )
                            writer.WriteLine();
                        }  // foreach ( KeyValuePair<string, FileInfo> pair in binary_file_info )
                    }  // if ( binary_file_info != null )
                    writer.WriteFormat( "--{0}--", boundary );
                    writer.WriteLine();
                    //request_stream.Close();  // 要らない気がするけど、とりあえず。
                }  // using ( Stream request_stream = request.GetRequestStream() )
            }  // if ( method == PostMethod || method == PutMethod )
            // cookie を設定します。
            if ( with_cookie )
                request.CookieContainer = __cookie_container;
            // タイムアウトを設定します。
            if ( this.InstanceTimeout > 0 )
                request.Timeout = this.InstanceTimeout;
            else
                request.Timeout = DefaultTimeout;

            return request;
        }


        /**
         * HTTP の応答を処理します。応答ボディデータが不要な用途向けです。
         * <p>
         * リダイレクト応答の場合(AllowAutoRedirect=False の場合のみ)は、header_info オブジェクトがあれば Location を追加してリダイレクト先を返却します。
         * WebException はハンドルしていないので、呼び出し元でキャッチしてください。
         * </p>
         * @param          request        HTTP 通信リクエストオブジェクト。
         * @param [in/out] header_info    HTTP 応答のヘッダ情報。ヘッダ名をキーにして空文字列のコレクションを渡すことで、該当ヘッダの値を設定して戻す。
         * @param          with_cookie    真なら通信に cookie を使用する。
         *
         * @return HTTP 応答のステータスコード。
         */
        protected HttpStatusCode GetResponse( HttpWebRequest request,
                                              IDictionary<string, string> header_info,
                                              bool with_cookie) {
            try {
                using ( HttpWebResponse response = (HttpWebResponse)WebResponse.GetResponse() ) {
                    HttpStatusCode status_code = response.StatusCode;
                    // cookie を保持します。
                    if ( with_cookie )
                        SaveCookie( response.Cookies );

                    // リダイレクト応答の場合はリダイレクト先を設定します。
                    GetHeaderInfo( response, header_info );
                    
                    return status_code;
                }  // using ( HttpWebResponse response = (HttpWebResponse)WebResponse.GetResponse() )
            } catch ( WebException we ) {
                if ( we.Status == WebExceptionStatus.ProtocolError ) {
                    HttpWebResponse response = (HttpWebResponse)we.Response;
                    GetHeader( response, header_info );
                    return response.StatusCode;
                }
                throw ;
            }
        }
        /**
         * HTTP の応答を処理し、応答ボディデータを Image として返却します。
         * <p>
         * リダイレクト応答の場合(AllowAutoRedirect=False の場合のみ)は、header_info オブジェクトがあれば Location を追加してリダイレクト先を返却します。
         * WebException はハンドルしていないので、呼び出し元でキャッチしてください。
         * </p>
         * @param          request        HTTP 通信リクエストオブジェクト。
         * @param [out]    content        HTTP 応答のボディデータを書き込む Image オブジェクト。
         * @param [in/out] header_info    HTTP 応答のヘッダ情報。ヘッダ名をキーにして空文字列のコレクションを渡すことで、該当ヘッダの値を設定して戻す。
         * @param          with_cookie    真なら通信に cookie を使用する。
         *
         * @return HTTP 応答のステータスコード。
         */
        protected HttpStatusCode GetResponse( HttpWebRequest request,
                                              out Image content,
                                              IDictionary<string, string> header_info,
                                              bool with_cookie) {
            try {
                using ( HttpWebResponse response = (HttpWebResponse)WebResponse.GetResponse() ) {
                    HttpStatusCode status_code = response.StatusCode;
                    // cookie を保持します。
                    if ( with_cookie )
                        SaveCookie( response.Cookies );

                    // リダイレクト応答の場合はリダイレクト先を設定します。
                    GetHeaderInfo( response, header_info );
                    content = new Bitmap( reponse.GetResponseStream() );
                    
                    return status_code;
                }  // using ( HttpWebResponse response = (HttpWebResponse)WebResponse.GetResponse() )
            } catch ( WebException we ) {
                if ( we.Status == WebExceptionStatus.ProtocolError ) {
                    HttpWebResponse response = (HttpWebResponse)we.Response;
                    GetHeader( response, header_info );

                    return response.StatusCode;
                }
                throw ;
            }
        }
        /**
         * HTTP の応答を処理し、引数で指定されたストリームに書き込みます。
         * <p>
         * リダイレクト応答の場合(AllowAutoRedirect=False の場合のみ)は、header_info オブジェクトがあれば Location を追加してリダイレクト先を返却します。
         * WebException はハンドルしていないので、呼び出し元でキャッチしてください。
         * gzip ファイルのダウンロードを想定しているため、他形式の場合は伸長時に問題が発生する場合があります。
         * </p>
         * @param          request        HTTP 通信リクエストオブジェクト。
         * @param [out]    content_stream HTTP 応答のボディストリームのコピー先。
         * @param [in/out] header_info    HTTP 応答のヘッダ情報。ヘッダ名をキーにして空文字列のコレクションを渡すことで、該当ヘッダの値を設定して戻す。
         * @param          with_cookie    真なら通信に cookie を使用する。
         *
         * @return HTTP 応答のステータスコード。
         */
        protected HttpStatusCode GetResponse( HttpWebRequest request,
                                              Stream content_stream,
                                              IDictionary<string, string> header_info,
                                              bool with_cookie) {
            try {
                using ( HttpWebResponse response = (HttpWebResponse)WebResponse.GetResponse() ) {
                    HttpStatusCode status_code = response.StatusCode;
                    // cookie を保持します。
                    if ( with_cookie )
                        SaveCookie( response.Cookies );

                    // リダイレクト応答の場合はリダイレクト先を設定します。
                    GetHeaderInfo( response, header_info );
                    // 応答ストリームをコピーして戻します。
                    if ( response.ContentLength > 0 ) {
                        // gzip なら応答ストリームの内容は伸長済みですが、それ以外なら伸長します。
                        if ( response.ContentEncoding == "gzip" || response.ContentEncoding == "deflate" ) {
                            using ( Stream stream = response.GetResponseStream() ) {
                                if ( stream != null )
                                    CopyStream( stream, content_stream );
                            }
                        } else {
                            using ( Stream stream = new GZipStream( response.GetResponseStream(), CompresstionMode.Decompress ) ) {
                                if ( stream != null )
                                    CopyStream( stream, content_stream );
                            }
                        }
                    }  // if ( response.ContentLength > 0 )
                    return status_code;
                }  // using ( HttpWebResponse response = (HttpWebResponse)WebResponse.GetResponse() )
            } catch ( WebException we ) {
                if ( we.Status == WebExceptionStatus.ProtocolError ) {
                    HttpWebResponse response = (HttpWebResponse)we.Response;
                    GetHeader( response, header_info );
                    return response.StatusCode;
                }
                throw ;
            }
        }
        /**
         * HTTP の応答を処理し、応答ボディデータを文字列として返します。
         * <p>
         * 
         * </p>
         * @param          request        HTTP 通信リクエストオブジェクト。
         * @param [out]    content_text   HTTP 応答のボディデータ。
         * @param [in/out] header_info    HTTP 応答のヘッダ情報。ヘッダ名をキーにして空文字列のコレクションを渡すことで、該当ヘッダの値を設定して戻す。
         * @param          with_cookie    真なら通信に cookie を使用する。
         *
         * @return HTTP 応答のステータスコード。
         */
        protected HttpStatusCode GetResponse( HttpWebRequest request,
                                              out string content_text,
                                              IDictionary<string, string> header_info,
                                              bool with_cookie) {
            try {
                using ( HttpWebResponse response = (HttpWebResponse)request.GetResponse() ) {
                    HttpStatusCode status_code = response.StatusCode;
                    // cookie を保持します。
                    if ( with_cookie )
                        SaveCookie( response.Cookies );
                    // リダイレクト応答の場合は、リダイレクト先を設定します。
                    GetHeaderInfo( response, header_info );
                    // 応答ストリームをテキストに書き出します。
                    using ( StreamReader reader = new StreamReader( response.GetResponseStream() ) ) {
                        content_text = reader.ReadToEnd();
                    }
                    return status_code;
                }  // using ( HttpWebResponse response = (HttpWebResponse)request.GetResponse() )
            } catch ( WebException we ) {
                if ( we.Status == WebExceptionStatus.ProtocolError ) {
                    HttpWebResponse response = (HttpWebResponse)we.Response;
                    GetHeaderInfo( response, header_info );
                    using ( StreamReader reader = new StreamReader( response.GetResponseStream() ) ) {
                        content_text = reader.ReadToEnd();
                    }
                    return response.StatusCode;
                }
            }
        }
            

        /**
         * クエリコレクションを "key=value" 形式の文字列に構成して返します。
         * @param  param クエリ、またはポストデータとなる key-value コレクション。
         */
        protected string CreateQueryString(IDictionary<string, string> param) {
            if ( param == null || param.Count == 0 )
                return string.Empty;

            StringBuilder query_builder = new StringBuilder();
            foreach ( string key in param.Keys ) {
                query_builder.AppendFormat( "{0}={1}&", UrlEncode( key ), UrlEncode( param[key] ) );
            }
            return query_builder.ToString( 0, query_builder.Length - 1 );
        }


        /**
         * クエリ形式の(key1=value1&key2=value2&...)文字列を key-value コレクションに詰め直します。
         * @param  query_string  クエリ文字列。
         *
         * @return key-value コレクション。
         */
        protected IDictionary<string, string> ParseQueryString(string query_string) {
            IDictionary<string, string> query = new Dictionary<string, string>();
            string[] parts = query_string.Split( '&' );

            foreach ( string part in parts ) {
                int index = part.IndexOf( '=' );
                if ( index == -1 )
                    query.Add( Uri.UnescapeDataString( part ), "" );
                else
                    query.Add( Uri.UnescapeDataString( part.Substring( 0, index ) ), Uri.UnescapeDataString( part.Substring( index + 1 ) ) );
            }
            return query;
        }


        /**
         * 2 バイト文字も考慮した URL エンコードメソッドです。
         * @param encodee エンコードする文字列。
         *
         * @return エンコードされた文字列。
         */
        protected string UrlEncode(string encodee) {
            const string[] UnreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

            StringBuilder builder = new StringBuilder();
            byte[] bytes = Encoding.UTF8.GetBytes( encodee );

            foreach ( byte[] b in bytes ) {
                if ( UnreservedChars.IndexOf( (char)b ) != -1 )
                    builder.Append( (char)b );
                else
                    builder.AppendFormat( "%{0:X2}", b );
            }
            return builder.ToString();
        }


        /**
         * 指定されたクッキーを保存します。ホスト名なしのドメインの場合、ドメイン名から先頭のドットを除去して追加しないと再利用できないために必要です。
         * @param cookies  保存するクッキーのコレクション。
         */
        private void SaveCookie(CookieCollection cookies) {
            foreach ( Cookie cookie in cookies ) {
                if ( cookie.Domain.StartsWith( "." ) ) {
                    cookie.Domin = cookie.Domain.Substring( 1, cookie.Domin.Length - 1 );
                    __cookie_container.Add( cookie );
                }
            }
        }


        /**
         * in/out のストリームインスタンスを受け取り、コピーして返します。
         */
        private void CopyStream(Stream input_stream, Stream write_stream) {
            if ( input_stream == null )
                throw new ArgumentNullException( "input_stream" );
            if ( write_stream == null )
                throw new ArgumentNullException( "write_stream" );
            if ( input_stream.CanRead )
                throw new ArgumentException( "Input stream can not read." );
            if ( write_stream.CanWrite )
                throw new ArgumentException( "Output stream can not write" );
            if ( input_stream.CanSeek )
                throw new ArgumentException( "Input stream can not have data." );

            while ( true ) {
                byte[]  buffer = new byte[1024];
                int temp = buffer.Length;
                
                temp = input_stream.Read( buffer, 0, temp );
                if ( temp == 0 )
                    break;
                output_stream.Write( buffer, 0, temp );
            }
        }


        /**
         * header_info のキー情報で指定された HTTP ヘッダ情報を取得・格納します。redirect 応答時は Location ヘッダの内容を追記します。
         * @param          response     HTTP 応答オブジェクト。
         * @param [in/out] header_info  キーにヘッダ名を指定したバリューが空文字列のコレクション。取得した値をバリューにセットして戻す。
         */
        private void GetHeaderInfo(HttpWebResponse response, IDictionary<string, string> header_info) {
            if ( header_info == null )
                return ;

            if ( header_info.Count > 0 ) {
                string[] keys = new string[ header_info.Count ];
                header_info.Keys.CopyTo( keys, 0 );

                foreach ( string key in keys ) {
                    if ( Array.IndexOf( response.Headers.AllKeys, key ) > -1 )
                        header_info[key] = response.Headers[key];
                    else
                        header_info[key] = string.Empty;
                }
            }

            HttpStatsCode status_code = response.StatusCode;
            if ( status_code == HttpStatsCode.MovedPermanently ||
                 status_code == HttpStatsCode.Found ||
                 status_code == HttpStatsCode.SeeOther ||
                 status_code == HttpStatsCode.TemporaryRedirect ) {
                if ( header_info.ContainsKey( "Location" ) )
                    header_info["Location"] = response.Headers["Location"];
                else
                    header_info.Add( "Location", response.Headers["Location"] );
            }
        }


        protected readonly string PostMethod = "POST";
        protected readonly string GetMethod = "GET";
        protected readonly string HeadMethod = "HEAD";
        protected readonly string PutMethod = "PUT";
        protected readonly string DeleteMethod = "DELETE";
        
        
        private int timeout_ = 0;
        
        
        private static int __timeout = 20000;

        /**
         * HTTP コネクションで使用されるプロキシです。
         */
        private static WebProxy __web_proxy = null;
        /**
         * ユーザーが選択したプロキシの方式を表します。
         */
        private static ProxyType __proxy_kind = ProxyType.IE;
        /**
         * クッキー保存用コンテナです。
         */
        private static CookieContainer __cookie_container = new CookieContainer();
        /**
         * 初期化済みフラグ。
         */
        private static bool __is_initialized = false;
    }


}
// Local Variables:
//   coding: utf-8
//   mode: ecmascript
// End:
