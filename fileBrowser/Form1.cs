using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileBrowser
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

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (txtPath.Text != null)
                {
                    webBrowser1.Navigate(txtPath.Text);
                }
                else
                    MessageBox.Show("Please input an address");
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //The class for browsing through local drive folders is instantiated
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
