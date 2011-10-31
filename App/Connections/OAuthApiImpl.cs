//  
//  OAuthApiImpl.cs
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
using System.IO;
using System.Net;


namespace Tween.Connections {


    /**
     * 
     */
    public abstract class OAuthApiImpl : ICloneable {
        /**
         *
         */
        public OAuthApiImpl(string access_token, string access_token_secret, string user_name, long user_id) {
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
        public virtual string Password {
            get { return string.Empty; }
        }


        /**
         * 
         */
        protected IHttpConnection InnerConnection {
            get { return this.http_connection_; }
            set { this.http_connection_ = value; }
        }


        /**
         * 
         */
        public abstract bool GetRequestToken(out string content);


        /**
         * 
         */
        public abstract HttpStatusCode GetAccessToken(string pin);


        /**
         * 
         */
        public abstract HttpStatusCode AuthenticateWithUserAndPassword(string user_name, string password, out string content);


        /**
         * 
         */
        public void ClearAuthInfo() {
            this.SetAuthInfo();
        }


        /**
         *
         */
        protected abstract IHttpConnection CreateHttpConnection(string access_token, string access_token_secret, string user_name, long user_id);


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
            connection = this.CreateHttpConnection( access_token, access_token_secret, user_name, user_id );

            this.http_connection_ = connection;
            this.connection_type_ = AuthMethod.OAuth;
            this.request_token_ = string.Empty;
        }


        /**
         * 
         */
        protected internal enum AuthMethod {
            OAuth,
            Basic
        }


        private IHttpConnection http_connection_;
        private HttpVarious http_connection_various_;
        private AuthMethod connection_type_;
        private string request_token_;
    }


}
// Local Variables:
//   coding: utf-8
//   mode: vala
// End:
