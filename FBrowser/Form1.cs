using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace FBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWebView2();
            txtAddressBar.KeyDown += txtAddressBar_KeyDown;
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private async void InitializeWebView2()
        {
            await webView2Control.EnsureCoreWebView2Async();

            webView2Control.CoreWebView2.NavigationCompleted += WebView2Control_NavigationCompleted;

            webView2Control.CoreWebView2.Navigate("https://www.google.com");
        }

        private void WebView2Control_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            UpdateAddressBar(webView2Control.CoreWebView2.Source);

            if (webView2Control.CoreWebView2 != null)
            {
                string url = webView2Control.CoreWebView2.Source;
                string title = webView2Control.CoreWebView2.DocumentTitle;

                SaveHistoryToDatabase(title, url);

                UpdateAddressBar(url);
            }


        }

        private void SaveHistoryToDatabase(string title, string url)
        {
            try
            {
                if (title.Length > 50)
                {
                    title = title.Substring(0, 50);
                }

                using (var baglan = bgl.baglanti())
                {
                    using (var komut = new SqlCommand("INSERT INTO Tbl_History (Name, Link) VALUES (@title, @url)", baglan))
                    {
                        komut.Parameters.AddWithValue("@title", title);
                        komut.Parameters.AddWithValue("@url", url);
                        komut.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "History Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewTab(string url)
        {
            TabPage newTab = new TabPage("New Tab");
            tabControl1.TabPages.Add(newTab);

            WebView2 newWebView2 = new WebView2
            {
                Dock = DockStyle.Fill
            };
            newTab.Controls.Add(newWebView2);

            newWebView2.EnsureCoreWebView2Async().ContinueWith((task) =>
            {
                if (newWebView2.InvokeRequired)
                {
                    newWebView2.Invoke(new Action(() =>
                    {
                        newWebView2.CoreWebView2.NavigationCompleted += (s, e) =>
                        {
                            UpdateAddressBar(newWebView2.CoreWebView2.Source);

                            string pageTitle = newWebView2.CoreWebView2.DocumentTitle;
                            newTab.Text = string.IsNullOrEmpty(pageTitle) ? url : pageTitle;

                            SaveHistoryToDatabase(pageTitle, newWebView2.CoreWebView2.Source);
                        };

                        newWebView2.CoreWebView2.Navigate(url);
                    }));
                }
                else
                {
                    newWebView2.CoreWebView2.NavigationCompleted += (s, e) =>
                    {
                        UpdateAddressBar(newWebView2.CoreWebView2.Source);

                        string pageTitle = newWebView2.CoreWebView2.DocumentTitle;
                        newTab.Text = string.IsNullOrEmpty(pageTitle) ? url : pageTitle;

                        SaveHistoryToDatabase(pageTitle, newWebView2.CoreWebView2.Source);
                    };

                    newWebView2.CoreWebView2.Navigate(url);
                }
            });
        }


        private void UpdateAddressBar(string url)
        {
            if (txtAddressBar.InvokeRequired)
            {
                txtAddressBar.Invoke(new Action(() => txtAddressBar.Text = url));
            }
            else
            {
                txtAddressBar.Text = url;
            }
        }

        private void txtAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; 
                btnGo_Click(sender, EventArgs.Empty);
            }
        }

        private string FormatUrl(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }
            return url;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                string url = FormatUrl(txtAddressBar.Text);

                if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Controls.Count > 0)
                {
                    var webView = tabControl1.SelectedTab.Controls[0] as WebView2;
                    if (webView?.CoreWebView2 != null)
                    {
                        webView.CoreWebView2.Navigate(url);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "URL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAddressBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Controls.Count > 0)
            {
                var webView = tabControl1.SelectedTab.Controls[0] as WebView2;
                if (webView?.CanGoBack == true)
                {
                    webView.GoBack();
                }
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Controls.Count > 0)
            {
                var webView = tabControl1.SelectedTab.Controls[0] as WebView2;
                if (webView?.CanGoForward == true)
                {
                    webView.GoForward();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Controls.Count > 0)
            {
                var webView = tabControl1.SelectedTab.Controls[0] as WebView2;
                webView?.Reload();
            }
        }

        private void webView2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            AddNewTab("https://www.google.com");
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }

        private void Bookmark_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Controls.Count > 0)
            {
                var webView = tabControl1.SelectedTab.Controls[0] as WebView2;
                if (webView?.CoreWebView2 != null)
                {
                    string url = webView.CoreWebView2.Source;
                    string title = webView.CoreWebView2.DocumentTitle;

                    SaveBookmarkToDatabase(title, url);
                    MessageBox.Show("Bookmark saved successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SaveBookmarkToDatabase(string title, string url)
        {
            try
            {
                using (var baglan = bgl.baglanti())
                {
                    using (var komut = new SqlCommand("INSERT INTO Tbl_Bookmarks (Name, Link) VALUES (@title, @url)", baglan))
                    {
                        komut.Parameters.AddWithValue("@title", title);
                        komut.Parameters.AddWithValue("@url", url);
                        komut.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Bookmark Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.OnBookmarkSelected += (selectedUrl) =>
            {
                AddNewTab(selectedUrl);
            };
            history.Show();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookmarks bookmarks = new Bookmarks();

            bookmarks.OnBookmarkSelected += (selectedUrl) =>
            {
                AddNewTab(selectedUrl);
            };

            bookmarks.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}