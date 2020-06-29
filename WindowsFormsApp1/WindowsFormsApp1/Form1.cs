using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour, minute, second;
        string alarmHour, alarmMinute;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
                comboBox1.Items.Add(i);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int j = 0; j < 60; j++)
                comboBox2.Items.Add(j);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            hour = DateTime.Now.Hour;
            label2.Text = hour.ToString();
            label3.Text = minute.ToString();
            label4.Text = second.ToString();
            ring_alarm();
        }
        void ring_alarm()
        {
            if (alarmHour == hour.ToString() && alarmMinute == minute.ToString()&& second.ToString() == "0")
            {


                axWindowsMediaPlayer1.URL = "C:\\Users\\annev\\Downloads\\Alarm-Fast-A1-www.fesliyanstudios.com.mp3";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = minute.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = second.ToString();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            void ring_alarm()
            {
                if (alarmHour == hour.ToString() && alarmMinute == minute.ToString() && second.ToString() == "0")
                {


                    axWindowsMediaPlayer1.URL = "C:\\Users\\annev\\Downloads\\Alarm-Fast-A1-www.fesliyanstudios.com.mp3";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = hour.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = comboBox1.Text;
            alarmMinute = comboBox2.Text;
        }
    }
}
