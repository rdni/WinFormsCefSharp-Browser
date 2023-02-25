﻿namespace ChromiumBrowser
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.Back = new System.Windows.Forms.ToolStripButton();
            this.Forward = new System.Windows.Forms.ToolStripButton();
            this.reloadButton = new System.Windows.Forms.ToolStripButton();
            this.Address = new System.Windows.Forms.ToolStripTextBox();
            this.AddBrowserTab = new System.Windows.Forms.ToolStripButton();
            this.removeBrowserTab = new System.Windows.Forms.ToolStripButton();
            this.settingsBtn = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BrowserTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.advancedSettings = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.blueUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenUpDown = new System.Windows.Forms.NumericUpDown();
            this.redUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ToolStrip.SuspendLayout();
            this.BrowserTabs.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.AutoSize = false;
            this.ToolStrip.BackColor = System.Drawing.Color.White;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Forward,
            this.reloadButton,
            this.Address,
            this.AddBrowserTab,
            this.removeBrowserTab,
            this.settingsBtn});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStrip.Size = new System.Drawing.Size(533, 42);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // Back
            // 
            this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Back.Image = global::ChromiumBrowser.Properties.Resources.backButton;
            this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(28, 39);
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Forward
            // 
            this.Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Forward.Image = global::ChromiumBrowser.Properties.Resources.forwardButton;
            this.Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Forward.Margin = new System.Windows.Forms.Padding(10, 2, 0, 3);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(28, 37);
            this.Forward.Text = "Forward";
            this.Forward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reloadButton.Image = global::ChromiumBrowser.Properties.Resources.refresh;
            this.reloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(28, 39);
            this.reloadButton.Text = "Refresh";
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = false;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Address.Margin = new System.Windows.Forms.Padding(0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(268, 39);
            this.Address.Text = "Search";
            this.Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBarKeyDown);
            this.Address.Click += new System.EventHandler(this.Address_Click);
            // 
            // AddBrowserTab
            // 
            this.AddBrowserTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddBrowserTab.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.AddBrowserTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBrowserTab.Image = ((System.Drawing.Image)(resources.GetObject("AddBrowserTab.Image")));
            this.AddBrowserTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBrowserTab.Name = "AddBrowserTab";
            this.AddBrowserTab.Size = new System.Drawing.Size(34, 39);
            this.AddBrowserTab.Text = "+";
            this.AddBrowserTab.Click += new System.EventHandler(this.AddBrowserTab_Click);
            // 
            // removeBrowserTab
            // 
            this.removeBrowserTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeBrowserTab.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.removeBrowserTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeBrowserTab.Image = ((System.Drawing.Image)(resources.GetObject("removeBrowserTab.Image")));
            this.removeBrowserTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBrowserTab.Name = "removeBrowserTab";
            this.removeBrowserTab.Size = new System.Drawing.Size(27, 39);
            this.removeBrowserTab.Text = "-";
            this.removeBrowserTab.Click += new System.EventHandler(this.removeBrowserTab_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsBtn.Image = global::ChromiumBrowser.Properties.Resources.settings;
            this.settingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(28, 39);
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BrowserTabs
            // 
            this.BrowserTabs.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BrowserTabs.Controls.Add(this.tabPage1);
            this.BrowserTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.BrowserTabs.Location = new System.Drawing.Point(0, 42);
            this.BrowserTabs.Margin = new System.Windows.Forms.Padding(2);
            this.BrowserTabs.Name = "BrowserTabs";
            this.BrowserTabs.SelectedIndex = 0;
            this.BrowserTabs.Size = new System.Drawing.Size(533, 445);
            this.BrowserTabs.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(525, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.advancedSettings);
            this.panel.Controls.Add(this.historyBtn);
            this.panel.Controls.Add(this.blueUpDown);
            this.panel.Controls.Add(this.greenUpDown);
            this.panel.Controls.Add(this.redUpDown);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.colorBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(266, 42);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.MaximumSize = new System.Drawing.Size(267, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(267, 445);
            this.panel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(7, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Incognito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // advancedSettings
            // 
            this.advancedSettings.Location = new System.Drawing.Point(7, 286);
            this.advancedSettings.Margin = new System.Windows.Forms.Padding(2);
            this.advancedSettings.Name = "advancedSettings";
            this.advancedSettings.Size = new System.Drawing.Size(253, 35);
            this.advancedSettings.TabIndex = 6;
            this.advancedSettings.Text = "Advanced settings";
            this.advancedSettings.UseVisualStyleBackColor = true;
            this.advancedSettings.Click += new System.EventHandler(this.advancedSettings_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Location = new System.Drawing.Point(7, 209);
            this.historyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(252, 28);
            this.historyBtn.TabIndex = 5;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // blueUpDown
            // 
            this.blueUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.blueUpDown.Location = new System.Drawing.Point(180, 165);
            this.blueUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.blueUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueUpDown.Name = "blueUpDown";
            this.blueUpDown.Size = new System.Drawing.Size(80, 29);
            this.blueUpDown.TabIndex = 4;
            this.blueUpDown.ValueChanged += new System.EventHandler(this.blueUpDown_ValueChanged);
            // 
            // greenUpDown
            // 
            this.greenUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.greenUpDown.Location = new System.Drawing.Point(93, 165);
            this.greenUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.greenUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenUpDown.Name = "greenUpDown";
            this.greenUpDown.Size = new System.Drawing.Size(80, 29);
            this.greenUpDown.TabIndex = 3;
            this.greenUpDown.ValueChanged += new System.EventHandler(this.greenUpDown_ValueChanged);
            // 
            // redUpDown
            // 
            this.redUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.redUpDown.Location = new System.Drawing.Point(7, 165);
            this.redUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.redUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redUpDown.Name = "redUpDown";
            this.redUpDown.Size = new System.Drawing.Size(80, 29);
            this.redUpDown.TabIndex = 2;
            this.redUpDown.ValueChanged += new System.EventHandler(this.redUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Background color";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.White;
            this.colorBox.Location = new System.Drawing.Point(7, 43);
            this.colorBox.Margin = new System.Windows.Forms.Padding(2);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(253, 107);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 487);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.BrowserTabs);
            this.Controls.Add(this.ToolStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Browser";
            this.Text = "Browser";
            this.Resize += new System.EventHandler(this.BrowserResize);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.BrowserTabs.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripTextBox Address;
        private System.Windows.Forms.ToolStripButton Back;
        private System.Windows.Forms.ToolStripButton Forward;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripButton AddBrowserTab;
        private System.Windows.Forms.TabControl BrowserTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripButton removeBrowserTab;
        private System.Windows.Forms.ToolStripButton reloadButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripButton settingsBtn;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown blueUpDown;
        private System.Windows.Forms.NumericUpDown greenUpDown;
        private System.Windows.Forms.NumericUpDown redUpDown;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button advancedSettings;
        private System.Windows.Forms.Button button1;
    }
}

