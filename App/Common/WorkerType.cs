//  
//  WorkerType.cs
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


namespace Tween.Common {


    /**
     * BackgroundWorker へ処理種別を通知するための列挙体。
     */
    public enum WorkerType {
        /**
         * タイムラインの取得。
         */
        Timeline,
        /**
         * 返信取得。
         */
        Reply,
        /**
         * 受信したダイレクトメッセージの取得。
         */
        DirectMessageReceive,
        /**
         * 送信したダイレクトメッセージの取得。
         */
        DirectMessageSent,
        /**
         * 発言をポスト。
         */
        PostMessage,
        /**
         * ふぁぼの追加。
         */
        FavoriteAddition,
        /**
         * ふぁぼの削除。
         */
        FavoriteRemove,
        /**
         * ふぉろわーリストの取得。
         */
        Follower,
        /**
         * URI を開く。
         */
        OpenUri,
        /**
         * ふぁぼリストの取得。
         */
        Favarites,
        /**
         * りついーと。
         */
        Retweet,
        /**
         * ぱぶりっくさーち！
         */
        PublicSearch,
        /**
         * りすと。
         */
        Lists,
        /**
         * 関連発言。
         */
        Related,
        /**
         * ゆーざーすとりーむ。
         */
        UserStream,
        /**
         * ゆーざーたいむらいん。
         */
        UserTimeline,
        /**
         * ぶろっきんぐ、またはぶろっくされた垢リスト？
         */
        BlockIds,
        /**
         * エラー表示だけ。
         */
        ErrorState
    }


}
