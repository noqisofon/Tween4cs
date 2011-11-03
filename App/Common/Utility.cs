//  
//  Utility.cs
//  
//  Author:
//       rihine <ned.rihine@gmail.com>
// 
//  Copyright (c) 2011 rihine All rights reserved.
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
using System;
using System.Collections;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Security.Principal;


namespace Tween.Common {


    /**
     * 
     */
    public static class Utility {
        /**
         * Windows NT 6 カーネル上で動いている時に真を返します。
         */
        public static bool IsNT6 {
            get { return Environment.OSVersion.Platform == PlatformID.Win32NT
                    && Environment.OSVersion.Version.Major == 6; }
        }


        /**
         * 
         */
        public static bool DebugBuild {
            get {
#if DEBUG
                return true;
#else
                return false;
#endif
            }
        }


        /**
         * 
         */
        public static bool IsNetworkAvailable {
            get {
                try {
                    return NetworkInterface.IsNetworkAvailable;
                } catch ( Exception ) {
                    return false;
                }
            }
        }


        /**
         * 
         */
        public static void Trace(string message) {
            Trace( __trace_flag, message );
        }
        /**
         * 
         */
        public static void Trace(Exception e, string message) {
            Trace( __trace_flag, message, RenderException( e ) );
        }
        /**
         * 
         */
        public static void Trace(bool output_flag, string message) {
            Trace( output_flag, message, string.Empty );
        }
        /**
         * 
         */
        public static void Trace(bool output_flag, string message, string what) {
            if ( !string.IsNullOrEmpty( what ) )
                message = string.Format( "{0}{1}{2}", message, Environment.NewLine, what );

            lock ( __sync_object ) {
                if ( output_flag )
                    return ;

                DateTime now = DateTime.Now;
                FileInfo log_file = new FileInfo( string.Format( "tween-trace-{0:yyyy-MM-ddThhmmss}.log", now ) );

                using ( StreamWriter writer = new StreamWriter( log_file.Open( FileMode.OpenOrCreate,
                                                                               FileAccess.Write,
                                                                               FileShare.Read ),
                                                                Encoding.UTF8  ) ) {
                    writer.WriteLine( "**** trace out: {0} ****", DateTime.Now );
                    writer.WriteLine( Tween.Properties.Resources.TraceOutText1 );
                    writer.WriteLine( Tween.Properties.Resources.TraceOutText2 );
                    writer.WriteLine();
                    writer.WriteLine( Tween.Properties.Resources.TraceOutText3 );
                    writer.WriteLine( Tween.Properties.Resources.TraceOutText4, Environment.OSVersion.VersionString );
                    writer.WriteLine( Tween.Properties.Resources.TraceOutText5, Environment.Version );
                    writer.WriteLine( Tween.Properties.Resources.TraceOutText6, __file_version );
                    writer.WriteLine( message );
                    writer.WriteLine();
                }
            }
        }


        /**
         * 
         */
        public static bool TraceWithException(Exception e) {
            lock ( __lock_object ) {
                bool is_terminate_permission = true;
                DateTime now = DateTime.Now;
                FileInfo log_file = new FileInfo( string.Format( "tween-{0:yyyy-MM-ddThhmmss}.log", now ) );

                using ( StreamWriter writer = new StreamWriter( log_file.Open( FileMode.OpenOrCreate,
                                                                               FileAccess.Write,
                                                                               FileShare.Read ),
                                                                Encoding.UTF8  ) ) {
                    WindowsIdentity identity = WindowsIdentity.GetCurrent();
                    WindiwsPrincipal principal = new WindiwsPrincipal( identity );

                    writer.WriteLine( Tween.Properties.Resources.UnhandledExceptionText1, DateTime.Now );
                    writer.WriteLine( Tween.Properties.Resources.UnhandledExceptionText2 );
                    writer.WriteLine( Tween.Properties.Resources.UnhandledExceptionText3 );
                    // 
                    // 権限書き出しを行います。
                    //
                    writer.WriteLine( Tween.Properties.Resources.UnhandledExceptionText11 + principal.IsInRole( WindowsBuiltInRole.Adoministrator ).ToString() );
                    writer.WriteLine( Tween.Properties.Resources.UnhandledExceptionText12 + principal.IsInRole( WindowsBuiltInRole.User ).ToString() );
                    // 
                    // OSVersion とか AppVersion の書き出しを行います。
                    //
                    writer.WriteLine( Tween.Properties.Resources.UnhandledExceptionText4 );
                    writer.WriteLine( Tween.Properties.Resources.UnhandledExceptionText5, Environment.OSVersion.VersionString );
                    writer.WriteLine( Tween.Properties.Resources.UnhandledExceptionText6, Environment.Version );
                    writer.WriteLine( Tween.Properties.Resources.UnhandledExceptionText7, __file_version );

                    writer.Write( RenderException( e, ref is_terminate_permission ) );
                    writer.Flush();
                }

                switch ( MessageBox.Show( string.Format( Tween.Properties.Resources.UnhandledExceptionText9,
                                                         filename,
                                                         Environment.NewLine ) ) ) {
                case DialogResult.Yes:
                    Process.Start( log_file.FullName );

                    return false;
                    break;

                case DialogResult.No:
                    return false;
                    break;

                case DialogResult.Cancel:
                    return is_terminate_permission;
                    break;
                }
            }
        }


        /**
         * 
         */
        public static string RenderException(Exception e) {
            if ( e == null )
                return string.Empty;

            StringBuilder buffer = new StringBuilder();

            buffer.AppendFormat( Tween.Properties.Resources.UnhandledException8, e.GetType().FullName, e.Message ).AppendLine();

            if ( e.Data != null && e.Data.Keys.Count > 0 ) {
                bool need_header = true;

                foreach ( DictionaryEntry entry in e.Data ) {
                    if ( need_header ) {
                        buffer.AppendLine();
                        buffer.AppendLine( "------- extra infomation -------" );

                        need_header = false;
                    }
                    buffer.AppenFormat( "{0}: {1}", entry.Key, entry.Value ).AppendLine();
                    // if ( entry.Key == "IsTerminatePermission" )
                    //     is_terminate_permission = Convert.ToBoolean( entry.Value );
                }
                if ( need_header )
                    buffer.AppendLine( "------- end extra infomation -------" );
            }
            buffer.AppendLine( e.StackTrace ).AppendLine();

            // InnerException に例外が入っている場合はそれも書き出します。
            Exception inner = e.InnerException;
            int nesting = 0;

            while ( inner != null ) {
                buffer.AppendFormat( "------- inner exception at: {0} -------", nesting ).AppendLine();
                buffer.AppendFormat( Tween.Properties.Resources.UnhandledExceptionText8,
                                     inner.GetType().FullName,
                                     inner.Message ).AppendLine();
                if ( inner.Data != null && inner.Data.Keys.Count > 0 ) {
                    bool need_header = true;

                    foreach ( DictionaryEntry entry in inner.Data ) {
                        if ( need_header ) {
                            buffer.AppendLine();
                            buffer.AppendLine( "-------------- extra infomation --------------" );

                            need_header = false;
                        }
                        buffer.AppenFormat( "{0}: {1}", entry.Key, entry.Value ).AppendLine();
                        // if ( entry.Key == "IsTerminatePermission" )
                        //     is_terminate_permission = Convert.ToBoolean( entry.Value );
                    }
                    if ( need_header )
                        buffer.AppendLine( "-------------- end extra infomation --------------" );
                }
                buffer.AppendLine( inner.StackTrace ).AppendLine();

                nesting += 1;
                inner = inner.InnerException;
            }
            return buffer.ToString();
        }
        /**
         * 
         */
        public static string RenderException(Exception e, ref bool is_terminate_permission) {
            if ( e == null )
                return string.Empty;

            StringBuilder buffer = new StringBuilder();

            buffer.AppendFormat( Tween.Properties.Resources.UnhandledException8, e.GetType().FullName, e.Message ).AppendLine();

            if ( e.Data != null && e.Data.Keys.Count > 0 ) {
                bool need_header = true;

                foreach ( DictionaryEntry entry in e.Data ) {
                    if ( need_header ) {
                        buffer.AppendLine();
                        buffer.AppendLine( "------- extra infomation -------" );

                        need_header = false;
                    }
                    buffer.AppenFormat( "{0}: {1}", entry.Key, entry.Value ).AppendLine();
                    if ( entry.Key == "IsTerminatePermission" )
                        is_terminate_permission = Convert.ToBoolean( entry.Value );
                }
                if ( need_header )
                    buffer.AppendLine( "------- end extra infomation -------" );
            }
            buffer.AppendLine( e.StackTrace ).AppendLine();

            // InnerException に例外が入っている場合はそれも書き出します。
            Exception inner = e.InnerException;
            int nesting = 0;
            while ( inner != null ) {
                buffer.AppendFormat( "------- inner exception at: {0} -------", nesting ).AppendLine();
                buffer.AppendFormat( Tween.Properties.Resources.UnhandledExceptionText8,
                                     inner.GetType().FullName,
                                     inner.Message ).AppendLine();
                if ( inner.Data != null && inner.Data.Keys.Count > 0 ) {
                    bool need_header = true;

                    foreach ( DictionaryEntry entry in inner.Data ) {
                        if ( need_header ) {
                            buffer.AppendLine();
                            buffer.AppendLine( "-------------- extra infomation --------------" );

                            need_header = false;
                        }
                        buffer.AppenFormat( "{0}: {1}", entry.Key, entry.Value ).AppendLine();
                        if ( entry.Key == "IsTerminatePermission" )
                            is_terminate_permission = Convert.ToBoolean( entry.Value );
                    }
                    if ( need_header )
                        buffer.AppendLine( "-------------- end extra infomation --------------" );
                }
                buffer.AppendLine( inner.StackTrace ).AppendLine();

                nesting += 1;
                inner = inner.InnerException;
            }
            return buffer.ToString();
        }


        /**
         * 
         */
        public static string UrlEncodeMultiByteChar(string input_url) {
            Uri uri = null;
            StringBuilder buffer = new StringBuilder( 256 );
            string result = string.Empty;
            //char ch = 'd';

            foreach ( char ch in input_url ) {
                if ( Convrt.ToInt32( ch ) > 127 )
                    break;
            }
            if ( Convrt.ToInt32( ch ) > 127 )
                return input_url;

            string input = HttpUtility.UrlDecode( input_url );
            retry:
            foreach ( char ch in input ) {
                if ( Convrt.ToInt32( ch ) > 255 ) {
                    // Unicode の場合(1 文字が複数のバイトで構成されている):
                    // Uri クラスを新しく作成し、入力を PathAndQuery のみとしてやり直します。
                    foreach ( byte b in Encoding.UTF8.GetBytes( ch ) ) {
                        builder.AppendFormat( "%{0X2}", b );
                    }
                } else if ( Convrt.ToInt32( ch ) > 127 || ch == '%' ) {
                    // UTF-8 の場合:
                    // Uri クラスを新しく作成し、入力を input から Authority 部分を除去してやり直します。
                    if ( uri == null ) {
                        uri = new Uri( input );
                        input = input.Remove( 0, uri.GetLeftPart( UriPartial.Authority ).Length );
                        buffer.Length = 0;

                        goto retry;
                    } else
                        builder.AppendFormat( "%{0}", Convert.ToInt16( ch ).ToString( "X2" ).ToUpper() );
                } else
                    builder.Append( ch );
            }  // foreach ( ch in input )

            if ( uri == null )
                result = buffer.ToString();
            else
                result = uri.GetLeftPart( UriPartial.Authority ) + buffer.ToString();

            return result;
        }


        /**
         * URL のドメイン名を Punycode 展開します。
         * <p>
         * ドメイン名が IDN でない場合はそのまま返します。
         * ドメインラベルの区切り文字は FULLSTOP(\U002E) に置き換えられます。
         * </p>
         * @param url 展開対象の URL。
         *
         * @return IDN が含まれていた場合は Punycode に展開した URL を返します。Punycode 展開時にエラーが発生した場合は null を返します。
         */
        public static string IdnDecode(string url) {
            string result = string.Empty;
            IdnMapping idn_convertor = new IdnMapping();

            if ( !url.Contains( "://" ) )
                return null;

            string domain;
            string ascii_domain;

            try {
                domain = url.Split( '/' )[2];
                ascii_domain = idn_convertor.GetAscii( domain );
            } catch ( Exception ) {
                return null;
            }
            return url.Replace( string.Format( "://{0}", domain ), string.Format( "://{0}", ascii_domain ) );
        }


        /**
         * 
         */
        public static void MoveArrayItem(Array values, int index_from, int index_to) {
            object moved_element = values[index_from];
            int moved_count = Math.Abs( index_from -  index_to );

            if ( index_to < index_from )
                Array.Copy( values, index_to, values, index_to + 1, moved_count );
            else
                Array.Copy( values, index_from + 1, values, index_from + 1, moved_count );

            values[index_to] = moved_element;
        }


        /**
         * 
         */
        public static string EncryptString(string s) {
            return EncryptString( s, Encoding.UTF8 );
        }
        /**
         * 
         */
        public static string EncryptString(string s, Encoding encoding) {
            if ( string.IsNullOrEmpty( s ) )
                return string.Empty;
            // 文字列をバイト配列に変換します。
            byte[] bytes_in = encoding.GetBytes( s );
            byte[] bytes_out = null;
            // DESCryptoServiceProvider オブジェクトを作成します。
            DESCryptoServiceProvider crypto_provider = new DESCryptoServiceProvider();

            // 共有キーと初期化ベクタを決定します。
            // パスワードをバイト配列にします。
            byte[] byte_key = encoding.GetBytes( "_tween4cs_encrypt_key_" );
            // 共有キーと初期化ベクタを設定します。
            crypto_provider.Key = ResizeBytesArray( bytes_key, crypto_provider.Key.Length );
            crypto_provider.IV = ResizeBytesArray( bytes_key, crypto_provider.IV.Length );

            // 暗号化されたデータを書き出すための MemoryStream オブジェクトを用意します。
            using ( Stream output_memory_stream = new MemoryStream() ) {
                // DEC 暗号化オブジェクトを作成します。
                using ( ICryptoTransform encryptor = crypto_provider.CreateEncryptor() ) {
                    // 書き込むための CryptoStream オブジェクトを作成します。
                    using ( Stream input_crypt_stream = CryptoStream( output_memory_stream, encryptor, CryptoStreamMode.Write ) ) {
                        // 書き込みます。
                        input_crypt_stream.Write( bytes_in, 0, bytes_in.Length );
                        input_crypt_stream.FlushFinalBlock();

                        // 暗号化されたデータを取得します。
                        bytes_out = output_memory_stream.ToArray();

                        // ストリームを閉じます。
                        /// 自動で閉じられるし、別に閉じなくてもいいんじゃないかなぁ。
                        //input_crypt_stream.Close();
                        //output_memory_stream.Close();
                    }
                }
            }
            // Base64 で文字列に変換してそれを返します。
            return Convert.ToBase64String( bytes_out );
        }


        /**
         * 
         */
        public static string DecryptString(string s, Encoding encoding) {
            if ( string.IsNullOrEmpty( s ) )
                return string.Empty;
            // DESCryptoServiceProvider オブジェクトを作成します。
            DESCryptoServiceProvider crypto_provider = new DESCryptoServiceProvider();
            // 共有キーと初期化ベクタを決定します。
            // パスワードをバイト配列にします。
            byte[] byte_key = encoding.GetBytes( "_tween4cs_encrypt_key_" );
            // 共有キーと初期化ベクタを設定します。
            crypto_provider.Key = ResizeBytesArray( bytes_key, crypto_provider.Key.Length );
            crypto_provider.IV = ResizeBytesArray( bytes_key, crypto_provider.IV.Length );

            // Base64 で文字列をバイト配列に戻します。
            byte[] bytes_in = Convert.FromBase64String( s );
            byte[] bytes_out = null;

            // 暗号化されたデータを読み込むための MemoryStream オブジェクトを用意します。
            string result = string.Empty;
            using ( MemoryStream input_memory_stream = new MemoryStream( bytes_in ) ) {
                // DES 復号化オブジェクトを作成します。
                using ( ICryptoTransform decryptor = crypto_provider.CreateDecryptor() ) {
                    // 読み込むための CryptoStream オブジェクトを作成します。
                    using ( CryptoStream output_crypto_stream = new CryptoStream( input_memory_stream, decryptor, CryptoStreamMode.Read ) ) {
                        // 復元されたデータを取得するための StreamReader オブジェクトを作成します。
                        using ( StreamReader reader = new StreamReader( output_crypto_stream, encoding ) ) {
                            // 複合されたデータを取得します。
                            result = reader.ReadToEnd();
                        }
                    }
                }
            }
            return result;
        }


        /**
         * 
         */
        public static byte[] ResizeBytesArray(byte[] bytes, int new_size) {
            byte[] new_bytes = new byte[new_size - 1];
            if ( bytes.Length <= new_size ) {
                for ( int i = 0; i < bytes.Length - 1; ++ i ) {
                    new_bytes[i] = bytes[i];
                }
            } else {
                int pos = 0;
                for ( int i = 0; i < bytes.Length - 1; ++ i ) {
                    new_bytes[pos] = new_bytes[pos] ^ bytes[i];
                    ++ pos;

                    if ( pos >= new_bytes.Length )
                        pos = 0;
                }
            }
            return new_bytes;
        }


        /**
         * 
         */
        public static string GetUserAgentString() {
            if ( string.IsNullOrEmpty( __file_version ) )
                throw new Exception( "file version is not Initialized" );

            return string.Format( "Tween/{0}", __file_version );
        }


        /**
         * 
         */
        public static bool IsAnimatedGif(string filename) {
            Image image = null;
            try {
                image = Image.FromFile( filename );

                if ( image == null )
                    return false;

                if ( image.RawFormat.Guid == Imaging.ImageFormat.Gif.Guid ) {
                    FrameDimension frame_dimension = new FrameDimension( image.FrameDimensionsList[0] );
                    int frame_count = image.GetFrameCount( frame_dimension );

                    if ( frame_count > 1 )
                        return true;
                    else
                        return false;
                } else
                    return false;
            } catch ( Exception ) {
                return false;
            }
        }


        /**
         * 
         */
        public static DateTime DateTimeParse(string s) {
            DateTime result;
            string[] formats = new string { "ddd MMM dd HH:mm:ss zzzz yyyy" };

            foreach ( string format in In ) {
                if ( DateTime.TryParseExact( s, format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result ) )
                    return result;
                else
                    continue;
            }
            Trace( string.Format( "parse error(DateTimeFormat): `{0}'", s ) );

            return DateTime.Now;
        }


        /**
         * 
         */
        public static _Type CreateDataFromJson<_Type>(string content) {
            return CreateDataFromJson<_Type>( content, Encoding.Unicode );
        }
        /**
         * 
         */
        public static _Type CreateDataFromJson<_Type>(string content, Encoding encoding) {
            _Type result_data;

            using ( Stream input_stream = new MemoryStream() ) {
                byte[] buf = encoding.GetBytes( content );

                input_stream.Write( encoding.GetBytes( content ), 0, buf.Length );
                input_stream.Seek( 0, SeekOrigin.Begin );

                result_data = (_Type)(newDataContractJsonSerializer( typeof(_Type) ).ReadObject( input_stream ));
            }
            return result_data;
        }


        /**
         * 
         */
        public static bool IsValidEmail(string s) {
            return Regex.IsMatch( s, "^(?(\")(\".+?\"@)|(([0-9a-zA-Z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-zA-Z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,6}))$" );
        }


        /**
         * 
         */
        private static bool __trace_flag = false;
        /**
         * 
         */
        private static object __sync_object;
        
        /**
         * 
         */
        private static string __file_version = string.Empty;
    }


}
