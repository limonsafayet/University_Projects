using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Assistant
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string a;
        public void catchuser(string u)
        {
            a = u;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.catchuser(a);
            this.Hide();
            f6.Show();
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 s7 = new Form7();
            s7.Show();
            s7.catchuser(a);
           // s7.load();

        }
        static int i = 1;
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                panel1.Visible = true;
                i = 2;
            }
            else if (i == 2)
            {
                panel1.Visible = false;
                i = 1;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            f8.back(this, a);
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
