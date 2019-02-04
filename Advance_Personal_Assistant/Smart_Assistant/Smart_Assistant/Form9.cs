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
    public partial class Form9 : Form
    {
        int r = 10;
        string aa;
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
        Form f;
        public void username(string a,Form v)
        {
            aa = a;
            f = v;
        }
       // SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=smartassistant;Integrated Security=True");
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
        public Form9()
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

        private void textPassword_OnValueChanged(object sender, EventArgs e)
        {
            textPassword.isPassword = true;
        }

        private void backup_OnValueChanged(object sender, EventArgs e)
        {
            backup.isPassword = true;
        }

        private void textRPassword_OnValueChanged(object sender, EventArgs e)
        {
            textRPassword.isPassword = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textPassword.Text != "" && textRPassword.Text != "" && backup.Text != "" && Currentpass.Text !="")
            {
                SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Password From Signup where Username='" + aa + "'", conn1);

                DataTable dt1 = new DataTable();
                conn1.Open();
                sda1.Fill(dt1);
                string p = dt1.Rows[0][0].ToString();
                if (Currentpass.Text == p)
                {
                    if (textPassword.Text.Length >= 8)
                    {
                        if (textPassword.Text == textRPassword.Text)
                        {
                            if (backup.Text.Length == 6)
                            {
                                Isintnum(backup.Text);
                                if (r == 1)
                                {
                                    try
                                    {
                                        con.Open();

                                        string Query = "update Signup set Password= '" + textPassword.Text.ToString() + "', Backuppin= '" + int.Parse(backup.Text.ToString()) + "'where Username= '" + aa + "'";
                                        SqlCommand cmd = new SqlCommand(Query, con);

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Successfully updated!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        Form8 f8 = new Form8();
                                        f8.Show();
                                        f8.back(f, aa);
                                        this.Hide();




                                        //btnNewRecord_Click(sender, e);
                                        //ShowInfo();

                                        con.Close();
                                    }
                                    catch (Exception exp)
                                    {
                                        MessageBox.Show(exp.Message);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Backup pin will be only number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Backup pin must contain 6 number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password & Re Password dont match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must containt at least 8 caracter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Your current password is wrong\nPlease enter right password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Please fill up all informations", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            f8.back(f, aa);
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void Currentpass_OnValueChanged(object sender, EventArgs e)
        {
            Currentpass.isPassword = true;
        }
    }
}
