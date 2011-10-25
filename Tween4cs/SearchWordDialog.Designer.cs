namespace Tween {
    partial class SearchWordDialog.list : System.Windows.Forms.Form {
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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof(SearchWordDialog.list) );

            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SWordText = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CheckSearchCaseSensitive = new System.Windows.Forms.CheckBox();
            this.CheckSearchRegex = new System.Windows.Forms.CheckBox();

            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // OK_Button
            // 
            this.OK_Button.Name = "OK_Button";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Name = "Cancel_Button";
            // 
            // SWordText
            // 
            this.SWordText.Name = "SWordText";
            // 
            // Label1
            // 
            this.Label1.Name = "Label1";
            // 
            // CheckSearchCaseSensitive
            // 
            this.CheckSearchCaseSensitive.Name = "CheckSearchCaseSensitive";
            // 
            // CheckSearchRegex
            // 
            this.CheckSearchRegex.Name = "CheckSearchRegex";

            this.TableLayoutPanel1.ResumeLayout( false );
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout( false );
        }

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox SWordText;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.CheckBox CheckSearchCaseSensitive;
        private System.Windows.Forms.CheckBox CheckSearchRegex;

    }


}
