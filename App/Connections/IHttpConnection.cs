// Tween - Client of Twitter
// Copyright (c) 2007-2011 kiri_feather (@kiri_feather) <kiri.feather@gmail.com>
//           (c) 2008-2011 Moz (@syo68k)
//           (c) 2008-2011 takeshik (@takeshik) <http://www.takeshik.org/>
//           (c) 2010-2011 anis774 (@anis774) <http://d.hatena.ne.jp/anis774/>
//           (c) 2010-2011 fantasticswallow (@f_swallow) <http://twitter.com/f_swallow>
// All rights reserved.
// 
// This file is part of Tween.
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the Free
// Software Foundation; either version 3 of the License, or (at your option)
// any later version.
// 
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License
// for more details. 
// 
// You should have received a copy of the GNU General Public License along
// with this program. If not, see <http://www.gnu.org/licenses/>, or write to
// the Free Software Foundation, Inc., 51 Franklin Street - Fifth Floor,
// Boston, MA 02110-1301, USA.
//
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace Tween.Connections {


    /**
     * 
     */
    public interface IHttpConnection {
        /**
         * 
         */
        string AuthUsername { get; }


        /**
         * 
         */
        long AuthUserId { get; set; }


        /**
         * 
         */
        HttpStatusCode GetContent( string method,
                                   Uri request_uri,
                                   IDictionary<string, string> param,
                                   ref Stream content,
                                   string user_agent );
        /**
         * 
         */
        HttpStatusCode GetContent( string method,
                                   Uri request_uri,
                                   IDictionary<string, string> param,
                                   ref string content,
                                   IDictionary<string, string> header_info,
                                   CallbackDelegate callback );
        /**
         * 
         */
        HttpStatusCode GetContent( string method,
                                   Uri request_uri,
                                   IDictionary<string, string> param,
                                   IList<KeyValuePair<string, FileInfo>> binary,
                                   ref string content,
                                   IDictionary<string, string> header_info,
                                   CallbackDelegate callback );


        /**
         * 
         */
        void RequestAbort();


        /**
         * 
         */
        HttpStatusCode Authenticate(Uri uri, string username, string password, out string content);
    }
    

}
