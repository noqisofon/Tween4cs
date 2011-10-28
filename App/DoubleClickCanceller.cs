using System;
using System.Windows.Forms;


namespace Tween.Widgets {


    /**
     * 
     */
    public class DoubleClickCopyCanveller : NativeWindow, IDisposable {
        /**
         * 
         */
        public DoubleClickCopyCanveller(Control control) {
            this.AssignHandle( control.Handle );
        }


        /**
         * 
         */
        protected void WndProc(Message message) {
            if ( message.Msg == WM_LBUTTONDBLCLICK )
                this.double_click_ = true;

            if ( this.double_click_ ) {
                if ( message.Msg == WM_GETTEXTLENGTH ) {
                    this.double_click_ = false;
                    message.Result = IntPtr.Zero;

                    return ;
                }   
            }
            base.WndProc( message );
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
