namespace DevExpressItemsTest
{
    partial class XtraUserControlTest
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 73);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // richEditControl1
            // 
            this.richEditControl1.Location = new System.Drawing.Point(48, 135);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(400, 200);
            this.richEditControl1.TabIndex = 1;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // XtraUserControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.progressBar1);
            this.Name = "XtraUserControlTest";
            this.Size = new System.Drawing.Size(557, 481);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
    }
}
