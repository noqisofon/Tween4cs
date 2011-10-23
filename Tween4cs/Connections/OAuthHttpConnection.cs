using System;


namespace Tween.Connections {


    /**
     * OAuth 認証を使用する HTTP 通信です。HMAC-SHA1 固定になっています。
     */
    public class OAuthHttpConnection : HttpConnection, IHttpConnection {
        /**
         * OAuth 署名の oauth_timestamp 算出用基準日付です(1970-01-01 00:00:00)。
         */
        private static readonly DateTime UnixEpoch = new DateTime( 1970, 1, 1, 0, 0, 0, DateTimeKind.Unspecified );
    }


}
// Local Variables:
//   coding: utf-8
//   mode: ecmascript
// End: