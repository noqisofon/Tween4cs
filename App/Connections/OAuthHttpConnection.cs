using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Security.Cryptography;


namespace Tween.Connections {


    /**
     * OAuth 認証を使用する HTTP 通信です。HMAC-SHA1 固定になっています。
     */
    public class OAuthHttpConnection : HttpConnection, IHttpConnection {
        /**
         * 
         */
        public OAuthHttpConnection()
            : this( string.Empty, string.Empty, string.Empty, string.Empty,
                    string.Empty, 0, string.Empty, string.Empty ) {
        }
        /**
         * 
         */
        public OAuthHttpConnection(OAuthHttpConnection other)
            : this( other.consumer_key_, other.consumer_secret_, other.access_token_, other.access_secret_,
                    other.authorized_username_, other.authorized_user_id_, other.user_ident_key_, other.user_id_ident_key_ ) {
        }
        /**
         * @param consumer_key
         * @param consumer_secret
         * @param access_token
         * @param access_token_secret
         */
        public OAuthHttpConnection( string consumer_key,
                                    string consumer_secret,
                                    string access_token,
                                    string access_token_secret)
            : this( consumer_key, consumer_secret, access_token, access_token_secret,
                    string.Empty, 0, string.Empty, string.Empty ){
        }
        /**
         * @param consumer_key
         * @param consumer_secret
         * @param access_token
         * @param access_token_secret
         * @param user_identifier
         * @param user_id_identifier
         */
        public OAuthHttpConnection( string consumer_key,
                                    string consumer_secret,
                                    string access_token,
                                    string access_token_secret,
                                    string user_identifier,
                                    string user_id_identifier )
            : this( consumer_key, consumer_secret, access_token, access_token_secret,
                    string.Empty, 0, user_identifier, user_id_identifier) {
        }
        /**
         * @param consumer_key
         * @param consumer_secret
         * @param access_token
         * @param access_token_secret
         * @param username
         * @param user_id
         * @param user_identifier
         * @param user_id_identifier
         */
        public OAuthHttpConnection( string consumer_key,
                                    string consumer_secret,
                                    string access_token,
                                    string access_token_secret,
                                    string username,
                                    long user_id,
                                    string user_identifier,
                                    string user_id_identifier) {
            this.consumer_key_ = consumer_key;
            this.consumer_secret_ = consumer_secret;
            this.access_token_ = access_token;
            this.access_secret_ = access_token_secret;
            this.user_ident_key_ = user_identifier;
            this.user_id_ident_key_ = user_id_identifier;

            this.authorized_username_ = username;
            this.authorized_user_id_ = user_id;
        }


        /**
         * 
         */
        public string AccessToken {
            get { return this.access_token_; }
        }


        /**
         * 
         */
        public string AccessTokenSecret {
            get { return this.access_secret_; }
        }


        /**
         * 
         */
        public string AuthUsername {
            get { return this.authorized_username_; }
        }


        /**
         * 
         */
        public long AuthUserId {
            get { return this.authorized_user_id_; }
            set { this.authorized_user_id_ = value; }
        }


        /**
         * OAuth 認証で指定の URL と HTTP 通信を行い、ストリームを返します。
         * @param       method       HTTP 通信メソッドを表す文字列(GET|HEAD|POST|PUT|DELETE)。
         * @param       request_uri  通信先 URI。
         * @param       param        GET 時のクエリ、または POST 時のエンティティボディ。
         * @param [out] content      HTTP 応答のボディストリーム。
         * @patam       user_agent   ユーザーエージェント名。
         *
         * @return HTTP 応答のステータスコード。
         */
        public HttpStatusCode GetContent( string method,
                                          Uri request_uri,
                                          IDictionary<string, string> param,
                                          ref Stream content,
                                          string user_agent ) {
            if ( string.IsNullOrEmpty( this.access_token_ ) )
                return HttpStatusCode.Unauthorized;

            this.RequestAbort();

            this.streaming_request_ = CreateRequest( method, request_uri, param, false );
            // User-Agent 指定がある場合は付加します。
            if ( !string.IsNullOrEmpty( user_agent ) )
                this.streaming_request_.UserAgent = user_agent;

            // OAuth 認証ヘッダを追加します。
            this.AppendOAuthInfo( this.streaming_request_,
                                  param,
                                  this.access_token_,
                                  this.access_secret_ );

            try {
                HttpWebResponse response = (HttpWebResponse)this.streaming_request_.GetResponse();
                content = response.GetResponseStream();

                return response.StatusCode;
            } catch ( WebException we ) {
                if ( we.Status == WebExceptionStatus.ProtocolError ) {
                    HttpWebResponse response = (HttpWebResponse)we.Response;
                
                    return response.StatusCode;
                }
                throw;
            }
        }
        /**
         * OAuth 認証で指定の URL と HTTP 通信を行い、結果を返します。
         * @param           method       HTTP 通信メソッドを表す文字列(GET|HEAD|POST|PUT|DELETE)。
         * @param           request_uri  通信先 URI。
         * @param           param        GET 時のクエリ、または POST 時のエンティティボディ。
         * @param [out]     content      HTTP 応答の文字列。
         * @patam [out,in]  header_info  HTTP 応答のヘッダ情報。必要なヘッダ名を事前に設定しておくこと。
         * @param           callback     処理終了直前に呼ばれるコールバック関数のデリゲート。不要な場合は null を渡すこと。
         *
         * @return HTTP 応答のステータスコード。
         */
        public HttpStatusCode GetContent( string method,
                                          Uri request_uri,
                                          IDictionary<string, string> param,
                                          ref string content,
                                          IDictionary<string, string> header_info,
                                          CallbackDelegate callback ) {
            if ( string.IsNullOrEmpty( this.access_token_ ) )
                return HttpStatusCode.Unauthorized;

            this.RequestAbort();

            HttpWebRequest request = CreateRequest( method, request_uri, param, false );
            // OAuth 認証ヘッダを追加します。
            this.AppendOAuthInfo( request,
                                  param,
                                  this.access_token_,
                                  this.access_secret_ );

            HttpStatusCode code;
            if ( content == null )
                code = base.GetResponse( request, header_info, false );
            else
                code = base.GetResponse( request, out content, header_info, false );

            if ( callback != null )
                callback( new StackFrame( 1 ).GetMethod().Name, ref code, content );

            return code;
        }
        /**
         * バイナリアップロードを行います。
         */
        public HttpStatusCode GetContent( string method,
                                          Uri request_uri,
                                          IDictionary<string, string> param,
                                          IList<KeyValuePair<string, FileInfo>> binary,
                                          ref string content,
                                          IDictionary<string, string> header_info,
                                          CallbackDelegate callback ) {
            if ( string.IsNullOrEmpty( this.access_token_ ) )
                return HttpStatusCode.Unauthorized;

            this.RequestAbort();

            HttpWebRequest request = CreateRequest( method, request_uri, param, binary, false );
            // OAuth 認証ヘッダを追加します。
            this.AppendOAuthInfo( request,
                                  param,
                                  this.access_token_,
                                  this.access_secret_ );

            HttpStatusCode code;
            if ( content == null )
                code = this.GetResponse( request, header_info, false );
            else
                code = this.GetResponse( request, out content, header_info, false );

            if ( callback != null )
                callback( new StackFrame( 1 ).GetMethod().Name, ref code, content );

            return code;
        }


        /**
         * 
         */
        public void RequestAbort() {
            try {
                if ( this.streaming_request_ != null ) {
                    this.streaming_request_.Abort();
                    this.streaming_request_ = null;
                }
            } catch ( Exception ) {
            }
        }


        /**
         * OAuth 認証のアクセストークンを XAuth 方式で取得します。
         * @param       access_token_uri  アクセストークンの取得先 URL。
         * @param       username          認証用ユーザー名。
         * @param       password          認証用パスワード。
         * @param [out] content
         *
         * @return 取得結果 HTTP ステータスコード。
         */
        public HttpStatusCode Authenticate(Uri access_token_uri, string username, string password, out string content) {
            // ユーザー名、パスワードをチェックします。
            if ( string.IsNullOrEmpty( username ) )
                throw new ArgumentException( "username", "Sequence error. (username is blank)" );
            if ( string.IsNullOrEmpty( password ) )
                throw new ArgumentException( "password", "Sequence error. (password is blank)" );

            // XAuth の拡張パラメータを設定します。
            IDictionary<string, string> palams = new Dictionary<string, string>();
            palams.Add( "x_auth_mode", "client_auth" );
            palams.Add( "x_auth_username", username );
            palams.Add( "x_aut_password", password );

            HttpStatusCode status_code = GetOAuthToken( access_token_uri,
                                                        string.Empty,
                                                        string.Empty,
                                                        palams,
                                                        out content );
            if ( status_code != HttpStatusCode.OK )
                return status_code;

            //IDictionary<string, string> access_token_data = ParseQueryString( content );
            IDictionary<string, string> access_token_data = ParseQueryString( content );
            if ( access_token_data != null ) {
                this.access_token_ = access_token_data["oauth_token"];
                this.access_secret_ = access_token_data["oauth_token_secret"];
                //
                // サービスごとの独自拡張対応。
                //
                if ( this.user_ident_key_ != string.Empty )
                    this.authorized_username_ = access_token_data[this.user_ident_key_];
                else
                    this.authorized_username_ = string.Empty;

                if ( this.user_id_ident_key_ != string.Empty ) {
                    try {
                        this.authorized_user_id_ = Convert.ToInt64( access_token_data[this.user_id_ident_key_] );
                    } catch ( Exception ) {
                        this.authorized_user_id_ = 0;
                    }
                } else
                    this.authorized_user_id_ = 0;

                if ( this.access_token_ == string.Empty )
                    throw new InvalidDataException( "Token is null" );

                //return HttpStatusCode.OK;
                return status_code;
            } else
                throw new InvalidDataException( "Return value is null" );
        }


        /**
         * OAuth 認証開始要求を行います(リクエストトークン取得)。PIN 入力用の前段。
         * <p>
         * 呼び出し元では戻された url をブラウザで開き、認証完了後、PIN 入力を受け付け、リクエストトークンと共に AuthenticatePinFlow を呼び出してください。
         * </p>
         * @param       request_token_url  リクエストトークンの取得先 URL。
         * @param       request_url        ブラウザで開く認証用 URL のベース。
         * @param [out] request_token      認証要求で戻されるリクエストトークン。使い捨て。
         * @param [out] auth_uri           request_url を元に生成された認証用 URL。通常はリクエストトークンをクエリとして付加した Uri オブジェクト。
         *
         * @return 成功したら真。
         */
        public bool AuthenticatePinFlowRequest(string request_token_url, string request_url, ref string request_token, out Uri authorize_uri) {
            authorize_uri = this.GetAuthenticatePageUri( request_token_url, request_url, out request_token );

            return authorize_uri == null? false: true;
        }


        /**
         * OAuth 認証のアクセストークンを取得します。PIN 入力用の後段です。
         * <p>
         * 事前に AuthenticatePinFlowRequest メソッドを呼んでから、ブラウザで認証後に表示される PIN を入力してもらい、その値と共に呼び出すこと。
         * </p>
         * @param request_token_url  アクセストークンの取得先 URL。
         * @param request_uri        AuthenticatePinFlowRequest メソッドで取得したリクエストトークン。
         * @param pin_code           Web で認証後に表示される PIN コード。
         *
         * @return 取得結果 HTTP ステータスコード。
         */
        public HttpStatusCode AuthenticatePinFlow(string request_token_url, string request_token, string pin_code) {
            if ( string.IsNullOrEmpty( request_token ) )
                throw new ArgumentException( "request_token", "Sequence error. (request_token is blank)" );

            // 
            // アクセストークンを取得します。
            //
            string content = string.Empty;
            IDictionary<string, string> access_token_data = null;
            HttpStatusCode status_code = this.GetOAuthToken( new Uri( request_token_url ),
                                                        pin_code,
                                                        request_token,
                                                        null,
                                                        out content );

            if ( status_code != HttpStatusCode.OK )
                return status_code;
            
            access_token_data = ParseQueryString( content );

            if ( access_token_data != null ) {
                this.access_token_ = access_token_data["oauth_token"];
                this.access_secret_ = access_token_data["oauth_token_secret"];
                //
                // サービスごとの独自拡張対応。
                //
                if ( this.user_ident_key_ != string.Empty )
                    this.authorized_username_ = access_token_data[this.user_ident_key_];
                else
                    this.authorized_username_ = string.Empty;

                if ( this.user_id_ident_key_ != string.Empty ) {
                    try {
                        this.authorized_user_id_ = Convert.ToInt64( access_token_data[this.user_id_ident_key_] );
                    } catch ( Exception ) {
                        this.authorized_user_id_ = 0;
                    }
                } else
                    this.authorized_user_id_ = 0;

                if ( this.access_token_ == string.Empty )
                    throw new InvalidDataException( "Token is null" );

                //return HttpStatusCode.OK;
                return status_code;
            } else
                throw new InvalidDataException( "Return value is null" );
        }


        /**
         * OAuth 認証のリクエストトークンを取得します。リクエストトークンと組み合わせた認証用の Uri オブジェクトも生成して返します。
         * @param       request_token_url  リクエストトークンの取得先 URL。
         * @param       authorize_url      ブラウザで開く認証用 URL のベース。
         * @param [out] request_token      取得したリクエストトークン。
         * 
         * @return リクエストトークン認証用 Uri オブジェクト。
         */
        private Uri GetAuthenticatePageUri(string request_token_url, string authorize_url, out string request_token) {
            const string token_key = "oauth_token";
            
            request_token = string.Empty;
            // 
            // リクエストトークンを取得します。
            //
            string content = string.Empty;
            IDictionary<string, string> request_token_data;
            if ( GetOAuthToken( new Uri( request_token_url ),
                                string.Empty,
                                string.Empty,
                                null,
                                out content ) != HttpStatusCode.OK )
                return null;

            request_token_data = ParseQueryString( content );
            
            if ( request_token_data != null ) {
                request_token = request_token_data[token_key];
                // Uri オブジェクトを生成します。
                UriBuilder uri_builder = new UriBuilder( authorize_url );
                uri_builder.Query = string.Format( "{0}={1}", token_key, request_token );

                return uri_builder.Uri;
            } else
                return null;
        }


        /**
         * OAuth 認証トークン取得用の共通処理です。
         */
        private HttpStatusCode GetOAuthToken(Uri request_uri, string pin_code, string request_token, IDictionary<string, string> palams, out string content) {
            HttpWebRequest request = null;
            // 
            // HTTP リクエストを生成します。
            // PIN コードもパラメータも未指定の場合は GET メソッドで通信します。それ以外は POST メソッドを遣います。
            //
            if ( string.IsNullOrEmpty( pin_code ) && palams == null )
                request = CreateRequest( "GET", request_uri, null, false );
            else
                request = CreateRequest( "GET", request_uri, palams, false );  // ボディに追加パラメータを書き込みます。
            // 
            // OAuth 関連パラメータを準備します。
            // 追加パラメータがあれば追加します。
            //
            IDictionary<string, string> query = new Dictionary<string, string>();
            if ( palams != null ) {
                foreach ( KeyValuePair<string, string> pair in palams ) {
                    query.Add( pair.Key, pair.Value );
                }
            }
            // PIN コードが指定されていればパラメータに追加します。
            if ( !string.IsNullOrEmpty( pin_code ) )
                query.Add( "oauth_verifier", pin_code );
            // OAuth 関連情報を HTTP リクエストに追加します。
            AppendOAuthInfo( request, query, request_token, string.Empty );
            // HTTP 応答を取得します。
            IDictionary<string, string> header = new Dictionary<string, string>();
            header["Date"] = string.Empty;
            HttpStatusCode status_code = base.GetResponse( request, out content, header, false );

            if ( status_code == HttpStatusCode.OK )
                return status_code;

            if ( !string.IsNullOrEmpty( header["Date"] ) ) {
                //content
                StringBuilder builder = new StringBuilder( content );

                builder.Append( Environment.NewLine );
                builder.Append( "Check the Date & Time of this computer." ).Append( Environment.NewLine );
                builder.AppendFormat( "Sever:{0}", DateTime.Parse( header["Date"] ) );
                builder.AppendFormat( "PC:{0}", DateTime.Now );

                content = builder.ToString();
            }
            return status_code;
        }


        /**
         * HTTP リクエストに OAuth 関連ヘッダを追加します。
         * @param request       追加対象の HTTP リクエスト。
         * @param query         OAuth 追加情報、クエリまたは POST データ。
         * @param token         アクセストークン、もしくはリクエストトークン。未取得の場合空文字列。
         * @param token_secret  アクセストークンシークレット。認証処理では空文字列。
         */
        protected virtual void AppendOAuthInfo(HttpWebRequest request, IDictionary<string, string> query, string token, string token_secret) {
            // OAuth 共通情報を取得します。
            IDictionary<string, string> palams = GetOAuthParameter( token );
            // OAuth 共通情報に query 情報を負荷します。
            if ( query != null ) {
                foreach ( KeyValuePair<string, string> item in query ) {
                    palams.Add( item.Key, item.Value );
                }
            }
            // 署名の作成・追加を行います。
            palams.Add( "oauth_signature", this.CreateSignature( token_secret, request.Method, request.RequestUri, palams ) );
            // HTTP リクエストのヘッダに追加します。
            StringBuilder buffer = new StringBuilder( "OAuth " );
            foreach ( KeyValuePair<string, string> item in palams ) {
                // 各種情報のうち、'oauth_' で始まる情報のみ、ヘッダに追加します。
                // 各情報はカンマ区切り、データはダブルクォーテーションでくくります。
                if ( item.Key.StartsWith( "oauth_" ) )
                    buffer.AppendFormat( "{0}=\"{1}\",", item.Key, UrlEncode( item.Value ) );
            }
            request.Headers.Add( HttpRequestHeader.Authorization, buffer.ToString() );
        }


        /**
         * OAuth で使用する共通情報を持った IDictionary<string, string> インスタンスを取得します。
         * @param token  アクセストークン、もしくはリクエストトークン。未取得なら空文字列。
         *
         * @return OAuth で使用する共通情報を持った IDictionary<string, string> インスタンス。
         */
        protected IDictionary<string, string> GetOAuthParameter(string token) {
            IDictionary<string, string> palams = new Dictionary<string, string>();

            palams.Add( "oauth_consumer_key", this.consumer_key_ );
            palams.Add( "oauth_signature_method", "HMAC-SHA1" );
            palams.Add( "oauth_timespamp", Convert.ToInt64( (DateTime.UtcNow - UnixEpoch) ).ToString() );  // epoch 秒。
            palams.Add( "oauth_nonce", NonceRandom.Next( 123400, 9999999 ).ToString() );
            palams.Add( "oauth_version", "1.0" );
            // トークンがあれば追加します。
            if ( !string.IsNullOrEmpty( token ) )
                palams.Add( "oauth_token", token );

            return palams;
        }


        /**
         * OAuth 認証ヘッダの署名を作成して返します。
         */
        protected virtual string CreateSignature(string token_secret, string method, Uri uri, IDictionary<string, string> palams) {
            // params をソート済みディクショナリに詰め替えます。
            SortedDictionary<string, string> sorted_params = new SortedDictionary<string, string>( palams );
            // URL エンコード済みのクエリ形式文字列に変換します。
            string param_string = CreateQueryString( sorted_params );
            // アクセス先 URL の整形をおこないます。
            string url = string.Format( "{0}://{1}{2}", uri.Scheme, uri.Host, uri.AbsolutePath );
            // 署名のベース文字列を生成します('&' 区切り)。クエリ形式文字列は再エンコードします。
            string sigunature_base = string.Format( "{0}&{1}&{2}", method, UrlEncode( url ), UrlEncode( param_string ) );
            // 署名鍵の文字列をコンシューマー秘密鍵とアクセストークン秘密鍵から生成します('&' 区切りです。
            // アクセストークン秘密鍵が無くても '&' を残すようにしてください)。
            StringBuilder key_builder = new StringBuilder( UrlEncode( this.consumer_secret_ ) ).Append( "&" );

            if ( !string.IsNullOrEmpty( token_secret ) )
                key_builder.Append( UrlEncode( token_secret ) );
            // 
            // 鍵と署名を生成します。
            // 
            using ( HMACSHA1 hmac = new HMACSHA1( Encoding.ASCII.GetBytes( key_builder.ToString() ) ) ) {
                byte[] hash = hmac.ComputeHash( Encoding.ASCII.GetBytes( sigunature_base ) );

                return Convert.ToBase64String( hash );
            }
        }


        /**
         * OAuth のアクセストークン。
         */
        private string access_token_;
        /**
         * OAuth の署名作成用秘密アクセストークン。
         */
        private string access_secret_;
        /**
         * OAuth のコンシューマ鍵。
         */
        private string consumer_key_;
        /**
         * OAuth の署名作成用秘密コンシューマーデータ。
         */
        private string consumer_secret_;
        /**
         * 認証成功時の応答でユーザー ID 情報を取得する場合のキー。設定しない場合は AuthUsername もブランクのままとなる。
         */
        private string user_ident_key_;
        /**
         * 認証成功時の応答でユーザー ID 情報を取得する場合のキー。設定しない場合は AuthUsername もブランクのままとなる。
         */
        private string user_id_ident_key_;
        /**
         * 認証完了時の応答から user_ident_key_ 情報に基づいて取得するユーザー情報。
         */
        private string authorized_username_;
        /**
         * 認証完了時の応答から user_ident_key_ 情報に基づいて取得するユーザー情報。
         */
        private long authorized_user_id_;
        /**
         * Stream 用の HttpWebRequest。
         */
        private HttpWebRequest streaming_request_;


        /**
         * OAuth 署名の oauth_timestamp 算出用基準日付(1970-01-01 00:00:00)。
         */
        private static readonly DateTime UnixEpoch = new DateTime( 1970, 1, 1, 0, 0, 0, DateTimeKind.Unspecified );
        /**
         * OAuth 署名の oauth_nonce 算出用乱数オブジェクト。
         */
        private static readonly Random NonceRandom = new Random();
    }


}
// Local Variables:
//   coding: utf-8
//   mode: ecmascript
// End: