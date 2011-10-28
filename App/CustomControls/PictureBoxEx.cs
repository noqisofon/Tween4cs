using System;
using System.Windows.Forms;


namespace Tween.CustomControls {


    /// <summary>
    /// 
    /// </summary>
    public class PictureBoxEx : PictureBox {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pergs">
        /// A <see cref="System.Windows.Forms.PaintEventArgs"/>
        /// </param>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pergs) {
            try {
                base.OnPaint( pergs );
            } catch (OutOfMemoryException oome) {
            }
        }
    }


}
