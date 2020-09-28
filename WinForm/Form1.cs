using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button1.Click += Button1_Click1;
        }

        private void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the button is clicked");
        }
        private void Test()
        {
            var text = textBox2.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                text = null;
            }

            textBox2.Text = text.ToUpper();
        }
    }
}
