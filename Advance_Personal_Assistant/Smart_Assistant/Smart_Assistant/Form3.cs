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
    public partial class ForgetPass : Form
    {
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        int r = 10;
        void Isintnum(string intnum)
        {
            int a = intnum.Length;
            for (int i = 0; i < a; i++)
            {
                if (!char.IsNumber(intnum[i]))
                {

                    //textBox2.Text = "";
                    r = 0;
                }
                else
                {
                    r = 1;
                }
            }
        }
        public ForgetPass()
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

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {
            backup.isPassword = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textUserName.Text != "" && textEmail.Text != "" && backup.Text != "")
            {
                if (IsValidEmail(textEmail.Text) == true)
                {
                    if (backup.Text.Length == 6)
                    {
                        Isintnum(backup.Text);
                        if (r == 1)
                        {

                            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
                            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Signup where Username='" + textUserName.Text + "'and Email='" + textEmail.Text + "'and Backuppin='" + int.Parse(backup.Text) + "'", conn);


                            DataTable dt = new DataTable();
                            conn.Open();
                            sda.Fill(dt);

                            SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
                            SqlDataAdapter sda1 = new SqlDataAdapter("Select isvalid From Signup where Username='" + textUserName.Text + "'", conn1);
                            DataTable dt1 = new DataTable();
                            conn1.Open();
                            sda1.Fill(dt1);
                            string s = dt1.Rows[0][0].ToString();
                            int i = int.Parse(s);
                            if (i == 2)
                            {
                                if (dt.Rows[0][0].ToString() == "1")
                                {
                                    this.Hide();
                                    Fpasschange p = new Fpasschange();
                                    p.username(textUserName.Text);
                                    p.Show();
                                }

                                else
                                {
                                    MessageBox.Show("Wrong credentials !!\nPlease Check Your User information is invalid !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textUserName.Text = "";
                                    textEmail.Text = "";
                                    backup.Text = "";
                                    textUserName.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your account is not valid!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Hide();
                                Login l = new Login();
                                l.Show();
                            }

                           
                        }
                        else
                        {
                            MessageBox.Show("Backup pin only contain number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Backup pin must contain 6 number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill up all informations", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            
            

            
        }

        private void ForgetPass_Load(object sender, EventArgs e)
        {

        }
    }
}
