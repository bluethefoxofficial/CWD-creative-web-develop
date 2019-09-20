namespace creative_web_Develop
{
    partial class plugins
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plugins));
            this.cxFlatStatusBar1 = new CxFlatUI.CxFlatStatusBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cxFlatStatusBar1
            // 
            this.cxFlatStatusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cxFlatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatStatusBar1.Name = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.Size = new System.Drawing.Size(800, 40);
            this.cxFlatStatusBar1.TabIndex = 0;
            this.cxFlatStatusBar1.Text = "Plugin interface";
            this.cxFlatStatusBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 356);
            this.listBox1.TabIndex = 1;
            // 
            // plugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cxFlatStatusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1042);
            this.Name = "plugins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "plugins";
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar cxFlatStatusBar1;
        private System.Windows.Forms.ListBox listBox1;
    }
}