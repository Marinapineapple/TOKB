using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace lab1
{
    class Encrypt
    {
        private string f = "file.txt";
        public string F
        {
            get
            {
                return f;
            }
        }

        private string EncPass(string pass, string key) //pass-пароль, введенный пользователем, key-ключ шифрования
        {
            string res = "";
            for (int i = 0, j = 0; i < pass.Length; i++, j++)
            {
                if (j == key.Length) j = 0;
                res += (char)(pass[i] ^ key[j]);
            }
            return res;
            
        }

        private string GenerateKey(int length = 4)
        {
            string a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string res = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            res += a[rand.Next(0, a.Length)];
            return res;
        }
        public string Write(string pass)    //pass-пароль, который нужно зашифровать в файле
       {

            string res = GenerateKey();
            StreamWriter file = new StreamWriter(f);
            file.Write(EncPass(pass, res));
            file.Close();
            return res;
       }
        public bool CheckPass(string pass, string res)
        {
           StreamReader file = new StreamReader(f);
            if (String.Equals(EncPass(pass, res), file.ReadLine()))

            {
                file.Close();
                return true;
            }
            else
            {
                file.Close();
                return false;
            }
            
        }
    }
}
