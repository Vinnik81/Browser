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
    public partial class FormFavorit : Form
    {
        public FormFavorit()
        {
            InitializeComponent();
        }

        private void buttonCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            if (listBoxFavorit.Items != null) listBoxFavorit.Items.Remove(listBoxFavorit.SelectedItem);
            else MessageBox.Show("Нет выбранных вкладок", "Warning", MessageBoxButtons.OK);
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            try
            {
                var form1 = new Form1();
                var index = form1.tabControl1.SelectedIndex;
                var page = form1.tabControl1.Controls[index];
                var web = page.Controls[0] as WebBrowser;
                web.Url = new Uri($"{listBoxFavorit.Text}");
            }
            catch (Exception)
            { 
            MessageBox.Show("Нет выбранных вкладок", "Warning", MessageBoxButtons.OK);  
            }
            this.Close();
        }
    }
}
