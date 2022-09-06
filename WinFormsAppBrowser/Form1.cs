using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppBrowser
{
    public partial class Form1 : Form
    {
        public FormTool FormTool = new FormTool();
        public Tool tool = new Tool();
        public string Search { get; set; } = $"https://www.google.com/";
        public int Count { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            //int count = tabControl1.TabCount;
            progressBar1.Value = 1;
            TabPage tabPage = new TabPage($"New tab ({++Count})");
            progressBar1.Value = 10;
            WebBrowser web = new WebBrowser();
            web.Navigated += Web_Navigated;
            progressBar1.Value = 20;
            web.Url = new Uri("https://www.google.com/");
            web.Dock = DockStyle.Fill;
            progressBar1.Value = 50;
            tabPage.Controls.Add(web);
            tabControl1.TabPages.Add(tabPage);
            progressBar1.Value = 100;
            tabControl1.SelectedIndex = Count - 1;
           
        }

        private void Web_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowser webBrowser = sender as WebBrowser;
            listBox1.Items.Add(webBrowser.Url);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //int count = tabControl1.TabCount;
            progressBar1.Value = 1;
            TabPage tabPage = new TabPage($"New tab ({++Count})");
            progressBar1.Value = 10;
            WebBrowser web = new WebBrowser();
            web.Navigated += Web_Navigated;
            progressBar1.Value = 20;
            web.Url = new Uri("https://www.google.com/");
            
            web.Dock = DockStyle.Fill;
            progressBar1.Value = 50;
            tabPage.Controls.Add(web);
            tabControl1.TabPages.Add(tabPage);
            progressBar1.Value = 100;
            tabControl1.SelectedIndex = Count - 1;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Text.Contains(Count.ToString());
               
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
            //if (listBox1.Visible) listBox1.Visible = false;
            //else listBox1.Visible = true;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int count = tabControl1.TabCount;
            if(count > 0)
            {
                int indexRemove = tabControl1.SelectedIndex;
                tabControl1.Controls.RemoveAt(indexRemove);
            }
            else
            {
                var result = MessageBox.Show("You want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) this.Close();
            }
        }

        private void textBoxRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                progressBar1.Value = 1;
                var index = tabControl1.SelectedIndex;
                progressBar1.Value = 10;
                var page = tabControl1.Controls[index];
                progressBar1.Value = 20;
                var web = page.Controls[0] as WebBrowser;
                progressBar1.Value = 50;
                if (tool.Search == null) web.Url = new Uri($"{Search}search?q={textBoxRequest.Text}");
                else web.Url = new Uri($"{tool.Search}search?q={textBoxRequest.Text}");
                progressBar1.Value = 100;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 1;
            var index = tabControl1.SelectedIndex;
            progressBar1.Value = 10;
            var page = tabControl1.Controls[index];
            progressBar1.Value = 20;
            var web = page.Controls[0] as WebBrowser;
            progressBar1.Value = 50;
            web.GoBack();
            progressBar1.Value = 100;
        }

        private void buttonForw_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 1;
            var index = tabControl1.SelectedIndex;
            progressBar1.Value = 10;
            var page = tabControl1.Controls[index];
            progressBar1.Value = 20;
            var web = page.Controls[0] as WebBrowser;
            progressBar1.Value = 50;
            web.GoForward();
            progressBar1.Value = 100;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void buttonSearchT_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 1;
            var index = tabControl1.SelectedIndex;
            progressBar1.Value = 10;
            var page = tabControl1.Controls[index];
            progressBar1.Value = 20;
            var web = page.Controls[0] as WebBrowser;
            progressBar1.Value = 50;
            web.Url = new Uri($"{Search}search?q={textBoxRequest.Text}");
            progressBar1.Value = 100;
        }

        private void buttonTool_Click(object sender, EventArgs e)
        {
            var FormTool = new FormTool();
            
            FormTool.ShowDialog();
            if (FormTool.DialogResult == DialogResult.OK)
            {
                tool = FormTool.Tool;
            }
            if (FormTool.IsClear)
            {
                this.listBox1.Items.Clear();
            }
        }

      

        private void buttonHome_Click(object sender, EventArgs e)
        {
                try
                {
                    var home = tool.HomeUrl;
                    progressBar1.Value = 1;
                    var index = tabControl1.SelectedIndex;
                    progressBar1.Value = 10;
                    var page = tabControl1.Controls[index];
                    progressBar1.Value = 20;
                    var web = page.Controls[0] as WebBrowser;
                    progressBar1.Value = 50;
                    web.Url = new Uri($"{home}");
                    progressBar1.Value = 100;

                }
                catch (Exception)
                {
                     MessageBox.Show("Нет домашней страницы", "Error", MessageBoxButtons.OK);
                }
            
        }

        private void buttonBookmarks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("🌍 Browser \n ver1.0\n СПД121.\n Система: Windows 10 64-bit.", "О программе.");
        }

        private void buttonFavorit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var formFavorit = new FormFavorit();
                formFavorit.listBoxFavorit.Items.Add(listBox1.SelectedItem);
                formFavorit.ShowDialog();
            }
            else MessageBox.Show("Нет выбранных вкладок", "Warning", MessageBoxButtons.OK);
        }
    }
}
