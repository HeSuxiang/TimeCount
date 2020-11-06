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



        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label2, "Power By cuisanzhang@163.com");
            button2.PerformClick();
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            //悬浮置顶窗口
            this.TopMost = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int time1;
            int time2;
            int time3;
            int time4;
            int time5;
            int time6;
            int time7;
            try
            {
                 time1 = userControl11.GetTimeOfMinute();
                 time2 = userControl12.GetTimeOfMinute();
                 time3 = userControl13.GetTimeOfMinute();
                 time4 = userControl14.GetTimeOfMinute();
                 time5 = userControl15.GetTimeOfMinute();
                 time6 = userControl16.GetTimeOfMinute();
                 time7 = userControl17.GetTimeOfMinute();
            }
            catch (Exception ex)
            {
                //输入时间错误
                label1.Text = "时间错误，请检查输入";
                return;
            }

            int LightTime = time1 + time2 + time3 + time4 + time5;
            //totalMinute = ((hour2 - hour1) * 60) + (minute2 - minute1);
            String light = "白天总时间为" + LightTime / 60 + "小时" + LightTime % 60 + "分钟,  ";


            int NightTime = time6 + time7;
            String night = "加班总时间为" + NightTime / 60 + "小时" + NightTime % 60 + "分钟";

            String allTime = light + night; 
            label1.Text = allTime;
            
            //label1.Text = "总时间为" + time1 + "分钟";
            WriteToText(DateTime.Now.ToString() + "\t" + allTime);
            label3.Text = allTime + ",结果已记录到timecout.txt";
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.getFocus();

            userControl11.ResetAllLightTime();
            userControl12.ResetAllLightTime();
            userControl13.ResetAllLightTime();
            userControl14.ResetAllLightTime();
            userControl15.ResetAllLightTime();

            userControl16.ResetAllNightTime();
            userControl17.ResetAllNightTime();
            label1.Text =  "请输入时间";
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



        //左、右方向键，及回车键切换控件焦点
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
           

            switch (keyData)
            {
                case Keys.Left:
                    System.Windows.Forms.SendKeys.Send("+{Tab}");;  //向左改成+Tab
                    return true;
                case Keys.Right:
                    System.Windows.Forms.SendKeys.Send("{Tab}"); //向右改成Tab
                    return true;
                case Keys.Enter:
                    System.Windows.Forms.SendKeys.Send("{Tab}"); //确认改成Tab
                    return true;
                case Keys.PageUp:
                    userControl11.getFocus(); //PaegDown切换白天输入焦点
                    return true;
                case Keys.PageDown:
                    userControl16.getFocus(); //PaegDown切换晚上输入焦点
                    return true;
                case Keys.End:
                    button1.PerformClick(); //End 计算
                    return true;
                case Keys.Delete:
                    button2.PerformClick(); //Delete 重置
                    return true;

                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);   //其他键按默认处理
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //悬浮置顶窗口
            if (checkBox1.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

 
 

 
 

    }








}
