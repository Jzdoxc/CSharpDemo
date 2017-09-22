using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图片浏览器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        int x = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] path = Directory.GetFiles(@"C:\Users\anpenghe\Documents\Tencent Files\1487759857\Image\Group");
            string[] newpath = Directory.GetFiles(@"C:\Users\anpenghe\Pictures\Saved Pictures");
            for (int i = 0; i < newpath.Length; i++)
            {
                list.Add(newpath[i]);
                //File.Move(path[i], @"C:\Users\anpenghe\Pictures\Saved Pictures\"+i+".jpg");
                listBox1.Items.Add(Path.GetFileName(newpath[i]));
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = list[listBox1.SelectedIndex];
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.SetSelected(x, true);
            pictureBox1.ImageLocation = list[x++];

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        bool flag = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {

            timer1.Stop();
                flag = false;
            }
            else
            {
                timer1.Start();
                flag = true;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value*100;
        }
    }
}
