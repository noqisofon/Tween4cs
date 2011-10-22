using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Tween {


    public class AppendSettingDialog {
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


        public TwitterDataModel.Configuration TwitterConfiguration {
            get { return this.twitter_configuration_; }
            set {
                if ( value != null )
                    this.twitter_configuration_ = value;
            }
        }


        private void TreeViewSetting_BeforeSelect(object sender, TreeViewCancelEventArgs tvcergs) {
            if ( this.TreeViewSetting.SelectedNode == null )
                return ;

            Panel panel = this.TreeViewSetting.SelectedNode.Tag as Panel;
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
                    IsNotifyUseGrowlCheckBox.Enabled = true;
                else
                    IsNotifyUseGrowlCheckBox.Enabled = false;
            }
        }


        private void btnSave_Click(object sender, EventArgs ergs) {
            if ( TweenMain.IsNetworkAvailable
                 && (ComboBoxAutoShortUrlFirst.SelectedIndex == UrlConvertor.Bitly
                     || ComboBoxAutoShortUrlFirst.SelectedIndex == UrlConvertor.Jmp)
                 && ( !string.IsNullOrEmpty( TextBitlyId.Text ) || !string.IsNullOrEmpty( TextBitlyPw.Text ) ) ) {
                if ( !BitlyValidation( TextBitlyId.Text, TextBitlyPw.Text ) ) {
                    MessageBox.Show( Resources["SettingSave_ClickText1"] );
                    this.validation_error_ = true;
                    this.TreeViewSetting.SelectedNode.Name = "TweetActNode";  // 動作タブを選択します。

                    TextBitlyId.Focus();

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
#if UA == "True"
            if ( FollowCheckBox.Checked ) {
                ProxyType proxy_type;

                if ( RadioProxyNone.Checked )
                    proxy_type = ProxyType.None;
                else if ( RadioProxyIE.Checked )
                    proxy_type = ProxyType.IE;
                else
                    proxy_type = ProxyType.Specified;

                string proxy_address = TextProxyAddress.Text.Trim();
                int proxy_port = int.Parse( TextProxyPort.Text.Trim() );
                string proxy_username = TextProxyUser.Text.Trim();
                string proxy_password = TextProxyPassword.Text.Trim();

                HttpConnection.InitializeConnection( 20, proxy_type, proxy_address, proxy_port, proxy_username, proxy_password );

                string ret = this.twitter_analysis_.PostFollowCommand( "Tween4csApp" );
            }
#endif
            IntervalChangedEventArgs arg;
            bool is_interval_changed = false;

            try {
                this.userstream_startup_ = this.StartupUserstreamCheck.Checked;

                if ( this.userstream_period_ != Convert.ToInt32( UserstreamPeriod.Text ) ) {
                    this.userstream_period_ = Convert.ToInt32( UserstreamPeriod.Text );
                    arg.UserStream = true;
                    is_interval_changed = true;
                }

                if ( this.timeline_period_ != Convert.ToInt32( TimelinePeriod.Text ) ) {
                    this.timeline_period_ = Convert.ToInt32( TimelinePeriod.Text );
                    arg.Timeline = true;
                    is_interval_changed = true;
                }
            }
        }


        private TwitterAnalysis twitter_analysis_;
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

        private string browser_path_;

        private bool use_recomment_status_;

        private bool display_username_;
        private DisplayTitles display_latest_post_;

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
        private TwitterDataModel.Configuration twitter_configuration_;

        private static AppendSettingDialog _instance = new AppendSettingDialog();


        
    }


}
// Local Variables:
//   mode: ecmascript
//   coding: utf-8
// End:
