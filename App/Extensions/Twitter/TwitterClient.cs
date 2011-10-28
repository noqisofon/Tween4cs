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


namespace Tween.Connections {
    

    /**
     * 
     */
    public class TwitterClient : ICloneable {
        /**
         *
         */
        public TwitterClient(string access_token, string access_token_secret, string user_name, long user_id) {
            this.SetAuthInfo( access_token, access_token_secret, user_name, user_id );
        }


        /**
         * 
         */
        public string AccessToken {
            get {
                if ( this.http_connection_ != null )
                    return ((OAuthHttpConnection)this.http_connection_).AccessToken;
                else
                    return string.Empty;
            }
        }


        /**
         * 
         */
        public string AccessTokenSecret {
            get {
                if ( this.http_connection_ != null )
                    return ((OAuthHttpConnection)this.http_connection_).AccessTokenSecret;
                else
                    return string.Empty;
            }
        }


        /**
         * 
         */
        public string AuthenticatedUsername {
            get {
                if ( this.http_connection_ != null )
                    return this.http_connection_.AuthUsername;
                else
                    return string.Empty;
            }
        }


        /**
         * 
         */
        public long AuthenticatedId {
            get {
                if ( this.http_connection_ != null )
                    return this.http_connection_.AuthUserId;
                else
                    return 0;
            }
            set {
                if ( this.http_connection_ != null )
                    this.http_connection_.AuthUserId = value;
            }
        }


        /**
         * 
         */
        public string Password {
            get { return string.Empty; }
        }


        /**
         * 
         */
        public bool GetRequestToken(out string content) {
            Uri authentic_uri = null;
            bool result;

            result = ((TwitterOAuthHttpConnection)this.http_connection_).AuthenticatePinFlowRequest( REQUEST_TOKEN_URL,
                                                                                                     AUTHORIZE_URL,
                                                                                                     this.request_token_,
                                                                                                     authentic_uri );
            content = authentic_uri.ToString();

            return result;
        }


        /**
         * 
         */
        public HttpStatusCode GetAccessToken(string pin) {
            return ((TwitterOAuthHttpConnection)this.http_connection_).AuthenticatePinFlow( ACCESS_TOKEN_URL, this.request_token_, pin );
        }


        /**
         * 
         */
        public HttpStatusCode AuthenticateWithUserAndPassword(string user_name, string password, out string content) {
            return this.http_connection_.Authenticate( new Uri( ACCESS_TOKEN_URL_XAUTH ),
                                                       user_name,
                                                       password,
                                                       content );
        }


        /**
         * 
         */
        public void ClearAuthInfo() {
            this.SetAuthInfo();
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

            return this.http_connection_.GetContent( POST_METHOD,
                                                     CreateTwitterUri( "/1/statuses/update.json" ),
                                                     palams,
                                                     content,
                                                     null,
                                                     null );
        }


        /**
         * 
         */
        private void SetAuthInfo() {
            this.SetAuthInfo( string.Empty, string.Empty, string.Empty, 0 );
        }
        /**
         * 
         */
        private void SetAuthInfo(string access_token, string access_token_secret, string user_name, long user_id) {
            OAuthHttpConnection connection = null;

            //static string _cache_key = string.Empty;
            //static string _cache_key_secret = string.Empty;
            //static string _cache_user_name = string.Empty;

            //if ( _cache_key != access_token || _cache_key_secret != access_token_secret || _cache_user_name == user_name ) {
            //    _cache_key = access_token;
            //    _cache_key_secret = access_token_secret;
            //    _cache_user_name = user_name;
            //}
            connection = new TwitterOAuthHttpConnection( DecryptString( CONSUMER_KEY ),
                                                         DecryptString( CONSUMER_SECRET ),
                                                         access_token,
                                                         access_token_secret,
                                                         user_name,
                                                         user_id,
                                                         "screen_name",
                                                         "user_id" );
            this.http_connection_ = connection;
            this.connection_type_ = AuthMethod.OAuth;
            this.request_token_ = string.Empty;
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
        private enum AuthMethod {
            OAuth,
            Basic
        }


        private IHttpConnection http_connection_;
        private HttpVarious http_connection_various_;
        private AuthMethod connection_type_;
        private string request_token_;


        /**
         * OAuth のコンシューマー鍵。
         */
        private readonly string CONSUMER_KEY = "";
        /**
         * OAuth の署名作成用秘密コンシューマーデータ。
         */
        private readonly string CONSUMER_SECRET = "";
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
//   mode: ecmascript
// End:
