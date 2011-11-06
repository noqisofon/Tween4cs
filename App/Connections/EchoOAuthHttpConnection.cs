//  
//  EchoOAuthHttpConnection.cs
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
using System.Collections.Generic;
using System.Net;


namespace Tween.Connections {


    /****/
    public class EchoOAuthHttpConnection : OAuthHttpConnection {
        /**
         * 
         */
        public EchoOAuthHttpConnection(Uri realm, Uri service_provider) {
            this.Realm = realm;
            this.ServiceProvider = service_provider;
        }


        /**
         * 
         */
        public Uri Realm {
            get { return this.realm_; }
            set { this.realm_ = value; }
        }


        /**
         * 
         */
        public Uri ServiceProvider {
            get { return this.service_provider_; }
            set { this.service_provider_ = value; }
        }


        /**
         * 
         */
        protected override void AppendOAuthInfo( HttpWebRequest request,
                                                 IDictionary<string, string> query,
                                                 string token,
                                                 string token_secret) {
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
            buffer.AppendFormat( "realm=\"{0}://{1}{2}\",", this.realm_.Scheme, this.realm_.Host, this.realm_.AbsolutePath );
            foreach ( KeyValuePair<string, string> item in palams ) {
                // 各種情報のうち、'oauth_' で始まる情報のみ、ヘッダに追加します。
                // 各情報はカンマ区切り、データはダブルクォーテーションでくくります。
                if ( item.Key.StartsWith( "oauth_" ) )
                    buffer.AppendFormat( "{0}=\"{1}\",", item.Key, UrlEncode( item.Value ) );
            }
            request.Headers.Add( "X-Verify-Credentials-Authorization", buffer.ToString() );
            request.Headers.Add( "X-Auth-Service-Provider",
                                 string.Format( "realm=\"{0}://{1}{2}\",",
                                                this.service_provider_.Scheme,
                                                this.service_provider_.Host,
                                                this.service_provider_.AbsolutePath ) );
        }


        private Uri realm_;
        private Uri service_provider_;
    }


}
