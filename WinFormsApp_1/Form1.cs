using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_1
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

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var age = tbage.Text;

            MessageBox.Show("Hello " + " and you are " + " Years old");


            // MessageBox.Show($"Hello " + { textBox1.Text}); // can do either way

        }
    }
}
