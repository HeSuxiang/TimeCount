using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace timecount
{
    public partial class UserControl1 : UserControl
    {
       // private int[] hours = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23};

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 24; i++)
            //{
            //    listBox1.Items.Add(hours[i]);
            //    comboBox1.Items.Add(i);
            //}
           //comboBox1.SelectedItem = 08;
        }

        public int GetTimeOfMinute()
        {
           

            int totalMinute = 0;

            int hour1 = int.Parse(comboBox1.Text);
            int hour2 = int.Parse(comboBox3.Text);

            int minute1 = int.Parse(comboBox2.Text);
            int minute2 = int.Parse(comboBox4.Text);
            //label5.Text = "hour1=" + hour1 + " hour2=" + hour2 + " minute1=" + minute1 + " minute2=" + minute2;

            //检查输入时间长度。第一个时间必须必第二个时间早，否则抛异常
            if ( CheckTimeFormat() == false || (hour1 > hour2))
            {
                label5.Text = "时间错误";
                throw (new Exception());
            }

            //第一个时间必须必第二个时间早，否则抛异常
            if ((hour1 >= hour2) && (minute1 > minute2))
            {
                label5.Text = "时间错误";
                throw(new Exception());
            }


            totalMinute = ((hour2 - hour1) * 60) + (minute2 - minute1);
            label5.Text = "" + totalMinute / 60 + "小时" + totalMinute % 60 + "分钟";
            return totalMinute;
        }


        public Boolean CheckTimeFormat()
        {



            if ((comboBox1.Text.Length > 2) || (comboBox2.Text.Length > 2) || (comboBox3.Text.Length > 2) || (comboBox4.Text.Length > 2))
            {
                return false;
            }

            return true;
        }

        //重置焦点
        public void getFocus()
        {
            comboBox1.Focus();
        }

        //重置白天时间
        public void ResetAllLightTime()
        {
            
            comboBox1.Text = "08";
            comboBox2.Text = "00";
            comboBox3.Text = "08";
            comboBox4.Text = "00";
            label5.Text = "单次时间";
        }

        //重置晚上加班时间
        public void ResetAllNightTime()
        {
            comboBox1.Text = "18";
            comboBox2.Text = "00";
            comboBox3.Text = "18";
            comboBox4.Text = "00";
            label5.Text = "单次时间";
        }

 
    }
}
