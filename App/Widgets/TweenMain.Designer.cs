namespace Tween.Widgets {
    partial class TweenMain : System.Windows.Forms.Form {
        /**
         * フォームがコンポーネントの一覧をクリーンアップするために Dispose メソッドをオーバーライドします。
         */
        protected override void Dispose(bool disposing) {
            try {
                if ( disposing && components != null )
                    components.Dispose();
            } finally {
                base.Dispose( disposing );
            }
        }


        //  Windows フォームデザイナーで必要です。
        private System.ComponentModel.IContainer components;


        //
        // メモ:
        //     以下のメソッドは Windows フォームデザイナーで必要です。
        //     Windows フォームデザイナーを使用して変更できます。
        //     コード エディターを使って変更しないでください。
        //
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof(TweenMain) );

            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon();
            this.ContextMenuFile = new System.Windows.Forms.ContextMenuStrip();
            this.EndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuOperate = new System.Windows.Forms.ContextMenuStrip();
            this.DMStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.TabImage = new System.Windows.Forms.ImageList();
            this.NewPostPopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListLockMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JumpUnreadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TimerRefreshIcon = new System.Windows.Forms.Timer();
            this.ContextMenuTabProperty = new System.Windows.Forms.ContextMenuStrip();
            this.UreadManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyDispMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoundFileComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.PlaySoundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ContextMenuUserPicture = new System.Windows.Forms.ContextMenuStrip();
            this.IconNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveIconPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListTab = new System.Windows.Forms.TabControl();
            this.MenuItemTab = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOperate = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabelUrl = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CopySTOTMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyURLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSubSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSearchNext = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSearchPrev = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MatomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.VerUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserPicture = new TweenCustomControl.PictureBoxEx();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.lblLen = new System.Windows.Forms.Label();
            this.PostButton = new System.Windows.Forms.Button();
            this.TinyUrlConvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateFollowersMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TinyURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsgdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrlConvertAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrlUndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuPostBrowser = new System.Windows.Forms.ContextMenuStrip();
            this.SelectionSearchContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectionCopyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectionAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchWikipediaContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchGoogleContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchYatsContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPublicSearchContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrlCopyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToFavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RepliedStatusOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavorareMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenURLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.TabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDRuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadedStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnreadStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplyAllStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReTweetStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuPostMode = new System.Windows.Forms.ContextMenuStrip();
            this.ToolStripMenuItemUrlMultibyteSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemApiCommandEvasion = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUrlAutoShorten = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DumpPostClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TraceOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwurlnlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabRenameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApiInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdeographicSpaceToSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FollowCommandMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveCommandMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FriendshipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.OwnStatusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReTweetOriginalStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.FollowContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FriendshipContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JmpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuoteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshMoreStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoRemoveTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveToRTHomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdFilterAddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.PublicSearchQueryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UseHashtagMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLabel = new Tween.TweenCustomControl.ToolStripLabelHistory();
            this.HashStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.HashToggleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.HashManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MultiLineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.NotifyFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaySoundFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LockListFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.EndFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplyOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplyAllOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DmOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RtOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RtUnOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QtOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.FavOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnFavOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateRuleOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangeReadOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JumpReadOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.SelAllOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshPrevOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenHomeOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFavOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStatusOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenRepSourceOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFavotterOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenUrlOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenRterHomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTabRuleOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateIdRuleOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnreadOpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameTbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnreadMngTbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyTbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditRuleTbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoundFileTbComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripSeparator28 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator29 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator30 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator31 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator32 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator33 = new System.Windows.Forms.ToolStripSeparator();
            this.PostBrowser = new System.Windows.Forms.WebBrowser();
            this.SplitContainer3 = new System.Windows.Forms.SplitContainer();
            this.PreviewPicture = new TweenCustomControl.PictureBoxEx();
            this.PreviewScrollBar = new System.Windows.Forms.VScrollBar();
            this.ToolTip1 = new System.Windows.Forms.ToolTip();
            this.FollowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnFollowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowFriendShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowUserStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowUserStatusContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowProfMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator34 = new System.Windows.Forms.ToolStripSeparator();
            this.HashToggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HashManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RtCountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPostsDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchAtPostsDetailNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimelinePanel = new System.Windows.Forms.Panel();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.FilePickButton = new System.Windows.Forms.Button();
            this.ImagefilePathText = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ImageSelectedPicture = new TweenCustomControl.PictureBoxEx();
            this.ImageSelectionPanel = new System.Windows.Forms.Panel();
            this.ImagePathPanel = new System.Windows.Forms.Panel();
            this.ImageServiceCombo = new System.Windows.Forms.ComboBox();
            this.ImageSelectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator35 = new System.Windows.Forms.ToolStripSeparator();
            this.FriendshipAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator36 = new System.Windows.Forms.ToolStripSeparator();
            this.UserStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageCancelButton = new System.Windows.Forms.Button();
            this.ToolStripFocusLockMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListManageUserContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator37 = new System.Windows.Forms.ToolStripSeparator();
            this.ShortcutKeyListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListManageUserContextToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListManageUserContextToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CacheInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CopyUserIdStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavoriteRetweetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavoriteRetweetUnofficialMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator38 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator39 = new System.Windows.Forms.ToolStripSeparator();
            this.FavoriteRetweetContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FavoriteRetweetUnofficialContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowRelatedStatusesMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowRelatedStatusesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUserStream = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator40 = new System.Windows.Forms.ToolStripSeparator();
            this.TrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllrepliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TweenRestartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPostsDetailNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchAtPostsDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator41 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenOwnHomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOwnFavedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator42 = new System.Windows.Forms.ToolStripSeparator();
            this.EventViewerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TranslationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UxnuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowUserTimelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowUserTimelineContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserTimelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserFavorareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectionTranslationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator43 = new System.Windows.Forms.ToolStripSeparator();
            this.StopRefreshAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenUserSpecifiedUrlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenUserSpecifiedUrlMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PostStateImageList = new System.Windows.Forms.ImageList();
            this.SplitContainer4 = new System.Windows.Forms.SplitContainer();
            this.ContextMenuSource = new System.Windows.Forms.ContextMenuStrip();
            this.SourceCopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SourceUrlCopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer3).BeginInit();
            this.SplitContainer3.Panel1.SuspendLayout();
            this.SplitContainer3.Panel2.SuspendLayout();
            this.SplitContainer3.SuspendLayout();
            this.TimelinePanel.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.ImageSelectionPanel.SuspendLayout();
            this.ImagePathPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer4).BeginInit();
            this.SplitContainer4.Panel1.SuspendLayout();
            this.SplitContainer4.Panel2.SuspendLayout();
            this.SplitContainer4.SuspendLayout();
            this.SuspendLayout();

            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.AccessibleDescription = null;
            this.NotifyIcon1.AccessibleName = null;
            this.NotifyIcon1.BackgroundImage = null;
            resources.ApplyResources( this.NotifyIcon1, "NotifyIcon1" );
            this.NotifyIcon1.Font = null;
            this.NotifyIcon1.Name = "NotifyIcon1";
            // 
            // ContextMenuFile
            // 
            this.ContextMenuFile.AccessibleDescription = null;
            this.ContextMenuFile.AccessibleName = null;
            this.ContextMenuFile.BackgroundImage = null;
            resources.ApplyResources( this.ContextMenuFile, "ContextMenuFile" );
            this.ContextMenuFile.Font = null;
            this.ContextMenuFile.Name = "ContextMenuFile";
            // 
            // EndToolStripMenuItem
            // 
            this.EndToolStripMenuItem.AccessibleDescription = null;
            this.EndToolStripMenuItem.AccessibleName = null;
            this.EndToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.EndToolStripMenuItem, "EndToolStripMenuItem" );
            this.EndToolStripMenuItem.Font = null;
            this.EndToolStripMenuItem.Name = "EndToolStripMenuItem";
            // 
            // ContextMenuOperate
            // 
            this.ContextMenuOperate.AccessibleDescription = null;
            this.ContextMenuOperate.AccessibleName = null;
            this.ContextMenuOperate.BackgroundImage = null;
            resources.ApplyResources( this.ContextMenuOperate, "ContextMenuOperate" );
            this.ContextMenuOperate.Font = null;
            this.ContextMenuOperate.Name = "ContextMenuOperate";
            // 
            // DMStripMenuItem
            // 
            this.DMStripMenuItem.AccessibleDescription = null;
            this.DMStripMenuItem.AccessibleName = null;
            this.DMStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.DMStripMenuItem, "DMStripMenuItem" );
            this.DMStripMenuItem.Font = null;
            this.DMStripMenuItem.Name = "DMStripMenuItem";
            // 
            // DeleteStripMenuItem
            // 
            this.DeleteStripMenuItem.AccessibleDescription = null;
            this.DeleteStripMenuItem.AccessibleName = null;
            this.DeleteStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.DeleteStripMenuItem, "DeleteStripMenuItem" );
            this.DeleteStripMenuItem.Font = null;
            this.DeleteStripMenuItem.Name = "DeleteStripMenuItem";
            // 
            // RefreshStripMenuItem
            // 
            this.RefreshStripMenuItem.AccessibleDescription = null;
            this.RefreshStripMenuItem.AccessibleName = null;
            this.RefreshStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RefreshStripMenuItem, "RefreshStripMenuItem" );
            this.RefreshStripMenuItem.Font = null;
            this.RefreshStripMenuItem.Name = "RefreshStripMenuItem";
            // 
            // SettingStripMenuItem
            // 
            this.SettingStripMenuItem.AccessibleDescription = null;
            this.SettingStripMenuItem.AccessibleName = null;
            this.SettingStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SettingStripMenuItem, "SettingStripMenuItem" );
            this.SettingStripMenuItem.Font = null;
            this.SettingStripMenuItem.Name = "SettingStripMenuItem";
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.AccessibleDescription = null;
            this.ToolStripSeparator9.AccessibleName = null;
            this.ToolStripSeparator9.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator9, "ToolStripSeparator9" );
            this.ToolStripSeparator9.Font = null;
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            // 
            // TabImage
            // 
            this.TabImage.AccessibleDescription = null;
            this.TabImage.AccessibleName = null;
            this.TabImage.BackgroundImage = null;
            resources.ApplyResources( this.TabImage, "TabImage" );
            this.TabImage.Font = null;
            this.TabImage.Name = "TabImage";
            // 
            // NewPostPopMenuItem
            // 
            this.NewPostPopMenuItem.AccessibleDescription = null;
            this.NewPostPopMenuItem.AccessibleName = null;
            this.NewPostPopMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.NewPostPopMenuItem, "NewPostPopMenuItem" );
            this.NewPostPopMenuItem.Font = null;
            this.NewPostPopMenuItem.Name = "NewPostPopMenuItem";
            // 
            // ListLockMenuItem
            // 
            this.ListLockMenuItem.AccessibleDescription = null;
            this.ListLockMenuItem.AccessibleName = null;
            this.ListLockMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ListLockMenuItem, "ListLockMenuItem" );
            this.ListLockMenuItem.Font = null;
            this.ListLockMenuItem.Name = "ListLockMenuItem";
            // 
            // JumpUnreadMenuItem
            // 
            this.JumpUnreadMenuItem.AccessibleDescription = null;
            this.JumpUnreadMenuItem.AccessibleName = null;
            this.JumpUnreadMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.JumpUnreadMenuItem, "JumpUnreadMenuItem" );
            this.JumpUnreadMenuItem.Font = null;
            this.JumpUnreadMenuItem.Name = "JumpUnreadMenuItem";
            // 
            // ToolStripSeparator15
            // 
            this.ToolStripSeparator15.AccessibleDescription = null;
            this.ToolStripSeparator15.AccessibleName = null;
            this.ToolStripSeparator15.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator15, "ToolStripSeparator15" );
            this.ToolStripSeparator15.Font = null;
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.AccessibleDescription = null;
            this.ToolStripSeparator4.AccessibleName = null;
            this.ToolStripSeparator4.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator4, "ToolStripSeparator4" );
            this.ToolStripSeparator4.Font = null;
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            // 
            // SaveLogMenuItem
            // 
            this.SaveLogMenuItem.AccessibleDescription = null;
            this.SaveLogMenuItem.AccessibleName = null;
            this.SaveLogMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SaveLogMenuItem, "SaveLogMenuItem" );
            this.SaveLogMenuItem.Font = null;
            this.SaveLogMenuItem.Name = "SaveLogMenuItem";
            // 
            // ToolStripSeparator17
            // 
            this.ToolStripSeparator17.AccessibleDescription = null;
            this.ToolStripSeparator17.AccessibleName = null;
            this.ToolStripSeparator17.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator17, "ToolStripSeparator17" );
            this.ToolStripSeparator17.Font = null;
            this.ToolStripSeparator17.Name = "ToolStripSeparator17";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.AccessibleDescription = null;
            this.SaveFileDialog1.AccessibleName = null;
            this.SaveFileDialog1.BackgroundImage = null;
            resources.ApplyResources( this.SaveFileDialog1, "SaveFileDialog1" );
            this.SaveFileDialog1.Font = null;
            this.SaveFileDialog1.Name = "SaveFileDialog1";
            // 
            // TimerRefreshIcon
            // 
            this.TimerRefreshIcon.AccessibleDescription = null;
            this.TimerRefreshIcon.AccessibleName = null;
            this.TimerRefreshIcon.BackgroundImage = null;
            resources.ApplyResources( this.TimerRefreshIcon, "TimerRefreshIcon" );
            this.TimerRefreshIcon.Font = null;
            this.TimerRefreshIcon.Name = "TimerRefreshIcon";
            // 
            // ContextMenuTabProperty
            // 
            this.ContextMenuTabProperty.AccessibleDescription = null;
            this.ContextMenuTabProperty.AccessibleName = null;
            this.ContextMenuTabProperty.BackgroundImage = null;
            resources.ApplyResources( this.ContextMenuTabProperty, "ContextMenuTabProperty" );
            this.ContextMenuTabProperty.Font = null;
            this.ContextMenuTabProperty.Name = "ContextMenuTabProperty";
            // 
            // UreadManageMenuItem
            // 
            this.UreadManageMenuItem.AccessibleDescription = null;
            this.UreadManageMenuItem.AccessibleName = null;
            this.UreadManageMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UreadManageMenuItem, "UreadManageMenuItem" );
            this.UreadManageMenuItem.Font = null;
            this.UreadManageMenuItem.Name = "UreadManageMenuItem";
            // 
            // NotifyDispMenuItem
            // 
            this.NotifyDispMenuItem.AccessibleDescription = null;
            this.NotifyDispMenuItem.AccessibleName = null;
            this.NotifyDispMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.NotifyDispMenuItem, "NotifyDispMenuItem" );
            this.NotifyDispMenuItem.Font = null;
            this.NotifyDispMenuItem.Name = "NotifyDispMenuItem";
            // 
            // SoundFileComboBox
            // 
            this.SoundFileComboBox.AccessibleDescription = null;
            this.SoundFileComboBox.AccessibleName = null;
            this.SoundFileComboBox.BackgroundImage = null;
            resources.ApplyResources( this.SoundFileComboBox, "SoundFileComboBox" );
            this.SoundFileComboBox.Font = null;
            this.SoundFileComboBox.Name = "SoundFileComboBox";
            // 
            // ToolStripSeparator18
            // 
            this.ToolStripSeparator18.AccessibleDescription = null;
            this.ToolStripSeparator18.AccessibleName = null;
            this.ToolStripSeparator18.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator18, "ToolStripSeparator18" );
            this.ToolStripSeparator18.Font = null;
            this.ToolStripSeparator18.Name = "ToolStripSeparator18";
            // 
            // DeleteTabMenuItem
            // 
            this.DeleteTabMenuItem.AccessibleDescription = null;
            this.DeleteTabMenuItem.AccessibleName = null;
            this.DeleteTabMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.DeleteTabMenuItem, "DeleteTabMenuItem" );
            this.DeleteTabMenuItem.Font = null;
            this.DeleteTabMenuItem.Name = "DeleteTabMenuItem";
            // 
            // FilterEditMenuItem
            // 
            this.FilterEditMenuItem.AccessibleDescription = null;
            this.FilterEditMenuItem.AccessibleName = null;
            this.FilterEditMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FilterEditMenuItem, "FilterEditMenuItem" );
            this.FilterEditMenuItem.Font = null;
            this.FilterEditMenuItem.Name = "FilterEditMenuItem";
            // 
            // ToolStripSeparator19
            // 
            this.ToolStripSeparator19.AccessibleDescription = null;
            this.ToolStripSeparator19.AccessibleName = null;
            this.ToolStripSeparator19.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator19, "ToolStripSeparator19" );
            this.ToolStripSeparator19.Font = null;
            this.ToolStripSeparator19.Name = "ToolStripSeparator19";
            // 
            // AddTabMenuItem
            // 
            this.AddTabMenuItem.AccessibleDescription = null;
            this.AddTabMenuItem.AccessibleName = null;
            this.AddTabMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.AddTabMenuItem, "AddTabMenuItem" );
            this.AddTabMenuItem.Font = null;
            this.AddTabMenuItem.Name = "AddTabMenuItem";
            // 
            // ToolStripSeparator20
            // 
            this.ToolStripSeparator20.AccessibleDescription = null;
            this.ToolStripSeparator20.AccessibleName = null;
            this.ToolStripSeparator20.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator20, "ToolStripSeparator20" );
            this.ToolStripSeparator20.Font = null;
            this.ToolStripSeparator20.Name = "ToolStripSeparator20";
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.AccessibleDescription = null;
            this.ToolStripSeparator10.AccessibleName = null;
            this.ToolStripSeparator10.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator10, "ToolStripSeparator10" );
            this.ToolStripSeparator10.Font = null;
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            // 
            // SelectAllMenuItem
            // 
            this.SelectAllMenuItem.AccessibleDescription = null;
            this.SelectAllMenuItem.AccessibleName = null;
            this.SelectAllMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SelectAllMenuItem, "SelectAllMenuItem" );
            this.SelectAllMenuItem.Font = null;
            this.SelectAllMenuItem.Name = "SelectAllMenuItem";
            // 
            // ClearTabMenuItem
            // 
            this.ClearTabMenuItem.AccessibleDescription = null;
            this.ClearTabMenuItem.AccessibleName = null;
            this.ClearTabMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ClearTabMenuItem, "ClearTabMenuItem" );
            this.ClearTabMenuItem.Font = null;
            this.ClearTabMenuItem.Name = "ClearTabMenuItem";
            // 
            // ToolStripSeparator11
            // 
            this.ToolStripSeparator11.AccessibleDescription = null;
            this.ToolStripSeparator11.AccessibleName = null;
            this.ToolStripSeparator11.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator11, "ToolStripSeparator11" );
            this.ToolStripSeparator11.Font = null;
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            // 
            // PlaySoundMenuItem
            // 
            this.PlaySoundMenuItem.AccessibleDescription = null;
            this.PlaySoundMenuItem.AccessibleName = null;
            this.PlaySoundMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.PlaySoundMenuItem, "PlaySoundMenuItem" );
            this.PlaySoundMenuItem.Font = null;
            this.PlaySoundMenuItem.Name = "PlaySoundMenuItem";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.AccessibleDescription = null;
            this.OpenFileDialog1.AccessibleName = null;
            this.OpenFileDialog1.BackgroundImage = null;
            resources.ApplyResources( this.OpenFileDialog1, "OpenFileDialog1" );
            this.OpenFileDialog1.Font = null;
            this.OpenFileDialog1.Name = "OpenFileDialog1";
            // 
            // ContextMenuUserPicture
            // 
            this.ContextMenuUserPicture.AccessibleDescription = null;
            this.ContextMenuUserPicture.AccessibleName = null;
            this.ContextMenuUserPicture.BackgroundImage = null;
            resources.ApplyResources( this.ContextMenuUserPicture, "ContextMenuUserPicture" );
            this.ContextMenuUserPicture.Font = null;
            this.ContextMenuUserPicture.Name = "ContextMenuUserPicture";
            // 
            // IconNameToolStripMenuItem
            // 
            this.IconNameToolStripMenuItem.AccessibleDescription = null;
            this.IconNameToolStripMenuItem.AccessibleName = null;
            this.IconNameToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.IconNameToolStripMenuItem, "IconNameToolStripMenuItem" );
            this.IconNameToolStripMenuItem.Font = null;
            this.IconNameToolStripMenuItem.Name = "IconNameToolStripMenuItem";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.AccessibleDescription = null;
            this.ToolStripMenuItem1.AccessibleName = null;
            this.ToolStripMenuItem1.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripMenuItem1, "ToolStripMenuItem1" );
            this.ToolStripMenuItem1.Font = null;
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            // 
            // SaveIconPictureToolStripMenuItem
            // 
            this.SaveIconPictureToolStripMenuItem.AccessibleDescription = null;
            this.SaveIconPictureToolStripMenuItem.AccessibleName = null;
            this.SaveIconPictureToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SaveIconPictureToolStripMenuItem, "SaveIconPictureToolStripMenuItem" );
            this.SaveIconPictureToolStripMenuItem.Font = null;
            this.SaveIconPictureToolStripMenuItem.Name = "SaveIconPictureToolStripMenuItem";
            // 
            // ToolStripContainer1
            // 
            this.ToolStripContainer1.AccessibleDescription = null;
            this.ToolStripContainer1.AccessibleName = null;
            this.ToolStripContainer1.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripContainer1, "ToolStripContainer1" );
            this.ToolStripContainer1.Font = null;
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.AccessibleDescription = null;
            this.SplitContainer1.AccessibleName = null;
            this.SplitContainer1.BackgroundImage = null;
            resources.ApplyResources( this.SplitContainer1, "SplitContainer1" );
            this.SplitContainer1.Font = null;
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // ListTab
            // 
            this.ListTab.AccessibleDescription = null;
            this.ListTab.AccessibleName = null;
            this.ListTab.BackgroundImage = null;
            resources.ApplyResources( this.ListTab, "ListTab" );
            this.ListTab.Font = null;
            this.ListTab.Name = "ListTab";
            // 
            // MenuItemTab
            // 
            this.MenuItemTab.AccessibleDescription = null;
            this.MenuItemTab.AccessibleName = null;
            this.MenuItemTab.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemTab, "MenuItemTab" );
            this.MenuItemTab.Font = null;
            this.MenuItemTab.Name = "MenuItemTab";
            // 
            // MenuItemOperate
            // 
            this.MenuItemOperate.AccessibleDescription = null;
            this.MenuItemOperate.AccessibleName = null;
            this.MenuItemOperate.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemOperate, "MenuItemOperate" );
            this.MenuItemOperate.Font = null;
            this.MenuItemOperate.Name = "MenuItemOperate";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.AccessibleDescription = null;
            this.StatusStrip1.AccessibleName = null;
            this.StatusStrip1.BackgroundImage = null;
            resources.ApplyResources( this.StatusStrip1, "StatusStrip1" );
            this.StatusStrip1.Font = null;
            this.StatusStrip1.Name = "StatusStrip1";
            // 
            // StatusLabelUrl
            // 
            this.StatusLabelUrl.AccessibleDescription = null;
            this.StatusLabelUrl.AccessibleName = null;
            this.StatusLabelUrl.BackgroundImage = null;
            resources.ApplyResources( this.StatusLabelUrl, "StatusLabelUrl" );
            this.StatusLabelUrl.Font = null;
            this.StatusLabelUrl.Name = "StatusLabelUrl";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.AccessibleDescription = null;
            this.MenuStrip1.AccessibleName = null;
            this.MenuStrip1.BackgroundImage = null;
            resources.ApplyResources( this.MenuStrip1, "MenuStrip1" );
            this.MenuStrip1.Font = null;
            this.MenuStrip1.Name = "MenuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.AccessibleDescription = null;
            this.MenuItemFile.AccessibleName = null;
            this.MenuItemFile.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemFile, "MenuItemFile" );
            this.MenuItemFile.Font = null;
            this.MenuItemFile.Name = "MenuItemFile";
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.AccessibleDescription = null;
            this.MenuItemEdit.AccessibleName = null;
            this.MenuItemEdit.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemEdit, "MenuItemEdit" );
            this.MenuItemEdit.Font = null;
            this.MenuItemEdit.Name = "MenuItemEdit";
            // 
            // CopySTOTMenuItem
            // 
            this.CopySTOTMenuItem.AccessibleDescription = null;
            this.CopySTOTMenuItem.AccessibleName = null;
            this.CopySTOTMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.CopySTOTMenuItem, "CopySTOTMenuItem" );
            this.CopySTOTMenuItem.Font = null;
            this.CopySTOTMenuItem.Name = "CopySTOTMenuItem";
            // 
            // CopyURLMenuItem
            // 
            this.CopyURLMenuItem.AccessibleDescription = null;
            this.CopyURLMenuItem.AccessibleName = null;
            this.CopyURLMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.CopyURLMenuItem, "CopyURLMenuItem" );
            this.CopyURLMenuItem.Font = null;
            this.CopyURLMenuItem.Name = "CopyURLMenuItem";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.AccessibleDescription = null;
            this.ToolStripSeparator6.AccessibleName = null;
            this.ToolStripSeparator6.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator6, "ToolStripSeparator6" );
            this.ToolStripSeparator6.Font = null;
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            // 
            // MenuItemSubSearch
            // 
            this.MenuItemSubSearch.AccessibleDescription = null;
            this.MenuItemSubSearch.AccessibleName = null;
            this.MenuItemSubSearch.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemSubSearch, "MenuItemSubSearch" );
            this.MenuItemSubSearch.Font = null;
            this.MenuItemSubSearch.Name = "MenuItemSubSearch";
            // 
            // MenuItemSearchNext
            // 
            this.MenuItemSearchNext.AccessibleDescription = null;
            this.MenuItemSearchNext.AccessibleName = null;
            this.MenuItemSearchNext.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemSearchNext, "MenuItemSearchNext" );
            this.MenuItemSearchNext.Font = null;
            this.MenuItemSearchNext.Name = "MenuItemSearchNext";
            // 
            // MenuItemSearchPrev
            // 
            this.MenuItemSearchPrev.AccessibleDescription = null;
            this.MenuItemSearchPrev.AccessibleName = null;
            this.MenuItemSearchPrev.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemSearchPrev, "MenuItemSearchPrev" );
            this.MenuItemSearchPrev.Font = null;
            this.MenuItemSearchPrev.Name = "MenuItemSearchPrev";
            // 
            // MenuItemCommand
            // 
            this.MenuItemCommand.AccessibleDescription = null;
            this.MenuItemCommand.AccessibleName = null;
            this.MenuItemCommand.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemCommand, "MenuItemCommand" );
            this.MenuItemCommand.Font = null;
            this.MenuItemCommand.Name = "MenuItemCommand";
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.AccessibleDescription = null;
            this.MenuItemHelp.AccessibleName = null;
            this.MenuItemHelp.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemHelp, "MenuItemHelp" );
            this.MenuItemHelp.Font = null;
            this.MenuItemHelp.Name = "MenuItemHelp";
            // 
            // MatomeMenuItem
            // 
            this.MatomeMenuItem.AccessibleDescription = null;
            this.MatomeMenuItem.AccessibleName = null;
            this.MatomeMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.MatomeMenuItem, "MatomeMenuItem" );
            this.MatomeMenuItem.Font = null;
            this.MatomeMenuItem.Name = "MatomeMenuItem";
            // 
            // ToolStripSeparator16
            // 
            this.ToolStripSeparator16.AccessibleDescription = null;
            this.ToolStripSeparator16.AccessibleName = null;
            this.ToolStripSeparator16.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator16, "ToolStripSeparator16" );
            this.ToolStripSeparator16.Font = null;
            this.ToolStripSeparator16.Name = "ToolStripSeparator16";
            // 
            // VerUpMenuItem
            // 
            this.VerUpMenuItem.AccessibleDescription = null;
            this.VerUpMenuItem.AccessibleName = null;
            this.VerUpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.VerUpMenuItem, "VerUpMenuItem" );
            this.VerUpMenuItem.Font = null;
            this.VerUpMenuItem.Name = "VerUpMenuItem";
            // 
            // ToolStripSeparator14
            // 
            this.ToolStripSeparator14.AccessibleDescription = null;
            this.ToolStripSeparator14.AccessibleName = null;
            this.ToolStripSeparator14.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator14, "ToolStripSeparator14" );
            this.ToolStripSeparator14.Font = null;
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.AccessibleDescription = null;
            this.ToolStripSeparator7.AccessibleName = null;
            this.ToolStripSeparator7.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator7, "ToolStripSeparator7" );
            this.ToolStripSeparator7.Font = null;
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.AccessibleDescription = null;
            this.AboutMenuItem.AccessibleName = null;
            this.AboutMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.AboutMenuItem, "AboutMenuItem" );
            this.AboutMenuItem.Font = null;
            this.AboutMenuItem.Name = "AboutMenuItem";
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.AccessibleDescription = null;
            this.SplitContainer2.AccessibleName = null;
            this.SplitContainer2.BackgroundImage = null;
            resources.ApplyResources( this.SplitContainer2, "SplitContainer2" );
            this.SplitContainer2.Font = null;
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.AccessibleDescription = null;
            this.TableLayoutPanel1.AccessibleName = null;
            this.TableLayoutPanel1.BackgroundImage = null;
            resources.ApplyResources( this.TableLayoutPanel1, "TableLayoutPanel1" );
            this.TableLayoutPanel1.Font = null;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // UserPicture
            // 
            this.UserPicture.AccessibleDescription = null;
            this.UserPicture.AccessibleName = null;
            this.UserPicture.BackgroundImage = null;
            resources.ApplyResources( this.UserPicture, "UserPicture" );
            this.UserPicture.Font = null;
            this.UserPicture.Name = "UserPicture";
            // 
            // NameLabel
            // 
            this.NameLabel.AccessibleDescription = null;
            this.NameLabel.AccessibleName = null;
            this.NameLabel.BackgroundImage = null;
            resources.ApplyResources( this.NameLabel, "NameLabel" );
            this.NameLabel.Font = null;
            this.NameLabel.Name = "NameLabel";
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AccessibleDescription = null;
            this.DateTimeLabel.AccessibleName = null;
            this.DateTimeLabel.BackgroundImage = null;
            resources.ApplyResources( this.DateTimeLabel, "DateTimeLabel" );
            this.DateTimeLabel.Font = null;
            this.DateTimeLabel.Name = "DateTimeLabel";
            // 
            // StatusText
            // 
            this.StatusText.AccessibleDescription = null;
            this.StatusText.AccessibleName = null;
            this.StatusText.BackgroundImage = null;
            resources.ApplyResources( this.StatusText, "StatusText" );
            this.StatusText.Font = null;
            this.StatusText.Name = "StatusText";
            // 
            // lblLen
            // 
            this.lblLen.AccessibleDescription = null;
            this.lblLen.AccessibleName = null;
            this.lblLen.BackgroundImage = null;
            resources.ApplyResources( this.lblLen, "lblLen" );
            this.lblLen.Font = null;
            this.lblLen.Name = "lblLen";
            // 
            // PostButton
            // 
            this.PostButton.AccessibleDescription = null;
            this.PostButton.AccessibleName = null;
            this.PostButton.BackgroundImage = null;
            resources.ApplyResources( this.PostButton, "PostButton" );
            this.PostButton.Font = null;
            this.PostButton.Name = "PostButton";
            // 
            // TinyUrlConvertToolStripMenuItem
            // 
            this.TinyUrlConvertToolStripMenuItem.AccessibleDescription = null;
            this.TinyUrlConvertToolStripMenuItem.AccessibleName = null;
            this.TinyUrlConvertToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.TinyUrlConvertToolStripMenuItem, "TinyUrlConvertToolStripMenuItem" );
            this.TinyUrlConvertToolStripMenuItem.Font = null;
            this.TinyUrlConvertToolStripMenuItem.Name = "TinyUrlConvertToolStripMenuItem";
            // 
            // UpdateFollowersMenuItem1
            // 
            this.UpdateFollowersMenuItem1.AccessibleDescription = null;
            this.UpdateFollowersMenuItem1.AccessibleName = null;
            this.UpdateFollowersMenuItem1.BackgroundImage = null;
            resources.ApplyResources( this.UpdateFollowersMenuItem1, "UpdateFollowersMenuItem1" );
            this.UpdateFollowersMenuItem1.Font = null;
            this.UpdateFollowersMenuItem1.Name = "UpdateFollowersMenuItem1";
            // 
            // TinyURLToolStripMenuItem
            // 
            this.TinyURLToolStripMenuItem.AccessibleDescription = null;
            this.TinyURLToolStripMenuItem.AccessibleName = null;
            this.TinyURLToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.TinyURLToolStripMenuItem, "TinyURLToolStripMenuItem" );
            this.TinyURLToolStripMenuItem.Font = null;
            this.TinyURLToolStripMenuItem.Name = "TinyURLToolStripMenuItem";
            // 
            // IsgdToolStripMenuItem
            // 
            this.IsgdToolStripMenuItem.AccessibleDescription = null;
            this.IsgdToolStripMenuItem.AccessibleName = null;
            this.IsgdToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.IsgdToolStripMenuItem, "IsgdToolStripMenuItem" );
            this.IsgdToolStripMenuItem.Font = null;
            this.IsgdToolStripMenuItem.Name = "IsgdToolStripMenuItem";
            // 
            // UrlConvertAutoToolStripMenuItem
            // 
            this.UrlConvertAutoToolStripMenuItem.AccessibleDescription = null;
            this.UrlConvertAutoToolStripMenuItem.AccessibleName = null;
            this.UrlConvertAutoToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UrlConvertAutoToolStripMenuItem, "UrlConvertAutoToolStripMenuItem" );
            this.UrlConvertAutoToolStripMenuItem.Font = null;
            this.UrlConvertAutoToolStripMenuItem.Name = "UrlConvertAutoToolStripMenuItem";
            // 
            // UrlUndoToolStripMenuItem
            // 
            this.UrlUndoToolStripMenuItem.AccessibleDescription = null;
            this.UrlUndoToolStripMenuItem.AccessibleName = null;
            this.UrlUndoToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UrlUndoToolStripMenuItem, "UrlUndoToolStripMenuItem" );
            this.UrlUndoToolStripMenuItem.Font = null;
            this.UrlUndoToolStripMenuItem.Name = "UrlUndoToolStripMenuItem";
            // 
            // ContextMenuPostBrowser
            // 
            this.ContextMenuPostBrowser.AccessibleDescription = null;
            this.ContextMenuPostBrowser.AccessibleName = null;
            this.ContextMenuPostBrowser.BackgroundImage = null;
            resources.ApplyResources( this.ContextMenuPostBrowser, "ContextMenuPostBrowser" );
            this.ContextMenuPostBrowser.Font = null;
            this.ContextMenuPostBrowser.Name = "ContextMenuPostBrowser";
            // 
            // SelectionSearchContextMenuItem
            // 
            this.SelectionSearchContextMenuItem.AccessibleDescription = null;
            this.SelectionSearchContextMenuItem.AccessibleName = null;
            this.SelectionSearchContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SelectionSearchContextMenuItem, "SelectionSearchContextMenuItem" );
            this.SelectionSearchContextMenuItem.Font = null;
            this.SelectionSearchContextMenuItem.Name = "SelectionSearchContextMenuItem";
            // 
            // ToolStripSeparator13
            // 
            this.ToolStripSeparator13.AccessibleDescription = null;
            this.ToolStripSeparator13.AccessibleName = null;
            this.ToolStripSeparator13.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator13, "ToolStripSeparator13" );
            this.ToolStripSeparator13.Font = null;
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            // 
            // SelectionCopyContextMenuItem
            // 
            this.SelectionCopyContextMenuItem.AccessibleDescription = null;
            this.SelectionCopyContextMenuItem.AccessibleName = null;
            this.SelectionCopyContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SelectionCopyContextMenuItem, "SelectionCopyContextMenuItem" );
            this.SelectionCopyContextMenuItem.Font = null;
            this.SelectionCopyContextMenuItem.Name = "SelectionCopyContextMenuItem";
            // 
            // SelectionAllContextMenuItem
            // 
            this.SelectionAllContextMenuItem.AccessibleDescription = null;
            this.SelectionAllContextMenuItem.AccessibleName = null;
            this.SelectionAllContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SelectionAllContextMenuItem, "SelectionAllContextMenuItem" );
            this.SelectionAllContextMenuItem.Font = null;
            this.SelectionAllContextMenuItem.Name = "SelectionAllContextMenuItem";
            // 
            // SearchWikipediaContextMenuItem
            // 
            this.SearchWikipediaContextMenuItem.AccessibleDescription = null;
            this.SearchWikipediaContextMenuItem.AccessibleName = null;
            this.SearchWikipediaContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SearchWikipediaContextMenuItem, "SearchWikipediaContextMenuItem" );
            this.SearchWikipediaContextMenuItem.Font = null;
            this.SearchWikipediaContextMenuItem.Name = "SearchWikipediaContextMenuItem";
            // 
            // SearchGoogleContextMenuItem
            // 
            this.SearchGoogleContextMenuItem.AccessibleDescription = null;
            this.SearchGoogleContextMenuItem.AccessibleName = null;
            this.SearchGoogleContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SearchGoogleContextMenuItem, "SearchGoogleContextMenuItem" );
            this.SearchGoogleContextMenuItem.Font = null;
            this.SearchGoogleContextMenuItem.Name = "SearchGoogleContextMenuItem";
            // 
            // SearchYatsContextMenuItem
            // 
            this.SearchYatsContextMenuItem.AccessibleDescription = null;
            this.SearchYatsContextMenuItem.AccessibleName = null;
            this.SearchYatsContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SearchYatsContextMenuItem, "SearchYatsContextMenuItem" );
            this.SearchYatsContextMenuItem.Font = null;
            this.SearchYatsContextMenuItem.Name = "SearchYatsContextMenuItem";
            // 
            // SearchPublicSearchContextMenuItem
            // 
            this.SearchPublicSearchContextMenuItem.AccessibleDescription = null;
            this.SearchPublicSearchContextMenuItem.AccessibleName = null;
            this.SearchPublicSearchContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SearchPublicSearchContextMenuItem, "SearchPublicSearchContextMenuItem" );
            this.SearchPublicSearchContextMenuItem.Font = null;
            this.SearchPublicSearchContextMenuItem.Name = "SearchPublicSearchContextMenuItem";
            // 
            // CurrentTabToolStripMenuItem
            // 
            this.CurrentTabToolStripMenuItem.AccessibleDescription = null;
            this.CurrentTabToolStripMenuItem.AccessibleName = null;
            this.CurrentTabToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.CurrentTabToolStripMenuItem, "CurrentTabToolStripMenuItem" );
            this.CurrentTabToolStripMenuItem.Font = null;
            this.CurrentTabToolStripMenuItem.Name = "CurrentTabToolStripMenuItem";
            // 
            // UrlCopyContextMenuItem
            // 
            this.UrlCopyContextMenuItem.AccessibleDescription = null;
            this.UrlCopyContextMenuItem.AccessibleName = null;
            this.UrlCopyContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UrlCopyContextMenuItem, "UrlCopyContextMenuItem" );
            this.UrlCopyContextMenuItem.Font = null;
            this.UrlCopyContextMenuItem.Name = "UrlCopyContextMenuItem";
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.AccessibleDescription = null;
            this.ToolStripMenuItem6.AccessibleName = null;
            this.ToolStripMenuItem6.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripMenuItem6, "ToolStripMenuItem6" );
            this.ToolStripMenuItem6.Font = null;
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            // 
            // MoveToHomeToolStripMenuItem
            // 
            this.MoveToHomeToolStripMenuItem.AccessibleDescription = null;
            this.MoveToHomeToolStripMenuItem.AccessibleName = null;
            this.MoveToHomeToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.MoveToHomeToolStripMenuItem, "MoveToHomeToolStripMenuItem" );
            this.MoveToHomeToolStripMenuItem.Font = null;
            this.MoveToHomeToolStripMenuItem.Name = "MoveToHomeToolStripMenuItem";
            // 
            // MoveToFavToolStripMenuItem
            // 
            this.MoveToFavToolStripMenuItem.AccessibleDescription = null;
            this.MoveToFavToolStripMenuItem.AccessibleName = null;
            this.MoveToFavToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.MoveToFavToolStripMenuItem, "MoveToFavToolStripMenuItem" );
            this.MoveToFavToolStripMenuItem.Font = null;
            this.MoveToFavToolStripMenuItem.Name = "MoveToFavToolStripMenuItem";
            // 
            // StatusOpenMenuItem
            // 
            this.StatusOpenMenuItem.AccessibleDescription = null;
            this.StatusOpenMenuItem.AccessibleName = null;
            this.StatusOpenMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.StatusOpenMenuItem, "StatusOpenMenuItem" );
            this.StatusOpenMenuItem.Font = null;
            this.StatusOpenMenuItem.Name = "StatusOpenMenuItem";
            // 
            // RepliedStatusOpenMenuItem
            // 
            this.RepliedStatusOpenMenuItem.AccessibleDescription = null;
            this.RepliedStatusOpenMenuItem.AccessibleName = null;
            this.RepliedStatusOpenMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RepliedStatusOpenMenuItem, "RepliedStatusOpenMenuItem" );
            this.RepliedStatusOpenMenuItem.Font = null;
            this.RepliedStatusOpenMenuItem.Name = "RepliedStatusOpenMenuItem";
            // 
            // FavorareMenuItem
            // 
            this.FavorareMenuItem.AccessibleDescription = null;
            this.FavorareMenuItem.AccessibleName = null;
            this.FavorareMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FavorareMenuItem, "FavorareMenuItem" );
            this.FavorareMenuItem.Font = null;
            this.FavorareMenuItem.Name = "FavorareMenuItem";
            // 
            // OpenURLMenuItem
            // 
            this.OpenURLMenuItem.AccessibleDescription = null;
            this.OpenURLMenuItem.AccessibleName = null;
            this.OpenURLMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenURLMenuItem, "OpenURLMenuItem" );
            this.OpenURLMenuItem.Font = null;
            this.OpenURLMenuItem.Name = "OpenURLMenuItem";
            // 
            // ToolStripMenuItem7
            // 
            this.ToolStripMenuItem7.AccessibleDescription = null;
            this.ToolStripMenuItem7.AccessibleName = null;
            this.ToolStripMenuItem7.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripMenuItem7, "ToolStripMenuItem7" );
            this.ToolStripMenuItem7.Font = null;
            this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
            // 
            // TabMenuItem
            // 
            this.TabMenuItem.AccessibleDescription = null;
            this.TabMenuItem.AccessibleName = null;
            this.TabMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.TabMenuItem, "TabMenuItem" );
            this.TabMenuItem.Font = null;
            this.TabMenuItem.Name = "TabMenuItem";
            // 
            // IDRuleMenuItem
            // 
            this.IDRuleMenuItem.AccessibleDescription = null;
            this.IDRuleMenuItem.AccessibleName = null;
            this.IDRuleMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.IDRuleMenuItem, "IDRuleMenuItem" );
            this.IDRuleMenuItem.Font = null;
            this.IDRuleMenuItem.Name = "IDRuleMenuItem";
            // 
            // ToolStripMenuItem11
            // 
            this.ToolStripMenuItem11.AccessibleDescription = null;
            this.ToolStripMenuItem11.AccessibleName = null;
            this.ToolStripMenuItem11.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripMenuItem11, "ToolStripMenuItem11" );
            this.ToolStripMenuItem11.Font = null;
            this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
            // 
            // ReadedStripMenuItem
            // 
            this.ReadedStripMenuItem.AccessibleDescription = null;
            this.ReadedStripMenuItem.AccessibleName = null;
            this.ReadedStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ReadedStripMenuItem, "ReadedStripMenuItem" );
            this.ReadedStripMenuItem.Font = null;
            this.ReadedStripMenuItem.Name = "ReadedStripMenuItem";
            // 
            // UnreadStripMenuItem
            // 
            this.UnreadStripMenuItem.AccessibleDescription = null;
            this.UnreadStripMenuItem.AccessibleName = null;
            this.UnreadStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UnreadStripMenuItem, "UnreadStripMenuItem" );
            this.UnreadStripMenuItem.Font = null;
            this.UnreadStripMenuItem.Name = "UnreadStripMenuItem";
            // 
            // ReplyStripMenuItem
            // 
            this.ReplyStripMenuItem.AccessibleDescription = null;
            this.ReplyStripMenuItem.AccessibleName = null;
            this.ReplyStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ReplyStripMenuItem, "ReplyStripMenuItem" );
            this.ReplyStripMenuItem.Font = null;
            this.ReplyStripMenuItem.Name = "ReplyStripMenuItem";
            // 
            // ReplyAllStripMenuItem
            // 
            this.ReplyAllStripMenuItem.AccessibleDescription = null;
            this.ReplyAllStripMenuItem.AccessibleName = null;
            this.ReplyAllStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ReplyAllStripMenuItem, "ReplyAllStripMenuItem" );
            this.ReplyAllStripMenuItem.Font = null;
            this.ReplyAllStripMenuItem.Name = "ReplyAllStripMenuItem";
            // 
            // FavAddToolStripMenuItem
            // 
            this.FavAddToolStripMenuItem.AccessibleDescription = null;
            this.FavAddToolStripMenuItem.AccessibleName = null;
            this.FavAddToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FavAddToolStripMenuItem, "FavAddToolStripMenuItem" );
            this.FavAddToolStripMenuItem.Font = null;
            this.FavAddToolStripMenuItem.Name = "FavAddToolStripMenuItem";
            // 
            // FavRemoveToolStripMenuItem
            // 
            this.FavRemoveToolStripMenuItem.AccessibleDescription = null;
            this.FavRemoveToolStripMenuItem.AccessibleName = null;
            this.FavRemoveToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FavRemoveToolStripMenuItem, "FavRemoveToolStripMenuItem" );
            this.FavRemoveToolStripMenuItem.Font = null;
            this.FavRemoveToolStripMenuItem.Name = "FavRemoveToolStripMenuItem";
            // 
            // ReTweetStripMenuItem
            // 
            this.ReTweetStripMenuItem.AccessibleDescription = null;
            this.ReTweetStripMenuItem.AccessibleName = null;
            this.ReTweetStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ReTweetStripMenuItem, "ReTweetStripMenuItem" );
            this.ReTweetStripMenuItem.Font = null;
            this.ReTweetStripMenuItem.Name = "ReTweetStripMenuItem";
            // 
            // ContextMenuPostMode
            // 
            this.ContextMenuPostMode.AccessibleDescription = null;
            this.ContextMenuPostMode.AccessibleName = null;
            this.ContextMenuPostMode.BackgroundImage = null;
            resources.ApplyResources( this.ContextMenuPostMode, "ContextMenuPostMode" );
            this.ContextMenuPostMode.Font = null;
            this.ContextMenuPostMode.Name = "ContextMenuPostMode";
            // 
            // ToolStripMenuItemUrlMultibyteSplit
            // 
            this.ToolStripMenuItemUrlMultibyteSplit.AccessibleDescription = null;
            this.ToolStripMenuItemUrlMultibyteSplit.AccessibleName = null;
            this.ToolStripMenuItemUrlMultibyteSplit.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripMenuItemUrlMultibyteSplit, "ToolStripMenuItemUrlMultibyteSplit" );
            this.ToolStripMenuItemUrlMultibyteSplit.Font = null;
            this.ToolStripMenuItemUrlMultibyteSplit.Name = "ToolStripMenuItemUrlMultibyteSplit";
            // 
            // ToolStripMenuItemApiCommandEvasion
            // 
            this.ToolStripMenuItemApiCommandEvasion.AccessibleDescription = null;
            this.ToolStripMenuItemApiCommandEvasion.AccessibleName = null;
            this.ToolStripMenuItemApiCommandEvasion.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripMenuItemApiCommandEvasion, "ToolStripMenuItemApiCommandEvasion" );
            this.ToolStripMenuItemApiCommandEvasion.Font = null;
            this.ToolStripMenuItemApiCommandEvasion.Name = "ToolStripMenuItemApiCommandEvasion";
            // 
            // ToolStripMenuItemUrlAutoShorten
            // 
            this.ToolStripMenuItemUrlAutoShorten.AccessibleDescription = null;
            this.ToolStripMenuItemUrlAutoShorten.AccessibleName = null;
            this.ToolStripMenuItemUrlAutoShorten.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripMenuItemUrlAutoShorten, "ToolStripMenuItemUrlAutoShorten" );
            this.ToolStripMenuItemUrlAutoShorten.Font = null;
            this.ToolStripMenuItemUrlAutoShorten.Name = "ToolStripMenuItemUrlAutoShorten";
            // 
            // DebugModeToolStripMenuItem
            // 
            this.DebugModeToolStripMenuItem.AccessibleDescription = null;
            this.DebugModeToolStripMenuItem.AccessibleName = null;
            this.DebugModeToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.DebugModeToolStripMenuItem, "DebugModeToolStripMenuItem" );
            this.DebugModeToolStripMenuItem.Font = null;
            this.DebugModeToolStripMenuItem.Name = "DebugModeToolStripMenuItem";
            // 
            // DumpPostClassToolStripMenuItem
            // 
            this.DumpPostClassToolStripMenuItem.AccessibleDescription = null;
            this.DumpPostClassToolStripMenuItem.AccessibleName = null;
            this.DumpPostClassToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.DumpPostClassToolStripMenuItem, "DumpPostClassToolStripMenuItem" );
            this.DumpPostClassToolStripMenuItem.Font = null;
            this.DumpPostClassToolStripMenuItem.Name = "DumpPostClassToolStripMenuItem";
            // 
            // TraceOutToolStripMenuItem
            // 
            this.TraceOutToolStripMenuItem.AccessibleDescription = null;
            this.TraceOutToolStripMenuItem.AccessibleName = null;
            this.TraceOutToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.TraceOutToolStripMenuItem, "TraceOutToolStripMenuItem" );
            this.TraceOutToolStripMenuItem.Font = null;
            this.TraceOutToolStripMenuItem.Name = "TraceOutToolStripMenuItem";
            // 
            // TwurlnlToolStripMenuItem
            // 
            this.TwurlnlToolStripMenuItem.AccessibleDescription = null;
            this.TwurlnlToolStripMenuItem.AccessibleName = null;
            this.TwurlnlToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.TwurlnlToolStripMenuItem, "TwurlnlToolStripMenuItem" );
            this.TwurlnlToolStripMenuItem.Font = null;
            this.TwurlnlToolStripMenuItem.Name = "TwurlnlToolStripMenuItem";
            // 
            // TabRenameMenuItem
            // 
            this.TabRenameMenuItem.AccessibleDescription = null;
            this.TabRenameMenuItem.AccessibleName = null;
            this.TabRenameMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.TabRenameMenuItem, "TabRenameMenuItem" );
            this.TabRenameMenuItem.Font = null;
            this.TabRenameMenuItem.Name = "TabRenameMenuItem";
            // 
            // BitlyToolStripMenuItem
            // 
            this.BitlyToolStripMenuItem.AccessibleDescription = null;
            this.BitlyToolStripMenuItem.AccessibleName = null;
            this.BitlyToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.BitlyToolStripMenuItem, "BitlyToolStripMenuItem" );
            this.BitlyToolStripMenuItem.Font = null;
            this.BitlyToolStripMenuItem.Name = "BitlyToolStripMenuItem";
            // 
            // ApiInfoMenuItem
            // 
            this.ApiInfoMenuItem.AccessibleDescription = null;
            this.ApiInfoMenuItem.AccessibleName = null;
            this.ApiInfoMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ApiInfoMenuItem, "ApiInfoMenuItem" );
            this.ApiInfoMenuItem.Font = null;
            this.ApiInfoMenuItem.Name = "ApiInfoMenuItem";
            // 
            // IdeographicSpaceToSpaceToolStripMenuItem
            // 
            this.IdeographicSpaceToSpaceToolStripMenuItem.AccessibleDescription = null;
            this.IdeographicSpaceToSpaceToolStripMenuItem.AccessibleName = null;
            this.IdeographicSpaceToSpaceToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.IdeographicSpaceToSpaceToolStripMenuItem, "IdeographicSpaceToSpaceToolStripMenuItem" );
            this.IdeographicSpaceToSpaceToolStripMenuItem.Font = null;
            this.IdeographicSpaceToSpaceToolStripMenuItem.Name = "IdeographicSpaceToSpaceToolStripMenuItem";
            // 
            // FollowCommandMenuItem
            // 
            this.FollowCommandMenuItem.AccessibleDescription = null;
            this.FollowCommandMenuItem.AccessibleName = null;
            this.FollowCommandMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FollowCommandMenuItem, "FollowCommandMenuItem" );
            this.FollowCommandMenuItem.Font = null;
            this.FollowCommandMenuItem.Name = "FollowCommandMenuItem";
            // 
            // RemoveCommandMenuItem
            // 
            this.RemoveCommandMenuItem.AccessibleDescription = null;
            this.RemoveCommandMenuItem.AccessibleName = null;
            this.RemoveCommandMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RemoveCommandMenuItem, "RemoveCommandMenuItem" );
            this.RemoveCommandMenuItem.Font = null;
            this.RemoveCommandMenuItem.Name = "RemoveCommandMenuItem";
            // 
            // FriendshipMenuItem
            // 
            this.FriendshipMenuItem.AccessibleDescription = null;
            this.FriendshipMenuItem.AccessibleName = null;
            this.FriendshipMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FriendshipMenuItem, "FriendshipMenuItem" );
            this.FriendshipMenuItem.Font = null;
            this.FriendshipMenuItem.Name = "FriendshipMenuItem";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.AccessibleDescription = null;
            this.ToolStripSeparator1.AccessibleName = null;
            this.ToolStripSeparator1.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator1, "ToolStripSeparator1" );
            this.ToolStripSeparator1.Font = null;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.AccessibleDescription = null;
            this.ToolStripSeparator3.AccessibleName = null;
            this.ToolStripSeparator3.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator3, "ToolStripSeparator3" );
            this.ToolStripSeparator3.Font = null;
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            // 
            // OwnStatusMenuItem
            // 
            this.OwnStatusMenuItem.AccessibleDescription = null;
            this.OwnStatusMenuItem.AccessibleName = null;
            this.OwnStatusMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OwnStatusMenuItem, "OwnStatusMenuItem" );
            this.OwnStatusMenuItem.Font = null;
            this.OwnStatusMenuItem.Name = "OwnStatusMenuItem";
            // 
            // ReTweetOriginalStripMenuItem
            // 
            this.ReTweetOriginalStripMenuItem.AccessibleDescription = null;
            this.ReTweetOriginalStripMenuItem.AccessibleName = null;
            this.ReTweetOriginalStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ReTweetOriginalStripMenuItem, "ReTweetOriginalStripMenuItem" );
            this.ReTweetOriginalStripMenuItem.Font = null;
            this.ReTweetOriginalStripMenuItem.Name = "ReTweetOriginalStripMenuItem";
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.AccessibleDescription = null;
            this.ToolStripSeparator5.AccessibleName = null;
            this.ToolStripSeparator5.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator5, "ToolStripSeparator5" );
            this.ToolStripSeparator5.Font = null;
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            // 
            // FollowContextMenuItem
            // 
            this.FollowContextMenuItem.AccessibleDescription = null;
            this.FollowContextMenuItem.AccessibleName = null;
            this.FollowContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FollowContextMenuItem, "FollowContextMenuItem" );
            this.FollowContextMenuItem.Font = null;
            this.FollowContextMenuItem.Name = "FollowContextMenuItem";
            // 
            // RemoveContextMenuItem
            // 
            this.RemoveContextMenuItem.AccessibleDescription = null;
            this.RemoveContextMenuItem.AccessibleName = null;
            this.RemoveContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RemoveContextMenuItem, "RemoveContextMenuItem" );
            this.RemoveContextMenuItem.Font = null;
            this.RemoveContextMenuItem.Name = "RemoveContextMenuItem";
            // 
            // FriendshipContextMenuItem
            // 
            this.FriendshipContextMenuItem.AccessibleDescription = null;
            this.FriendshipContextMenuItem.AccessibleName = null;
            this.FriendshipContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FriendshipContextMenuItem, "FriendshipContextMenuItem" );
            this.FriendshipContextMenuItem.Font = null;
            this.FriendshipContextMenuItem.Name = "FriendshipContextMenuItem";
            // 
            // JmpStripMenuItem
            // 
            this.JmpStripMenuItem.AccessibleDescription = null;
            this.JmpStripMenuItem.AccessibleName = null;
            this.JmpStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.JmpStripMenuItem, "JmpStripMenuItem" );
            this.JmpStripMenuItem.Font = null;
            this.JmpStripMenuItem.Name = "JmpStripMenuItem";
            // 
            // QuoteStripMenuItem
            // 
            this.QuoteStripMenuItem.AccessibleDescription = null;
            this.QuoteStripMenuItem.AccessibleName = null;
            this.QuoteStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.QuoteStripMenuItem, "QuoteStripMenuItem" );
            this.QuoteStripMenuItem.Font = null;
            this.QuoteStripMenuItem.Name = "QuoteStripMenuItem";
            // 
            // RefreshMoreStripMenuItem
            // 
            this.RefreshMoreStripMenuItem.AccessibleDescription = null;
            this.RefreshMoreStripMenuItem.AccessibleName = null;
            this.RefreshMoreStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RefreshMoreStripMenuItem, "RefreshMoreStripMenuItem" );
            this.RefreshMoreStripMenuItem.Font = null;
            this.RefreshMoreStripMenuItem.Name = "RefreshMoreStripMenuItem";
            // 
            // UndoRemoveTabMenuItem
            // 
            this.UndoRemoveTabMenuItem.AccessibleDescription = null;
            this.UndoRemoveTabMenuItem.AccessibleName = null;
            this.UndoRemoveTabMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UndoRemoveTabMenuItem, "UndoRemoveTabMenuItem" );
            this.UndoRemoveTabMenuItem.Font = null;
            this.UndoRemoveTabMenuItem.Name = "UndoRemoveTabMenuItem";
            // 
            // ToolStripSeparator12
            // 
            this.ToolStripSeparator12.AccessibleDescription = null;
            this.ToolStripSeparator12.AccessibleName = null;
            this.ToolStripSeparator12.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator12, "ToolStripSeparator12" );
            this.ToolStripSeparator12.Font = null;
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            // 
            // MoveToRTHomeMenuItem
            // 
            this.MoveToRTHomeMenuItem.AccessibleDescription = null;
            this.MoveToRTHomeMenuItem.AccessibleName = null;
            this.MoveToRTHomeMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.MoveToRTHomeMenuItem, "MoveToRTHomeMenuItem" );
            this.MoveToRTHomeMenuItem.Font = null;
            this.MoveToRTHomeMenuItem.Name = "MoveToRTHomeMenuItem";
            // 
            // IdFilterAddMenuItem
            // 
            this.IdFilterAddMenuItem.AccessibleDescription = null;
            this.IdFilterAddMenuItem.AccessibleName = null;
            this.IdFilterAddMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.IdFilterAddMenuItem, "IdFilterAddMenuItem" );
            this.IdFilterAddMenuItem.Font = null;
            this.IdFilterAddMenuItem.Name = "IdFilterAddMenuItem";
            // 
            // ToolStripSeparator22
            // 
            this.ToolStripSeparator22.AccessibleDescription = null;
            this.ToolStripSeparator22.AccessibleName = null;
            this.ToolStripSeparator22.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator22, "ToolStripSeparator22" );
            this.ToolStripSeparator22.Font = null;
            this.ToolStripSeparator22.Name = "ToolStripSeparator22";
            // 
            // PublicSearchQueryMenuItem
            // 
            this.PublicSearchQueryMenuItem.AccessibleDescription = null;
            this.PublicSearchQueryMenuItem.AccessibleName = null;
            this.PublicSearchQueryMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.PublicSearchQueryMenuItem, "PublicSearchQueryMenuItem" );
            this.PublicSearchQueryMenuItem.Font = null;
            this.PublicSearchQueryMenuItem.Name = "PublicSearchQueryMenuItem";
            // 
            // UseHashtagMenuItem
            // 
            this.UseHashtagMenuItem.AccessibleDescription = null;
            this.UseHashtagMenuItem.AccessibleName = null;
            this.UseHashtagMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UseHashtagMenuItem, "UseHashtagMenuItem" );
            this.UseHashtagMenuItem.Font = null;
            this.UseHashtagMenuItem.Name = "UseHashtagMenuItem";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AccessibleDescription = null;
            this.StatusLabel.AccessibleName = null;
            this.StatusLabel.BackgroundImage = null;
            resources.ApplyResources( this.StatusLabel, "StatusLabel" );
            this.StatusLabel.Font = null;
            this.StatusLabel.Name = "StatusLabel";
            // 
            // HashStripSplitButton
            // 
            this.HashStripSplitButton.AccessibleDescription = null;
            this.HashStripSplitButton.AccessibleName = null;
            this.HashStripSplitButton.BackgroundImage = null;
            resources.ApplyResources( this.HashStripSplitButton, "HashStripSplitButton" );
            this.HashStripSplitButton.Font = null;
            this.HashStripSplitButton.Name = "HashStripSplitButton";
            // 
            // HashToggleMenuItem
            // 
            this.HashToggleMenuItem.AccessibleDescription = null;
            this.HashToggleMenuItem.AccessibleName = null;
            this.HashToggleMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.HashToggleMenuItem, "HashToggleMenuItem" );
            this.HashToggleMenuItem.Font = null;
            this.HashToggleMenuItem.Name = "HashToggleMenuItem";
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.AccessibleDescription = null;
            this.ToolStripSeparator8.AccessibleName = null;
            this.ToolStripSeparator8.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator8, "ToolStripSeparator8" );
            this.ToolStripSeparator8.Font = null;
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            // 
            // HashManageMenuItem
            // 
            this.HashManageMenuItem.AccessibleDescription = null;
            this.HashManageMenuItem.AccessibleName = null;
            this.HashManageMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.HashManageMenuItem, "HashManageMenuItem" );
            this.HashManageMenuItem.Font = null;
            this.HashManageMenuItem.Name = "HashManageMenuItem";
            // 
            // MultiLineMenuItem
            // 
            this.MultiLineMenuItem.AccessibleDescription = null;
            this.MultiLineMenuItem.AccessibleName = null;
            this.MultiLineMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.MultiLineMenuItem, "MultiLineMenuItem" );
            this.MultiLineMenuItem.Font = null;
            this.MultiLineMenuItem.Name = "MultiLineMenuItem";
            // 
            // SettingFileMenuItem
            // 
            this.SettingFileMenuItem.AccessibleDescription = null;
            this.SettingFileMenuItem.AccessibleName = null;
            this.SettingFileMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SettingFileMenuItem, "SettingFileMenuItem" );
            this.SettingFileMenuItem.Font = null;
            this.SettingFileMenuItem.Name = "SettingFileMenuItem";
            // 
            // ToolStripSeparator21
            // 
            this.ToolStripSeparator21.AccessibleDescription = null;
            this.ToolStripSeparator21.AccessibleName = null;
            this.ToolStripSeparator21.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator21, "ToolStripSeparator21" );
            this.ToolStripSeparator21.Font = null;
            this.ToolStripSeparator21.Name = "ToolStripSeparator21";
            // 
            // SaveFileMenuItem
            // 
            this.SaveFileMenuItem.AccessibleDescription = null;
            this.SaveFileMenuItem.AccessibleName = null;
            this.SaveFileMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SaveFileMenuItem, "SaveFileMenuItem" );
            this.SaveFileMenuItem.Font = null;
            this.SaveFileMenuItem.Name = "SaveFileMenuItem";
            // 
            // ToolStripSeparator23
            // 
            this.ToolStripSeparator23.AccessibleDescription = null;
            this.ToolStripSeparator23.AccessibleName = null;
            this.ToolStripSeparator23.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator23, "ToolStripSeparator23" );
            this.ToolStripSeparator23.Font = null;
            this.ToolStripSeparator23.Name = "ToolStripSeparator23";
            // 
            // NotifyFileMenuItem
            // 
            this.NotifyFileMenuItem.AccessibleDescription = null;
            this.NotifyFileMenuItem.AccessibleName = null;
            this.NotifyFileMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.NotifyFileMenuItem, "NotifyFileMenuItem" );
            this.NotifyFileMenuItem.Font = null;
            this.NotifyFileMenuItem.Name = "NotifyFileMenuItem";
            // 
            // PlaySoundFileMenuItem
            // 
            this.PlaySoundFileMenuItem.AccessibleDescription = null;
            this.PlaySoundFileMenuItem.AccessibleName = null;
            this.PlaySoundFileMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.PlaySoundFileMenuItem, "PlaySoundFileMenuItem" );
            this.PlaySoundFileMenuItem.Font = null;
            this.PlaySoundFileMenuItem.Name = "PlaySoundFileMenuItem";
            // 
            // LockListFileMenuItem
            // 
            this.LockListFileMenuItem.AccessibleDescription = null;
            this.LockListFileMenuItem.AccessibleName = null;
            this.LockListFileMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.LockListFileMenuItem, "LockListFileMenuItem" );
            this.LockListFileMenuItem.Font = null;
            this.LockListFileMenuItem.Name = "LockListFileMenuItem";
            // 
            // ToolStripSeparator24
            // 
            this.ToolStripSeparator24.AccessibleDescription = null;
            this.ToolStripSeparator24.AccessibleName = null;
            this.ToolStripSeparator24.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator24, "ToolStripSeparator24" );
            this.ToolStripSeparator24.Font = null;
            this.ToolStripSeparator24.Name = "ToolStripSeparator24";
            // 
            // EndFileMenuItem
            // 
            this.EndFileMenuItem.AccessibleDescription = null;
            this.EndFileMenuItem.AccessibleName = null;
            this.EndFileMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.EndFileMenuItem, "EndFileMenuItem" );
            this.EndFileMenuItem.Font = null;
            this.EndFileMenuItem.Name = "EndFileMenuItem";
            // 
            // ReplyOpMenuItem
            // 
            this.ReplyOpMenuItem.AccessibleDescription = null;
            this.ReplyOpMenuItem.AccessibleName = null;
            this.ReplyOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ReplyOpMenuItem, "ReplyOpMenuItem" );
            this.ReplyOpMenuItem.Font = null;
            this.ReplyOpMenuItem.Name = "ReplyOpMenuItem";
            // 
            // ReplyAllOpMenuItem
            // 
            this.ReplyAllOpMenuItem.AccessibleDescription = null;
            this.ReplyAllOpMenuItem.AccessibleName = null;
            this.ReplyAllOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ReplyAllOpMenuItem, "ReplyAllOpMenuItem" );
            this.ReplyAllOpMenuItem.Font = null;
            this.ReplyAllOpMenuItem.Name = "ReplyAllOpMenuItem";
            // 
            // DmOpMenuItem
            // 
            this.DmOpMenuItem.AccessibleDescription = null;
            this.DmOpMenuItem.AccessibleName = null;
            this.DmOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.DmOpMenuItem, "DmOpMenuItem" );
            this.DmOpMenuItem.Font = null;
            this.DmOpMenuItem.Name = "DmOpMenuItem";
            // 
            // RtOpMenuItem
            // 
            this.RtOpMenuItem.AccessibleDescription = null;
            this.RtOpMenuItem.AccessibleName = null;
            this.RtOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RtOpMenuItem, "RtOpMenuItem" );
            this.RtOpMenuItem.Font = null;
            this.RtOpMenuItem.Name = "RtOpMenuItem";
            // 
            // RtUnOpMenuItem
            // 
            this.RtUnOpMenuItem.AccessibleDescription = null;
            this.RtUnOpMenuItem.AccessibleName = null;
            this.RtUnOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RtUnOpMenuItem, "RtUnOpMenuItem" );
            this.RtUnOpMenuItem.Font = null;
            this.RtUnOpMenuItem.Name = "RtUnOpMenuItem";
            // 
            // QtOpMenuItem
            // 
            this.QtOpMenuItem.AccessibleDescription = null;
            this.QtOpMenuItem.AccessibleName = null;
            this.QtOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.QtOpMenuItem, "QtOpMenuItem" );
            this.QtOpMenuItem.Font = null;
            this.QtOpMenuItem.Name = "QtOpMenuItem";
            // 
            // ToolStripSeparator25
            // 
            this.ToolStripSeparator25.AccessibleDescription = null;
            this.ToolStripSeparator25.AccessibleName = null;
            this.ToolStripSeparator25.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator25, "ToolStripSeparator25" );
            this.ToolStripSeparator25.Font = null;
            this.ToolStripSeparator25.Name = "ToolStripSeparator25";
            // 
            // FavOpMenuItem
            // 
            this.FavOpMenuItem.AccessibleDescription = null;
            this.FavOpMenuItem.AccessibleName = null;
            this.FavOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FavOpMenuItem, "FavOpMenuItem" );
            this.FavOpMenuItem.Font = null;
            this.FavOpMenuItem.Name = "FavOpMenuItem";
            // 
            // UnFavOpMenuItem
            // 
            this.UnFavOpMenuItem.AccessibleDescription = null;
            this.UnFavOpMenuItem.AccessibleName = null;
            this.UnFavOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UnFavOpMenuItem, "UnFavOpMenuItem" );
            this.UnFavOpMenuItem.Font = null;
            this.UnFavOpMenuItem.Name = "UnFavOpMenuItem";
            // 
            // OpenOpMenuItem
            // 
            this.OpenOpMenuItem.AccessibleDescription = null;
            this.OpenOpMenuItem.AccessibleName = null;
            this.OpenOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenOpMenuItem, "OpenOpMenuItem" );
            this.OpenOpMenuItem.Font = null;
            this.OpenOpMenuItem.Name = "OpenOpMenuItem";
            // 
            // CreateRuleOpMenuItem
            // 
            this.CreateRuleOpMenuItem.AccessibleDescription = null;
            this.CreateRuleOpMenuItem.AccessibleName = null;
            this.CreateRuleOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.CreateRuleOpMenuItem, "CreateRuleOpMenuItem" );
            this.CreateRuleOpMenuItem.Font = null;
            this.CreateRuleOpMenuItem.Name = "CreateRuleOpMenuItem";
            // 
            // ToolStripSeparator26
            // 
            this.ToolStripSeparator26.AccessibleDescription = null;
            this.ToolStripSeparator26.AccessibleName = null;
            this.ToolStripSeparator26.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator26, "ToolStripSeparator26" );
            this.ToolStripSeparator26.Font = null;
            this.ToolStripSeparator26.Name = "ToolStripSeparator26";
            // 
            // ChangeReadOpMenuItem
            // 
            this.ChangeReadOpMenuItem.AccessibleDescription = null;
            this.ChangeReadOpMenuItem.AccessibleName = null;
            this.ChangeReadOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ChangeReadOpMenuItem, "ChangeReadOpMenuItem" );
            this.ChangeReadOpMenuItem.Font = null;
            this.ChangeReadOpMenuItem.Name = "ChangeReadOpMenuItem";
            // 
            // JumpReadOpMenuItem
            // 
            this.JumpReadOpMenuItem.AccessibleDescription = null;
            this.JumpReadOpMenuItem.AccessibleName = null;
            this.JumpReadOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.JumpReadOpMenuItem, "JumpReadOpMenuItem" );
            this.JumpReadOpMenuItem.Font = null;
            this.JumpReadOpMenuItem.Name = "JumpReadOpMenuItem";
            // 
            // ToolStripSeparator27
            // 
            this.ToolStripSeparator27.AccessibleDescription = null;
            this.ToolStripSeparator27.AccessibleName = null;
            this.ToolStripSeparator27.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator27, "ToolStripSeparator27" );
            this.ToolStripSeparator27.Font = null;
            this.ToolStripSeparator27.Name = "ToolStripSeparator27";
            // 
            // SelAllOpMenuItem
            // 
            this.SelAllOpMenuItem.AccessibleDescription = null;
            this.SelAllOpMenuItem.AccessibleName = null;
            this.SelAllOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SelAllOpMenuItem, "SelAllOpMenuItem" );
            this.SelAllOpMenuItem.Font = null;
            this.SelAllOpMenuItem.Name = "SelAllOpMenuItem";
            // 
            // DelOpMenuItem
            // 
            this.DelOpMenuItem.AccessibleDescription = null;
            this.DelOpMenuItem.AccessibleName = null;
            this.DelOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.DelOpMenuItem, "DelOpMenuItem" );
            this.DelOpMenuItem.Font = null;
            this.DelOpMenuItem.Name = "DelOpMenuItem";
            // 
            // RefreshOpMenuItem
            // 
            this.RefreshOpMenuItem.AccessibleDescription = null;
            this.RefreshOpMenuItem.AccessibleName = null;
            this.RefreshOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RefreshOpMenuItem, "RefreshOpMenuItem" );
            this.RefreshOpMenuItem.Font = null;
            this.RefreshOpMenuItem.Name = "RefreshOpMenuItem";
            // 
            // RefreshPrevOpMenuItem
            // 
            this.RefreshPrevOpMenuItem.AccessibleDescription = null;
            this.RefreshPrevOpMenuItem.AccessibleName = null;
            this.RefreshPrevOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RefreshPrevOpMenuItem, "RefreshPrevOpMenuItem" );
            this.RefreshPrevOpMenuItem.Font = null;
            this.RefreshPrevOpMenuItem.Name = "RefreshPrevOpMenuItem";
            // 
            // OpenHomeOpMenuItem
            // 
            this.OpenHomeOpMenuItem.AccessibleDescription = null;
            this.OpenHomeOpMenuItem.AccessibleName = null;
            this.OpenHomeOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenHomeOpMenuItem, "OpenHomeOpMenuItem" );
            this.OpenHomeOpMenuItem.Font = null;
            this.OpenHomeOpMenuItem.Name = "OpenHomeOpMenuItem";
            // 
            // OpenFavOpMenuItem
            // 
            this.OpenFavOpMenuItem.AccessibleDescription = null;
            this.OpenFavOpMenuItem.AccessibleName = null;
            this.OpenFavOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenFavOpMenuItem, "OpenFavOpMenuItem" );
            this.OpenFavOpMenuItem.Font = null;
            this.OpenFavOpMenuItem.Name = "OpenFavOpMenuItem";
            // 
            // OpenStatusOpMenuItem
            // 
            this.OpenStatusOpMenuItem.AccessibleDescription = null;
            this.OpenStatusOpMenuItem.AccessibleName = null;
            this.OpenStatusOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenStatusOpMenuItem, "OpenStatusOpMenuItem" );
            this.OpenStatusOpMenuItem.Font = null;
            this.OpenStatusOpMenuItem.Name = "OpenStatusOpMenuItem";
            // 
            // OpenRepSourceOpMenuItem
            // 
            this.OpenRepSourceOpMenuItem.AccessibleDescription = null;
            this.OpenRepSourceOpMenuItem.AccessibleName = null;
            this.OpenRepSourceOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenRepSourceOpMenuItem, "OpenRepSourceOpMenuItem" );
            this.OpenRepSourceOpMenuItem.Font = null;
            this.OpenRepSourceOpMenuItem.Name = "OpenRepSourceOpMenuItem";
            // 
            // OpenFavotterOpMenuItem
            // 
            this.OpenFavotterOpMenuItem.AccessibleDescription = null;
            this.OpenFavotterOpMenuItem.AccessibleName = null;
            this.OpenFavotterOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenFavotterOpMenuItem, "OpenFavotterOpMenuItem" );
            this.OpenFavotterOpMenuItem.Font = null;
            this.OpenFavotterOpMenuItem.Name = "OpenFavotterOpMenuItem";
            // 
            // OpenUrlOpMenuItem
            // 
            this.OpenUrlOpMenuItem.AccessibleDescription = null;
            this.OpenUrlOpMenuItem.AccessibleName = null;
            this.OpenUrlOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenUrlOpMenuItem, "OpenUrlOpMenuItem" );
            this.OpenUrlOpMenuItem.Font = null;
            this.OpenUrlOpMenuItem.Name = "OpenUrlOpMenuItem";
            // 
            // OpenRterHomeMenuItem
            // 
            this.OpenRterHomeMenuItem.AccessibleDescription = null;
            this.OpenRterHomeMenuItem.AccessibleName = null;
            this.OpenRterHomeMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenRterHomeMenuItem, "OpenRterHomeMenuItem" );
            this.OpenRterHomeMenuItem.Font = null;
            this.OpenRterHomeMenuItem.Name = "OpenRterHomeMenuItem";
            // 
            // CreateTabRuleOpMenuItem
            // 
            this.CreateTabRuleOpMenuItem.AccessibleDescription = null;
            this.CreateTabRuleOpMenuItem.AccessibleName = null;
            this.CreateTabRuleOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.CreateTabRuleOpMenuItem, "CreateTabRuleOpMenuItem" );
            this.CreateTabRuleOpMenuItem.Font = null;
            this.CreateTabRuleOpMenuItem.Name = "CreateTabRuleOpMenuItem";
            // 
            // CreateIdRuleOpMenuItem
            // 
            this.CreateIdRuleOpMenuItem.AccessibleDescription = null;
            this.CreateIdRuleOpMenuItem.AccessibleName = null;
            this.CreateIdRuleOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.CreateIdRuleOpMenuItem, "CreateIdRuleOpMenuItem" );
            this.CreateIdRuleOpMenuItem.Font = null;
            this.CreateIdRuleOpMenuItem.Name = "CreateIdRuleOpMenuItem";
            // 
            // ReadOpMenuItem
            // 
            this.ReadOpMenuItem.AccessibleDescription = null;
            this.ReadOpMenuItem.AccessibleName = null;
            this.ReadOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ReadOpMenuItem, "ReadOpMenuItem" );
            this.ReadOpMenuItem.Font = null;
            this.ReadOpMenuItem.Name = "ReadOpMenuItem";
            // 
            // UnreadOpMenuItem
            // 
            this.UnreadOpMenuItem.AccessibleDescription = null;
            this.UnreadOpMenuItem.AccessibleName = null;
            this.UnreadOpMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UnreadOpMenuItem, "UnreadOpMenuItem" );
            this.UnreadOpMenuItem.Font = null;
            this.UnreadOpMenuItem.Name = "UnreadOpMenuItem";
            // 
            // CreateTbMenuItem
            // 
            this.CreateTbMenuItem.AccessibleDescription = null;
            this.CreateTbMenuItem.AccessibleName = null;
            this.CreateTbMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.CreateTbMenuItem, "CreateTbMenuItem" );
            this.CreateTbMenuItem.Font = null;
            this.CreateTbMenuItem.Name = "CreateTbMenuItem";
            // 
            // RenameTbMenuItem
            // 
            this.RenameTbMenuItem.AccessibleDescription = null;
            this.RenameTbMenuItem.AccessibleName = null;
            this.RenameTbMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RenameTbMenuItem, "RenameTbMenuItem" );
            this.RenameTbMenuItem.Font = null;
            this.RenameTbMenuItem.Name = "RenameTbMenuItem";
            // 
            // UnreadMngTbMenuItem
            // 
            this.UnreadMngTbMenuItem.AccessibleDescription = null;
            this.UnreadMngTbMenuItem.AccessibleName = null;
            this.UnreadMngTbMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UnreadMngTbMenuItem, "UnreadMngTbMenuItem" );
            this.UnreadMngTbMenuItem.Font = null;
            this.UnreadMngTbMenuItem.Name = "UnreadMngTbMenuItem";
            // 
            // NotifyTbMenuItem
            // 
            this.NotifyTbMenuItem.AccessibleDescription = null;
            this.NotifyTbMenuItem.AccessibleName = null;
            this.NotifyTbMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.NotifyTbMenuItem, "NotifyTbMenuItem" );
            this.NotifyTbMenuItem.Font = null;
            this.NotifyTbMenuItem.Name = "NotifyTbMenuItem";
            // 
            // EditRuleTbMenuItem
            // 
            this.EditRuleTbMenuItem.AccessibleDescription = null;
            this.EditRuleTbMenuItem.AccessibleName = null;
            this.EditRuleTbMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.EditRuleTbMenuItem, "EditRuleTbMenuItem" );
            this.EditRuleTbMenuItem.Font = null;
            this.EditRuleTbMenuItem.Name = "EditRuleTbMenuItem";
            // 
            // ClearTbMenuItem
            // 
            this.ClearTbMenuItem.AccessibleDescription = null;
            this.ClearTbMenuItem.AccessibleName = null;
            this.ClearTbMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ClearTbMenuItem, "ClearTbMenuItem" );
            this.ClearTbMenuItem.Font = null;
            this.ClearTbMenuItem.Name = "ClearTbMenuItem";
            // 
            // DeleteTbMenuItem
            // 
            this.DeleteTbMenuItem.AccessibleDescription = null;
            this.DeleteTbMenuItem.AccessibleName = null;
            this.DeleteTbMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.DeleteTbMenuItem, "DeleteTbMenuItem" );
            this.DeleteTbMenuItem.Font = null;
            this.DeleteTbMenuItem.Name = "DeleteTbMenuItem";
            // 
            // SoundFileTbComboBox
            // 
            this.SoundFileTbComboBox.AccessibleDescription = null;
            this.SoundFileTbComboBox.AccessibleName = null;
            this.SoundFileTbComboBox.BackgroundImage = null;
            resources.ApplyResources( this.SoundFileTbComboBox, "SoundFileTbComboBox" );
            this.SoundFileTbComboBox.Font = null;
            this.SoundFileTbComboBox.Name = "SoundFileTbComboBox";
            // 
            // ToolStripSeparator28
            // 
            this.ToolStripSeparator28.AccessibleDescription = null;
            this.ToolStripSeparator28.AccessibleName = null;
            this.ToolStripSeparator28.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator28, "ToolStripSeparator28" );
            this.ToolStripSeparator28.Font = null;
            this.ToolStripSeparator28.Name = "ToolStripSeparator28";
            // 
            // ToolStripSeparator29
            // 
            this.ToolStripSeparator29.AccessibleDescription = null;
            this.ToolStripSeparator29.AccessibleName = null;
            this.ToolStripSeparator29.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator29, "ToolStripSeparator29" );
            this.ToolStripSeparator29.Font = null;
            this.ToolStripSeparator29.Name = "ToolStripSeparator29";
            // 
            // ToolStripSeparator30
            // 
            this.ToolStripSeparator30.AccessibleDescription = null;
            this.ToolStripSeparator30.AccessibleName = null;
            this.ToolStripSeparator30.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator30, "ToolStripSeparator30" );
            this.ToolStripSeparator30.Font = null;
            this.ToolStripSeparator30.Name = "ToolStripSeparator30";
            // 
            // ToolStripSeparator31
            // 
            this.ToolStripSeparator31.AccessibleDescription = null;
            this.ToolStripSeparator31.AccessibleName = null;
            this.ToolStripSeparator31.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator31, "ToolStripSeparator31" );
            this.ToolStripSeparator31.Font = null;
            this.ToolStripSeparator31.Name = "ToolStripSeparator31";
            // 
            // ToolStripSeparator32
            // 
            this.ToolStripSeparator32.AccessibleDescription = null;
            this.ToolStripSeparator32.AccessibleName = null;
            this.ToolStripSeparator32.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator32, "ToolStripSeparator32" );
            this.ToolStripSeparator32.Font = null;
            this.ToolStripSeparator32.Name = "ToolStripSeparator32";
            // 
            // ToolStripSeparator33
            // 
            this.ToolStripSeparator33.AccessibleDescription = null;
            this.ToolStripSeparator33.AccessibleName = null;
            this.ToolStripSeparator33.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator33, "ToolStripSeparator33" );
            this.ToolStripSeparator33.Font = null;
            this.ToolStripSeparator33.Name = "ToolStripSeparator33";
            // 
            // PostBrowser
            // 
            this.PostBrowser.AccessibleDescription = null;
            this.PostBrowser.AccessibleName = null;
            this.PostBrowser.BackgroundImage = null;
            resources.ApplyResources( this.PostBrowser, "PostBrowser" );
            this.PostBrowser.Font = null;
            this.PostBrowser.Name = "PostBrowser";
            // 
            // SplitContainer3
            // 
            this.SplitContainer3.AccessibleDescription = null;
            this.SplitContainer3.AccessibleName = null;
            this.SplitContainer3.BackgroundImage = null;
            resources.ApplyResources( this.SplitContainer3, "SplitContainer3" );
            this.SplitContainer3.Font = null;
            this.SplitContainer3.Name = "SplitContainer3";
            // 
            // PreviewPicture
            // 
            this.PreviewPicture.AccessibleDescription = null;
            this.PreviewPicture.AccessibleName = null;
            this.PreviewPicture.BackgroundImage = null;
            resources.ApplyResources( this.PreviewPicture, "PreviewPicture" );
            this.PreviewPicture.Font = null;
            this.PreviewPicture.Name = "PreviewPicture";
            // 
            // PreviewScrollBar
            // 
            this.PreviewScrollBar.AccessibleDescription = null;
            this.PreviewScrollBar.AccessibleName = null;
            this.PreviewScrollBar.BackgroundImage = null;
            resources.ApplyResources( this.PreviewScrollBar, "PreviewScrollBar" );
            this.PreviewScrollBar.Font = null;
            this.PreviewScrollBar.Name = "PreviewScrollBar";
            // 
            // ToolTip1
            // 
            this.ToolTip1.AccessibleDescription = null;
            this.ToolTip1.AccessibleName = null;
            this.ToolTip1.BackgroundImage = null;
            resources.ApplyResources( this.ToolTip1, "ToolTip1" );
            this.ToolTip1.Font = null;
            this.ToolTip1.Name = "ToolTip1";
            // 
            // FollowToolStripMenuItem
            // 
            this.FollowToolStripMenuItem.AccessibleDescription = null;
            this.FollowToolStripMenuItem.AccessibleName = null;
            this.FollowToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FollowToolStripMenuItem, "FollowToolStripMenuItem" );
            this.FollowToolStripMenuItem.Font = null;
            this.FollowToolStripMenuItem.Name = "FollowToolStripMenuItem";
            // 
            // UnFollowToolStripMenuItem
            // 
            this.UnFollowToolStripMenuItem.AccessibleDescription = null;
            this.UnFollowToolStripMenuItem.AccessibleName = null;
            this.UnFollowToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UnFollowToolStripMenuItem, "UnFollowToolStripMenuItem" );
            this.UnFollowToolStripMenuItem.Font = null;
            this.UnFollowToolStripMenuItem.Name = "UnFollowToolStripMenuItem";
            // 
            // ShowFriendShipToolStripMenuItem
            // 
            this.ShowFriendShipToolStripMenuItem.AccessibleDescription = null;
            this.ShowFriendShipToolStripMenuItem.AccessibleName = null;
            this.ShowFriendShipToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ShowFriendShipToolStripMenuItem, "ShowFriendShipToolStripMenuItem" );
            this.ShowFriendShipToolStripMenuItem.Font = null;
            this.ShowFriendShipToolStripMenuItem.Name = "ShowFriendShipToolStripMenuItem";
            // 
            // ShowUserStatusToolStripMenuItem
            // 
            this.ShowUserStatusToolStripMenuItem.AccessibleDescription = null;
            this.ShowUserStatusToolStripMenuItem.AccessibleName = null;
            this.ShowUserStatusToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ShowUserStatusToolStripMenuItem, "ShowUserStatusToolStripMenuItem" );
            this.ShowUserStatusToolStripMenuItem.Font = null;
            this.ShowUserStatusToolStripMenuItem.Name = "ShowUserStatusToolStripMenuItem";
            // 
            // ShowUserStatusContextMenuItem
            // 
            this.ShowUserStatusContextMenuItem.AccessibleDescription = null;
            this.ShowUserStatusContextMenuItem.AccessibleName = null;
            this.ShowUserStatusContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ShowUserStatusContextMenuItem, "ShowUserStatusContextMenuItem" );
            this.ShowUserStatusContextMenuItem.Font = null;
            this.ShowUserStatusContextMenuItem.Name = "ShowUserStatusContextMenuItem";
            // 
            // ShowProfileMenuItem
            // 
            this.ShowProfileMenuItem.AccessibleDescription = null;
            this.ShowProfileMenuItem.AccessibleName = null;
            this.ShowProfileMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ShowProfileMenuItem, "ShowProfileMenuItem" );
            this.ShowProfileMenuItem.Font = null;
            this.ShowProfileMenuItem.Name = "ShowProfileMenuItem";
            // 
            // ShowProfMenuItem
            // 
            this.ShowProfMenuItem.AccessibleDescription = null;
            this.ShowProfMenuItem.AccessibleName = null;
            this.ShowProfMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ShowProfMenuItem, "ShowProfMenuItem" );
            this.ShowProfMenuItem.Font = null;
            this.ShowProfMenuItem.Name = "ShowProfMenuItem";
            // 
            // ToolStripSeparator34
            // 
            this.ToolStripSeparator34.AccessibleDescription = null;
            this.ToolStripSeparator34.AccessibleName = null;
            this.ToolStripSeparator34.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator34, "ToolStripSeparator34" );
            this.ToolStripSeparator34.Font = null;
            this.ToolStripSeparator34.Name = "ToolStripSeparator34";
            // 
            // HashToggleToolStripMenuItem
            // 
            this.HashToggleToolStripMenuItem.AccessibleDescription = null;
            this.HashToggleToolStripMenuItem.AccessibleName = null;
            this.HashToggleToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.HashToggleToolStripMenuItem, "HashToggleToolStripMenuItem" );
            this.HashToggleToolStripMenuItem.Font = null;
            this.HashToggleToolStripMenuItem.Name = "HashToggleToolStripMenuItem";
            // 
            // HashManageToolStripMenuItem
            // 
            this.HashManageToolStripMenuItem.AccessibleDescription = null;
            this.HashManageToolStripMenuItem.AccessibleName = null;
            this.HashManageToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.HashManageToolStripMenuItem, "HashManageToolStripMenuItem" );
            this.HashManageToolStripMenuItem.Font = null;
            this.HashManageToolStripMenuItem.Name = "HashManageToolStripMenuItem";
            // 
            // RtCountMenuItem
            // 
            this.RtCountMenuItem.AccessibleDescription = null;
            this.RtCountMenuItem.AccessibleName = null;
            this.RtCountMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.RtCountMenuItem, "RtCountMenuItem" );
            this.RtCountMenuItem.Font = null;
            this.RtCountMenuItem.Name = "RtCountMenuItem";
            // 
            // SearchPostsDetailToolStripMenuItem
            // 
            this.SearchPostsDetailToolStripMenuItem.AccessibleDescription = null;
            this.SearchPostsDetailToolStripMenuItem.AccessibleName = null;
            this.SearchPostsDetailToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SearchPostsDetailToolStripMenuItem, "SearchPostsDetailToolStripMenuItem" );
            this.SearchPostsDetailToolStripMenuItem.Font = null;
            this.SearchPostsDetailToolStripMenuItem.Name = "SearchPostsDetailToolStripMenuItem";
            // 
            // SearchAtPostsDetailNameToolStripMenuItem
            // 
            this.SearchAtPostsDetailNameToolStripMenuItem.AccessibleDescription = null;
            this.SearchAtPostsDetailNameToolStripMenuItem.AccessibleName = null;
            this.SearchAtPostsDetailNameToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SearchAtPostsDetailNameToolStripMenuItem, "SearchAtPostsDetailNameToolStripMenuItem" );
            this.SearchAtPostsDetailNameToolStripMenuItem.Font = null;
            this.SearchAtPostsDetailNameToolStripMenuItem.Name = "SearchAtPostsDetailNameToolStripMenuItem";
            // 
            // TimelinePanel
            // 
            this.TimelinePanel.AccessibleDescription = null;
            this.TimelinePanel.AccessibleName = null;
            this.TimelinePanel.BackgroundImage = null;
            resources.ApplyResources( this.TimelinePanel, "TimelinePanel" );
            this.TimelinePanel.Font = null;
            this.TimelinePanel.Name = "TimelinePanel";
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.AccessibleDescription = null;
            this.ProfilePanel.AccessibleName = null;
            this.ProfilePanel.BackgroundImage = null;
            resources.ApplyResources( this.ProfilePanel, "ProfilePanel" );
            this.ProfilePanel.Font = null;
            this.ProfilePanel.Name = "ProfilePanel";
            // 
            // Label2
            // 
            this.Label2.AccessibleDescription = null;
            this.Label2.AccessibleName = null;
            this.Label2.BackgroundImage = null;
            resources.ApplyResources( this.Label2, "Label2" );
            this.Label2.Font = null;
            this.Label2.Name = "Label2";
            // 
            // FilePickButton
            // 
            this.FilePickButton.AccessibleDescription = null;
            this.FilePickButton.AccessibleName = null;
            this.FilePickButton.BackgroundImage = null;
            resources.ApplyResources( this.FilePickButton, "FilePickButton" );
            this.FilePickButton.Font = null;
            this.FilePickButton.Name = "FilePickButton";
            // 
            // ImagefilePathText
            // 
            this.ImagefilePathText.AccessibleDescription = null;
            this.ImagefilePathText.AccessibleName = null;
            this.ImagefilePathText.BackgroundImage = null;
            resources.ApplyResources( this.ImagefilePathText, "ImagefilePathText" );
            this.ImagefilePathText.Font = null;
            this.ImagefilePathText.Name = "ImagefilePathText";
            // 
            // Label1
            // 
            this.Label1.AccessibleDescription = null;
            this.Label1.AccessibleName = null;
            this.Label1.BackgroundImage = null;
            resources.ApplyResources( this.Label1, "Label1" );
            this.Label1.Font = null;
            this.Label1.Name = "Label1";
            // 
            // ImageSelectedPicture
            // 
            this.ImageSelectedPicture.AccessibleDescription = null;
            this.ImageSelectedPicture.AccessibleName = null;
            this.ImageSelectedPicture.BackgroundImage = null;
            resources.ApplyResources( this.ImageSelectedPicture, "ImageSelectedPicture" );
            this.ImageSelectedPicture.Font = null;
            this.ImageSelectedPicture.Name = "ImageSelectedPicture";
            // 
            // ImageSelectionPanel
            // 
            this.ImageSelectionPanel.AccessibleDescription = null;
            this.ImageSelectionPanel.AccessibleName = null;
            this.ImageSelectionPanel.BackgroundImage = null;
            resources.ApplyResources( this.ImageSelectionPanel, "ImageSelectionPanel" );
            this.ImageSelectionPanel.Font = null;
            this.ImageSelectionPanel.Name = "ImageSelectionPanel";
            // 
            // ImagePathPanel
            // 
            this.ImagePathPanel.AccessibleDescription = null;
            this.ImagePathPanel.AccessibleName = null;
            this.ImagePathPanel.BackgroundImage = null;
            resources.ApplyResources( this.ImagePathPanel, "ImagePathPanel" );
            this.ImagePathPanel.Font = null;
            this.ImagePathPanel.Name = "ImagePathPanel";
            // 
            // ImageServiceCombo
            // 
            this.ImageServiceCombo.AccessibleDescription = null;
            this.ImageServiceCombo.AccessibleName = null;
            this.ImageServiceCombo.BackgroundImage = null;
            resources.ApplyResources( this.ImageServiceCombo, "ImageServiceCombo" );
            this.ImageServiceCombo.Font = null;
            this.ImageServiceCombo.Name = "ImageServiceCombo";
            // 
            // ImageSelectMenuItem
            // 
            this.ImageSelectMenuItem.AccessibleDescription = null;
            this.ImageSelectMenuItem.AccessibleName = null;
            this.ImageSelectMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ImageSelectMenuItem, "ImageSelectMenuItem" );
            this.ImageSelectMenuItem.Font = null;
            this.ImageSelectMenuItem.Name = "ImageSelectMenuItem";
            // 
            // ToolStripSeparator35
            // 
            this.ToolStripSeparator35.AccessibleDescription = null;
            this.ToolStripSeparator35.AccessibleName = null;
            this.ToolStripSeparator35.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator35, "ToolStripSeparator35" );
            this.ToolStripSeparator35.Font = null;
            this.ToolStripSeparator35.Name = "ToolStripSeparator35";
            // 
            // FriendshipAllMenuItem
            // 
            this.FriendshipAllMenuItem.AccessibleDescription = null;
            this.FriendshipAllMenuItem.AccessibleName = null;
            this.FriendshipAllMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FriendshipAllMenuItem, "FriendshipAllMenuItem" );
            this.FriendshipAllMenuItem.Font = null;
            this.FriendshipAllMenuItem.Name = "FriendshipAllMenuItem";
            // 
            // ToolStripSeparator36
            // 
            this.ToolStripSeparator36.AccessibleDescription = null;
            this.ToolStripSeparator36.AccessibleName = null;
            this.ToolStripSeparator36.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator36, "ToolStripSeparator36" );
            this.ToolStripSeparator36.Font = null;
            this.ToolStripSeparator36.Name = "ToolStripSeparator36";
            // 
            // UserStatusToolStripMenuItem
            // 
            this.UserStatusToolStripMenuItem.AccessibleDescription = null;
            this.UserStatusToolStripMenuItem.AccessibleName = null;
            this.UserStatusToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UserStatusToolStripMenuItem, "UserStatusToolStripMenuItem" );
            this.UserStatusToolStripMenuItem.Font = null;
            this.UserStatusToolStripMenuItem.Name = "UserStatusToolStripMenuItem";
            // 
            // ImageCancelButton
            // 
            this.ImageCancelButton.AccessibleDescription = null;
            this.ImageCancelButton.AccessibleName = null;
            this.ImageCancelButton.BackgroundImage = null;
            resources.ApplyResources( this.ImageCancelButton, "ImageCancelButton" );
            this.ImageCancelButton.Font = null;
            this.ImageCancelButton.Name = "ImageCancelButton";
            // 
            // ToolStripFocusLockMenuItem
            // 
            this.ToolStripFocusLockMenuItem.AccessibleDescription = null;
            this.ToolStripFocusLockMenuItem.AccessibleName = null;
            this.ToolStripFocusLockMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripFocusLockMenuItem, "ToolStripFocusLockMenuItem" );
            this.ToolStripFocusLockMenuItem.Font = null;
            this.ToolStripFocusLockMenuItem.Name = "ToolStripFocusLockMenuItem";
            // 
            // ListManageUserContextToolStripMenuItem
            // 
            this.ListManageUserContextToolStripMenuItem.AccessibleDescription = null;
            this.ListManageUserContextToolStripMenuItem.AccessibleName = null;
            this.ListManageUserContextToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ListManageUserContextToolStripMenuItem, "ListManageUserContextToolStripMenuItem" );
            this.ListManageUserContextToolStripMenuItem.Font = null;
            this.ListManageUserContextToolStripMenuItem.Name = "ListManageUserContextToolStripMenuItem";
            // 
            // ToolStripSeparator37
            // 
            this.ToolStripSeparator37.AccessibleDescription = null;
            this.ToolStripSeparator37.AccessibleName = null;
            this.ToolStripSeparator37.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator37, "ToolStripSeparator37" );
            this.ToolStripSeparator37.Font = null;
            this.ToolStripSeparator37.Name = "ToolStripSeparator37";
            // 
            // ShortcutKeyListMenuItem
            // 
            this.ShortcutKeyListMenuItem.AccessibleDescription = null;
            this.ShortcutKeyListMenuItem.AccessibleName = null;
            this.ShortcutKeyListMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ShortcutKeyListMenuItem, "ShortcutKeyListMenuItem" );
            this.ShortcutKeyListMenuItem.Font = null;
            this.ShortcutKeyListMenuItem.Name = "ShortcutKeyListMenuItem";
            // 
            // ListManageMenuItem
            // 
            this.ListManageMenuItem.AccessibleDescription = null;
            this.ListManageMenuItem.AccessibleName = null;
            this.ListManageMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ListManageMenuItem, "ListManageMenuItem" );
            this.ListManageMenuItem.Font = null;
            this.ListManageMenuItem.Name = "ListManageMenuItem";
            // 
            // ListManageUserContextToolStripMenuItem2
            // 
            this.ListManageUserContextToolStripMenuItem2.AccessibleDescription = null;
            this.ListManageUserContextToolStripMenuItem2.AccessibleName = null;
            this.ListManageUserContextToolStripMenuItem2.BackgroundImage = null;
            resources.ApplyResources( this.ListManageUserContextToolStripMenuItem2, "ListManageUserContextToolStripMenuItem2" );
            this.ListManageUserContextToolStripMenuItem2.Font = null;
            this.ListManageUserContextToolStripMenuItem2.Name = "ListManageUserContextToolStripMenuItem2";
            // 
            // ListManageUserContextToolStripMenuItem3
            // 
            this.ListManageUserContextToolStripMenuItem3.AccessibleDescription = null;
            this.ListManageUserContextToolStripMenuItem3.AccessibleName = null;
            this.ListManageUserContextToolStripMenuItem3.BackgroundImage = null;
            resources.ApplyResources( this.ListManageUserContextToolStripMenuItem3, "ListManageUserContextToolStripMenuItem3" );
            this.ListManageUserContextToolStripMenuItem3.Font = null;
            this.ListManageUserContextToolStripMenuItem3.Name = "ListManageUserContextToolStripMenuItem3";
            // 
            // ListManageToolStripMenuItem
            // 
            this.ListManageToolStripMenuItem.AccessibleDescription = null;
            this.ListManageToolStripMenuItem.AccessibleName = null;
            this.ListManageToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ListManageToolStripMenuItem, "ListManageToolStripMenuItem" );
            this.ListManageToolStripMenuItem.Font = null;
            this.ListManageToolStripMenuItem.Name = "ListManageToolStripMenuItem";
            // 
            // CacheInfoMenuItem
            // 
            this.CacheInfoMenuItem.AccessibleDescription = null;
            this.CacheInfoMenuItem.AccessibleName = null;
            this.CacheInfoMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.CacheInfoMenuItem, "CacheInfoMenuItem" );
            this.CacheInfoMenuItem.Font = null;
            this.CacheInfoMenuItem.Name = "CacheInfoMenuItem";
            // 
            // SourceLinkLabel
            // 
            this.SourceLinkLabel.AccessibleDescription = null;
            this.SourceLinkLabel.AccessibleName = null;
            this.SourceLinkLabel.BackgroundImage = null;
            resources.ApplyResources( this.SourceLinkLabel, "SourceLinkLabel" );
            this.SourceLinkLabel.Font = null;
            this.SourceLinkLabel.Name = "SourceLinkLabel";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.AccessibleDescription = null;
            this.ToolStripStatusLabel1.AccessibleName = null;
            this.ToolStripStatusLabel1.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripStatusLabel1, "ToolStripStatusLabel1" );
            this.ToolStripStatusLabel1.Font = null;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            // 
            // CopyUserIdStripMenuItem
            // 
            this.CopyUserIdStripMenuItem.AccessibleDescription = null;
            this.CopyUserIdStripMenuItem.AccessibleName = null;
            this.CopyUserIdStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.CopyUserIdStripMenuItem, "CopyUserIdStripMenuItem" );
            this.CopyUserIdStripMenuItem.Font = null;
            this.CopyUserIdStripMenuItem.Name = "CopyUserIdStripMenuItem";
            // 
            // FavoriteRetweetMenuItem
            // 
            this.FavoriteRetweetMenuItem.AccessibleDescription = null;
            this.FavoriteRetweetMenuItem.AccessibleName = null;
            this.FavoriteRetweetMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FavoriteRetweetMenuItem, "FavoriteRetweetMenuItem" );
            this.FavoriteRetweetMenuItem.Font = null;
            this.FavoriteRetweetMenuItem.Name = "FavoriteRetweetMenuItem";
            // 
            // FavoriteRetweetUnofficialMenuItem
            // 
            this.FavoriteRetweetUnofficialMenuItem.AccessibleDescription = null;
            this.FavoriteRetweetUnofficialMenuItem.AccessibleName = null;
            this.FavoriteRetweetUnofficialMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.FavoriteRetweetUnofficialMenuItem, "FavoriteRetweetUnofficialMenuItem" );
            this.FavoriteRetweetUnofficialMenuItem.Font = null;
            this.FavoriteRetweetUnofficialMenuItem.Name = "FavoriteRetweetUnofficialMenuItem";
            // 
            // ToolStripSeparator38
            // 
            this.ToolStripSeparator38.AccessibleDescription = null;
            this.ToolStripSeparator38.AccessibleName = null;
            this.ToolStripSeparator38.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator38, "ToolStripSeparator38" );
            this.ToolStripSeparator38.Font = null;
            this.ToolStripSeparator38.Name = "ToolStripSeparator38";
            // 
            // ToolStripSeparator39
            // 
            this.ToolStripSeparator39.AccessibleDescription = null;
            this.ToolStripSeparator39.AccessibleName = null;
            this.ToolStripSeparator39.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator39, "ToolStripSeparator39" );
            this.ToolStripSeparator39.Font = null;
            this.ToolStripSeparator39.Name = "ToolStripSeparator39";
            // 
            // FavoriteRetweetContextMenu
            // 
            this.FavoriteRetweetContextMenu.AccessibleDescription = null;
            this.FavoriteRetweetContextMenu.AccessibleName = null;
            this.FavoriteRetweetContextMenu.BackgroundImage = null;
            resources.ApplyResources( this.FavoriteRetweetContextMenu, "FavoriteRetweetContextMenu" );
            this.FavoriteRetweetContextMenu.Font = null;
            this.FavoriteRetweetContextMenu.Name = "FavoriteRetweetContextMenu";
            // 
            // FavoriteRetweetUnofficialContextMenu
            // 
            this.FavoriteRetweetUnofficialContextMenu.AccessibleDescription = null;
            this.FavoriteRetweetUnofficialContextMenu.AccessibleName = null;
            this.FavoriteRetweetUnofficialContextMenu.BackgroundImage = null;
            resources.ApplyResources( this.FavoriteRetweetUnofficialContextMenu, "FavoriteRetweetUnofficialContextMenu" );
            this.FavoriteRetweetUnofficialContextMenu.Font = null;
            this.FavoriteRetweetUnofficialContextMenu.Name = "FavoriteRetweetUnofficialContextMenu";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.AccessibleDescription = null;
            this.ToolStripSeparator2.AccessibleName = null;
            this.ToolStripSeparator2.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator2, "ToolStripSeparator2" );
            this.ToolStripSeparator2.Font = null;
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            // 
            // ShowRelatedStatusesMenuItem2
            // 
            this.ShowRelatedStatusesMenuItem2.AccessibleDescription = null;
            this.ShowRelatedStatusesMenuItem2.AccessibleName = null;
            this.ShowRelatedStatusesMenuItem2.BackgroundImage = null;
            resources.ApplyResources( this.ShowRelatedStatusesMenuItem2, "ShowRelatedStatusesMenuItem2" );
            this.ShowRelatedStatusesMenuItem2.Font = null;
            this.ShowRelatedStatusesMenuItem2.Name = "ShowRelatedStatusesMenuItem2";
            // 
            // ShowRelatedStatusesMenuItem
            // 
            this.ShowRelatedStatusesMenuItem.AccessibleDescription = null;
            this.ShowRelatedStatusesMenuItem.AccessibleName = null;
            this.ShowRelatedStatusesMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ShowRelatedStatusesMenuItem, "ShowRelatedStatusesMenuItem" );
            this.ShowRelatedStatusesMenuItem.Font = null;
            this.ShowRelatedStatusesMenuItem.Name = "ShowRelatedStatusesMenuItem";
            // 
            // MenuItemUserStream
            // 
            this.MenuItemUserStream.AccessibleDescription = null;
            this.MenuItemUserStream.AccessibleName = null;
            this.MenuItemUserStream.BackgroundImage = null;
            resources.ApplyResources( this.MenuItemUserStream, "MenuItemUserStream" );
            this.MenuItemUserStream.Font = null;
            this.MenuItemUserStream.Name = "MenuItemUserStream";
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.AccessibleDescription = null;
            this.StopToolStripMenuItem.AccessibleName = null;
            this.StopToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.StopToolStripMenuItem, "StopToolStripMenuItem" );
            this.StopToolStripMenuItem.Font = null;
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            // 
            // ToolStripSeparator40
            // 
            this.ToolStripSeparator40.AccessibleDescription = null;
            this.ToolStripSeparator40.AccessibleName = null;
            this.ToolStripSeparator40.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator40, "ToolStripSeparator40" );
            this.ToolStripSeparator40.Font = null;
            this.ToolStripSeparator40.Name = "ToolStripSeparator40";
            // 
            // TrackToolStripMenuItem
            // 
            this.TrackToolStripMenuItem.AccessibleDescription = null;
            this.TrackToolStripMenuItem.AccessibleName = null;
            this.TrackToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.TrackToolStripMenuItem, "TrackToolStripMenuItem" );
            this.TrackToolStripMenuItem.Font = null;
            this.TrackToolStripMenuItem.Name = "TrackToolStripMenuItem";
            // 
            // AllrepliesToolStripMenuItem
            // 
            this.AllrepliesToolStripMenuItem.AccessibleDescription = null;
            this.AllrepliesToolStripMenuItem.AccessibleName = null;
            this.AllrepliesToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.AllrepliesToolStripMenuItem, "AllrepliesToolStripMenuItem" );
            this.AllrepliesToolStripMenuItem.Font = null;
            this.AllrepliesToolStripMenuItem.Name = "AllrepliesToolStripMenuItem";
            // 
            // TweenRestartMenuItem
            // 
            this.TweenRestartMenuItem.AccessibleDescription = null;
            this.TweenRestartMenuItem.AccessibleName = null;
            this.TweenRestartMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.TweenRestartMenuItem, "TweenRestartMenuItem" );
            this.TweenRestartMenuItem.Font = null;
            this.TweenRestartMenuItem.Name = "TweenRestartMenuItem";
            // 
            // SearchPostsDetailNameToolStripMenuItem
            // 
            this.SearchPostsDetailNameToolStripMenuItem.AccessibleDescription = null;
            this.SearchPostsDetailNameToolStripMenuItem.AccessibleName = null;
            this.SearchPostsDetailNameToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SearchPostsDetailNameToolStripMenuItem, "SearchPostsDetailNameToolStripMenuItem" );
            this.SearchPostsDetailNameToolStripMenuItem.Font = null;
            this.SearchPostsDetailNameToolStripMenuItem.Name = "SearchPostsDetailNameToolStripMenuItem";
            // 
            // SearchAtPostsDetailToolStripMenuItem
            // 
            this.SearchAtPostsDetailToolStripMenuItem.AccessibleDescription = null;
            this.SearchAtPostsDetailToolStripMenuItem.AccessibleName = null;
            this.SearchAtPostsDetailToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SearchAtPostsDetailToolStripMenuItem, "SearchAtPostsDetailToolStripMenuItem" );
            this.SearchAtPostsDetailToolStripMenuItem.Font = null;
            this.SearchAtPostsDetailToolStripMenuItem.Name = "SearchAtPostsDetailToolStripMenuItem";
            // 
            // ToolStripSeparator41
            // 
            this.ToolStripSeparator41.AccessibleDescription = null;
            this.ToolStripSeparator41.AccessibleName = null;
            this.ToolStripSeparator41.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator41, "ToolStripSeparator41" );
            this.ToolStripSeparator41.Font = null;
            this.ToolStripSeparator41.Name = "ToolStripSeparator41";
            // 
            // OpenOwnHomeMenuItem
            // 
            this.OpenOwnHomeMenuItem.AccessibleDescription = null;
            this.OpenOwnHomeMenuItem.AccessibleName = null;
            this.OpenOwnHomeMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenOwnHomeMenuItem, "OpenOwnHomeMenuItem" );
            this.OpenOwnHomeMenuItem.Font = null;
            this.OpenOwnHomeMenuItem.Name = "OpenOwnHomeMenuItem";
            // 
            // OpenOwnFavedMenuItem
            // 
            this.OpenOwnFavedMenuItem.AccessibleDescription = null;
            this.OpenOwnFavedMenuItem.AccessibleName = null;
            this.OpenOwnFavedMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenOwnFavedMenuItem, "OpenOwnFavedMenuItem" );
            this.OpenOwnFavedMenuItem.Font = null;
            this.OpenOwnFavedMenuItem.Name = "OpenOwnFavedMenuItem";
            // 
            // ToolStripSeparator42
            // 
            this.ToolStripSeparator42.AccessibleDescription = null;
            this.ToolStripSeparator42.AccessibleName = null;
            this.ToolStripSeparator42.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator42, "ToolStripSeparator42" );
            this.ToolStripSeparator42.Font = null;
            this.ToolStripSeparator42.Name = "ToolStripSeparator42";
            // 
            // EventViewerMenuItem
            // 
            this.EventViewerMenuItem.AccessibleDescription = null;
            this.EventViewerMenuItem.AccessibleName = null;
            this.EventViewerMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.EventViewerMenuItem, "EventViewerMenuItem" );
            this.EventViewerMenuItem.Font = null;
            this.EventViewerMenuItem.Name = "EventViewerMenuItem";
            // 
            // TranslationToolStripMenuItem
            // 
            this.TranslationToolStripMenuItem.AccessibleDescription = null;
            this.TranslationToolStripMenuItem.AccessibleName = null;
            this.TranslationToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.TranslationToolStripMenuItem, "TranslationToolStripMenuItem" );
            this.TranslationToolStripMenuItem.Font = null;
            this.TranslationToolStripMenuItem.Name = "TranslationToolStripMenuItem";
            // 
            // UxnuMenuItem
            // 
            this.UxnuMenuItem.AccessibleDescription = null;
            this.UxnuMenuItem.AccessibleName = null;
            this.UxnuMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UxnuMenuItem, "UxnuMenuItem" );
            this.UxnuMenuItem.Font = null;
            this.UxnuMenuItem.Name = "UxnuMenuItem";
            // 
            // ShowUserTimelineToolStripMenuItem
            // 
            this.ShowUserTimelineToolStripMenuItem.AccessibleDescription = null;
            this.ShowUserTimelineToolStripMenuItem.AccessibleName = null;
            this.ShowUserTimelineToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ShowUserTimelineToolStripMenuItem, "ShowUserTimelineToolStripMenuItem" );
            this.ShowUserTimelineToolStripMenuItem.Font = null;
            this.ShowUserTimelineToolStripMenuItem.Name = "ShowUserTimelineToolStripMenuItem";
            // 
            // ShowUserTimelineContextMenuItem
            // 
            this.ShowUserTimelineContextMenuItem.AccessibleDescription = null;
            this.ShowUserTimelineContextMenuItem.AccessibleName = null;
            this.ShowUserTimelineContextMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.ShowUserTimelineContextMenuItem, "ShowUserTimelineContextMenuItem" );
            this.ShowUserTimelineContextMenuItem.Font = null;
            this.ShowUserTimelineContextMenuItem.Name = "ShowUserTimelineContextMenuItem";
            // 
            // UserTimelineToolStripMenuItem
            // 
            this.UserTimelineToolStripMenuItem.AccessibleDescription = null;
            this.UserTimelineToolStripMenuItem.AccessibleName = null;
            this.UserTimelineToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UserTimelineToolStripMenuItem, "UserTimelineToolStripMenuItem" );
            this.UserTimelineToolStripMenuItem.Font = null;
            this.UserTimelineToolStripMenuItem.Name = "UserTimelineToolStripMenuItem";
            // 
            // UserFavorareToolStripMenuItem
            // 
            this.UserFavorareToolStripMenuItem.AccessibleDescription = null;
            this.UserFavorareToolStripMenuItem.AccessibleName = null;
            this.UserFavorareToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.UserFavorareToolStripMenuItem, "UserFavorareToolStripMenuItem" );
            this.UserFavorareToolStripMenuItem.Font = null;
            this.UserFavorareToolStripMenuItem.Name = "UserFavorareToolStripMenuItem";
            // 
            // SelectionTranslationToolStripMenuItem
            // 
            this.SelectionTranslationToolStripMenuItem.AccessibleDescription = null;
            this.SelectionTranslationToolStripMenuItem.AccessibleName = null;
            this.SelectionTranslationToolStripMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SelectionTranslationToolStripMenuItem, "SelectionTranslationToolStripMenuItem" );
            this.SelectionTranslationToolStripMenuItem.Font = null;
            this.SelectionTranslationToolStripMenuItem.Name = "SelectionTranslationToolStripMenuItem";
            // 
            // ToolStripSeparator43
            // 
            this.ToolStripSeparator43.AccessibleDescription = null;
            this.ToolStripSeparator43.AccessibleName = null;
            this.ToolStripSeparator43.BackgroundImage = null;
            resources.ApplyResources( this.ToolStripSeparator43, "ToolStripSeparator43" );
            this.ToolStripSeparator43.Font = null;
            this.ToolStripSeparator43.Name = "ToolStripSeparator43";
            // 
            // StopRefreshAllMenuItem
            // 
            this.StopRefreshAllMenuItem.AccessibleDescription = null;
            this.StopRefreshAllMenuItem.AccessibleName = null;
            this.StopRefreshAllMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.StopRefreshAllMenuItem, "StopRefreshAllMenuItem" );
            this.StopRefreshAllMenuItem.Font = null;
            this.StopRefreshAllMenuItem.Name = "StopRefreshAllMenuItem";
            // 
            // OpenUserSpecifiedUrlMenuItem
            // 
            this.OpenUserSpecifiedUrlMenuItem.AccessibleDescription = null;
            this.OpenUserSpecifiedUrlMenuItem.AccessibleName = null;
            this.OpenUserSpecifiedUrlMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.OpenUserSpecifiedUrlMenuItem, "OpenUserSpecifiedUrlMenuItem" );
            this.OpenUserSpecifiedUrlMenuItem.Font = null;
            this.OpenUserSpecifiedUrlMenuItem.Name = "OpenUserSpecifiedUrlMenuItem";
            // 
            // OpenUserSpecifiedUrlMenuItem2
            // 
            this.OpenUserSpecifiedUrlMenuItem2.AccessibleDescription = null;
            this.OpenUserSpecifiedUrlMenuItem2.AccessibleName = null;
            this.OpenUserSpecifiedUrlMenuItem2.BackgroundImage = null;
            resources.ApplyResources( this.OpenUserSpecifiedUrlMenuItem2, "OpenUserSpecifiedUrlMenuItem2" );
            this.OpenUserSpecifiedUrlMenuItem2.Font = null;
            this.OpenUserSpecifiedUrlMenuItem2.Name = "OpenUserSpecifiedUrlMenuItem2";
            // 
            // PostStateImageList
            // 
            this.PostStateImageList.AccessibleDescription = null;
            this.PostStateImageList.AccessibleName = null;
            this.PostStateImageList.BackgroundImage = null;
            resources.ApplyResources( this.PostStateImageList, "PostStateImageList" );
            this.PostStateImageList.Font = null;
            this.PostStateImageList.Name = "PostStateImageList";
            // 
            // SplitContainer4
            // 
            this.SplitContainer4.AccessibleDescription = null;
            this.SplitContainer4.AccessibleName = null;
            this.SplitContainer4.BackgroundImage = null;
            resources.ApplyResources( this.SplitContainer4, "SplitContainer4" );
            this.SplitContainer4.Font = null;
            this.SplitContainer4.Name = "SplitContainer4";
            // 
            // ContextMenuSource
            // 
            this.ContextMenuSource.AccessibleDescription = null;
            this.ContextMenuSource.AccessibleName = null;
            this.ContextMenuSource.BackgroundImage = null;
            resources.ApplyResources( this.ContextMenuSource, "ContextMenuSource" );
            this.ContextMenuSource.Font = null;
            this.ContextMenuSource.Name = "ContextMenuSource";
            // 
            // SourceCopyMenuItem
            // 
            this.SourceCopyMenuItem.AccessibleDescription = null;
            this.SourceCopyMenuItem.AccessibleName = null;
            this.SourceCopyMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SourceCopyMenuItem, "SourceCopyMenuItem" );
            this.SourceCopyMenuItem.Font = null;
            this.SourceCopyMenuItem.Name = "SourceCopyMenuItem";
            // 
            // SourceUrlCopyMenuItem
            // 
            this.SourceUrlCopyMenuItem.AccessibleDescription = null;
            this.SourceUrlCopyMenuItem.AccessibleName = null;
            this.SourceUrlCopyMenuItem.BackgroundImage = null;
            resources.ApplyResources( this.SourceUrlCopyMenuItem, "SourceUrlCopyMenuItem" );
            this.SourceUrlCopyMenuItem.Font = null;
            this.SourceUrlCopyMenuItem.Name = "SourceUrlCopyMenuItem";
            // 
            // TweenMain
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources( this, "$this" );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizeable;
            this.Name = "TweenMain";

            this.SplitContainer1.Panel1.ResumeLayout( false );
            this.SplitContainer1.Panel2.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout( false );
            this.SplitContainer2.Panel1.ResumeLayout( false );
            this.SplitContainer2.Panel2.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).EndInit();
            this.SplitContainer2.ResumeLayout( false );
            this.TableLayoutPanel1.ResumeLayout( false );
            this.TableLayoutPanel1.PerformLayout();
            this.SplitContainer3.Panel1.ResumeLayout( false );
            this.SplitContainer3.Panel2.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer3).EndInit();
            this.SplitContainer3.ResumeLayout( false );
            this.TimelinePanel.ResumeLayout( false );
            this.TimelinePanel.PerformLayout();
            this.ProfilePanel.ResumeLayout( false );
            this.ProfilePanel.PerformLayout();
            this.ImageSelectionPanel.ResumeLayout( false );
            this.ImageSelectionPanel.PerformLayout();
            this.ImagePathPanel.ResumeLayout( false );
            this.ImagePathPanel.PerformLayout();
            this.SplitContainer4.Panel1.ResumeLayout( false );
            this.SplitContainer4.Panel2.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer4).EndInit();
            this.SplitContainer4.ResumeLayout( false );
            this.ResumeLayout( false );
        }

        private System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuFile;
        private System.Windows.Forms.ToolStripMenuItem EndToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOperate;
        private System.Windows.Forms.ToolStripMenuItem DMStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        private System.Windows.Forms.ImageList TabImage;
        private System.Windows.Forms.ToolStripMenuItem NewPostPopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListLockMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JumpUnreadMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator15;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem SaveLogMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator17;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.Timer TimerRefreshIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenuTabProperty;
        private System.Windows.Forms.ToolStripMenuItem UreadManageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotifyDispMenuItem;
        private System.Windows.Forms.ToolStripComboBox SoundFileComboBox;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem DeleteTabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterEditMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem AddTabMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator20;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem SelectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearTabMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem PlaySoundMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuUserPicture;
        private System.Windows.Forms.ToolStripMenuItem IconNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveIconPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer ToolStripContainer1;
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.TabControl ListTab;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTab;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOperate;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelUrl;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem CopySTOTMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyURLMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSubSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSearchNext;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSearchPrev;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCommand;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MatomeMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem VerUpMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator14;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private Tween.CustomControls.PictureBoxEx UserPicture;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.Label lblLen;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.ToolStripMenuItem TinyUrlConvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateFollowersMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TinyURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IsgdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrlConvertAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrlUndoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuPostBrowser;
        private System.Windows.Forms.ToolStripMenuItem SelectionSearchContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem SelectionCopyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectionAllContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchWikipediaContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchGoogleContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchYatsContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchPublicSearchContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CurrentTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrlCopyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem MoveToHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveToFavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusOpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RepliedStatusOpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FavorareMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenURLMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem TabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IDRuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem ReadedStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnreadStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplyStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplyAllStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FavAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FavRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReTweetStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuPostMode;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUrlMultibyteSplit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemApiCommandEvasion;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUrlAutoShorten;
        private System.Windows.Forms.ToolStripMenuItem DebugModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DumpPostClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TraceOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TwurlnlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TabRenameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BitlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ApiInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IdeographicSpaceToSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FollowCommandMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveCommandMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FriendshipMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem OwnStatusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReTweetOriginalStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem FollowContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FriendshipContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JmpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuoteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshMoreStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoRemoveTabMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem MoveToRTHomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IdFilterAddMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator22;
        private System.Windows.Forms.ToolStripMenuItem PublicSearchQueryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UseHashtagMenuItem;
        private Tween.CustomControls.ToolStripLabelHistory StatusLabel;
        private System.Windows.Forms.ToolStripSplitButton HashStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem HashToggleMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem HashManageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MultiLineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator21;
        private System.Windows.Forms.ToolStripMenuItem SaveFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator23;
        private System.Windows.Forms.ToolStripMenuItem NotifyFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlaySoundFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LockListFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator24;
        private System.Windows.Forms.ToolStripMenuItem EndFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplyOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplyAllOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DmOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RtOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RtUnOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QtOpMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator25;
        private System.Windows.Forms.ToolStripMenuItem FavOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnFavOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateRuleOpMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator26;
        private System.Windows.Forms.ToolStripMenuItem ChangeReadOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JumpReadOpMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator27;
        private System.Windows.Forms.ToolStripMenuItem SelAllOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshPrevOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenHomeOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFavOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenStatusOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenRepSourceOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFavotterOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenUrlOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenRterHomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTabRuleOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateIdRuleOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReadOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnreadOpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameTbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnreadMngTbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotifyTbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditRuleTbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearTbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteTbMenuItem;
        private System.Windows.Forms.ToolStripComboBox SoundFileTbComboBox;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator28;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator29;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator30;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator31;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator32;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator33;
        private System.Windows.Forms.WebBrowser PostBrowser;
        private System.Windows.Forms.SplitContainer SplitContainer3;
        private Tween.CustomControls.PictureBoxEx PreviewPicture;
        private System.Windows.Forms.VScrollBar PreviewScrollBar;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.ToolStripMenuItem FollowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnFollowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowFriendShipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowUserStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowUserStatusContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowProfMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator34;
        private System.Windows.Forms.ToolStripMenuItem HashToggleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HashManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RtCountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchPostsDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchAtPostsDetailNameToolStripMenuItem;
        private System.Windows.Forms.Panel TimelinePanel;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button FilePickButton;
        private System.Windows.Forms.TextBox ImagefilePathText;
        private System.Windows.Forms.Label Label1;
        private Tween.CustomControls.PictureBoxEx ImageSelectedPicture;
        private System.Windows.Forms.Panel ImageSelectionPanel;
        private System.Windows.Forms.Panel ImagePathPanel;
        private System.Windows.Forms.ComboBox ImageServiceCombo;
        private System.Windows.Forms.ToolStripMenuItem ImageSelectMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator35;
        private System.Windows.Forms.ToolStripMenuItem FriendshipAllMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator36;
        private System.Windows.Forms.ToolStripMenuItem UserStatusToolStripMenuItem;
        private System.Windows.Forms.Button ImageCancelButton;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFocusLockMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListManageUserContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator37;
        private System.Windows.Forms.ToolStripMenuItem ShortcutKeyListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListManageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListManageUserContextToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ListManageUserContextToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ListManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CacheInfoMenuItem;
        private System.Windows.Forms.LinkLabel SourceLinkLabel;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem CopyUserIdStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FavoriteRetweetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FavoriteRetweetUnofficialMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator38;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator39;
        private System.Windows.Forms.ToolStripMenuItem FavoriteRetweetContextMenu;
        private System.Windows.Forms.ToolStripMenuItem FavoriteRetweetUnofficialContextMenu;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ShowRelatedStatusesMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ShowRelatedStatusesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUserStream;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator40;
        private System.Windows.Forms.ToolStripMenuItem TrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllrepliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TweenRestartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchPostsDetailNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchAtPostsDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator41;
        private System.Windows.Forms.ToolStripMenuItem OpenOwnHomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenOwnFavedMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator42;
        private System.Windows.Forms.ToolStripMenuItem EventViewerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TranslationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UxnuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowUserTimelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowUserTimelineContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserTimelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserFavorareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectionTranslationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator43;
        private System.Windows.Forms.ToolStripMenuItem StopRefreshAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenUserSpecifiedUrlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenUserSpecifiedUrlMenuItem2;
        private System.Windows.Forms.ImageList PostStateImageList;
        private System.Windows.Forms.SplitContainer SplitContainer4;
        private System.Windows.Forms.ContextMenuStrip ContextMenuSource;
        private System.Windows.Forms.ToolStripMenuItem SourceCopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SourceUrlCopyMenuItem;

    }


}
