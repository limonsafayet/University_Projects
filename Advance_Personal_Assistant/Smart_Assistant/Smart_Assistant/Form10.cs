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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        Form f;
        string aa;
        public void username(string a, Form v)
        {
            aa = a;
            f = v;
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
        public void show()
        {
            label10.Text = aa;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Email From Signup where Username='" + aa + "'", conn);

            DataTable dt = new DataTable();
            conn.Open();
            sda.Fill(dt);
            string q = dt.Rows[0][0].ToString();
            label8.Text = q;

            SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
            SqlDataAdapter sda1 = new SqlDataAdapter("Select Dateofbirth From Signup where Username='" + aa + "'", conn1);

            DataTable dt1 = new DataTable();
            conn1.Open();
            sda1.Fill(dt1);
            string p = dt1.Rows[0][0].ToString();
            //public var z;
           // string number="";
            //int i = 0;
            
                //z[i]= p[i];
               // number = p.Substring(10);

            p = p.Replace(" 12:00:00 AM", " ");    
           
            label9.Text = p;
        }
       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            f8.back(f, aa);
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.username(aa, f);
            this.Hide();
            f9.Show();
        }

      

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = aa;
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
}
