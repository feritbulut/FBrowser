namespace FBrowser
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAddressBar = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webView2Control = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.btnAddTab = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bookmark = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddressBar
            // 
            this.txtAddressBar.AcceptsReturn = true;
            this.txtAddressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAddressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddressBar.Location = new System.Drawing.Point(208, 33);
            this.txtAddressBar.Name = "txtAddressBar";
            this.txtAddressBar.Size = new System.Drawing.Size(795, 33);
            this.txtAddressBar.TabIndex = 0;
            this.txtAddressBar.Text = "https://www.google.com";
            this.txtAddressBar.TextChanged += new System.EventHandler(this.txtAddressBar_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnGo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGo.BackgroundImage")));
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGo.Location = new System.Drawing.Point(1016, 29);
            this.btnGo.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(46, 39);
            this.btnGo.TabIndex = 2;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(85, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 35);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Gray;
            this.btnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForward.BackgroundImage")));
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnForward.Location = new System.Drawing.Point(126, 33);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(35, 35);
            this.btnForward.TabIndex = 5;
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(167, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 35);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1890, 924);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.webView2Control);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1882, 887);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // webView2Control
            // 
            this.webView2Control.AllowExternalDrop = true;
            this.webView2Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.webView2Control.CreationProperties = null;
            this.webView2Control.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.webView2Control.Location = new System.Drawing.Point(0, 0);
            this.webView2Control.Name = "webView2Control";
            this.webView2Control.Size = new System.Drawing.Size(1882, 887);
            this.webView2Control.TabIndex = 7;
            this.webView2Control.ZoomFactor = 1D;
            this.webView2Control.Click += new System.EventHandler(this.webView2_Click);
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseTab.BackgroundImage")));
            this.btnCloseTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnCloseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCloseTab.Location = new System.Drawing.Point(1818, 33);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Size = new System.Drawing.Size(39, 36);
            this.btnCloseTab.TabIndex = 9;
            this.btnCloseTab.UseVisualStyleBackColor = false;
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // btnAddTab
            // 
            this.btnAddTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTab.BackgroundImage")));
            this.btnAddTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnAddTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTab.Location = new System.Drawing.Point(1863, 33);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(39, 35);
            this.btnAddTab.TabIndex = 10;
            this.btnAddTab.UseVisualStyleBackColor = true;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Bookmark
            // 
            this.Bookmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Bookmark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bookmark.BackgroundImage")));
            this.Bookmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bookmark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Bookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bookmark.Location = new System.Drawing.Point(1773, 33);
            this.Bookmark.Name = "Bookmark";
            this.Bookmark.Size = new System.Drawing.Size(39, 35);
            this.Bookmark.TabIndex = 8;
            this.Bookmark.UseVisualStyleBackColor = false;
            this.Bookmark.Click += new System.EventHandler(this.Bookmark_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu.BackgroundImage")));
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Location = new System.Drawing.Point(1068, 27);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(34, 49);
            this.Menu.TabIndex = 11;
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "History";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.AppWorkspace;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "Bookmarks";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem1.Image")));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1914, 1010);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Bookmark);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddTab);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtAddressBar);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnRefresh);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "F Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView2Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddressBar;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCloseTab;
        private System.Windows.Forms.Button btnAddTab;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button Bookmark;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

