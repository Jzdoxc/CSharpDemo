using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMangerment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            account.Text = "\0";
            password.Text = "\0";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(account.Text.Equals("admin")))
            {
                MessageBox.Show("用户名错误");
            }
            else if (!(password.Text.Equals("admin")))
            {
                MessageBox.Show("密码错误");
            }
            else
            {
                MessageBox.Show("登陆成功");
                Form2 from2 = new Form2();
                from2.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
