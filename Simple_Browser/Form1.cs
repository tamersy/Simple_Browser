using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebSite.Navigate(txtURL.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebSite.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebSite.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebSite.GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebSite.Refresh();
        }
    }
}
