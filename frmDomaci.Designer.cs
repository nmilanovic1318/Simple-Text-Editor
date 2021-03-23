namespace Nikola_Milanovic_S13_18_3S2
{
    partial class frmWindow
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lbPronadji = new System.Windows.Forms.Label();
            this.lbZameni = new System.Windows.Forms.Label();
            this.txbFind = new System.Windows.Forms.TextBox();
            this.txbReplace = new System.Windows.Forms.TextBox();
            this.btnFindReplace = new System.Windows.Forms.Button();
            this.txbMultiLine = new System.Windows.Forms.TextBox();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 22);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(110, 57);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "&Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lbPronadji
            // 
            this.lbPronadji.AutoSize = true;
            this.lbPronadji.Location = new System.Drawing.Point(183, 25);
            this.lbPronadji.Name = "lbPronadji";
            this.lbPronadji.Size = new System.Drawing.Size(30, 13);
            this.lbPronadji.TabIndex = 1;
            this.lbPronadji.Text = "Find:";
            // 
            // lbZameni
            // 
            this.lbZameni.AutoSize = true;
            this.lbZameni.Location = new System.Drawing.Point(182, 62);
            this.lbZameni.Name = "lbZameni";
            this.lbZameni.Size = new System.Drawing.Size(47, 13);
            this.lbZameni.TabIndex = 2;
            this.lbZameni.Text = "Replace";
            // 
            // txbFind
            // 
            this.txbFind.Location = new System.Drawing.Point(233, 22);
            this.txbFind.Name = "txbFind";
            this.txbFind.Size = new System.Drawing.Size(100, 20);
            this.txbFind.TabIndex = 3;
            // 
            // txbReplace
            // 
            this.txbReplace.Location = new System.Drawing.Point(233, 59);
            this.txbReplace.Name = "txbReplace";
            this.txbReplace.Size = new System.Drawing.Size(100, 20);
            this.txbReplace.TabIndex = 4;
            // 
            // btnFindReplace
            // 
            this.btnFindReplace.Location = new System.Drawing.Point(353, 22);
            this.btnFindReplace.Name = "btnFindReplace";
            this.btnFindReplace.Size = new System.Drawing.Size(130, 57);
            this.btnFindReplace.TabIndex = 5;
            this.btnFindReplace.Text = "Find and Replace";
            this.btnFindReplace.UseVisualStyleBackColor = true;
            this.btnFindReplace.Click += new System.EventHandler(this.btnFindReplace_Click);
            // 
            // txbMultiLine
            // 
            this.txbMultiLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMultiLine.Location = new System.Drawing.Point(12, 106);
            this.txbMultiLine.Multiline = true;
            this.txbMultiLine.Name = "txbMultiLine";
            this.txbMultiLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMultiLine.Size = new System.Drawing.Size(1060, 534);
            this.txbMultiLine.TabIndex = 6;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(529, 22);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(130, 57);
            this.btnSaveAs.TabIndex = 7;
            this.btnSaveAs.Text = "&Save as";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(942, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 57);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.txbMultiLine);
            this.Controls.Add(this.btnFindReplace);
            this.Controls.Add(this.txbReplace);
            this.Controls.Add(this.txbFind);
            this.Controls.Add(this.lbZameni);
            this.Controls.Add(this.lbPronadji);
            this.Controls.Add(this.btnOpenFile);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1100, 900);
            this.MinimumSize = new System.Drawing.Size(900, 200);
            this.Name = "frmWindow";
            this.Load += new System.EventHandler(this.frmDomaci_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CloseAppOnEsc_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lbPronadji;
        private System.Windows.Forms.Label lbZameni;
        private System.Windows.Forms.TextBox txbFind;
        private System.Windows.Forms.TextBox txbReplace;
        private System.Windows.Forms.Button btnFindReplace;
        private System.Windows.Forms.TextBox txbMultiLine;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog ofDialog;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

