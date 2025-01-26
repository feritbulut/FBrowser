using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBrowser
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.linkedin.com/in/feritbulut/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/feritbulut",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://x.com/fertbult",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.instagram.com/fertbult/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
