using System;
using System.Windows.Forms;
using spbgui.backend;
using RestSharp;

namespace spbgui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            spbgui.backend.ApiClass data;
            try
            {
                data = Request.ApiRequest(textBox1.Text).Data;
            }
            catch
            {
                MessageBox.Show("User not found.");
                return;
            }
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

            label3.Text = $"Private telegram ID: {data.Results.PrivateTelegramId}";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
