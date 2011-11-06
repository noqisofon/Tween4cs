//  
//  HttpVarious.cs
//  
// Copyright (c) 2007-2011 kiri_feather (@kiri_feather) <kiri.feather@gmail.com>
//           (c) 2008-2011 Moz (@syo68k)
//           (c) 2008-2011 takeshik (@takeshik) <http://www.takeshik.org/>
//           (c) 2010-2011 anis774 (@anis774) <http://d.hatena.ne.jp/anis774/>
//           (c) 2010-2011 fantasticswallow (@f_swallow) <http://twitter.com/f_swallow>
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
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;


namespace Tween.Connections {
    

    /**
     * 
     */
    public class HttpVarious : HttpConnection {


        /**
         * 
         */
        public bool PostData(string url, IDictionary<string, string> param) {
            try {
                HttpWebRequest request = CreateRequest( POST_METHOD, new Uri( url ), param, false );
                HttpStatusCode status_code = GetResponse( request, null, false );

                if ( status_code == HttpStatusCode.OK )
                    return true;
                
            } catch ( Exception ) {
            }
            return false;
        }
        /**
         * 
         */
        public bool PostData(string url, IDictionary<string, string> param, ref string content) {
            try {
                HttpWebRequest request = CreateRequest( POST_METHOD, new Uri( url ), param, false );
                HttpStatusCode status_code = GetResponse( request, ref content, false );

                if ( status_code == HttpStatusCode.OK )
                    return true;
                
            } catch ( Exception ) {
            }
            return false;
        }


        /**
         * 
         */
        public bool GetData(string url, IDictionary<string, string> param, ref string content, ref string user_agent) {
            return this.GetData( url, param, ref content, 100000, null, ref user_agent );
        }
        /**
         * 
         */
        public bool GetData(string url, IDictionary<string, string> param, ref string content) {
            return this.GetData( url, param, ref content, 100000, null, string.Empty );
        }
        /**
         * 
         */
        public bool GetData(string url, IDictionary<string, string> param, ref string content, int timeout) {
            return this.GetData( url, param, ref content, timeout, null, string.Empty );
        }
        /**
         * 
         */
        public bool GetData(string url, IDictionary<string, string> param, ref string content, int timeout, ref string error_message, string user_agent) {
            try {
                HttpWebRequest request = CreateRequest( GET_METHOD, new Uri( uri ), param, false );

                if ( timeout < 3000 || timeout > 30000 )
                    request.Timeout = DEFAULT_TIMEOUT;
                else
                    request.Timeout = timeout;
                if ( string.IsNullOrEmpty( user_agent ) )
                    request.UserAgent = user_agent;

                HttpStatusCode status_code = this.GetResponse( request, ref content, null, false );

                if ( status_code == HttpStatusCode.OK )
                    return true;
                if ( error_message != null )
                    error_message = status_code.ToString();
            } catch ( Exception e ) {
                error_message = e.ToString();

                return false;
            }
            return false;
        }


        /**
         * 
         */
        public bool GetDataToFile(string url, string save_path) {
            try {
                HttpWebRequest request = CreateRequest( GET_METHOD, new Uri( uri ), param, false );
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.UserAgent = GetUserAgentString();
                /*
                 * using 使ってるのに、Close メソッドいるの？
                 */
                using ( Stream input_stream = new FileStream( save_path, FileMode.Create, FileAccess.Write ) ) {
                    //try {
                    HttpStatusCode status_code = this.GetResponse( request, input_stream, null, false );

                    //input_stream.Close();
                    if ( status_code == HttpStatusCode.OK )
                        return true;
                    //} catch ( Exception ) {
                    //}
                }
            } catch ( Exception ) {

                return false;
            }
            return false;
        }


        /**
         * 
         */
        public HttpStatusCode GetContent( string method,
                                          Uri url,
                                          IDictionary<string, string> param,
                                          ref string content,
                                          IDictionary<string, string> header_info,
                                          string user_agent ) {
            HttpWebRequest request = CreateRequest( GET_METHOD, new Uri( uri ), param, false );
            request.UserAgent = user_agent;

            return this.GetResponse( request, ref content, header_info, false );
        }


        /**
         * 
         */
        public string GetRedirectTo(string url) {
            try {
                HttpWebRequest request = base.CreateRequest( HEAD_METHOD, new Uri( url ), null, false );

                request.Timeout = 5000;
                request.AllowAutoRedirect = false;

                string data = string.Empty;
                IDirectionary<string, string> header = new Directionary<string, string>();
                HttpStatusCode response_code = base.GetResponse( request, out data, header, false );

                if ( header.ContainsKey( "Location" ) )
                    return header["Location"];
                else
                    return url;
            } catch ( Exception ) {
                return url;
            }
        }


        /**
         * 
         */
        public Image GetImage(Uri url) {
            return this.GetImage( url.ToString(), string.Empty, DEFAULT_TIMEOUT, null );
        }
        /**
         * 
         */
        public Image GetImage(string url) {
            return this.GetImage( url, string.Empty, DEFAULT_TIMEOUT, null );
        }
        /**
         * 
         */
        public Image GetImage(string url, int timeout) {
            return this.GetImage( url, string.Empty, timeout, null );
        }
        /**
         * 
         */
        public Image GetImage(string url, string referer) {
            return this.GetImage( url, referer, DEFAULT_TIMEOUT, null );
        }
        /**
         * 
         */
        public Image GetImage(string url, string referer, int timeout, out string error_message) {
            return this.GetImageInternal( CheckValidImage, url, referer, timeout, error_message );
        }


        /**
         * 
         */
        public Image GetIconImage(string url, string referer, int timeout) {
            return this.GetImageInternal( CheckValidIconImage, url, string.Empty, timeout, null );
        }


        /**
         * 
         */
        public Image CheckValidImage(Image image, int width, int height) {
            if ( image == null )
                return null;

            Image result_bitmap =  new Bitmap( width, height );

            try {
                using ( Graphics g = Graphics.FromImage( result_bitmap ) ) {
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality;
                    g.DrawImage( image, 0, 0, width, height );
                }
                result_bitmap.Tag = image.Tag;
            } catch ( Exception ) {
                result_bitmap.Dispose();
                result_bitmap = new Bitmap( width, height );
                result_bitmap.Tag = image.Tag;
            }
            return result_bitmap;
        }


        /**
         * 
         */
        private Image GetImageInternal(CheckValidImageDelegate check_valid_image_block, string url, string referer, int timeout, out string error_message) {
            try {
                HttpWebRequest request = CreateRequest( GET_METHOD, new Uri( url ), null, false );

                if ( timeout < 3000 || timeout > 30000 )
                    request.Timeout = DEFAULT_TIMEOUT;
                else
                    request.Timeout = timeout;

                Image image = null;
                HttpStatusCode status_code = GetResponse( request, image, null, false );

                if ( error_message != null ) {
                    if ( status_code == HttpStatusCode.OK )
                        error_message = string.Empty;
                    else
                        error_message = status_code.ToString();
                }
                if ( image != null )
                    image.Tag = url;
                /*
                 * check_valid_image_block が null かどうか調べる必要があるが、null の入り込む要素は今の処無いので書いていない。
                 */
                if ( status_code == HttpStatusCode.OK )
                    return check_valid_image_block( image, image.Width, image.Height );
                return null; 
            } catch ( WebException we ) {
                error_message = we.Message;

                return null;
            } catch ( Exception ) {
                return null;
            }
        }


        /**
         * 
         */
        private delegate Image CheckValidImageDelegate(Image image, int width, int height);


        private const int DEFAULT_TIMEOUT = 10000;
    }


}
// Local Variables:
//   coding: utf-8
//   mode: vala
// End:
