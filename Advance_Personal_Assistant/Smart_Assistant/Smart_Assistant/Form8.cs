using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Smart_Assistant
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        static int i = 1;
        private void pictureBox5_Click(object sender, EventArgs e)
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
        Form fm;
        string a;
        public void back(Form f,string v)
        {

            fm = f;
            a = v;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();


        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm.Show();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
                
            Form10 f10 = new Form10();
            f10.username(a, fm);
            f10.show();
            this.Hide();
            f10.Show();
            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            Form9 f9 = new Form9();
            f9.username(a, fm);
            this.Hide();
            f9.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
   
    }
}
