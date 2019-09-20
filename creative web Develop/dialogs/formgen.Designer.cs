using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
namespace creative_web_Develop
{
    partial class formgen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formgen));
            this.cxFlatButton1 = new CxFlatUI.Controls.CxFlatButton();
            this.custom = new FastColoredTextBoxNS.FastColoredTextBox();
            this.action = new System.Windows.Forms.TextBox();
            this.post = new System.Windows.Forms.CheckBox();
            this.uploadfile = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uploadfilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttontext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.none = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cxFlatButton2 = new CxFlatUI.Controls.CxFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.custom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cxFlatButton1
            // 
            this.cxFlatButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxFlatButton1.Location = new System.Drawing.Point(586, 683);
            this.cxFlatButton1.Name = "cxFlatButton1";
            this.cxFlatButton1.Size = new System.Drawing.Size(152, 34);
            this.cxFlatButton1.TabIndex = 0;
            this.cxFlatButton1.Text = "add to code";
            this.cxFlatButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatButton1.Click += new System.EventHandler(this.CxFlatButton1_Click);
            // 
            // custom
            // 
            this.custom.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.custom.AutoIndentCharsPatterns = "";
            this.custom.AutoScrollMinSize = new System.Drawing.Size(29, 16);
            this.custom.BackBrush = null;
            this.custom.CharHeight = 16;
            this.custom.CharWidth = 9;
            this.custom.CommentPrefix = null;
            this.custom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custom.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.custom.Font = new System.Drawing.Font("Courier New", 9F);
            this.custom.IsReplaceMode = false;
            this.custom.Language = FastColoredTextBoxNS.Language.HTML;
            this.custom.LeftBracket = '<';
            this.custom.LeftBracket2 = '(';
            this.custom.Location = new System.Drawing.Point(113, 556);
            this.custom.Name = "custom";
            this.custom.Paddings = new System.Windows.Forms.Padding(0);
            this.custom.RightBracket = '>';
            this.custom.RightBracket2 = ')';
            this.custom.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.custom.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("custom.ServiceColors")));
            this.custom.Size = new System.Drawing.Size(495, 101);
            this.custom.TabIndex = 1;
            this.custom.Zoom = 100;
            // 
            // action
            // 
            this.action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action.Location = new System.Drawing.Point(293, 91);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(221, 24);
            this.action.TabIndex = 2;
            this.action.TabStop = false;
            // 
            // post
            // 
            this.post.AutoSize = true;
            this.post.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post.Location = new System.Drawing.Point(273, 149);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(236, 22);
            this.post.TabIndex = 4;
            this.post.Text = "is the method for this form post";
            this.post.UseVisualStyleBackColor = true;
            this.post.CheckedChanged += new System.EventHandler(this.Post_CheckedChanged);
            // 
            // uploadfile
            // 
            this.uploadfile.AutoSize = true;
            this.uploadfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadfile.Location = new System.Drawing.Point(286, 189);
            this.uploadfile.Name = "uploadfile";
            this.uploadfile.Size = new System.Drawing.Size(204, 22);
            this.uploadfile.TabIndex = 5;
            this.uploadfile.Text = "is this form uploading a file";
            this.uploadfile.UseVisualStyleBackColor = true;
            this.uploadfile.CheckedChanged += new System.EventHandler(this.Uploadfile_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "name for file input";
            // 
            // uploadfilename
            // 
            this.uploadfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadfilename.Location = new System.Drawing.Point(260, 255);
            this.uploadfilename.Name = "uploadfilename";
            this.uploadfilename.Size = new System.Drawing.Size(221, 24);
            this.uploadfilename.TabIndex = 6;
            this.uploadfilename.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "custom code";
            // 
            // buttontext
            // 
            this.buttontext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontext.Location = new System.Drawing.Point(228, 462);
            this.buttontext.Name = "buttontext";
            this.buttontext.Size = new System.Drawing.Size(296, 24);
            this.buttontext.TabIndex = 13;
            this.buttontext.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "name for submit / button";
            // 
            // none
            // 
            this.none.AutoSize = true;
            this.none.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.none.Location = new System.Drawing.Point(188, 21);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(65, 22);
            this.none.TabIndex = 2;
            this.none.Text = "None";
            this.none.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.Checked = true;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(15, 21);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(108, 22);
            this.submit.TabIndex = 1;
            this.submit.TabStop = true;
            this.submit.Text = "submit input";
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submit.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.AutoSize = true;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(93, 65);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(94, 22);
            this.button.TabIndex = 0;
            this.button.Text = "button tag";
            this.button.UseVisualStyleBackColor = true;
            this.button.CheckedChanged += new System.EventHandler(this.Button_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "action (leave blank if it is not needed)";
            // 
            // cxFlatButton2
            // 
            this.cxFlatButton2.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxFlatButton2.Location = new System.Drawing.Point(428, 683);
            this.cxFlatButton2.Name = "cxFlatButton2";
            this.cxFlatButton2.Size = new System.Drawing.Size(152, 34);
            this.cxFlatButton2.TabIndex = 16;
            this.cxFlatButton2.Text = "cancel";
            this.cxFlatButton2.TextColor = System.Drawing.Color.White;
            this.cxFlatButton2.Click += new System.EventHandler(this.CxFlatButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button);
            this.groupBox1.Controls.Add(this.none);
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Location = new System.Drawing.Point(228, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 103);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "submit button";
            // 
            // formgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cxFlatButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttontext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uploadfilename);
            this.Controls.Add(this.uploadfile);
            this.Controls.Add(this.post);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.action);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.cxFlatButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formgen";
            this.Text = "generate a form";
            this.Load += new System.EventHandler(this.Formgen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CxFlatUI.Controls.CxFlatButton cxFlatButton1;
        private FastColoredTextBoxNS.FastColoredTextBox custom;
        private TextBox action;
        private CheckBox post;
        private CheckBox uploadfile;
        private System.Windows.Forms.Label label2;
        private TextBox uploadfilename;
        private System.Windows.Forms.Label label3;
        private TextBox buttontext;
        private System.Windows.Forms.Label label4;
        private RadioButton submit;
        private RadioButton button;
        private RadioButton none;
        private System.Windows.Forms.Label label1;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton2;
        private GroupBox groupBox1;
    }
}