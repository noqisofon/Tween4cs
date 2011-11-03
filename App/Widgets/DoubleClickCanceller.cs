using System;
using System.Windows.Forms;


namespace Tween.Widgets {


    /**
     * 
     */
    internal class DoubleClickCopyCanveller : NativeWindow, IDisposable {
        /**
         * 
         */
        public DoubleClickCopyCanveller(Control control) {
            this.AssignHandle( control.Handle );
        }


        /**
         * 
         */
        protected override void WndProc(ref Message message) {
            if ( message.Msg == WM_LBUTTONDBLCLICK )
                this.double_click_ = true;

            if ( this.double_click_ ) {
                if ( message.Msg == WM_GETTEXTLENGTH ) {
                    this.double_click_ = false;
                    message.Result = IntPtr.Zero;

                    return ;
                }   
            }
            base.WndProc( ref message );
        }


        void IDisposable.Dispose() {
            this.ReleaseHandle();
            GC.SuppressFinalize();
        }


        private bool double_click_;


        private const int WM_GETTEXTLENGTH = 0xe;
        private const int WM_GETTEXT = 0xd;
        private const int WM_LBUTTONDBLCLICK = 0x203;
    }


}
// Local Variables:
//   coding: utf-8
//   mode: vala
// End:
