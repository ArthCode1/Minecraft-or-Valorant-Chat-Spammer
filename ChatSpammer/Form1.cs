using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSpammer
{
    public partial class Form1 : Form
    {
        int intervals = 100;        
        bool start;
        bool siege = false;
        bool minecraft = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            start = true;

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter Some Text to Spam Faggot");
                start = false;

            }            
        }

        string keybind;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                keybind = "t";
                minecraft = true;
                siege = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                keybind = "{ENTER}";
                minecraft = false;
                siege = false;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            start = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            intervals = int.Parse(textBox2.Text);            
            

            string textboxtext = textBox1.Text;
            string enterkey = "{ENTER}";




            if (start == true && minecraft == false && siege == false)
            {
                
                SendKeys.Send(keybind);
                Thread.Sleep(intervals);
                SendKeys.SendWait(textboxtext);    
                SendKeys.Send(enterkey);
                Thread.Sleep(intervals);


            }

            if (start == true && minecraft == true && siege == false)
            {

                SendKeys.Send(keybind);
                Thread.Sleep(intervals);
                SendKeys.Send(textboxtext);
                SendKeys.Send(enterkey);
                Thread.Sleep(intervals);


            }

            if (start == true && minecraft == false && siege == true)
            {
                SendKeys.SendWait(keybind);
                Thread.Sleep(intervals);
                SendKeys.SendWait(textboxtext);
                SendKeys.Send(enterkey);
                Thread.Sleep(intervals);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                keybind = "t";
                minecraft = false;
                siege = true;
            }
        }
    }
}
