using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace alarm_clock
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        int hour, minute, second;
        string alarmHour, alarmMinute;

        private void Timer1_Tick(object sender, EventArgs e)
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
            if(alarmHour==hour.ToString() && alarmMinute == minute.ToString() && second.ToString == "0")
            {

           
            axWindowsMediaPlayer1.URL = "C:\\Users\\annev\\Downloads\\Alarm-Fast-A1-www.fesliyanstudios.com.mp3";
            }
        }
     
        private void Form1_Load(object sender, EventArgs e)
        { 
            timer1.Start();
            for( int i=0; i<24; i++)
            {

                domainUpDown1.Items.Add(i);
            }
            for (int j = 0; j < 60; j++)
            {
                domainUpDown2.Items.Add(j);
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

            domainUpDown1.Items.Add(i);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            alarmHour = domainUpDown1.Text;
            alarmMinute = domainUpDown2.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
