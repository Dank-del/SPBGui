
namespace spbgui
{
    partial class MainForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.apiEndpointPanel = new System.Windows.Forms.Panel();
            this.apiEndpointTextBox = new System.Windows.Forms.TextBox();
            this.apiEndpointLabel = new System.Windows.Forms.Label();
            this.rememberEndpointCheckBox = new System.Windows.Forms.CheckBox();
            this.footerPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.apiEndpointPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerLabel.Location = new System.Drawing.Point(11, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(446, 31);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Search the SpamProtection Database";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.Text = "&File";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.footerPanel.Controls.Add(this.aboutButton);
            this.footerPanel.Controls.Add(this.searchButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 167);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(489, 44);
            this.footerPanel.TabIndex = 11;
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(297, 8);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(88, 28);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(391, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 28);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(0, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(132, 25);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Username, ID, PTID:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Location = new System.Drawing.Point(16, 125);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(452, 25);
            this.searchPanel.TabIndex = 13;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(132, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(320, 25);
            this.searchTextBox.TabIndex = 13;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // apiEndpointPanel
            // 
            this.apiEndpointPanel.Controls.Add(this.apiEndpointTextBox);
            this.apiEndpointPanel.Controls.Add(this.apiEndpointLabel);
            this.apiEndpointPanel.Location = new System.Drawing.Point(16, 54);
            this.apiEndpointPanel.Name = "apiEndpointPanel";
            this.apiEndpointPanel.Size = new System.Drawing.Size(452, 25);
            this.apiEndpointPanel.TabIndex = 14;
            // 
            // apiEndpointTextBox
            // 
            this.apiEndpointTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.apiEndpointTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.apiEndpointTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apiEndpointTextBox.Enabled = false;
            this.apiEndpointTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiEndpointTextBox.Location = new System.Drawing.Point(132, 0);
            this.apiEndpointTextBox.Name = "apiEndpointTextBox";
            this.apiEndpointTextBox.Size = new System.Drawing.Size(320, 25);
            this.apiEndpointTextBox.TabIndex = 13;
            this.apiEndpointTextBox.Text = "https://api.intellivoid.net/spamprotection/v1/lookup";
            // 
            // apiEndpointLabel
            // 
            this.apiEndpointLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.apiEndpointLabel.Enabled = false;
            this.apiEndpointLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiEndpointLabel.Location = new System.Drawing.Point(0, 0);
            this.apiEndpointLabel.Name = "apiEndpointLabel";
            this.apiEndpointLabel.Size = new System.Drawing.Size(132, 25);
            this.apiEndpointLabel.TabIndex = 12;
            this.apiEndpointLabel.Text = "API Endpoint:";
            this.apiEndpointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rememberEndpointCheckBox
            // 
            this.rememberEndpointCheckBox.AutoSize = true;
            this.rememberEndpointCheckBox.Enabled = false;
            this.rememberEndpointCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rememberEndpointCheckBox.Location = new System.Drawing.Point(148, 85);
            this.rememberEndpointCheckBox.Name = "rememberEndpointCheckBox";
            this.rememberEndpointCheckBox.Size = new System.Drawing.Size(178, 19);
            this.rememberEndpointCheckBox.TabIndex = 15;
            this.rememberEndpointCheckBox.Text = "Remember this API Endpoint";
            this.rememberEndpointCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 211);
            this.Controls.Add(this.rememberEndpointCheckBox);
            this.Controls.Add(this.apiEndpointPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::spbgui.Properties.Resources.AppIcon;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "SpamProtection GUI";
            this.footerPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.apiEndpointPanel.ResumeLayout(false);
            this.apiEndpointPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel apiEndpointPanel;
        private System.Windows.Forms.TextBox apiEndpointTextBox;
        private System.Windows.Forms.Label apiEndpointLabel;
        private System.Windows.Forms.CheckBox rememberEndpointCheckBox;
    }
}

