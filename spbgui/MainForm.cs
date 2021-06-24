using System;
using System.Windows.Forms;
using spbgui.backend;

namespace spbgui
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// Public Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executes the search query against the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length == 0)
            {
                MessageBox.Show(text: "The search query cannot be empty!", caption: "Invalid Input", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return;
            }

            ApiClass data;

            try
            {
                data = Request.ApiRequest(searchTextBox.Text).Data;
                SearchResultsForm resultsForm = new SearchResultsForm(data, searchTextBox.Text);
                resultsForm.Show();

                searchTextBox.Text = string.Empty;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(text: "User not found.", caption: "Notice", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return;
            }
        }

        /// <summary>
        /// Submits on "Enter" key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(this, new EventArgs());
            }
        }

        /**
        private void Okay_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            if (textBox1.Text == "")
            {
                MessageBox.Show(text: "Enter ID or Username", caption: "Error", buttons:MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return;
            }
            label4.Text = $"Query: {textBox1.Text}";
            spbgui.backend.ApiClass data;
            try
            {
            data = Request.ApiRequest(textBox1.Text).Data;
            
            //label2.Text = $"Private telegram ID: {data.Results.PrivateTelegramId}\n";
            label2.Text = $"Entity Type: {data.Results.EntityType}\n";
            label2.Text += $"Blacklisted: {data.Results.Attributes.IsBlacklisted}\n";
            if (data.Results.Attributes.BlacklistFlag != null)
            {
                label2.Text += $"Blacklist Flag: {data.Results.Attributes.BlacklistFlag}\n";
            }

            if (data.Results.Attributes.BlacklistReason != null)
            {
                label2.Text += $"Blacklist Reason: {data.Results.Attributes.BlacklistReason}\n";
            }

            if (data.Results.Attributes.OriginalPrivateId != null)
            {
                label2.Text += $"Original PTID (only for 0xEVADE): {data.Results.Attributes.OriginalPrivateId}\n";
            }

            label2.Text += $"Official: {data.Results.Attributes.IsOfficial}\n";
            label2.Text += $"Operator: {data.Results.Attributes.IsOperator}\n";
            label2.Text += $"Whitelisted: {data.Results.Attributes.IsWhitelisted}\n";
            label2.Text += $"Potential Spammer: {data.Results.Attributes.IsPotentialSpammer}\n";
            label2.Text += $"Intellivoid Accounts verified: {data.Results.Attributes.IntellivoidAccountsVerified}\n";
            label2.Text += $"Language: {data.Results.LanguagePrediction.Language}";

            label3.Text = $"Private Telegram ID: {data.Results.PrivateTelegramId}";
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(text:"User not found.", caption:"Notice");
                label4.Text = "";
                textBox1.Text = "";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var msg = "SpamProtection GUI, an app to get user, channel or chat information on Intellivoid SpamProtection API.\n";
            msg += "The Intellivoid logo is a trademark of Intellivoid Technologies.\n";
            msg += "Copyright ©  2021 Dank-Del, Intellivoid\n";
            msg += "Website: Intellivoid.net\n";
            msg += "Github: github.com/Intellivoid";
            MessageBox.Show(text:msg, caption:"About", buttons:MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                MessageBox.Show(text:"No PTID to be copied", caption:"ERROR", buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(label3.Text);
            }
        }

        **/

    }
}
