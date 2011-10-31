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
using System.Drawing;


namespace Tween.Connections {
    

    /**
     * 
     */
    public class HttpVarious : HttpConnection {
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
        private Image GetImageInternal(CheckValidImageDelegate check_valid_image_block, string url, string referer, int timeout, out string error_message) {
            try {
                HttpWebRequest request = CreateRequest( GET_METHOD );
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
