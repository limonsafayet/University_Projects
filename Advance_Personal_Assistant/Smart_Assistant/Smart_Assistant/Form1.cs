using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Smart_Assistant
{
    public partial class Login : Form
    {
      
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //this.MdiParent.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.Show();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            textPassword.isPassword = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPass f = new ForgetPass();
            f.Show();

        }

       

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
            SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
            SqlDataAdapter sda2 = new SqlDataAdapter("Select Usertype From Admins where Username='" + textUserName.Text + "'and Password='" + textPassword.Text + "'", conn2);
            DataTable dt2 = new DataTable();
            conn2.Open();
            sda2.Fill(dt2);
            string s2 = dt2.Rows[0][0].ToString();
            if (s2 == "admin")
            {
                SqlConnection conn3 = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
                SqlDataAdapter sda3 = new SqlDataAdapter("Select Count(*) From Admins where Username='" + textUserName.Text + "'and Password='" + textPassword.Text + "'", conn3);


                DataTable dt3 = new DataTable();
                conn3.Open();
                sda3.Fill(dt3);
                if (dt3.Rows[0][0].ToString() == "1")
                {
                  
                        Form11 f11 = new Form11();
                        //f1.catchuser(textUserName.Text);

                        this.Hide();
                        f11.Show();
                        f11.admin(textUserName.Text);
                        f11.suser();
                    
                }

            }
            }
            
            catch
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Signup where Username='" + textUserName.Text + "'and Password='" + textPassword.Text + "'", conn);


                DataTable dt = new DataTable();
                conn.Open();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
                    SqlDataAdapter sda1 = new SqlDataAdapter("Select isvalid From Signup where Username='" + textUserName.Text + "'", conn1);
                    DataTable dt1 = new DataTable();
                    conn1.Open();
                    sda1.Fill(dt1);
                    string s = dt1.Rows[0][0].ToString();
                    int i = int.Parse(s);
                    if (i == 2)
                    {
                        Form5 f1 = new Form5();
                        f1.catchuser(textUserName.Text);

                        this.Hide();
                        f1.Show();
                    }
                   
                    else
                    {
                        MessageBox.Show("Your account is not valid\nPlease try again later!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textUserName.Text = "";
                        textPassword.Text = "";
                        textUserName.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Wrong credentials !!\nPlease Check Your User Name and Password !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUserName.Text = "";
                    textPassword.Text = "";
                    textUserName.Focus();
                }
            }


            

            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
