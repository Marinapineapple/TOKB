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
    public partial class FormKey2 : Form
    {
        private Encrypt encrypt = new Encrypt();
        private string pass;
        int counter = 0;

        public FormKey2(string pass)
        {
            InitializeComponent();
            this.pass = pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string key = textBox1.Text;
            
            if (counter < 2)
            {
                if (key == "")
                {
                    textBox1.Text = System.Convert.ToString("Введите ключ");
                }

                else if (encrypt.CheckPass(pass, key))
                { 
                            counter = 0;
                            FormKey keynew = new FormKey(encrypt.Write(pass));
                            keynew.Show();
                            
                }    
                
                else
                {
                    counter++;
                    MessageBox.Show("Неверный пароль", "Закрытие", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Веели неверный пароль более 3 раз", "Закрытие", MessageBoxButtons.OK);
                this.Close();
            }

        }
    }
}
