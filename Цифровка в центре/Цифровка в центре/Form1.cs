using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Цифровка_в_центре
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string al = "абвгдеёжийклмнопрстуфхцчшщъыьэюя 0123456789";
  
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Ori(textBox1.Text);
        }
        public string Ori(string inp)
        {
            StringBuilder code = new StringBuilder();
            string s = textBox1.Text;
            string sd = textBox3.Text;
            int step = Convert.ToInt32(sd);
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < al.Length; j++)
                    if (s[i] == al[j]) code.Append(al[(j + step) % al.Length]);
            return code.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = Org(textBox2.Text);
            }

            string Org(string inp)

            {
                StringBuilder code = new StringBuilder();
                string s = textBox2.Text;
                string sd = textBox3.Text;
                int step = Convert.ToInt32(sd);
                for (int i = 0; i < s.Length; i++)
                    for (int j = 0; j < al.Length; j++)
                        if (s[i] == al[j]) code.Append(al[(j - step  + al.Length) % al.Length]);
                return code.ToString();
            }
        }
    }
}
