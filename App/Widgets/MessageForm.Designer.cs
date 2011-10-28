namespace Tween.Widgets {


    /**
     * 
     */
    public partial class MessageForm : System.Windows.Forms.Form {


        // フォームがコンポーネントの一覧をクリーンアップするために Dispose 眼ドッドをオーバーライドします。
        protected override void Dispose(bool disposing) {
            try {
                if ( disposing && components != null ) {
                    components.Dispose();
                }
            } finally {
                base.Dispose( disposing );
            }
        }


        // Windows フォームデザイナーで必要です。
        private System.ComponentModel.IContainer components;


        //
        // メモ:
        //     以下のメソッドは Windows フォームデザイナーで必要です。
        //     Windows フォームデザイナーを使用して変更できます。
        //     コード エディターを使って変更しないでください。
        //
        private void InitializeComponent() {
            this.Label1 = new System.Window.Forms.Label();

            this.SuspendLayout();

            // 
            // Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point( 123, 125 );
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size( 38, 12 );
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Label1";
            // 
            // MessageForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6.0f, 12.0f );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size( 284, 262 );
            this.Controls.Add( Label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageForm";
            this.ResumeLayout( false );
            this.PerformLayout();
        }


        internal System.Windows.Forms.Label Label1;


    }


}
