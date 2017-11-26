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
    public partial class FormNewP : Form
    {
        private string key;
        private Encrypt encrypt = new Encrypt();
        public FormNewP(string key)
        {
            InitializeComponent();
            this.key = key;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldp = textBox1.Text;
            string newp = textBox2.Text;
            if ((!encrypt.CheckPass(oldp, key)))
            {
                MessageBox.Show("Пароли не совпадают! Либо введен неправильный старый пароль");
            }

            else
            {
                FormKey keyn = new FormKey(encrypt.Write(newp));
                keyn.Show();
                Close();
            }
        }
    }
}
