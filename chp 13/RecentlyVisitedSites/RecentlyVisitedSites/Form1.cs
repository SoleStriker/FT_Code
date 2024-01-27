using System.Security.Cryptography;
using System;
using System.Windows.Forms;
using System.Diagnostics;
namespace RecentlyVisitedSites
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkedLabel1_Hover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(linkLabel1, "Google very good website.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            string url = "https://google.com";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Handle the exception or log it
                MessageBox.Show($"Error opening link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://paycom.com";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Handle the exception or log it
                MessageBox.Show($"Error opening link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://clash.gg";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Handle the exception or log it
                MessageBox.Show($"Error opening link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkedLabel2_Hover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(linkLabel1, "Paycom good for money");
        }
        private void linkedLabel3_Hover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(linkLabel1, "Clash GG good for loosing money.");
        }
    }
}
