namespace IEClassic
{
    partial class IE6
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IE6));
            statusStrip = new StatusStrip();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            favouritesToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStripControlBar = new ToolStrip();
            TSBtnBack = new ToolStripSplitButton();
            TSBtnForward = new ToolStripSplitButton();
            TSBStopLoading = new ToolStripButton();
            TSBRefresh = new ToolStripButton();
            TSBHome = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TSBSearch = new ToolStripButton();
            TSBFavourites = new ToolStripButton();
            TSBHistory = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TSBEmail = new ToolStripSplitButton();
            TSBPrint = new ToolStripButton();
            TSBEdit = new ToolStripButton();
            TSBMessage = new ToolStripButton();
            toolStripAddressBar = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripButton11 = new ToolStripButton();
            menuStrip.SuspendLayout();
            toolStripControlBar.SuspendLayout();
            toolStripAddressBar.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Location = new Point(0, 581);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1027, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            menuStrip.BackgroundImageLayout = ImageLayout.Zoom;
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, favouritesToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.System;
            menuStrip.Size = new Size(1027, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // favouritesToolStripMenuItem
            // 
            favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            favouritesToolStripMenuItem.Size = new Size(73, 20);
            favouritesToolStripMenuItem.Text = "Favourites";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripControlBar
            // 
            toolStripControlBar.ImageScalingSize = new Size(32, 32);
            toolStripControlBar.Items.AddRange(new ToolStripItem[] { TSBtnBack, TSBtnForward, TSBStopLoading, TSBRefresh, TSBHome, toolStripSeparator1, TSBSearch, TSBFavourites, TSBHistory, toolStripSeparator2, TSBEmail, TSBPrint, TSBEdit, TSBMessage });
            toolStripControlBar.Location = new Point(0, 24);
            toolStripControlBar.Name = "toolStripControlBar";
            toolStripControlBar.RenderMode = ToolStripRenderMode.System;
            toolStripControlBar.Size = new Size(1027, 39);
            toolStripControlBar.TabIndex = 2;
            toolStripControlBar.Text = "toolStrip1";
            // 
            // TSBtnBack
            // 
            TSBtnBack.Image = Properties.Resources.back;
            TSBtnBack.ImageTransparentColor = Color.Magenta;
            TSBtnBack.Name = "TSBtnBack";
            TSBtnBack.Size = new Size(80, 36);
            TSBtnBack.Text = "Back";
            // 
            // TSBtnForward
            // 
            TSBtnForward.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBtnForward.Image = Properties.Resources.forward;
            TSBtnForward.ImageTransparentColor = Color.Magenta;
            TSBtnForward.Name = "TSBtnForward";
            TSBtnForward.Size = new Size(48, 36);
            TSBtnForward.Text = "Forward";
            // 
            // TSBStopLoading
            // 
            TSBStopLoading.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBStopLoading.Image = (Image)resources.GetObject("TSBStopLoading.Image");
            TSBStopLoading.ImageTransparentColor = Color.Magenta;
            TSBStopLoading.Name = "TSBStopLoading";
            TSBStopLoading.Size = new Size(36, 36);
            TSBStopLoading.Text = "toolStripButton1";
            // 
            // TSBRefresh
            // 
            TSBRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBRefresh.Image = (Image)resources.GetObject("TSBRefresh.Image");
            TSBRefresh.ImageTransparentColor = Color.Magenta;
            TSBRefresh.Name = "TSBRefresh";
            TSBRefresh.Size = new Size(36, 36);
            TSBRefresh.Text = "toolStripButton2";
            // 
            // TSBHome
            // 
            TSBHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBHome.Image = (Image)resources.GetObject("TSBHome.Image");
            TSBHome.ImageTransparentColor = Color.Magenta;
            TSBHome.Name = "TSBHome";
            TSBHome.Size = new Size(36, 36);
            TSBHome.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // TSBSearch
            // 
            TSBSearch.Image = (Image)resources.GetObject("TSBSearch.Image");
            TSBSearch.ImageTransparentColor = Color.Magenta;
            TSBSearch.Name = "TSBSearch";
            TSBSearch.Size = new Size(78, 36);
            TSBSearch.Text = "Search";
            // 
            // TSBFavourites
            // 
            TSBFavourites.Image = (Image)resources.GetObject("TSBFavourites.Image");
            TSBFavourites.ImageTransparentColor = Color.Magenta;
            TSBFavourites.Name = "TSBFavourites";
            TSBFavourites.Size = new Size(97, 36);
            TSBFavourites.Text = "Favourites";
            // 
            // TSBHistory
            // 
            TSBHistory.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBHistory.Image = (Image)resources.GetObject("TSBHistory.Image");
            TSBHistory.ImageTransparentColor = Color.Magenta;
            TSBHistory.Name = "TSBHistory";
            TSBHistory.Size = new Size(36, 36);
            TSBHistory.Text = "toolStripButton7";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // TSBEmail
            // 
            TSBEmail.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBEmail.Image = (Image)resources.GetObject("TSBEmail.Image");
            TSBEmail.ImageTransparentColor = Color.Magenta;
            TSBEmail.Name = "TSBEmail";
            TSBEmail.Size = new Size(48, 36);
            TSBEmail.Text = "toolStripSplitButton3";
            // 
            // TSBPrint
            // 
            TSBPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBPrint.Image = (Image)resources.GetObject("TSBPrint.Image");
            TSBPrint.ImageTransparentColor = Color.Magenta;
            TSBPrint.Name = "TSBPrint";
            TSBPrint.Size = new Size(36, 36);
            TSBPrint.Text = "toolStripButton8";
            // 
            // TSBEdit
            // 
            TSBEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBEdit.Image = (Image)resources.GetObject("TSBEdit.Image");
            TSBEdit.ImageTransparentColor = Color.Magenta;
            TSBEdit.Name = "TSBEdit";
            TSBEdit.Size = new Size(36, 36);
            TSBEdit.Text = "toolStripButton9";
            // 
            // TSBMessage
            // 
            TSBMessage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBMessage.Image = (Image)resources.GetObject("TSBMessage.Image");
            TSBMessage.ImageTransparentColor = Color.Magenta;
            TSBMessage.Name = "TSBMessage";
            TSBMessage.Size = new Size(36, 36);
            TSBMessage.Text = "toolStripButton10";
            // 
            // toolStripAddressBar
            // 
            toolStripAddressBar.ImeMode = ImeMode.NoControl;
            toolStripAddressBar.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripComboBox1, toolStripButton11 });
            toolStripAddressBar.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStripAddressBar.Location = new Point(0, 63);
            toolStripAddressBar.Name = "toolStripAddressBar";
            toolStripAddressBar.RenderMode = ToolStripRenderMode.System;
            toolStripAddressBar.Size = new Size(1027, 25);
            toolStripAddressBar.TabIndex = 3;
            toolStripAddressBar.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(49, 22);
            toolStripLabel1.Text = "Address";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(600, 25);
            // 
            // toolStripButton11
            // 
            toolStripButton11.Image = (Image)resources.GetObject("toolStripButton11.Image");
            toolStripButton11.ImageTransparentColor = Color.Magenta;
            toolStripButton11.Name = "toolStripButton11";
            toolStripButton11.Size = new Size(42, 22);
            toolStripButton11.Text = "Go";
            // 
            // IE6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 603);
            Controls.Add(toolStripAddressBar);
            Controls.Add(statusStrip);
            Controls.Add(toolStripControlBar);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "IE6";
            Text = "IEClassic";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStripControlBar.ResumeLayout(false);
            toolStripControlBar.PerformLayout();
            toolStripAddressBar.ResumeLayout(false);
            toolStripAddressBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem favouritesToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStrip toolStripControlBar;
        private ToolStripSplitButton TSBtnBack;
        private ToolStripSplitButton TSBtnForward;
        private ToolStripButton TSBStopLoading;
        private ToolStripButton TSBRefresh;
        private ToolStripButton TSBHome;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TSBSearch;
        private ToolStripButton TSBFavourites;
        private ToolStripButton TSBHistory;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSplitButton TSBEmail;
        private ToolStripButton TSBPrint;
        private ToolStripButton TSBEdit;
        private ToolStripButton TSBMessage;
        private ToolStrip toolStripAddressBar;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripButton toolStripButton11;
    }
}
