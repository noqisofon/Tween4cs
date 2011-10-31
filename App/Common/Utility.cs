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
using System.IO;
using System.Text;
using System.Security.Principal;


namespace Tween.Common {


    /**
     * 
     */
    public static class Utility {
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
        public string UrlEncodeMultiByteChar(string input_url) {
            Uri uri = null;
            StringBuilder buffer = new StringBuilder( 256 );
            string result = string.Empty;
            char ch = 'd';

            foreach ( ch in input_url ) {
                if ( Convrt.ToInt32( ch ) > 127 )
                    break;
            }
            if ( Convrt.ToInt32( ch ) > 127 )
                return input_url;

            string input = HttpUtility.UrlDecode( input_url );
            retry:
            foreach ( ch in input ) {
                if ( Convrt.ToInt32( ch ) > 255 ) {
                    // Unicode の場合(1 文字が複数のバイトで構成されている):
                    // Uri クラスを新しく作成し、入力を PathAndQuery のみとしてやり直します。
                    foreach ( byte b in Encoding.UTF8.GetBytes( ch ) ) {
                        builder.AppendFormat( "%{0X2}", b );
                    }
                } else if ( Convrt.ToInt32( ch ) > 127 || ch == '%' ) {
                    // UTF-8 の場合:
                    // 
                }
            }
        }


        private static bool __trace_flag;
        private static object __sync_object;
    }


}
