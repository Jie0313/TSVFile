namespace TSVFile
{
    partial class frmTSVFile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvwWord = new System.Windows.Forms.ListView();
            this.colWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhonogram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoundPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExplain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSearch.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.pnlSearch.Controls.Add(this.lblSearchIcon);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 48);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.pnlSearch.Size = new System.Drawing.Size(1545, 43);
            this.pnlSearch.TabIndex = 1;
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(238)))));
            this.lblSearchIcon.Location = new System.Drawing.Point(10, 8);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(33, 23);
            this.lblSearchIcon.TabIndex = 0;
            this.lblSearchIcon.Text = "🔍";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(136)))));
            this.txtSearch.Location = new System.Drawing.Point(34, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(742, 28);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lvwWord
            // 
            this.lvwWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colWord,
            this.colPhonogram,
            this.colSoundPath,
            this.colExplain});
            this.lvwWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWord.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.5F);
            this.lvwWord.FullRowSelect = true;
            this.lvwWord.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwWord.HideSelection = false;
            this.lvwWord.Location = new System.Drawing.Point(0, 101);
            this.lvwWord.Name = "lvwWord";
            this.lvwWord.OwnerDraw = true;
            this.lvwWord.Size = new System.Drawing.Size(1545, 998);
            this.lvwWord.TabIndex = 2;
            this.lvwWord.UseCompatibleStateImageBehavior = false;
            this.lvwWord.View = System.Windows.Forms.View.Details;
            this.lvwWord.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvwWord_DrawColumnHeader);
            this.lvwWord.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvwWord_DrawItem);
            this.lvwWord.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvwWord_DrawSubItem);
            // 
            // colWord
            // 
            this.colWord.Text = "單字";
            this.colWord.Width = 160;
            // 
            // colPhonogram
            // 
            this.colPhonogram.Text = "音標";
            this.colPhonogram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPhonogram.Width = 150;
            // 
            // colSoundPath
            // 
            this.colSoundPath.Text = "音效路徑";
            this.colSoundPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoundPath.Width = 180;
            // 
            // colExplain
            // 
            this.colExplain.Text = "解釋";
            this.colExplain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colExplain.Width = 339;
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ssStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.ssStatus.Location = new System.Drawing.Point(0, 1106);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1545, 28);
            this.ssStatus.TabIndex = 3;
            // 
            // tsslMessage
            // 
            this.tsslMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(34)))), ((int)(((byte)(187)))));
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(0, 22);
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.msMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.5F);
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.msMenu.Size = new System.Drawing.Size(1545, 38);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "檔案(&F)";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(34)))), ((int)(((byte)(170)))));
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(73, 32);
            this.tsmiFile.Text = "檔案(&F)";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(179, 26);
            this.tsmiOpen.Text = "開啟檔案(&O)";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(179, 26);
            this.tsmiExit.Text = "離開(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(77, 32);
            this.tsmiHelp.Text = "幫助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(145, 26);
            this.tsmiAbout.Text = "關於(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // frmTSVFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 907);
            this.Controls.Add(this.lvwWord);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmTSVFile";
            this.Text = "TSV 資料檔讀取程式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTSVFile_FormClosing);
            this.Load += new System.EventHandler(this.frmTSVFile_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lvwWord;
        private System.Windows.Forms.ColumnHeader colWord;
        private System.Windows.Forms.ColumnHeader colPhonogram;
        private System.Windows.Forms.ColumnHeader colSoundPath;
        private System.Windows.Forms.ColumnHeader colExplain;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
    }

    internal class ColorfulMenuRenderer : System.Windows.Forms.ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(
            System.Windows.Forms.ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                using (var b = new System.Drawing.SolidBrush(
                    System.Drawing.Color.FromArgb(237, 216, 255)))
                    e.Graphics.FillRectangle(b, e.Item.ContentRectangle);
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }

        protected override void OnRenderToolStripBackground(
            System.Windows.Forms.ToolStripRenderEventArgs e)
        {
            using (var b = new System.Drawing.SolidBrush(
                System.Drawing.Color.FromArgb(248, 244, 255)))
                e.Graphics.FillRectangle(b, e.AffectedBounds);
        }
    }
}