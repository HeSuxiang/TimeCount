using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace timecount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int time1 = userControl11.GetTimeOfMinute();
           int time2 = userControl12.GetTimeOfMinute();
           int time3 = userControl13.GetTimeOfMinute();
           int time4 = userControl14.GetTimeOfMinute();
           int time5 = userControl15.GetTimeOfMinute();

           int totalMinute = time1 + time2 + time3 + time4 + time5;
           //totalMinute = ((hour2 - hour1) * 60) + (minute2 - minute1);
           label1.Text ="总时间为" + totalMinute / 60 + "小时" + totalMinute % 60 + "分钟";
           //label1.Text = "总时间为" + time1 + "分钟";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.ResetAllTime();
            userControl12.ResetAllTime();
            userControl13.ResetAllTime();
            userControl14.ResetAllTime();
            userControl15.ResetAllTime();
        }
 
 

   
    }
}
