using System;
using System.Windows.Forms;



namespace Tween.Widgets {


    /**
     * 
     */
    public partial class MessageForm {
        /**
         * 
         */
        public new DialogResult ShowDialog(string message) {
            Label1.Text = message;
            // ラベルウィジェットをセンタリングします。
            Label1.Left = (this.ClientSize.Width - Label1.Size.Width) / 2;

            Label1.Refresh();
            Label1.Visible = true;

            return base.ShowDialog();
        }
    }


}
