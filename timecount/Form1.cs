using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using System.IO;

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
            int time1;
            int time2;
            int time3;
            int time4;
            int time5;
            try
            {
                 time1 = userControl11.GetTimeOfMinute();
                 time2 = userControl12.GetTimeOfMinute();
                 time3 = userControl13.GetTimeOfMinute();
                 time4 = userControl14.GetTimeOfMinute();
                 time5 = userControl15.GetTimeOfMinute();
            }
            catch (Exception ex)
            {
                MessageBox.Show("时间错误，请检查输入");
                return;
            }

            int totalMinute = time1 + time2 + time3 + time4 + time5;
            //totalMinute = ((hour2 - hour1) * 60) + (minute2 - minute1);
            String allTime = "总时间为" + totalMinute / 60 + "小时" + totalMinute % 60 + "分钟";
            label1.Text = allTime;
            //label1.Text = "总时间为" + time1 + "分钟";
            WriteToText(DateTime.Now.ToString() + "\t" + allTime);
            label3.Text = allTime + ",结果已记录到timecout.txt";
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.ResetAllTime();
            userControl12.ResetAllTime();
            userControl13.ResetAllTime();
            userControl14.ResetAllTime();
            userControl15.ResetAllTime();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label2, "Power By cuisanzhang@163.com");
        }


        private void WriteToText(String line)
        {
            //https://www.cnblogs.com/hushaojun/p/10601022.html
            //在将文本写入文件前，处理文本行
            //StreamWriter一个参数默认覆盖
            //StreamWriter第二个参数为false覆盖现有文件，为true则把文本追加到文件末尾
            //try
            //{
            String path = Directory.GetCurrentDirectory();
            path += "\\timecout.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path, true))
            {

                file.WriteLine(line);// 直接追加文件末尾，换行 
                file.Flush();
                file.Close();

            }
            //}
            //catch (Exception e)
            //{
            //}
        }

    }
}
