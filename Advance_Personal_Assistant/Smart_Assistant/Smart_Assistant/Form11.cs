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
    public partial class Form11 : Form
    {
        public Form11()
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }
        string v;
        public void admin(string a)
        {
            v = a;
        }
        public void suser()
        {
            textName.Text = v;
        }
        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
            f12.showinfo();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            this.Hide();
            f13.Show();
            f13.showinfo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
