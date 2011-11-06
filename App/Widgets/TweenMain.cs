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
using Microsoft.Win32;

using System;
using System.Collections.Generic;
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

using Tween.Common;
using Tween.CustomControls;
using Tween.Connections;
using Tween.Extensions;
using Tween.Extensions.Common;
using Tween.Extensions.Growl;
using Tween.Extensions.Twitter;
using Tween.Settings;
using Tween.Widgets;


namespace Tween.Widgets {


    public partial class TweenMain {


        /**
         * 
         */
        private Icon LoadIcon(string filepath) {
            Icon result_icon;
            FileInfo icon_file = new FileInfo( filepath );
            
            if ( icon_file.Exists ) {
                try {
                    result_icon = new Icon( icon_file.FullName );
                } catch ( Exception ) {
                    return null;
                }
            }
            return result_icon;
        }


        /**
         * 
         */
        private Icon LoadIconAbsent(string filepath, Icon found_icon) {
            Icon result_icon;
            FileInfo icon_file = new FileInfo( filepath );
            
            if ( icon_file.Exists ) {
                try {
                    result_icon = new Icon( icon_file.FullName );
                } catch ( Exception ) {
                    return found_icon;
                }
            }
            return result_icon;
        }


        /**
         * 
         */
        private void LoadIcons() {
            string starting_dirpath = Application.StartupPath;

            if ( Directory.Exists( Path.Combine( dirname, "Icons" ) ) ) {
                this.tasktray_at_ = LoadIcon( "Icons/At.png" );
                this.tasktray_status_red_ = LoadIcon( "Icons/AtRed.png" );
                this.tasktray_status_smoke_ = LoadIcon( "Icons/AtSmoke.png" );

                this.tasktray_status_refresh_.Add( LoadIcon( "Icons/Refresh.png" ) );
                this.tasktray_status_refresh_.Add( LoadIcon( "Icons/Refresh1.png" ) );
                this.tasktray_status_refresh_.Add( LoadIcon( "Icons/Refresh2.png" ) );
                this.tasktray_status_refresh_.Add( LoadIcon( "Icons/Refresh3.png" ) );

                this.tab_icon_ = LoadIcon( "Icons/TabIcon.png" );
                this.main_icon_ = LoadIcon( "Icons/MainIcon.png" );

                this.reply_icon_ = LoadIcon( "Icons/Reply.png" );
                this.reply_icon_blink_ = LoadIcon( "Icons/ReplyBlink.png" );
            } else {
                this.tasktray_at_ = Tween.Properties.Resources.At;
                this.tasktray_status_red_ = Tween.Properties.Resources.AtRed;
                this.tasktray_status_smoke_ = Tween.Properties.Resources.AtSmoke;

                this.tasktray_status_refresh_.Add( Tween.Properties.Resources.Refresh );
                this.tasktray_status_refresh_.Add( Tween.Properties.Resources.Refresh1 );
                this.tasktray_status_refresh_.Add( Tween.Properties.Resources.Refresh2 );
                this.tasktray_status_refresh_.Add( Tween.Properties.Resources.Refresh3 );

                this.tab_icon_ = Tween.Properties.Resources.TabIcon;
                this.main_icon_ = Tween.Properties.Resources.MainIcon;

                this.reply_icon_ = Tween.Properties.Resources.Reply;
                this.reply_icon_blink_ = Tween.Properties.Resources.ReplyBlink;
            }
        }


        /**
         * 
         */
        private void TweenMain_Activated(object sender, EventArgs eargs) {
            // 画面がアクティブになったら発言ランの背景色を戻します。
            if ( StatusText.Focused )
                this.StatusText_Enter( this.StatusText, EventArgs.Empty );
        }


        /**
         * 
         */
        private void TweenMain_Disposed(object sender, EventArgs eargs) {
            // 後始末をします。
            this.setting_dialog_.Dispose();
            this.tab_dialog_.Dispose();
            this.search_dialog_.Dispose();
            this.filter_dialog_.Dispose();
            this.url_dialog_.Dispose();
            this.space_key_canceler_.Dispose();

            if ( this.tasktray_at_ != null )
                this.tasktray_at_.Dispose();
            if ( this.tasktray_status_red_ != null )
                this.tasktray_status_red_.Dispose();
            if ( this.tasktray_status_smoke_ != null )
                this.tasktray_status_smoke_.Dispose();

            foreach ( Icon refresh_icon in this.tasktray_status_refresh_ ) {
                if ( refresh_icon != null )
                    refresh_icon.Dispose();
            }

            if ( this.tab_icon_ != null )
                this.tab_icon_.Dispose();
            if ( this.main_icon_ != null )
                this.main_icon_.Dispose();
            if ( this.reply_icon_ != null )
                this.reply_icon_.Dispose();
            if ( this.reply_icon_blink_ != null )
                this.reply_icon_blink_.Dispose();

            SolidBrush[] tmp_solid_brushs = new SolidBrush[] { highlight_brush_, highlight_text_brush_, forecolor_unread_brush_, forecolor_readed_brush_,
                                                               forecolor_favorite_brush_, forecolor_owl_brush_, forecolor_retweet_brush_, backcolor_mine_brush_,
                                                               backcolor_at_brush_, backcolor_at_you_brush_, backcolor_at_from_target_brush_, backcolor_at_to_brush_,
                                                               backcolor_none_brush_, deactive_selection_brush_ };

            foreach ( SolidBrush brush in tmp_solid_brushs ) {
                if ( brush != null )
                    brush.Dispose();
            }

            if ( this.shield_ != null )
                this.shield_.Dispose();
            if ( this.tab_format_ != null )
                this.tab_format_.Dispose();

            foreach ( BackgroundWorker worker in this.background_workers_ ) {
                if ( worker != null )
                    worker.Dispose();
            }
            if ( this.follewer_worker_ != null )
                this.follewer_worker_.Dispose();

            if ( this.icon_dictionary_ != null ) {
                ((ImageDirectory)this.icon_dictionary_).PauseGetImage = true;
                ((IDisposable)this.icon_dictionary_).Dispose();
            }
            /**
             * 終了時にハンドラを除去しておかないとメモリリークしてしまいます。
             * @see http://msdn.microsoft.com/ja-jp/library/microsoft.win32.systemevents.powermodechanged.aspx
             */
            SystemEvents.PowerModeChanded -= SystemEvents_PowerModeChanged;
        }


        


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

        private readonly object __sync_object = new object();  //!< ロック用。

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

        private SettingToConfig setting_;
        private SettingLocal local_setting_;
        private bool modify_setting_local_ = false;
        private bool modify_setting_common_ = false;
        private bool modify_setting_at_id_ = false;

        /** 
         * Twitter 解析部。
         */ 
        private Twitter twitter_analysis_ = new Twitter();
        /** 
         * Growl 呼び出し部。
         */ 
        private GrowlHelper growl_helper_ = new GrowlHelper( "Tween" );
        /** 
         * サブ画面インスタンス。
         */
        private AppendSettingDialog setting_dialog_ = AppendSettingDialog.Instance;
        /** 
         * タブ選択ダイアログ。
         */ 
        private TabsDialog tab_dialog_ = new TabsDialog();
        /** 
         * 検索画面。
         */
        private SearchWordDialog search_dialog_ = new SearchWordDialog();
        /**
         * フィルター編集画面。
         */ 
        private FilterDialog filter_dialog_ = new FilterDialog();
        /**
         *
         */
        private OpenUrl url_dialog_ = new OpenUrl();
        /**
         * シールドアイコン付きダイアログ。
         */ 
        private DialogAsShieldIcon dialog_as_shield_icon_;
        /**
         * @<id> 補助。
         */
        private AtIdSupplement at_id_supl_;
        /**
         * hash-tag 補助。
         */
        private AtIdSupplement hash_supl_;
        /**
         *
         */
        private HashtagManager hashtag_manager_;
        /**
         *
         */
        private EventViewerDialog event_viewer_dialog_;


        private Font unread_font_;  //!< 未読用フォント。
        private Color unread_color_;  //!< 未読用文字色。
        private Font readed_font_;  //!< 既読用フォント。
        private Color readed_color_;  //!< 既読用文字色。

        private Color favorite_color_;  //!< ふぁぼ用文字色。
        private Color own_color_;  //!< 片思い用文字色。
        private Color retweet_color_;  //!< りついーと用文字色。

        private Font detail_font_;  //!< 発言詳細部用フォント。
        private Color detail_color_;  //!< 発言詳細部用文字色。
        private Color detail_link_color_;  //!< 発言詳細部内リンク文字色。
        private Color detail_backcolor_;  //!< 発言詳細部背景色。

        private Color self_backcolor_;  //!< 自分の発言用背景色。
        private Color at_self_backcolor_;  //!< 自分宛返信用背景色。
        private Color target_backcolor_;  //!< 選択された発言者の他の発言用背景色。
        private Color at_from_target_backcolor_;  //!< 選択された発言者への返信発言用背景色。
        private Color at_to_backcolor_;  //!< 選択発言の唯一の＠先用背景色。
        private Color list_backcolor_;  //!< リスト部通常発言背景色。

        private Font input_font_;  //!< 入力欄のフォント。
        private Color input_backcolor_;  //!< 入力欄背景色。

        /**
         * 垢のアイコン画像リスト。
         */
        private IDictionary<string, Image> icon_dictionary_;

        private Icon tasktray_at_;  //!< タスクトレイアイコン: 通常時。
        private Icon tasktray_status_red_;  //!< タスクトレイアイコン: 通信エラー時。
        private Icon tasktray_status_smoke_;  //!< タスクトレイアイコン: オフライン時。
        private IList<Icon> tasktray_status_refresh_ = new List<Icon>( 4 );  //!< タスクトレイアイコン: 更新中(アニメーション用に 4 種類を保持するリストになっています)。

        private Icon tab_icon_;  //!< 未読のあるタブ用アイコン。
        private Icon main_icon_;  //!< 画面左上のアイコン。

        private Icon reply_icon_;
        private Icon reply_icon_blink_;

        private PostClass anchor_post_;
        private bool anchor_flag_;

        private IList<PostingStatus> history_;
        private int history_index_;

        // 
        // 発言投稿時の API 引数(発言編集時に設定します。手書き reply では設定されません)。
        // 
        private long reply_to_id_;  //!< リプライ先のステータス ID。0 の場合はリプライではない(注: 複数宛のものはリプライではない)。
        private string reply_to_name_;  //!< リプライ先のステータス書込者の名前。
        // 
        // 時速表示用。
        //
        private List<DateTime> post_timestamps_;
        private List<DateTime> favorite_timestamps_;
        private IDictionary<DateTime, int> timeline_timestamps_;
        private int timeline_count_;
        // 
        // 以下、DrawItem 関連。
        //
        private SolidBrush highlight_brush_ = new SolidBrush( Color.FromKnownColor( KnownColor.Highlight ) );
        private SolidBrush highlight_text_brush_ = new SolidBrush( Color.FromKnownColor( KnownColor.HighlightText ) );
        private SolidBrush forecolor_unread_brush_;
        private SolidBrush forecolor_readed_brush_;
        private SolidBrush forecolor_favorite_brush_;
        private SolidBrush forecolor_owl_brush_;
        private SolidBrush forecolor_retweet_brush_;
        private SolidBrush backcolor_mine_brush_;
        private SolidBrush backcolor_at_brush_;
        private SolidBrush backcolor_at_you_brush_;
        private SolidBrush backcolor_at_from_target_brush_;
        private SolidBrush backcolor_at_to_brush_;
        private SolidBrush backcolor_none_brush_;
        private SolidBrush deactive_selection_brush_ = new SolidBrush( Color.FromKnownColor( KnownColor.ButtonFace ) );  //!< list にフォーカスがないときの選択行の背景色。

        private StringFormat tab_format_ = new StringFormat();

        private ToolStripAPIGauge api_gauge_ = new ToolStripAPIGauge();
        private TabInformations statuses_;

        private IList<ListViewItem> item_cache_;
        private int item_cache_index_;

        private IList<PostClass> post_cache_;

        private TabPage current_tabpage_;
        private int current_item_index_;
        private DetailsListView current_listview_;

        private bool is_column_changed_ = false;
        private bool wait_timeline_ = false;
        private bool wait_reply_ = false;
        private bool wait_direct_message_ = false;
        private bool wait_favorite_ = false;
        private bool wait_public_search_ = false;
        private bool wait_user_timeline_ = false;
        private bool wait_lists_ = false;

        private IList<BackgroundWorker> background_workers_ = new List<BackgroundWorker>( 18 );
        private BackgroundWorker follewer_worker_;

        private int mode_;
        private ShieldIcon shield_ = new ShieldIcon();
        private InternetSecurityManager security_manager_;
        private Thumbnail thumbnail_;

        private int unread_counter_ = -1;
        private int unread_at_counter_ = -1;

        private IList<string> column_org_text_ = new List<string>( 8 );
        private IList<string> column_text_ = new List<string>( 8 );

        private bool do_favorite_retweet_flags_ = false;
        private bool os_resumed_ = false;
        private IDictionary<string, IMultimediaShareService> picture_service_;

        private string post_browser_status_text_ = string.Empty;
        private bool colorize_ = false;

        private System.Timers.Timer timeline_timer_ = new System.Timers.Timer();

        private ImageListViewItem display_item_;
        private AdsBrowser ads_browser_;
        private Extensions.Google.GASender ga_sender_;


        /**
         * URL 短縮の Undo 用。
         */
        private struct UrlUndoInfo {
            public string Before;
            public string After;
        }

        private IList<UrlUndoInfo> url_undo_buffer_ = null;

        
        /**
         * 
         */
        private struct ReplayChain {
            /**
             * 
             */
            public ReplayChain(long original_id, long in_reply_to_id, TabPage original_tab) {
                this.OriginalId = original_id;
                this.InReplyToId = in_reply_to_id;
                this.OriginalTab = original_tab;
            }


            public long OriginalId;
            public long InReplyToId;
            public TabPage OriginalTab;
        }

        private Stack<ReplayChain> replay_chains_;

        private Stack<Tuple<TabPage, PostClass>> select_post_chains_ = new Stack<Tuple<TabPage, PostClass>>();
    }


}
// Local Variables:
//   coding: utf-8
//   mode: vala
// End:
