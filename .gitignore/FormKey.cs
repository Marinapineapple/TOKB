using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab1
{
    public partial class FormKey : Form
    {
        private string key;
        public FormKey(string key)
        {
            InitializeComponent();
            this.key = key;
            textBox1.Text = key;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNewP newpass = new FormNewP(key);
            newpass.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
