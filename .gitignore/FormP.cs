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
    public partial class FormP : Form
    {
        private Encrypt encrypt = new Encrypt();
        public FormP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;
            if (pass == "")
            {
                textBox1.Text = System.Convert.ToString("введите пароль");
            }
            if (!File.Exists(encrypt.F))
            {

                FormKey key = new FormKey(encrypt.Write(pass));
                key.Show();

            }
             else
            {
                 FormKey2 keypass = new FormKey2(pass);
                 keypass.Show();
                 
            }
            Hide(); 
        }

    }
}
