namespace puzzCode
{
    partial class UI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.fastColoredTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolbox = new System.Windows.Forms.ToolStrip();
            this.compile = new System.Windows.Forms.ToolStripButton();
            this.run = new System.Windows.Forms.ToolStripButton();
            this.config = new System.Windows.Forms.ToolStripButton();
            this.browse = new System.Windows.Forms.ToolStripButton();
            this.logPanelBtn = new System.Windows.Forms.ToolStripButton();
            this.Snippet = new System.Windows.Forms.ToolStripDropDownButton();
            this.runPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripButton();
            this.percntLB = new System.Windows.Forms.ToolStripLabel();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).BeginInit();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.fastColoredTextBox);
            this.splitContainer.Panel1.Controls.Add(this.toolbox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.logBox);
            this.splitContainer.Size = new System.Drawing.Size(791, 351);
            this.splitContainer.SplitterDistance = 169;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 5;
            // 
            // fastColoredTextBox
            // 
            this.fastColoredTextBox.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox.BackBrush = null;
            this.fastColoredTextBox.CharHeight = 14;
            this.fastColoredTextBox.CharWidth = 8;
            this.fastColoredTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox.IsReplaceMode = false;
            this.fastColoredTextBox.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox.Name = "fastColoredTextBox";
            this.fastColoredTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox.ServiceColors")));
            this.fastColoredTextBox.Size = new System.Drawing.Size(789, 128);
            this.fastColoredTextBox.TabIndex = 8;
            this.fastColoredTextBox.Zoom = 100;
            // 
            // toolbox
            // 
            this.toolbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolbox.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compile,
            this.run,
            this.config,
            this.browse,
            this.logPanelBtn,
            this.Snippet,
            this.about,
            this.percntLB});
            this.toolbox.Location = new System.Drawing.Point(0, 128);
            this.toolbox.Name = "toolbox";
            this.toolbox.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolbox.Size = new System.Drawing.Size(789, 39);
            this.toolbox.Stretch = true;
            this.toolbox.TabIndex = 7;
            this.toolbox.Text = "toolStrip";
            // 
            // compile
            // 
            this.compile.Image = ((System.Drawing.Image)(resources.GetObject("compile.Image")));
            this.compile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.compile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compile.Name = "compile";
            this.compile.Size = new System.Drawing.Size(92, 36);
            this.compile.Text = "&Compile";
            this.compile.ToolTipText = "Compile";
            this.compile.Click += new System.EventHandler(this.compile_Click);
            // 
            // run
            // 
            this.run.Image = ((System.Drawing.Image)(resources.GetObject("run.Image")));
            this.run.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(66, 36);
            this.run.Text = "&Run";
            this.run.ToolTipText = "Run";
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // config
            // 
            this.config.Image = ((System.Drawing.Image)(resources.GetObject("config.Image")));
            this.config.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.config.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(82, 36);
            this.config.Text = "&Config";
            this.config.ToolTipText = "Config";
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // browse
            // 
            this.browse.Image = ((System.Drawing.Image)(resources.GetObject("browse.Image")));
            this.browse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.browse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(84, 36);
            this.browse.Text = "&Browse";
            this.browse.ToolTipText = "Browse";
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // logPanelBtn
            // 
            this.logPanelBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logPanelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logPanelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logPanelBtn.Name = "logPanelBtn";
            this.logPanelBtn.Size = new System.Drawing.Size(23, 36);
            this.logPanelBtn.Text = "+";
            this.logPanelBtn.ToolTipText = "Log Panel";
            this.logPanelBtn.Click += new System.EventHandler(this.logPanelBtn_Click);
            // 
            // Snippet
            // 
            this.Snippet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runPEToolStripMenuItem});
            this.Snippet.Image = ((System.Drawing.Image)(resources.GetObject("Snippet.Image")));
            this.Snippet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Snippet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Snippet.Name = "Snippet";
            this.Snippet.Size = new System.Drawing.Size(89, 36);
            this.Snippet.Text = "&Snippet";
            // 
            // runPEToolStripMenuItem
            // 
            this.runPEToolStripMenuItem.Name = "runPEToolStripMenuItem";
            this.runPEToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.runPEToolStripMenuItem.Text = "RunPE";
            this.runPEToolStripMenuItem.Click += new System.EventHandler(this.runPEToolStripMenuItem_Click);
            // 
            // about
            // 
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(79, 36);
            this.about.Text = "&About";
            this.about.ToolTipText = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // percntLB
            // 
            this.percntLB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.percntLB.Name = "percntLB";
            this.percntLB.Size = new System.Drawing.Size(40, 36);
            this.percntLB.Text = "100%";
            // 
            // logBox
            // 
            this.logBox.AcceptsTab = true;
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.logBox.Location = new System.Drawing.Point(0, 0);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(789, 179);
            this.logBox.TabIndex = 9;
            this.logBox.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Executable File|*.exe";
            this.openFileDialog.Title = "Select Your Executable File To Inject";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 351);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.refreshUi);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).EndInit();
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox logBox;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox;
        private System.Windows.Forms.ToolStrip toolbox;
        private System.Windows.Forms.ToolStripButton compile;
        private System.Windows.Forms.ToolStripButton config;
        private System.Windows.Forms.ToolStripButton browse;
        private System.Windows.Forms.ToolStripButton about;
        private System.Windows.Forms.ToolStripButton run;
        private System.Windows.Forms.ToolStripButton logPanelBtn;
        private System.Windows.Forms.ToolStripDropDownButton Snippet;
        private System.Windows.Forms.ToolStripMenuItem runPEToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.ToolStripLabel percntLB;
    }
}

