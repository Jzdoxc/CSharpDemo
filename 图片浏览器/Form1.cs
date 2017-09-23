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
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);

        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta >= 0)
            {
                pictureBox1.Width = (int)(pictureBox1.Width * 1.1);//因为Widthh和Height都是int类型，所以要强制转换一下-_-||  
                pictureBox1.Height = (int)(pictureBox1.Height * 1.1);
                pictureBox1.Location=new System.Drawing.Point(500, 0);
            }
            else
            {
                pictureBox1.Width = (int)(pictureBox1.Width * 0.9);
                pictureBox1.Height = (int)(pictureBox1.Height * 0.9);
                pictureBox1.Location = new Point(300, 0);
            }
        }

        List<string> list = new List<string>();
        int x = 0;
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] path = Directory.GetFiles(@"C:\Users\anpenghe\Documents\Tencent Files\1487759857\Image\Group");
            string[] path2 = Directory.GetFiles(@"C:\Users\anpenghe\Pictures\Camera Roll");
            for (int i = 0; i < path.Length; i++)
            {
                list.Add(path[i]);
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = list[listBox1.SelectedIndex];
        }


        private void ShowPic()
        {
            listBox1.SetSelected(x, true);
            pictureBox1.ImageLocation = list[x++];
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ShowPic();
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
            timer1.Interval = trackBar1.Value * 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Move(pictureBox1.ImageLocation, @"C:\Users\anpenghe\Pictures\Camera Roll\" +DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpg");
            x++;
            ShowPic();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }
    }
}
