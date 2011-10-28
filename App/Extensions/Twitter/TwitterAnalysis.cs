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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Reflection;
using System.Runtime.Serialization;
//using System.Runtime.Serialization.Json;
using System.Web;
using System.Xml;
using System.Xml.Linq;


namespace Tween.Extensions.Twitter {
    
    
    using Tween.Connections;


    /**
     * 
     */
    public class TwitterAnalysis : IDisposable {
        /**
         * 
         */
        public string Authenticate(string username, string password) {
            HttpStatusCode respond_code;
            string content = string.Empty;

            TwitterApiInfo.Start();

            try {
                respond_code = this.twitter_connection_;
            } catch ( Exception e ) {
            }
        }


        private HttpTwitter twitter_connection_;
        private List<long> follower_ids;
        private bool get_follower_result_  = false;
        private List<long> no_retweet_ids_;
        private bool get_no_retweet_result_ = false;

        private int followers_count_ = 0;
        private int friends_count_ = 0;
        private int statuses_count_ = 0;
        private string location_ = string.Empty;
        private string bio_ = string.Empty;
    }


}
// Local Variables:
//  coding: utf-8
//  mode: ecmascript
// End:
