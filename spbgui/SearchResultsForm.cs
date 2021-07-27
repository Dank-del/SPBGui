using spbgui.backend;
using System;
using System.Windows.Forms;

namespace spbgui
{
    /// <summary>
    /// Displays the search results of the user
    /// </summary>
    public partial class SearchResultsForm : Form
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        /// <param name="apiClass"></param>
        public SearchResultsForm(ApiClass apiClass, string searchQuery)
        {
            InitializeComponent();
            Text = string.Format("Results for - {0}", searchQuery);


            if (apiClass.Results.PrivateTelegramId != null)
                ptidValueLabel.Text = apiClass.Results.PrivateTelegramId;

            if (apiClass.Results.EntityType != null)
                entityTypeValueLabel.Text = apiClass.Results.EntityType;

            if (apiClass.Results.Attributes.IsBlacklisted)
            {
                blacklistedValueLabel.Text = "Yes";

                if (apiClass.Results.Attributes.BlacklistReason != null)
                    blacklistedValueLabel.Text = (string)apiClass.Results.Attributes.BlacklistReason;

                if (apiClass.Results.Attributes.BlacklistFlag != null)
                    blacklistFlagValueLabel.Text = (string)apiClass.Results.Attributes.BlacklistFlag;

                if (apiClass.Results.Attributes.OriginalPrivateId != null)
                {
                    originalPtidBlacklistValueLabel.Text = (string)apiClass.Results.Attributes.OriginalPrivateId;

                    resolveIdButton.Enabled = true;
                    resolveIdButton.Tag = apiClass.Results.Attributes.OriginalPrivateId;
                }
            }
            else
            {
                blacklistedValueLabel.Text = "No";

                // Remove the tab page if no blacklist information is available in the first place
                mainTabControl.TabPages.Remove(blacklistTabPage);
            }

            if (apiClass.Results.Attributes.IsOfficial)
            {
                officialValueLabel.Text = "Yes";
            }
            else
            {
                officialValueLabel.Text = "No";
            }

            if (apiClass.Results.Attributes.IsOperator)
            {
                operatorValueLabel.Text = "Yes";
            }
            else
            {
                operatorValueLabel.Text = "No";
            }

            if (apiClass.Results.Attributes.IsWhitelisted)
            {
                whitelistedValueLabel.Text = "Yes";
            }
            else
            {
                whitelistedValueLabel.Text = "No";
            }

            if (apiClass.Results.Attributes.IntellivoidAccountsVerified)
            {
                intellivoidAccountsValueLabel.Text = "Yes";
            }
            else
            {
                intellivoidAccountsValueLabel.Text = "No";
            }

            if (apiClass.Results.LanguagePrediction.Language != null)
                languageValueLabel.Text = apiClass.Results.LanguagePrediction.Language;

            if (apiClass.Results.SpamPrediction.SpamPredictionSpamPrediction > 0)
                spamValueLabel.Text = $"{apiClass.Results.SpamPrediction.SpamPredictionSpamPrediction}";

            if (apiClass.Results.SpamPrediction.HamPrediction > 0)
                hamValueLabel.Text = $"{apiClass.Results.SpamPrediction.HamPrediction}";

        }


        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Attempts to resolve the original private telegram ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ResolveIdButton_Click(object sender, System.EventArgs e)
        {
            ApiClass data;

            try
            {
                data = await Request.ApiRequest((string)resolveIdButton.Tag);
                SearchResultsForm resultsForm = new SearchResultsForm(data, (string)resolveIdButton.Tag);
                resultsForm.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(text: "User not found.", caption: "Notice", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return;
            }
        }

        /// <summary>
        /// Copies the selected text to the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripItem item)
            {
                if (item.Owner is ContextMenuStrip owner)
                {
                    Clipboard.SetText(owner.SourceControl.Text);
                }

            }
        }
    }
}
