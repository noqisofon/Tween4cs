using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace Tween.Connections {


    


        /**
         * API メソッドの処理が終了し、呼び出し元へ戻る直前に呼ばれるデリゲートです。
         * @param  sender メソッド名？？
         * @param  code API メソッドの返した HTTP ステータスコード。
         * @param  content API メソッドの処理結果。
         *
         * <p>
         * content は null になることがあるので、チェックを必ず行なってください。
         * </p>
         */
        public delegate void CallbackDelegate(object sender, out HttpStatusCode code, string content);


}
