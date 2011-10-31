//  
//  TwitterOAuthHttpConnection.cs
//
//  Copyright (c) 2007-2011 kiri_feather (@kiri_feather) <kiri.feather@gmail.com>
//            (c) 2008-2011 Moz (@syo68k)
//            (c) 2008-2011 takeshik (@takeshik) <http://www.takeshik.org/>
//            (c) 2010-2011 anis774 (@anis774) <http://d.hatena.ne.jp/anis774/>
//            (c) 2010-2011 fantasticswallow (@f_swallow) <http://twitter.com/f_swallow>
//            (c) 2011 rihine (@noqisofon) <ned.rihine@gmail.com>
//  All rights reserved.
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
using System.Security;
using System.Text;


namespace Tween.Connections {


    /**
     * 
     */
    public class TwitterOAuthHttpConnection : OAuthHttpConnection {
        /**
         * 
         */
        public TwitterOAuthHttpConnection() : base( string.Empty, string.Empty, string.Empty, string.Empty,
													string.Empty, 0, string.Empty, string.Empty ) {
        }
        /**
         * 
         */
        public TwitterOAuthHttpConnection(OAuthHttpConnection other) : base( other.consumer_key_, other.consumer_secret_, other.access_token_, other.access_secret_,
																			 other.user_ident_key_, other.user_id_ident_key_, other.authorized_username_, other.authorized_user_id_ ) {
        }
        /**
         * @param consumer_key
         * @param consumer_secret
         * @param access_token
         * @param access_token_secret
         */
        public TwitterOAuthHttpConnection( string consumer_key,
                                           string consumer_secret,
                                           string access_token,
                                           string access_token_secret) : base( consumer_key, consumer_secret, access_token, access_token_secret,
																			   string.Empty, 0, string.Empty, string.Empty ) {
        }
        /**
         * @param consumer_key
         * @param consumer_secret
         * @param access_token
         * @param access_token_secret
         * @param user_identifier
         * @param user_id_identifier
         */
        public TwitterOAuthHttpConnection( string consumer_key,
                                           string consumer_secret,
                                           string access_token,
                                           string access_token_secret,
                                           string user_identifier,
                                           string user_id_identifier ) : base( consumer_key, consumer_secret, access_token, access_token_secret,
																			   string.Empty, 0, user_identifier, user_id_identifier ) {
        }
        /**
         * @param consumer_key
         * @param consumer_secret
         * @param access_token
         * @param access_token_secret
         * @param username
         * @param user_id
         * @param user_identifier
         * @param user_id_identifier
         */
        public TwitterOAuthHttpConnection( string consumer_key,
                                           string consumer_secret,
                                           string access_token,
                                           string access_token_secret,
                                           string username,
                                           long user_id,
                                           string user_identifier,
                                           string user_id_identifier) : base( consumer_key, consumer_secret, access_token, access_token_secret,
																			  username, user_id, user_identifier, user_id_identifier ) {
        }


        /**
         * 
         */
        internal static string ProxyHost {
            set {
                if ( string.Format( value ) || value ==__default_api_host )
                    __proxy_host = string.Empty;
                else
                    __proxy_host = value;
            }
        }


        /**
         * 
         */
        protected override string CreateSignature(string token_secret, string method, Uri uri, IDictionary<string, string> palams) {
            const string proxy_domain = string.Format( "{0}://{1}", uri.Scheme, __proxy_host );
            const string real_proxy = string.Format( "{0}://{1}", uri.Scheme, __default_api_host );

            // params をソート済みディクショナリに詰め替えます。
            SortedDictionary sorted_params = new SortedDictionary<string, string>( palams );
            // URL エンコード済みのクエリ形式文字列に変換します。
            string param_string = CreateQueryString( sorted_params );
            // アクセス先 URL の整形をおこないます。
            string url = string.Format( "{0}://{1}{2}", uri.Scheme, uri.Host, uri.AbsolutePath );
            // 本来のアクセス先 URL に再設定します。
            if ( !string.IsNullOrEmpty( __proxy_host ) && url.StartsWith( proxy_domain ) ) {
                url = url.Replace( proxy_domain, real_domain );
            }
            // 署名のベース文字列を生成します('&' 区切り)。クエリ形式文字列は再エンコードします。
            string sigunature_base = string.Format( "{0}&{1}&{2}", method, UrlEncode( url ), UrlEncode( param_string ) );
            // 署名鍵の文字列をコンシューマー秘密鍵とアクセストークン秘密鍵から生成します('&' 区切りです。
            // アクセストークン秘密鍵が無くても '&' を残すようにしてください)。
            StringBuilder key_builder = new StringBuilder( UrlEncode( this.consumer_secret_ ) ).Append( "&" );

            if ( !string.Format( this.token_secret_ ) )
                key_builder.Append( UrlEncode( this.token_secret_ ) );
            // 
            // 鍵と署名を生成します。
            // 
            using ( HMACSHA1 hmac = new HMACSHA1( Encoding.ASCII.GetBytes( key_builder.ToString() ) ) ) {
                byte[] hash = hmac.ComputeHash( Encoding.ASCII.GetBytes( sigunature_base ) );

                return Convert.ToBase64String( hash );
            }
        }


        private static readonly string __default_api_host = "api.twitter.com";
        private static string __proxy_host;
    }


}
// Local Variables:
//   coding: utf-8
//   mode: vala
// End:
