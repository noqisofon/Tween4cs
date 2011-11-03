//  
//  TwitterClient.cs
//  
// Tween - Client of Twitter
// Copyright (c) 2007-2011 kiri_feather (@kiri_feather) <kiri.feather@gmail.com>
//           (c) 2008-2011 Moz (@syo68k)
//           (c) 2008-2011 takeshik (@takeshik) <http://www.takeshik.org/>
//           (c) 2010-2011 anis774 (@anis774) <http://d.hatena.ne.jp/anis774/>
//           (c) 2010-2011 fantasticswallow (@f_swallow) <http://twitter.com/f_swallow>
//           (c) 2011 rihine (@noqisofon) <ned.rihine@gmail.com>
// All rights reserved.
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
using System.IO;
using System.Net;

using Tween.Connections;


namespace Tween.Extensions.Twitter {
    

    /**
     * 
     */
    public class TwitterClient : OAuthApiImpl {
        /**
         *
         */
        public TwitterClient(string access_token, string access_token_secret, string user_name, long user_id)
            : base( access_token, access_token_secret, user_name, user_id ) {
        }


        /**
         * 
         */
        public override bool GetRequestToken(out string content) {
            Uri authentic_uri = null;
            bool result;

            result = ((TwitterOAuthHttpConnection)base.InnerConnection).AuthenticatePinFlowRequest( REQUEST_TOKEN_URL,
                                                                                                     AUTHORIZE_URL,
                                                                                                     this.request_token_,
                                                                                                     authentic_uri );
            content = authentic_uri.ToString();

            return result;
        }


        /**
         * 
         */
        public override HttpStatusCode GetAccessToken(string pin) {
            return ((TwitterOAuthHttpConnection)base.InnerConnection).AuthenticatePinFlow( ACCESS_TOKEN_URL, this.request_token_, pin );
        }


        /**
         * 
         */
        public override HttpStatusCode AuthenticateWithUserAndPassword(string user_name, string password, out string content) {
            return base.InnerConnection.Authenticate( new Uri( ACCESS_TOKEN_URL_XAUTH ),
                                                       user_name,
                                                       password,
                                                       content );
        }


        /**
         * 
         */
        public HttpStatusCode UpdateStatus(string status, out string content) {
            return this.UpdateStatus( status, -1, content );
        }
        /**
         * 
         */
        public HttpStatusCode UpdateStatus(string status, long reply_to_id, out string content) {
            IDictionary<string, string> palams = new Dictionary<string, string>();

            palams.Add( "status", status );
            if ( reply_to_id > 0 )
                palams.Add( "in_reply_to_status_id", reply_to_id.ToString() );
            palams.Add( "include_entities", "true" );

            return base.InnerConnection.GetContent( POST_METHOD,
                                                     CreateTwitterUri( "/1/statuses/update.json" ),
                                                     palams,
                                                     content,
                                                     null,
                                                     null );
        }


        /**
         * 
         */
        public static bool EnableSsl(bool flag) {
            if ( flag )
                __protocol = "https://";
            else
                __protocol = "http://";
        }
        
        
        /**
         *
         */
        protected override IHttpConnection CreateHttpConnection(string access_token, string access_token_secret, string user_name, long user_id) {
            return new TwitterOAuthHttpConnection( DecryptString( CONSUMER_KEY ),
                                                         DecryptString( CONSUMER_SECRET ),
                                                         access_token,
                                                         access_token_secret,
                                                         user_name,
                                                         user_id,
                                                         "screen_name",
                                                         "user_id" );
        }


        /**
         * OAuth のコンシューマー鍵。
         */
        private readonly string CONSUMER_KEY = "YM01qSkuRcXAxKWcthNOw";
        /**
         * OAuth の署名作成用秘密コンシューマーデータ。
         */
        private readonly string CONSUMER_SECRET = "yHveugMdnCbx2oZXOhRPjetePRblEkNKbg9p2EXbI";
        /**
         * OAuth のアクセストークン取得先 URI。
         */
        private readonly string ACCESS_TOKEN_URL_XAUTH = "http://api.twitter.com/oauth/access_token";
        /**
         * 
         */
        private readonly string REQUEST_TOKEN_URL = "http://api.twitter.com/oauth/request_token";
        /**
         * 
         */
        private readonly string AUTHORIZE_URL = "http://api.twitter.com/oauth/authorize";
        /**
         * 
         */
        private readonly string ACCESS_TOKEN_URL = "http://api.twitter.com/oauth/access_token";

        /**
         * 
         */
        private readonly string POST_METHOD = "POST";
        /**
         * 
         */
        private readonly string GET_METHOD = "GET";

        private static string __protocol = "http://";
    }


}
// Local Variables:
//   coding: utf-8
//   mode: vala
// End:
