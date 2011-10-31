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
// コンパイル後コマンド
// "c:\Program Files\Microsoft.NET\SDK\v2.0\Bin\sgen.exe" /f /a:"$(TargetPath)"
// "C:\Program Files\Microsoft Visual Studio 8\SDK\v2.0\Bin\sgen.exe" /f /a:"$(TargetPath)"
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;

using Tween.CustomControls;
using Tween.Extensions.Growl;
using Tween.Extensions.Twitter;
using Tween.Settings;
using Tween.Widgets;


namespace Tween {


    public class TweenMain {
        private Size size_;   //!< 窓サイズ。
        private Point location_;  //!< 窓の位置。

        private int display_separate_;  //!< 区切り位置。
        private int display_separate_remarks_;  //!< 発言欄区切り位置。
        private int display_separate_preview_;  //!< プレビュー区切り位置。

        private int icon_size_;  //!< アイコンサイズ(現在は 16, 24, 48 の 3 種類です。将来直接数字指定可能にします。注: 24x24 の場合に 25 と指定しているのは MS ゴシック系フォントのための仕様です)。
        private int icon_one_rowview_p_;  //!< 1 列表示の時真になります(サイズが 48 の場合)。

        // 
        // 雑多なフラグ類。
        //
        private bool startup_processing_p_;  //!< 真の時は起動時処理中。
        private bool initial_layout_ = true;
        private bool ignore_config_save_p_;  //!< 真の時は起動時処理中。
        private bool tab_drag_p_;  //!< タブドラッグ中フラグ(DoDragDrop を実行するかの判定用)。
        private TabPage before_selected_tab_;  //!< タブが削除されたときに前回選択されていた時のタブを入れておく。
        private Point tab_mouse_down_point_;
        private string rclick_tab_name_;  //!< 右クリックしたタブの名前(Tab コントロール機能不足の対応)。

        private readonly object sync_object_ = new object();  //!< ロック用。

        private const string DetailHtmlFormatMono1 = "<html><head><style type=\"text/css\"><!-- pre { font-family: \"";
        private const string DetailHtmlFormat2 = "\", sans-serif; font-size: ";
        private const string DetailHtmlFormat3 = "pt; word-wrap: break-word; color: rgb(";
        private const string DetailHtmlFormat4 = "); } a:link, a:visited, a:actice, a:hover { color: rgb(";
        private const string DetailHtmlFormat5 = "); } --></style></head><body style=\"margin: 0px; background-color: rgb(>";
        private const string DetailHtmlFormatMono6 = "\");\"><p>";
        private const string DetailHtmlFormatMono7 = "</p></body></html>";

        private string detailHtmlFormatHeader;
        private string detailHtmlFormatFooter;
        private bool status_error_ = false;
        private bool status_online_ = false;
        private bool sound_file_listup_ = false;
        private SpaceKeyCanceler space_key_canceler_;

        private struct ConfigFileSpecify {
            public SettingToConfig Setting;
            public SettingLocal Local;
            public bool ModifySettingLocal/* = false*/;
            public bool ModifySettingCommon/* = false*/;
            public bool ModifySettingAtId/* = false*/;
        }
        private ConfigFileSpecify specify_;

        // 
        // Twitter 解析部。
        // 
        private Twitter twitter_analysis_ = new Twitter();
        // 
        // Growl 呼び出し部。
        // 
        private GrowlHelper growl_helper_ = new GrowlHelper( "Tween" );

        // 
        // サブ画面インスタンス。
        //
        private AppendSettingDialog setting_dialog_ = AppendSettingDialog.Instance;
        // 
        // タブ選択ダイアログ。
        // 
        private TabsDialog tab_dialog_;
        // 
        // 検索画面。
        //
        private SearchWordDialog search_dialog_;
    }


}
// Local Variables:
//   coding: utf-8
//   mode: vala
// End:
