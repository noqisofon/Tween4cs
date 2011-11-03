namespace Tween.Widgets {
    partial class SearchWordDialog : System.Windows.Forms.Form {
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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof(SearchWordDialog) );

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
            this.TableLayoutPanel1.BackgroundImage = null;
            resources.ApplyResources( this.TableLayoutPanel1, "TableLayoutPanel1" );
            this.TableLayoutPanel1.Font = null;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // OK_Button
            // 
            this.OK_Button.BackgroundImage = null;
            resources.ApplyResources( this.OK_Button, "OK_Button" );
            this.OK_Button.Font = null;
            this.OK_Button.Name = "OK_Button";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackgroundImage = null;
            resources.ApplyResources( this.Cancel_Button, "Cancel_Button" );
            this.Cancel_Button.Font = null;
            this.Cancel_Button.Name = "Cancel_Button";
            // 
            // SWordText
            // 
            this.SWordText.BackgroundImage = null;
            resources.ApplyResources( this.SWordText, "SWordText" );
            this.SWordText.Font = null;
            this.SWordText.Name = "SWordText";
            // 
            // Label1
            // 
            this.Label1.BackgroundImage = null;
            resources.ApplyResources( this.Label1, "Label1" );
            this.Label1.Font = null;
            this.Label1.Name = "Label1";
            // 
            // CheckSearchCaseSensitive
            // 
            this.CheckSearchCaseSensitive.BackgroundImage = null;
            resources.ApplyResources( this.CheckSearchCaseSensitive, "CheckSearchCaseSensitive" );
            this.CheckSearchCaseSensitive.Font = null;
            this.CheckSearchCaseSensitive.Name = "CheckSearchCaseSensitive";
            this.CheckSearchCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // CheckSearchRegex
            // 
            this.CheckSearchRegex.BackgroundImage = null;
            resources.ApplyResources( this.CheckSearchRegex, "CheckSearchRegex" );
            this.CheckSearchRegex.Font = null;
            this.CheckSearchRegex.Name = "CheckSearchRegex";
            this.CheckSearchRegex.UseVisualStyleBackColor = true;
            // 
            // SearchWordDialog
            // 
            resources.ApplyResources( this, "$this" );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchWordDialog";
            this.ShowInTaskbar = false;
            this.TopMost = true;

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
