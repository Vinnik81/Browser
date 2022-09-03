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
    public partial class FormTool : Form
    {
        public Tool Tool { get; set; }
        public bool IsClear { get; set; }
        public FormTool()
        {
            InitializeComponent();
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            Tool = new Tool();
            Tool.HomeUrl = textBoxHomeURL.Text;
            if (comboBoxSearchUrl.Text == "Google") Tool.Search = Tool.Google;
            else if (comboBoxSearchUrl.Text == "Yandex") Tool.Search = Tool.Yandex;
            else if (comboBoxSearchUrl.Text == "Bing") Tool.Search = Tool.Bing;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            IsClear = true;
        }

        
    }
}
