using System;
using System.Windows.Forms;

namespace konverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_KeyPress(object sender, EventArgs e)
        {

        }

        private void Key(object sender, ControlEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // если не число           и не  управляющий символ
            if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                //если не запатая          и  есть запатая в тексте
                if (!((e.KeyChar.ToString() == ",") && (textBox1.Text.IndexOf(",") == -1)))
                    // символ не обрабатывается
                    e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //если не запатая          и  есть запатая в тексте
            if (!((e.KeyChar.ToString() == ",") && (textBox2.Text.IndexOf(",") == -1)))
                // символ не обрабатывается
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double k; //Курс (отношение рубля к доллару
            double usd; // Цена  в долларах 
            double rub; // Цена в рублях

            label4.Text = "";
            try
            {
                // исходные данные
                usd = System.Convert.ToDouble(textBox1.Text);
                k = System.Convert.ToDouble(textBox2.Text);

                // пересчет

                rub = usd * k;

                // Вывод резултата
                label4.Text = usd.ToString("N") + " USD = " + rub.ToString("C");
            }

            catch
            {
                //ловим исключение
                if((textBox1.Text == "") ||(textBox2.Text ==""))
                {
                    MessageBox.Show("Ошибка исходных данных.\n" + "Необходимо ввести в оба поля.", "конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Ошибка исходных данных.\n" + "неверный формат данных в одном из полей.", "конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void textBox2_KeyPress(object sender, EventArgs e)
        {
            //если не запатая          и  есть запатая в тексте
            if (!((e.KeyChar.ToString() == ",") && (textBox2.Text.IndexOf(",") == -1)))
                // символ не обрабатывается
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

