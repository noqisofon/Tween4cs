using System;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Windows.Forms;


namespace Tween.CustomControls {


    public class AdsBrowser : WebBrowser {
        public AdsBrowser() : base() {
            this.abs_path_ = Path.Combine( Path.GetTempPath(), Path.GetRandomFileName() );
            //File.WroteAllText( this.abs_path_, Resources["Ads"] );

            InitializeComponent();
        }


        private void InitializeComponent() {
            base.Size = new Size( 728 + 5, 90 );
            base.ScrollBarsEnabled = false;
            base.AllowWebBrowserDrop = false;
            base.IsWebBrowserContextMenuEnabled = false;
            base.ScriptErrorsSuppressed = true;
            base.TabStop = false;
            base.WebBrowserShortcutsEnabled = false;
            base.Dock = DockStyle.Fill;

            base.Visible = false;
            base.Navigate( this.abs_path_ );
            base.Visible = true;

            this.refresh_timer_ = new System.Timers.Timer( 45 * 1000 );
            this.refresh_timer_.AutoReset = true;
            this.refresh_timer_.SynchronizingObject = this;
            this.refresh_timer_.Enabled = true;
        }


        private void AdsBrowser_Disposed(object sender, EventArgs ergs) {
            this.refresh_timer_.Dispose();
            File.Delete( this.abs_path_ );
        }


        private void refresh_timer__Elapsed(object sender, ElapsedEventArgs eergs) {
            base.Visible = false;
            base.Refresh();
            base.Visible = true;
        }
        
        private string abs_path_;
        private System.Timers.Timer refresh_timer_;
    }


}
// Local Variables:
//   coding: utf-8
//   mode: ecmascript
// End:
