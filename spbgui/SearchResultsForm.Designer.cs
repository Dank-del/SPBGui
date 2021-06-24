
namespace spbgui
{
    partial class SearchResultsForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.intellivoidAccountsPanel = new System.Windows.Forms.Panel();
            this.intellivoidAccountsValueLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intellivoidAccountsLabel = new System.Windows.Forms.Label();
            this.whitelistedPanel = new System.Windows.Forms.Panel();
            this.whitelistedValueLabel = new System.Windows.Forms.Label();
            this.whitelistedLabel = new System.Windows.Forms.Label();
            this.operatorPanel = new System.Windows.Forms.Panel();
            this.operatorValueLabel = new System.Windows.Forms.Label();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.officialPanel = new System.Windows.Forms.Panel();
            this.officialValueLabel = new System.Windows.Forms.Label();
            this.officialLabel = new System.Windows.Forms.Label();
            this.blacklistedPanel = new System.Windows.Forms.Panel();
            this.blacklistedValueLabel = new System.Windows.Forms.Label();
            this.blacklistedLabel = new System.Windows.Forms.Label();
            this.entityTypePanel = new System.Windows.Forms.Panel();
            this.entityTypeValueLabel = new System.Windows.Forms.Label();
            this.entityTypeLabel = new System.Windows.Forms.Label();
            this.ptidPanel = new System.Windows.Forms.Panel();
            this.ptidValueLabel = new System.Windows.Forms.Label();
            this.ptidLabel = new System.Windows.Forms.Label();
            this.blacklistTabPage = new System.Windows.Forms.TabPage();
            this.resolveIdButton = new System.Windows.Forms.Button();
            this.originalPtidBlacklistPanel = new System.Windows.Forms.Panel();
            this.originalPtidBlacklistValueLabel = new System.Windows.Forms.Label();
            this.originalPtidBlacklistLabel = new System.Windows.Forms.Label();
            this.blacklistPanel = new System.Windows.Forms.Panel();
            this.blacklistFlagValueLabel = new System.Windows.Forms.Label();
            this.blacklistFlagLabel = new System.Windows.Forms.Label();
            this.blacklistReasonPanel = new System.Windows.Forms.Panel();
            this.blacklistReasonValueLabel = new System.Windows.Forms.Label();
            this.blacklistReasonLabel = new System.Windows.Forms.Label();
            this.predictionsTabPage = new System.Windows.Forms.TabPage();
            this.languagePanel = new System.Windows.Forms.Panel();
            this.languageValueLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.intellivoidAccountsPanel.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.whitelistedPanel.SuspendLayout();
            this.operatorPanel.SuspendLayout();
            this.officialPanel.SuspendLayout();
            this.blacklistedPanel.SuspendLayout();
            this.entityTypePanel.SuspendLayout();
            this.ptidPanel.SuspendLayout();
            this.blacklistTabPage.SuspendLayout();
            this.originalPtidBlacklistPanel.SuspendLayout();
            this.blacklistPanel.SuspendLayout();
            this.blacklistReasonPanel.SuspendLayout();
            this.predictionsTabPage.SuspendLayout();
            this.languagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.generalTabPage);
            this.mainTabControl.Controls.Add(this.blacklistTabPage);
            this.mainTabControl.Controls.Add(this.predictionsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(7, 8);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(372, 337);
            this.mainTabControl.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.intellivoidAccountsPanel);
            this.generalTabPage.Controls.Add(this.whitelistedPanel);
            this.generalTabPage.Controls.Add(this.operatorPanel);
            this.generalTabPage.Controls.Add(this.officialPanel);
            this.generalTabPage.Controls.Add(this.blacklistedPanel);
            this.generalTabPage.Controls.Add(this.entityTypePanel);
            this.generalTabPage.Controls.Add(this.ptidPanel);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(364, 311);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // intellivoidAccountsPanel
            // 
            this.intellivoidAccountsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intellivoidAccountsPanel.Controls.Add(this.intellivoidAccountsValueLabel);
            this.intellivoidAccountsPanel.Controls.Add(this.intellivoidAccountsLabel);
            this.intellivoidAccountsPanel.Location = new System.Drawing.Point(16, 129);
            this.intellivoidAccountsPanel.Name = "intellivoidAccountsPanel";
            this.intellivoidAccountsPanel.Size = new System.Drawing.Size(331, 16);
            this.intellivoidAccountsPanel.TabIndex = 6;
            // 
            // intellivoidAccountsValueLabel
            // 
            this.intellivoidAccountsValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.intellivoidAccountsValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intellivoidAccountsValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intellivoidAccountsValueLabel.Location = new System.Drawing.Point(157, 0);
            this.intellivoidAccountsValueLabel.Name = "intellivoidAccountsValueLabel";
            this.intellivoidAccountsValueLabel.Size = new System.Drawing.Size(174, 16);
            this.intellivoidAccountsValueLabel.TabIndex = 14;
            this.intellivoidAccountsValueLabel.Text = "N/A";
            this.intellivoidAccountsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy to clipboard";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // intellivoidAccountsLabel
            // 
            this.intellivoidAccountsLabel.AutoSize = true;
            this.intellivoidAccountsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.intellivoidAccountsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intellivoidAccountsLabel.Location = new System.Drawing.Point(0, 0);
            this.intellivoidAccountsLabel.Name = "intellivoidAccountsLabel";
            this.intellivoidAccountsLabel.Size = new System.Drawing.Size(157, 15);
            this.intellivoidAccountsLabel.TabIndex = 13;
            this.intellivoidAccountsLabel.Text = "Intellivoid Accounts Verified:";
            this.intellivoidAccountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // whitelistedPanel
            // 
            this.whitelistedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.whitelistedPanel.Controls.Add(this.whitelistedValueLabel);
            this.whitelistedPanel.Controls.Add(this.whitelistedLabel);
            this.whitelistedPanel.Location = new System.Drawing.Point(16, 110);
            this.whitelistedPanel.Name = "whitelistedPanel";
            this.whitelistedPanel.Size = new System.Drawing.Size(331, 16);
            this.whitelistedPanel.TabIndex = 5;
            // 
            // whitelistedValueLabel
            // 
            this.whitelistedValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.whitelistedValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whitelistedValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whitelistedValueLabel.Location = new System.Drawing.Point(69, 0);
            this.whitelistedValueLabel.Name = "whitelistedValueLabel";
            this.whitelistedValueLabel.Size = new System.Drawing.Size(262, 16);
            this.whitelistedValueLabel.TabIndex = 14;
            this.whitelistedValueLabel.Text = "N/A";
            this.whitelistedValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // whitelistedLabel
            // 
            this.whitelistedLabel.AutoSize = true;
            this.whitelistedLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.whitelistedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whitelistedLabel.Location = new System.Drawing.Point(0, 0);
            this.whitelistedLabel.Name = "whitelistedLabel";
            this.whitelistedLabel.Size = new System.Drawing.Size(69, 15);
            this.whitelistedLabel.TabIndex = 13;
            this.whitelistedLabel.Text = "Whitelisted:";
            this.whitelistedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // operatorPanel
            // 
            this.operatorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operatorPanel.Controls.Add(this.operatorValueLabel);
            this.operatorPanel.Controls.Add(this.operatorLabel);
            this.operatorPanel.Location = new System.Drawing.Point(16, 91);
            this.operatorPanel.Name = "operatorPanel";
            this.operatorPanel.Size = new System.Drawing.Size(331, 16);
            this.operatorPanel.TabIndex = 4;
            // 
            // operatorValueLabel
            // 
            this.operatorValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.operatorValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorValueLabel.Location = new System.Drawing.Point(57, 0);
            this.operatorValueLabel.Name = "operatorValueLabel";
            this.operatorValueLabel.Size = new System.Drawing.Size(274, 16);
            this.operatorValueLabel.TabIndex = 14;
            this.operatorValueLabel.Text = "N/A";
            this.operatorValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.operatorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorLabel.Location = new System.Drawing.Point(0, 0);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(57, 15);
            this.operatorLabel.TabIndex = 13;
            this.operatorLabel.Text = "Operator:";
            this.operatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // officialPanel
            // 
            this.officialPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.officialPanel.Controls.Add(this.officialValueLabel);
            this.officialPanel.Controls.Add(this.officialLabel);
            this.officialPanel.Location = new System.Drawing.Point(16, 72);
            this.officialPanel.Name = "officialPanel";
            this.officialPanel.Size = new System.Drawing.Size(331, 16);
            this.officialPanel.TabIndex = 3;
            // 
            // officialValueLabel
            // 
            this.officialValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.officialValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.officialValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officialValueLabel.Location = new System.Drawing.Point(48, 0);
            this.officialValueLabel.Name = "officialValueLabel";
            this.officialValueLabel.Size = new System.Drawing.Size(283, 16);
            this.officialValueLabel.TabIndex = 14;
            this.officialValueLabel.Text = "N/A";
            this.officialValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // officialLabel
            // 
            this.officialLabel.AutoSize = true;
            this.officialLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.officialLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officialLabel.Location = new System.Drawing.Point(0, 0);
            this.officialLabel.Name = "officialLabel";
            this.officialLabel.Size = new System.Drawing.Size(48, 15);
            this.officialLabel.TabIndex = 13;
            this.officialLabel.Text = "Official:";
            this.officialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // blacklistedPanel
            // 
            this.blacklistedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blacklistedPanel.Controls.Add(this.blacklistedValueLabel);
            this.blacklistedPanel.Controls.Add(this.blacklistedLabel);
            this.blacklistedPanel.Location = new System.Drawing.Point(16, 53);
            this.blacklistedPanel.Name = "blacklistedPanel";
            this.blacklistedPanel.Size = new System.Drawing.Size(331, 16);
            this.blacklistedPanel.TabIndex = 2;
            // 
            // blacklistedValueLabel
            // 
            this.blacklistedValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.blacklistedValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blacklistedValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistedValueLabel.Location = new System.Drawing.Point(66, 0);
            this.blacklistedValueLabel.Name = "blacklistedValueLabel";
            this.blacklistedValueLabel.Size = new System.Drawing.Size(265, 16);
            this.blacklistedValueLabel.TabIndex = 14;
            this.blacklistedValueLabel.Text = "N/A";
            this.blacklistedValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blacklistedLabel
            // 
            this.blacklistedLabel.AutoSize = true;
            this.blacklistedLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.blacklistedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistedLabel.Location = new System.Drawing.Point(0, 0);
            this.blacklistedLabel.Name = "blacklistedLabel";
            this.blacklistedLabel.Size = new System.Drawing.Size(66, 15);
            this.blacklistedLabel.TabIndex = 13;
            this.blacklistedLabel.Text = "Blacklisted:";
            this.blacklistedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // entityTypePanel
            // 
            this.entityTypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entityTypePanel.Controls.Add(this.entityTypeValueLabel);
            this.entityTypePanel.Controls.Add(this.entityTypeLabel);
            this.entityTypePanel.Location = new System.Drawing.Point(16, 34);
            this.entityTypePanel.Name = "entityTypePanel";
            this.entityTypePanel.Size = new System.Drawing.Size(331, 16);
            this.entityTypePanel.TabIndex = 1;
            // 
            // entityTypeValueLabel
            // 
            this.entityTypeValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.entityTypeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityTypeValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityTypeValueLabel.Location = new System.Drawing.Point(67, 0);
            this.entityTypeValueLabel.Name = "entityTypeValueLabel";
            this.entityTypeValueLabel.Size = new System.Drawing.Size(264, 16);
            this.entityTypeValueLabel.TabIndex = 14;
            this.entityTypeValueLabel.Text = "N/A";
            this.entityTypeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // entityTypeLabel
            // 
            this.entityTypeLabel.AutoSize = true;
            this.entityTypeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.entityTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityTypeLabel.Location = new System.Drawing.Point(0, 0);
            this.entityTypeLabel.Name = "entityTypeLabel";
            this.entityTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.entityTypeLabel.TabIndex = 13;
            this.entityTypeLabel.Text = "Entity Type:";
            this.entityTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptidPanel
            // 
            this.ptidPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptidPanel.Controls.Add(this.ptidValueLabel);
            this.ptidPanel.Controls.Add(this.ptidLabel);
            this.ptidPanel.Location = new System.Drawing.Point(16, 15);
            this.ptidPanel.Name = "ptidPanel";
            this.ptidPanel.Size = new System.Drawing.Size(331, 16);
            this.ptidPanel.TabIndex = 0;
            // 
            // ptidValueLabel
            // 
            this.ptidValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.ptidValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptidValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptidValueLabel.Location = new System.Drawing.Point(111, 0);
            this.ptidValueLabel.Name = "ptidValueLabel";
            this.ptidValueLabel.Size = new System.Drawing.Size(220, 16);
            this.ptidValueLabel.TabIndex = 14;
            this.ptidValueLabel.Text = "N/A";
            this.ptidValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ptidLabel
            // 
            this.ptidLabel.AutoSize = true;
            this.ptidLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptidLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptidLabel.Location = new System.Drawing.Point(0, 0);
            this.ptidLabel.Name = "ptidLabel";
            this.ptidLabel.Size = new System.Drawing.Size(111, 15);
            this.ptidLabel.TabIndex = 13;
            this.ptidLabel.Text = "Private Telegram ID:";
            this.ptidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // blacklistTabPage
            // 
            this.blacklistTabPage.Controls.Add(this.resolveIdButton);
            this.blacklistTabPage.Controls.Add(this.originalPtidBlacklistPanel);
            this.blacklistTabPage.Controls.Add(this.blacklistPanel);
            this.blacklistTabPage.Controls.Add(this.blacklistReasonPanel);
            this.blacklistTabPage.Location = new System.Drawing.Point(4, 22);
            this.blacklistTabPage.Name = "blacklistTabPage";
            this.blacklistTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.blacklistTabPage.Size = new System.Drawing.Size(364, 311);
            this.blacklistTabPage.TabIndex = 1;
            this.blacklistTabPage.Text = "Blacklist";
            this.blacklistTabPage.UseVisualStyleBackColor = true;
            // 
            // resolveIdButton
            // 
            this.resolveIdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resolveIdButton.Enabled = false;
            this.resolveIdButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resolveIdButton.Location = new System.Drawing.Point(20, 85);
            this.resolveIdButton.Name = "resolveIdButton";
            this.resolveIdButton.Size = new System.Drawing.Size(101, 25);
            this.resolveIdButton.TabIndex = 10;
            this.resolveIdButton.Text = "Resolve ID...";
            this.resolveIdButton.UseVisualStyleBackColor = true;
            this.resolveIdButton.Click += new System.EventHandler(this.resolveIdButton_Click);
            // 
            // originalPtidBlacklistPanel
            // 
            this.originalPtidBlacklistPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalPtidBlacklistPanel.Controls.Add(this.originalPtidBlacklistValueLabel);
            this.originalPtidBlacklistPanel.Controls.Add(this.originalPtidBlacklistLabel);
            this.originalPtidBlacklistPanel.Location = new System.Drawing.Point(16, 53);
            this.originalPtidBlacklistPanel.Name = "originalPtidBlacklistPanel";
            this.originalPtidBlacklistPanel.Size = new System.Drawing.Size(331, 16);
            this.originalPtidBlacklistPanel.TabIndex = 9;
            // 
            // originalPtidBlacklistValueLabel
            // 
            this.originalPtidBlacklistValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.originalPtidBlacklistValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPtidBlacklistValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPtidBlacklistValueLabel.Location = new System.Drawing.Point(105, 0);
            this.originalPtidBlacklistValueLabel.Name = "originalPtidBlacklistValueLabel";
            this.originalPtidBlacklistValueLabel.Size = new System.Drawing.Size(226, 16);
            this.originalPtidBlacklistValueLabel.TabIndex = 14;
            this.originalPtidBlacklistValueLabel.Text = "N/A";
            this.originalPtidBlacklistValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // originalPtidBlacklistLabel
            // 
            this.originalPtidBlacklistLabel.AutoSize = true;
            this.originalPtidBlacklistLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.originalPtidBlacklistLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPtidBlacklistLabel.Location = new System.Drawing.Point(0, 0);
            this.originalPtidBlacklistLabel.Name = "originalPtidBlacklistLabel";
            this.originalPtidBlacklistLabel.Size = new System.Drawing.Size(105, 15);
            this.originalPtidBlacklistLabel.TabIndex = 13;
            this.originalPtidBlacklistLabel.Text = "Original Private ID:";
            this.originalPtidBlacklistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // blacklistPanel
            // 
            this.blacklistPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blacklistPanel.Controls.Add(this.blacklistFlagValueLabel);
            this.blacklistPanel.Controls.Add(this.blacklistFlagLabel);
            this.blacklistPanel.Location = new System.Drawing.Point(16, 34);
            this.blacklistPanel.Name = "blacklistPanel";
            this.blacklistPanel.Size = new System.Drawing.Size(331, 16);
            this.blacklistPanel.TabIndex = 8;
            // 
            // blacklistFlagValueLabel
            // 
            this.blacklistFlagValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.blacklistFlagValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blacklistFlagValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistFlagValueLabel.Location = new System.Drawing.Point(32, 0);
            this.blacklistFlagValueLabel.Name = "blacklistFlagValueLabel";
            this.blacklistFlagValueLabel.Size = new System.Drawing.Size(299, 16);
            this.blacklistFlagValueLabel.TabIndex = 14;
            this.blacklistFlagValueLabel.Text = "N/A";
            this.blacklistFlagValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blacklistFlagLabel
            // 
            this.blacklistFlagLabel.AutoSize = true;
            this.blacklistFlagLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.blacklistFlagLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistFlagLabel.Location = new System.Drawing.Point(0, 0);
            this.blacklistFlagLabel.Name = "blacklistFlagLabel";
            this.blacklistFlagLabel.Size = new System.Drawing.Size(32, 15);
            this.blacklistFlagLabel.TabIndex = 13;
            this.blacklistFlagLabel.Text = "Flag:";
            this.blacklistFlagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // blacklistReasonPanel
            // 
            this.blacklistReasonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blacklistReasonPanel.Controls.Add(this.blacklistReasonValueLabel);
            this.blacklistReasonPanel.Controls.Add(this.blacklistReasonLabel);
            this.blacklistReasonPanel.Location = new System.Drawing.Point(16, 15);
            this.blacklistReasonPanel.Name = "blacklistReasonPanel";
            this.blacklistReasonPanel.Size = new System.Drawing.Size(331, 16);
            this.blacklistReasonPanel.TabIndex = 7;
            // 
            // blacklistReasonValueLabel
            // 
            this.blacklistReasonValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.blacklistReasonValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blacklistReasonValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistReasonValueLabel.Location = new System.Drawing.Point(48, 0);
            this.blacklistReasonValueLabel.Name = "blacklistReasonValueLabel";
            this.blacklistReasonValueLabel.Size = new System.Drawing.Size(283, 16);
            this.blacklistReasonValueLabel.TabIndex = 14;
            this.blacklistReasonValueLabel.Text = "N/A";
            this.blacklistReasonValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blacklistReasonLabel
            // 
            this.blacklistReasonLabel.AutoSize = true;
            this.blacklistReasonLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.blacklistReasonLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistReasonLabel.Location = new System.Drawing.Point(0, 0);
            this.blacklistReasonLabel.Name = "blacklistReasonLabel";
            this.blacklistReasonLabel.Size = new System.Drawing.Size(48, 15);
            this.blacklistReasonLabel.TabIndex = 13;
            this.blacklistReasonLabel.Text = "Reason:";
            this.blacklistReasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // predictionsTabPage
            // 
            this.predictionsTabPage.Controls.Add(this.languagePanel);
            this.predictionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.predictionsTabPage.Name = "predictionsTabPage";
            this.predictionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.predictionsTabPage.Size = new System.Drawing.Size(364, 311);
            this.predictionsTabPage.TabIndex = 2;
            this.predictionsTabPage.Text = "Predictions";
            this.predictionsTabPage.UseVisualStyleBackColor = true;
            // 
            // languagePanel
            // 
            this.languagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languagePanel.Controls.Add(this.languageValueLabel);
            this.languagePanel.Controls.Add(this.languageLabel);
            this.languagePanel.Location = new System.Drawing.Point(16, 15);
            this.languagePanel.Name = "languagePanel";
            this.languagePanel.Size = new System.Drawing.Size(331, 16);
            this.languagePanel.TabIndex = 14;
            // 
            // languageValueLabel
            // 
            this.languageValueLabel.ContextMenuStrip = this.contextMenuStrip;
            this.languageValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.languageValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageValueLabel.Location = new System.Drawing.Point(62, 0);
            this.languageValueLabel.Name = "languageValueLabel";
            this.languageValueLabel.Size = new System.Drawing.Size(269, 16);
            this.languageValueLabel.TabIndex = 14;
            this.languageValueLabel.Text = "N/A";
            this.languageValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.languageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(0, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(62, 15);
            this.languageLabel.TabIndex = 13;
            this.languageLabel.Text = "Language:";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeButton.Location = new System.Drawing.Point(302, 351);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(77, 25);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SearchResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(387, 385);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::spbgui.Properties.Resources.AppIcon;
            this.Name = "SearchResultsForm";
            this.Text = "Results for - {SearchQuery}";
            this.mainTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.intellivoidAccountsPanel.ResumeLayout(false);
            this.intellivoidAccountsPanel.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.whitelistedPanel.ResumeLayout(false);
            this.whitelistedPanel.PerformLayout();
            this.operatorPanel.ResumeLayout(false);
            this.operatorPanel.PerformLayout();
            this.officialPanel.ResumeLayout(false);
            this.officialPanel.PerformLayout();
            this.blacklistedPanel.ResumeLayout(false);
            this.blacklistedPanel.PerformLayout();
            this.entityTypePanel.ResumeLayout(false);
            this.entityTypePanel.PerformLayout();
            this.ptidPanel.ResumeLayout(false);
            this.ptidPanel.PerformLayout();
            this.blacklistTabPage.ResumeLayout(false);
            this.originalPtidBlacklistPanel.ResumeLayout(false);
            this.originalPtidBlacklistPanel.PerformLayout();
            this.blacklistPanel.ResumeLayout(false);
            this.blacklistPanel.PerformLayout();
            this.blacklistReasonPanel.ResumeLayout(false);
            this.blacklistReasonPanel.PerformLayout();
            this.predictionsTabPage.ResumeLayout(false);
            this.languagePanel.ResumeLayout(false);
            this.languagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel ptidPanel;
        private System.Windows.Forms.Panel officialPanel;
        private System.Windows.Forms.Label officialValueLabel;
        private System.Windows.Forms.Label officialLabel;
        private System.Windows.Forms.Panel blacklistedPanel;
        private System.Windows.Forms.Label blacklistedValueLabel;
        private System.Windows.Forms.Label blacklistedLabel;
        private System.Windows.Forms.Panel entityTypePanel;
        private System.Windows.Forms.Label entityTypeValueLabel;
        private System.Windows.Forms.Label entityTypeLabel;
        private System.Windows.Forms.Label ptidValueLabel;
        private System.Windows.Forms.Label ptidLabel;
        private System.Windows.Forms.Panel intellivoidAccountsPanel;
        private System.Windows.Forms.Label intellivoidAccountsValueLabel;
        private System.Windows.Forms.Label intellivoidAccountsLabel;
        private System.Windows.Forms.Panel whitelistedPanel;
        private System.Windows.Forms.Label whitelistedValueLabel;
        private System.Windows.Forms.Label whitelistedLabel;
        private System.Windows.Forms.Panel operatorPanel;
        private System.Windows.Forms.Label operatorValueLabel;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.TabPage blacklistTabPage;
        private System.Windows.Forms.Panel originalPtidBlacklistPanel;
        private System.Windows.Forms.Label originalPtidBlacklistValueLabel;
        private System.Windows.Forms.Label originalPtidBlacklistLabel;
        private System.Windows.Forms.Panel blacklistPanel;
        private System.Windows.Forms.Label blacklistFlagValueLabel;
        private System.Windows.Forms.Label blacklistFlagLabel;
        private System.Windows.Forms.Panel blacklistReasonPanel;
        private System.Windows.Forms.Label blacklistReasonValueLabel;
        private System.Windows.Forms.Label blacklistReasonLabel;
        private System.Windows.Forms.TabPage predictionsTabPage;
        private System.Windows.Forms.Panel languagePanel;
        private System.Windows.Forms.Label languageValueLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button resolveIdButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}