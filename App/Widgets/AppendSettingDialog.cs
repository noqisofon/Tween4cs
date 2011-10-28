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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using Tween.Connections;
using Tween.Extensions;
using Tween.Extensions.Outputz;
using Tween.Extensions.Twitter;
using Tween.Extensions.Twitter.DataModel;


namespace Tween.Widgets {
    
    
    public partial class AppendSettingDialog {
        public bool IsPreviewFoursquare {
            get { return this.is_preview_foursquare_; }
        }


        public int FoursquarePreviewHeight {
            get { return this.foursquare_preview_height_; }
            set { this.foursquare_preview_height_ = value; }
        }


        public int FoursquarePreviewWidth {
            get { return this.foursquare_preview_width_; }
            set { this.foursquare_preview_width_ = value; }
        }


        public int FoursquarePreviewZoom {
            get { return this.foursquare_preview_zoom_; }
            set { this.foursquare_preview_zoom_ = value; }
        }


        public bool IsListStatusesIncludeReTweets {
            get { return this.is_list_statuses_include_retweets_; }
        }
        


        public UserAccount[] UserAccounts {
            get { return this.user_accounts_.ToArray(); }
        }


        public bool TabMouseLock {
            get { return this.tab_mouse_lock_; }
            set { this.tab_mouse_lock_ = value; }
        }


        public bool IsRemoveSameEvent {
            get { return this.is_remove_same_event_; }
        }


        public bool IsNotifyUseGrowl {
            get { return this.is_notify_use_growl_; }
        }


        public Tween.Extensions.Twitter.DataModel.Configuration TwitterConfiguration {
            get { return this.twitter_configuration_; }
            set {
                if ( value != null )
                    this.twitter_configuration_ = value;
            }
        }


        private void TreeViewSetting_BeforeSelect(object sender, TreeViewCancelEventArgs tvcergs) {
            if ( this.treeViewSetting.SelectedNode == null )
                return ;

            Panel panel = this.treeViewSetting.SelectedNode.Tag as Panel;
            if ( panel == null )
                return ;

            panel.Enabled = false;
            panel.Visible = false;
        }


        private void TreeViewSetting_AfterSelect(object sender, TreeViewEventArgs tvergs) {
            if ( tvergs.Node == null )
                return ;

            Panel panel = tvergs.Node.Tag as Panel;
            if ( panel == null )
                return ;

            panel.Enabled = true;
            panel.Visible = true;

            if ( panel.Name == "PreviewPanel" ) {
                if ( GrowlHelper.IsDllExists )
                    isNotifyUseGrowlCheckBox.Enabled = true;
                else
                    isNotifyUseGrowlCheckBox.Enabled = false;
            }
        }


        private void btnSave_Click(object sender, EventArgs ergs) {
            if ( TweenMain.IsNetworkAvailable
                 && (autoShortUrlFirstComboBox.SelectedIndex == UrlConvertor.Bitly
                     || autoShortUrlFirstComboBox.SelectedIndex == UrlConvertor.Jmp)
                 && ( !string.IsNullOrEmpty( bitlyIdEntry.Text ) || !string.IsNullOrEmpty( bitlyPasswordEntry.Text ) ) ) {
                if ( !BitlyValidation( bitlyIdEntry.Text, bitlyPasswordEntry.Text ) ) {
                    MessageBox.Show( Resources["SettingSave_ClickText1"] );
                    this.validation_error_ = true;
                    this.treeViewSetting.SelectedNode.Name = "TweetActNode";  // 動作タブを選択します。

                    bitlyIdEntry.Focus();

                    return ;
                } else
                    this.validation_error_ = false;
            } else
                this.validation_error_ = false;

            this.user_accounts_.Clear();
            foreach ( object item in AuthUserCombo.Items ) {
                this.user_accounts_.Add( item as UserAccount );
            }

            if ( AuthUserCombo.SelectedIndex > -1 ) {
                foreach ( UserAccount account in this.user_accounts_ ) {
                    if ( account.Username.ToLower() == ((UserAccount)AuthUserCombo.SelectedItem).Username.ToLower() ) {
                        //this.twitter_analysis_.Initialize( account.Token, account.TokenSecret, account.Username, accoun.UserId );
                        this.twitter_analysis_.Start( account.Token, account.TokenSecret, account.Username, accoun.UserId );
                        if ( account.UserId == 0 ) {
                            this.twitter_analysis_.VerifyCredentiials();
                            account.UserId = this.twitter_analysis_.UserId;
                        }

                        Google.GASender.Instance.SessionFirst = account.GAFirst;
                        Google.GASender.Instance.SessionLast = account.GaLast;
                    }
                }
            } else {
                this.twitter_analysis_.ClearAuthInfo();
                this.twitter_analysis_.Start( string.Empty, string.Empty, string.Empty, 0 );
            }
#if UA == true
            if ( FollowCheckBox.Checked ) {
                ProxyType proxy_type;

                if ( proxyNoneRadioButton.Checked )
                    proxy_type = ProxyType.None;
                else if ( proxyIERadioButton.Checked )
                    proxy_type = ProxyType.IE;
                else
                    proxy_type = ProxyType.Specified;

                string proxy_address = proxyAddressEntry.Text.Trim();
                int proxy_port = int.Parse( proxyPortEntry.Text.Trim() );
                string proxy_username = proxyUserEntry.Text.Trim();
                string proxy_password = proxyPasswordEntry.Text.Trim();

                HttpConnection.InitializeConnection( 20, proxy_type, proxy_address, proxy_port, proxy_username, proxy_password );

                string ret = this.twitter_analysis_.PostFollowCommand( "Tween4csApp" );
            }
#endif
            IntervalChangedEventArgs arg;
            bool is_interval_changed = false;

            try {
                this.userstream_startup_ = this.startupUserstreamCheckBox.Checked;

                if ( this.userstream_period_ != Convert.ToInt32( UserstreamPeriod.Text ) ) {
                    this.userstream_period_ = Convert.ToInt32( UserstreamPeriod.Text );
                    arg.UserStream = true;
                    is_interval_changed = true;
                }

                if ( this.timeline_period_ != Convert.ToInt32( timelinePeriodEntry.Text ) ) {
                    this.timeline_period_ = Convert.ToInt32( timelinePeriodEntry.Text );
                    arg.Timeline = true;
                    is_interval_changed = true;
                }

                if ( this.directmessage_period_ != Convert.ToInt32( directMessagePeriodEntry.Text ) ) {
                    this.directmessage_period_ = Convert.ToInt32( directMessagePeriodEntry.Text );
                    arg.DirectMessage = true;
                    is_interval_changed = true;
                }

                if ( this.pulic_search_period_ != Convert.ToInt32( pubSearchPeriodEntry.Text ) ) {
                    this.pulic_search_period_ = Convert.ToInt32( pubSearchPeriodEntry.Text );
                    arg.PublicSearch = true;
                    is_interval_changed = true;
                }

                if ( this.lists_period_ != Convert.ToInt32( listsPeriodEntry.Text ) ) {
                    this.lists_period_ = Convert.ToInt32( listsPeriodEntry.Text );
                    arg.Lists = true;
                    is_interval_changed = true;
                }

                if ( this.user_timeline_period_ != Convert.ToInt32( userTimelinePeriodEntry ) ) {
                    this.user_timeline_period_ = Convert.ToInt32( userTimelinePeriodEntry );
                    arg.UserTimeLine = true;
                    is_interval_changed = true;
                }

                if ( is_interval_changed )
                    IntervalChanged( this, arg );

                this.readed_ = startupReadedCheckBox.Checked;
                switch ( iconSizeComboBox.SelectedIndex ) {
                    case 0:
                        this.icon_size_ = IconSizes.IconNone;
                        break;

                    case 1:
                        this.icon_size_ = IconSizes.Icon16;
                        break;

                    case 2:
                        this.icon_size_ = IconSizes.Icon24;
                        break;

                    case 3:
                        this.icon_size_ = IconSizes.Icon48;
                        break;

                    case 4:
                        this.icon_size_ = IconSizes.Icon48_2;
                        break;
                }

                this.status_text_ = statusEntry.Text;
                this.play_sound_ = playSndCheckBox.Checked;
                this.unread_manage_ = unreadMngCheckBox.Checked;
                this.one_way_love_ = oneWayLvCheckBox.Checked;

                if ( this.font_book_ == null )
                    this.font_book_ = new Dictionary<string, Font>();
                if ( this.color_book_ == null )
                    this.color_book_ = new Dictionary<string, Color>();

                this.font_book_.Add( "unread", unreadLabel.Font );  // 未使用です。
                this.color_book_.Add( "unread", unreadLabel.ForeColor );

                this.font_book_.Add( "readed", listFontButton.Font );
                this.color_book_.Add( "readed", listFontButton.ForeColor );

                this.color_book_.Add( "retweet", lblReTweet.ForeColor );
                this.color_book_.Add( "favorite", favoriteLabel.ForeColor );
                this.color_book_.Add( "owl", lblOwl.ForeColor );

                this.font_book_.Add( "detail", detailLabel.Font );
                this.color_book_.Add( "detail_back", detailBackcolorLabel.BackColor );
                this.color_book_.Add( "detail_link", detailLinkLabel.ForeColor );

                this.color_book_.Add( "self", lblSelf.BackColor );
                this.color_book_.Add( "at_self", lblAtSelf.BackColor );
                this.color_book_.Add( "at_from_target", lblAtFromTarget.backColor );
                this.color_book_.Add( "at_to", lblAtTo.BackColor );

                this.color_book_.Add( "list_back", lblListBackcolor.BackColor );

                this.font_book_.Add( "input_font", lblInputFont.ForeColor );
                this.color_book_.Add( "input_back", lblInputBackcolor.BackColor );
                this.color_book_.Add( "input_font", lblInputFont.ForeColor );

                switch ( nameBalloonComboBox.SelectedIndex ) {
                    case 0:
                        this.name_balloon_ = NameBalloons.None;
                        break;

                    case 1:
                        this.name_balloon_ = NameBalloons.UserID;
                        break;

                    case 2:
                        this.name_balloon_ = NameBalloons.NickName;
                        break;
                }

                switch ( postKeySelectComboBox.SelectedIndex ) {
                    case 2:
                        this.post_shift_enter_ = true;
                        this.post_ctrl_enter_ = false;
                        break;

                    case 1:
                        this.post_shift_enter_ = false;
                        this.post_ctrl_enter_ = true;
                        break;

                    case 0:
                        this.post_shift_enter_ = false;
                        this.post_ctrl_enter_ = false;
                        break;
                }

                this.use_post_method_ = false;
                this.count_api_ = Convert.ToInt32( countApiEntry.Text );
                this.count_api_reply_ = Convert.ToInt32( countApiEntry.Text );
                this.browser_path_ = browserPathEntry.Text.Trim();
                this.post_and_get_ = postAndGetCheckBox.Checked;
                this.use_recommend_status_ = useRecommendStatusCheckBox.Checked;
                this.display_user_name_ = dispUsernameCheckBox.Checked;
                this.close_to_exit_ = closeToExitCheckBox.Checked;
                this.minimize_to_tray_ = minimizeToTrayCheckBox.Checked;

                switch ( ComboDispTile.SelectedIndex ) {
                    case 0:
                        this.display_latest_post_ = DisplayTitleKind.None;
                        break;

                    case 1:
                        this.display_latest_post_ = DisplayTitleKind.Version;
                        break;

                    case 2:
                        this.display_latest_post_ = DisplayTitleKind.Post;
                        break;

                    case 3:
                        this.display_latest_post_ = DisplayTitleKind.UnreadReplyCount;
                        break;

                    case 4:
                        this.display_latest_post_ = DisplayTitleKind.UnreadAllCount;
                        break;

                    case 5:
                        this.display_latest_post_ = DisplayTitleKind.UnreadAllReplyCount;
                        break;

                    case 6:
                        this.display_latest_post_ = DisplayTitleKind.UnreadAllCount;
                        break;

                    case 7:
                        this.display_latest_post_ = DisplayTitleKind.OwnStatus;
                        break;
                }

                this.sort_order_lock_ = sortOrderLockCheckBox.Checked;
                this.tiny_url_resolve_ = tinyUrlCheckBox.Checked;
                this.short_url_force_resolve_ = this.tiny_url_resolve_;

                ShortUrl.IsResolve = this.tiny_url_resolve_;
                ShortUrl.IsForceResolve = this.short_url_force_resolve_;

                if ( RadioProcyNone.Checked )
                    this.proxy_type_ = ProxyType.None;
                else if ( proxyIERadioButton.Checked )
                    this.proxy_type_ = ProxyType.IE;
                else
                    this.proxy_type_ = ProxyType.Specified;

                this.proxy_address_ = proxyAddressEntry.Text.Trim();
                this.proxy_port_ = int.Parse( proxyPortEntry.Text.Trim() );
                this.proxy_user_ = proxyUserEntry.Text.Trim();
                this.proxy_password_ = proxyPasswordEntry.Text.Trim();

                this.period_adjust_ = CheeckPeriodAdjust.Checked;

                this.startup_version_ = startupVersionCheckBox.Checked;
                this.startup_followers_ = startupFollowersCheckBox.Checked;

                this.restrict_favorite_check_ = favRestrictCheckBox.Checked;

                this.always_top_ = alwaysTopCheckBox.Checked;

                this.url_convert_auto_ = autoConvertUrlCheckBox.Checked;
                this.shorten_tco_ = ShortenTcoCheck.Checked;

                this.outputz_ = CheckeOutputz.Checked;
                this.outputz_key = outputzKeyEntry.Text.Trim();

                switch ( outputzUrlmodeComboBox.SelectedIndex ) {
                    case 0:
                        this.outputz_url_mode_ = OutputzUrlMode.TwitterCom;
                        break;

                    case 1:
                        this.outputz_url_mode_ = OutputzUrlMode.TwitterComWithUsername;
                        break;
                }

                this.nicoms_ = nicomsCheckBox.Checked;
                this.unread_style_ = unreadStyleCheckBox.Checked;
                this.datetime_format_ = dateTimeFormatComboBox.Text;
                this.default_timeout_ = Convert.ToInt32( connectionTimeOutEntry.Text );
                this.retweet_no_confirm_ = retweetNoConfirmCheckBox.Checked;
                this.limit_balloon_ = balloonLimitCheckBox.Checked;

                this.event_notify_enabled_ = eventNotifyCheckBox.Checked;
                GetEventNotifyFlag( this.event_notify_flag_, this.is_event_notify_flag_ );
                this.force_event_unread_ = favEventUnreadCheckBox.Checked;

                this.translate_language_ = new Bing.GetLanguageEnumFromIndex( translateLanguageComboBox.SelectedIndex );
                this.event_sound_file_ = eventNotifySoundComboBox.SelectedItem.ToString();
                this.auto_short_url_first_ = autoShortUrlFirstComboBox.SelectedIndex as UrlConvertor;
                this.tab_icon_display_ = tabIconDispCheckBox.Checked;
                this.read_own_post_ = readOwnPostCheckBox.Checked;
                this.get_favorite_ = getFavoriteCheckBox.Checked;
                this.mono_space_ = monospaceCheckBox.Checked;
                this.read_old_posts_ = readOldPostsCheckBox.Checked;

                this.use_ssl_ = useSslCheckBox.Checked;

                this.bitly_id_ = bitlyIdEntry.Text;
                this.bitly_password_ = bitlyPasswordEntry.Text;

                this.show_grid_ = showGridCheckBox.Checked;
                this.use_at_id_supplement_ = atIdSuppleCheckBox.Checked;
                this.use_hash_supplement_ = hashSuppleCheckBox.Checked;

                this.preview_enable_ = previewEnableCheckBox.Checked;

                this.twitter_api_url_ = TwitterApiUrl.Text.Trim();
                this.twitter_search_api_url_ = TwitterSearchApiUrl.Text.Trim();

                switch ( ComboReplyIconState.SelectedIndex ) {
                    case 0:
                        this.reply_icon_state_ = ReplyIconState.None;
                        break;

                    case 1:
                        this.reply_icon_state_ = ReplyIconState.StaticIcon;
                        break;

                    case 2:
                        this.reply_icon_state_ = ReplyIconState.BlinkIcon;
                        break;
                }

                switch ( LanguageComboSelectedIndex ) {
                    case 0:
                        this.language_ = "OS";
                        break;

                    case 1:
                        this.language_ = "ja";
                        break;

                    case 2:
                        this.language_ = "en";
                        break;

                    case 3:
                        this.language_ = "zh-CN";
                        break;

                    default:
                        this.language_ = "en";
                        break;
                }

                this.hotkey_enabled_ = CheckHotKey.Checked;
                this.hotkey_mod_ = Keys.None;

                if ( hotkeyAltCheckBox.Checked )
                    this.hotkey_mod_ = this.hotkey_mod_ | Keys.Alt;
                if ( hotkeyShiftCheckBox.Checked )
                    this.hotkey_mod_ = this.hotkey_mod_ | Keys.Shift;
                if ( hotkeyCtrlCheckBox.Checked )
                    this.hotkey_mod_ = this.hotkey_mod_ | Keys.Control;
                if ( hotkeyWinCheckBox.Checked )
                    this.hotkey_mod_ = this.hotkey_mod_ | Keys.LWin;

                int temp = 0;
                if ( int.TryParse( hotkeyCodeLabel.Text ) )
                    this.hotkey_value_ = Convert.ToInt32( hotkeyCodeLabel.Text );

                this.hotkey_key_ = (Keys)HotkeyEntry.Tag;
                this.blink_new_mentions_ = CheckNewMentionsBlink.Checked;
                this.use_additonal_count_ = useChangeGetCountCheckBox.Checked;
                this.more_count_api_ = Convert.ToInt32( getMoreTextCountApiEntry.Text );
                this.first_count_api_ = Convert.ToInt32( firstTextCountApiEntry.Text );
                this.search_count_api_ = Convert.ToInt32( SearchTextCuntApi.Text );
                this.favorites_count_api_ = Convert.ToInt32( favoritesTextCountApiEntry.Text );
                this.user_timelinee_count_api_ = Convert.ToInt32( UserTimeelineTextCountApi.Text );
                this.list_count_api_ = Convert.ToInt32( ListOpenuserTimeline.Checked );
                this.open_user_timeline_ = CheckOpenu8serTimeline.Checked;
                this.double_click_action_ = listDoubleClickActionComboBox.SelectedIndex;
                this.user_appoint_url_ = UserAppointUrlText.Text;

                this.HideDuplicatedRetweets = HideDuplicatedRetweetsCheck.Checked;
                this.is_preview_foursquare_ = IsPreviewFoursquareCheckBox.Checked;
                this.FoursquarePreviewWidth = Convert.ToInt32( FoursquarePreviewWidthTextBox.Text );
                this.FoursquarePreviewHeight = Convert.ToInt32( FoursquarePreviewHeightTextBox.Text );
                this.FoursquarePreviewZoom = Convert.ToInt32( FoursquarePreviewZoomTextBox.Text );

                this.is_list_statuses_include_retweets_ = IsListsIncludeRtsCheckBox.Checked;

                this.TabMouseLock = TabMouseLockCheck.Checked;
                this.is_remove_same_event_ = IsRemoveSameFavEventCheckBox.Checked;
                this.is_notify_use_growl_ = IsNotigyUseGrowlCheckBox.Checked;
            } catch ( Exception e ) {
                MessageBox.Show( Resurces["Save_ClickText3"] );
                base.DialogResult = DialogResult.Cancel;

                return ;
            }
        }


        private void Setting_FormClosing(object sender, FormClosingEventArgs fceargs) {
            if ( this.ending_flags_ )
                return ;

            if ( basebase.DialogResult == DialogResult.Cancel ) {
                /*
                 * キャンセル時は画面表示時のアカウントに戻します。
                 * キャンセル時でも認証済みのアカウント情報は保存します。
                 */
                this.user_accounts_.Clear();
                foreach ( object item in AuthUserCombo.Items ) {
                    this.user_accounts_.Add( item as UserAccount );
                }
                /*
                 * アクティブユーザーを起動時のアカウントに戻します(起動時にアカウントがなければ何もしません)。
                 */
                bool user_setting = false;
                if ( this.InitialUserId > 0 ) {
                    foreach ( UserAccount account in this.user_accounts_ ) {
                        if ( account.UserId == this.InitialUserId ) {
                            this.twetter_analysis_.Start( account.Token, account.TokenSecret, account.Username, account.UserId );
                            Google.GASender.Instance.SessionFirst = account.GAFirst;
                            Google.GASender.Instance.SessionLast = account.GALast;
                            user_setting = true;

                            break;
                        }
                    }
                }
                /* 
                 * 認証済みアカウントが削除されていた場合、もしくは起動時にアカウントがなかった場合は、
                 * アクティブユーザー無しとして初期化します。
                 */
                if ( !user_setting ) {
                    this.twetter_analysis_.ClearAuthInfo();
                    this.twetter_analysis_.Start( string.Empty, string.Empty, string.Empty, 0 );
                }
            }

            if ( this.twetter_analysis_ != null && this.twetter_analysis_.Username == string.Empty && fceargs.CoseReason == CloseReason.None ) {
                if ( MessageBox.Show( Resources["Setting_FormClosing1"],
                                      "Confirm",
                                      MessageBoxButtons.OKCancel,
                                      MessageBoxIcon.Question ) == DialogResult.Cancel ) {
                    fceargs.Cancel = true;
                }

                if ( this.validation_error_ )
                    fceargs.Cancel = true;

                if ( fceargs.Cancel == false && treeViewSetting.SelectedNode != null ) {
                    current_panel = treeViewSetting.SelectedNode as Panel;
                    current_panel.Visible = false;
                    current_panel.Enabled = false;
                }
            }
        }


        private void Setting_Load(object sender, EventArgs ergs) {
#if UA == true
            GroupBox2.Visible = true;
#else
            GroupBox2.Visible = false;
#endif
            this.twetter_analysis_ = ((TweenMain)this.Parent).TwitterInstance;

            string user_name = this.twetter_analysis_.Username;
            string password = this.twetter_analysis_.Password;
            string access_token = this.twetter_analysis_.AccessToken;
            string access_token_secret = this.twetter_analysis_.AccessTokenSecret;

            authClearButton.Enabled = true;

            AuthUserCombo.Item.Clear();
            if ( this.user_accounts_.Count > 0 ) {
                AuthUserCombo.Items.AddRange( this.UserAccounts );
                foreach ( UserAccount account in this.user_accounts_ ) {
                    if ( account.UserId == this.twetter_analysis_.UserId ) {
                        AuthUserCombo.SelectedItem = account;
                        this.InitialUserId = account.UserId;

                        break;
                    }
                }
            }

            startupUserstreamCheckBox.Checked = this.userstream_startup_;
            UserstreamPeriod.Text = this.userstream_period_.ToString();
            TimeelinePeriod.Text = this.timeline_period_.ToString();
            replyPeriod.Text = this.reply_period_.ToString();
            directMessagePeriodEntry.Text = this.directmessage_period_.ToString();
            pubSearchPeriodEntry.Text = this.public_search_period_.ToString();
            listsPeriodEntry.Text = this.lists_period_.ToString();
            userTimelinePeriodEntry.Text = this.user_timeeline_period_.ToString();

            startupReadedCheckBox.Checked = this.readed_;

            switch ( this.icon_size_ ) {
                case IconSizes.IconNone:
                    iconSizeComboBox.SelectedIndex = 0;
                    break;

                case IconSizes.Icon16:
                    iconSizeComboBox.SelectedIndex = 1;
                    break;

                case IconSizes.Icon24:
                    iconSizeComboBox.SelectedIndex = 2;
                    break;

                case IconSizes.Icon48:
                    iconSizeComboBox.SelectedIndex = 3;
                    break;

                case IconSizes.Icon48_2:
                    iconSizeComboBox.SelectedIndex = 4;
                    break;
            }

            listFontButton.Font = this.font_book_["readed"];
            unreadLabel.Font = this.font_book_["unread"];
            lblInputFont.ForeColor = this.color_book_["input_font"];
            detailLabel.Font = this.font_book_["detail"];
            lblInputFont.Font = this.font_book_["input_font"];

            listFontButton.ForeColor = this.color_book_["readed"];
            favoriteLabel.ForeColor = this.color_book_["favorite"];
            owlButton.ForeColor = this.color_book_["owl"];
            retweetLabel.ForeColor = this.color_book_["retweet"];
            detailLabel.ForeColor = this.color_book_["detail"];
            detailLinkLabel.ForeColor = this.color_book_["detail_link"];

            lblSelf.BackColor = this.color_book_["self"];
            lblAtSelf.BackColor = this.color_book_["at_self"];
            lblTarget.BackColor = this.color_book_["target"];
            lblAtTarget.BackColor = this.color_book_["at_target"];
            lblAtFromTarget.BackColor = this.color_book_["at_from_target"];
            lblAtTo.BackColor = this.color_book_["at_to"];
            lblInputBackcolor.BackColor = this.color_book_["input_back"];
            detailBackcolorLabel.BackColor = this.color_book_["detail_back"];
            lblListBackcolor.BackColor = this.color_book_["list_back"];

            switch ( this.name_ballon_ ) {
                case NameBallons.None:
                    nameBalloonComboBox.SelectedIndex = 0;
                    break;

                case NameBallons.UserID:
                    nameBalloonComboBox.SelectedIndex = 1;
                    break;

                case NameBallons.NickName:
                    nameBalloonComboBox.SelectedIndex = 2;
                    break;
            }

            if ( this.post_ctrl_enter_ )
                postKeySelectComboBox.SelectedIndex = 1;
            else if ( this.post_shift_enter_ )
                postKeySelectComboBox.SelectedIndex = 2;
            else
                postKeySelectComboBox.SelectedIndex = 0;

            countApiEntry.Text = this.count_api_.ToString();
            countApiReplyEntry.Text = this.count_api_reply_.ToString();
            browserPathEntry.Text = this.browser_path_;
            postAndGetCheckBox.Checked = this.post_and_get_;
            ChackUseRecommendStatus.Checked = this.use_recommend_status_;
            closeToExitCheckBox.Checked = this.close_to_exit_;
            minimizeToTrayCheckBox.Checked = this.minimize_to_tray_;

            switch ( this.dsplay_latest_post_ ) {
                case DisplayTitleKind.None:
                    ComboDispTitle.SelectedIndex = 0;
                    break;

                case DisplayTitleKind.Version:
                    ComboDispTitle.SelectedIndex = 1;
                    break;

                case DisplayTitleKind.Post:
                    ComboDispTitle.SelectedIndex = 2;
                    break;

                case DisplayTitleKind.UnreadReplyCount:
                    ComboDispTitle.SelectedIndex = 3;
                    break;

                case DisplayTitleKind.UnreadAllCount:
                    ComboDispTitle.SelectedIndex = 4;
                    break;

                case DisplayTitleKind.UnreadAllReplyCount:
                    ComboDispTitle.SelectedIndex = 5;
                    break;

                case DisplayTitleKind.UnreadCountAllCount:
                    ComboDispTitle.SelectedIndex = 6;
                    break;

                case DisplayTitleKind.OwnStatus:
                    ComboDispTitle.SelectedIndex = 7;
                    break;
            }

            sortOrderLockCheckBox.Checked = this.sort_order_lock_;
            CheckTinyUrl.Checked = this.tiny_url_resolve_;
            CheckForseResolve.Checked = this.short_url_force_resolve_;

            switch ( this.proxy_type_ ) {
                case ProxyType.None:
                    RaidoProxyNode.Checked = true;
                    break;

                case ProxyType.IE:
                    RaidoProxyIE.Checked = true;
                    break;

                default:
                    RaidoProxySpecified.Checked = true;
                    break;
            }

            bool check = proxySpecifiedRadioButton.Checked;

            proxyAddressLabel.Enabled = check;
            proxyAddressEntry.Enabled = check;

            proxyPortLabel.Enabled = check;
            proxyPortEntry.Enabled = check;

            proxyUserLabel.Enabled = check;
            proxyUserEntry.Enabled = check;

            proxyPasswordLabel.Enabled = check;
            proxyPasswordEntry.Enabled = check;

            proxyAddressEntry.Text = this.proxy_address_;
            proxyPortEntry.Text = this.proxy_port_;
            proxyUserEntry.Text = this.proxy_user_;
            proxyPasswordEntry.Text = this.proxy_password_;

            periodAdjustCheckBox.Checked = this.period_adjust_;
            startupVersionCheckBox.Checked = this.startup_version_;
            startupFollowersCheckBox.Checked = this.startup_followers_;
            favRestrictCheckBox.Checked = this.restrict_favorite_check_;
            alwaysTopCheckBox.Checked = this.always_top_;
            autoConvertUrlCheckBox.Checked = this.url_convert_auto_;

            ShortenTcoCheck.Checked = this.shorten_tco_;
            ShortenTcoCheck.Enabled = autoConvertUrlCheckBox.Checked;

            outputzCheckBox.Checked = this.outputz_;
            outputzKeyEntry.Text = this.outputz_key_;

            switch ( this.outputz_url_mode_ ) {
                case OutputzUrlmode.TwiiterCom:
                    outputzUrlmodeComboBox.SelectedIndex = 0;
                    break;

                case OutputzUrlmode.TwiiterComWithUsername:
                    outputzUrlmodeComboBox.SelectedIndex = 1;
                    break;
            }

            nicomsCheckBox.Checked = this.nicoms_;
            unreadStyleCheckBox.Checked = this.unread_style_;
            dateTimeFormatComboBox.Text = this.datetime_format_;
            connectionTimeOutEntry.Text = this.default_timeout_.ToString();
            retweetNoConfirmCheckBox.Checked = this.retweet_no_confirm_;
            balloonLimitCheckBox.Checked = this.limit_balloon_;

            ApplyEventNotifyFlag( this.event_notify_enabled_, this.event_notify_flag_, this.is_event_notify_flags_ );

            CheckForseEventNotify.Checked = this.force_event_notify_;
            favEventUnreadCheckBox.Checked = this.favorite_event_unread_;

            translateLanguageComboBox.SelectedIndex = new Bing().GetIndexFromLanguage( this.translate_language_ );

            SoundFileListup();

            autoShortUrlFirstComboBox.SelectedIndex = this.auto_short_url_first_;
            tabIconDispCheckBox.Checked = this.tab_icon_display_;
            readOwnPostCheckBox.Checked = this.read_own_post_;
            getFavoriteCheckBox.Checked = this.get_favorite_;
            monospaceCheckBox.Checked = this.mono_space_;
            readOldPostsCheckBox.Checked = this.read_old_posts_;
            useSslCheckBox.Checked = this.use_ssl_;
            bitlyIdEntry.Text = this.bitly_id_;
            bitlyPasswordEntry.Text = this.bitly_password_;
            showGridCheckBox.Checked = this.show_grid_;
            atIdSuppleCheckBox.Checked = this.use_at_id_supplement_;
            hashSuppleCheckBox.Checked = this.use_hash_supplement_;
            previewEnableCheckBox.Checked = this.preview_enable_;
            TwitterAPIEntry.Text = this.twitter_api_url_;
            TwitterSearchAPIEntry.Text = this.twitter_search_api_url_;
        }


        private Twitter twitter_analysis_;
        private int timeline_period_;
        private int direct_message_period_;
        private int public_search_period_;
        private int lists_period_;
        private int user_timeline_period_;
        private int log_days_;
        private LogUnitEnum log_unit_;
        private bool readed_;
        private IconSizes icon_size_;
        private string status_text_;
        private string recommend_status_text_;
        private bool play_sound_;
        private bool one_way_love_;

        private Dictionary<string, Font> font_book_;
        private Dictionary<string, Color> color_book_;

        private bool post_ctrl_enter_;
        private bool post_shift_enter_;

        private bool use_post_method_;
        private int count_api_;
        private int count_api_reply_;

        private string browser_path_;
        private bool use_recomment_status_;

        private bool display_username_;
        private DisplayTitleKind display_latest_post_;

        private bool sort_order_lock_;
        private bool minimize_to_tray_;
        private bool close_to_exit_;
        private bool tiny_url_resolve_;
        private bool short_url_force_resolve_;

        private ProxyType proxy_type_;
        private string proxy_address_;
        private int proxy_port_;
        private string proxy_user_;
        private string proxy_password_;

        private bool period_adjust_;

        private bool startup_version_;
        private bool startup_followers_;

        private bool restrict_fav_check_;

        private bool always_top_;
        private bool url_convert_auto_;
        private bool shorten_tco_;

        private bool outputz_;
        private string outputz_key_;
        private OutputzUrlMode outputz_url_mode_;

        private bool nicoms_;

        private bool unread_style_;

        private string datetime_format_;
        private int default_timeout_;

        private bool limit_balloon_;
        private bool post_and_get_;

        private int reply_period_;

        private UrlConvertor auto_short_url_first_;

        private bool tab_icon_display_;

        private ReplyIconState reply_icon_state_;
        private bool read_own_post_;

        private bool get_favorites_;

        private bool mono_space_;
        private bool read_old_posts_;
        private bool use_ssl_;

        private string bitly_id_;
        private string biyly_password_;

        private bool show_grid_;

        private bool use_at_id_supplement_;
        private bool use_hash_supplement_;

        private string language_;

        private string twitter_api_url_;
        private string twitter_search_api_url_;

        private bool preview_enable_;
        private int more_count_api_;
        private int first_count_api_;
        private bool use_additonal_count_;
        private int search_count_api_;
        private int cavorites_count_api_;
        private int user_timeline_count_api_;
        private int list_count_api_;
        private bool retweet_no_confirm_;
        private bool userstream_startup_;
        private bool open_user_timeline_;

        private bool validation_error_ = false;
        private bool event_notify_enabled_;
        private TweenEventType event_notify_flag_;
        private TweenEventType is_event_notify_flag_;
        private bool force_event_notify_;
        private bool facorite_event_unread_;

        private string translate_language_;
        private string event_sound_file_;

        private int userstream_period_;

        private int double_click_action_;
        private string user_appoint_url_;

        private int initial_user_id_;
        private string pin_;

        // 
        // プロパティ
        //
        private bool is_preview_foursquare_;
        private int foursquare_preview_height_;
        private int foursquare_preview_width_;
        private int foursquare_preview_zoom_;
        private bool is_list_statuses_include_retweets_;
        private List<UserAccount> user_accounts_;
        private bool tab_mouse_lock_;
        private bool is_remove_same_event_;
        private bool is_notify_use_growl_;
        private Tween.Extensions.Twitter.DataModel.Configuration twitter_configuration_;

        private static AppendSettingDialog _instance = new AppendSettingDialog();
    }


}
// Local Variables:
//   mode: ecmascript
//   coding: utf-8
// End:
