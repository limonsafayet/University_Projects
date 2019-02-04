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
    public partial class Fpasschange : Form
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

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
        public Fpasschange()
        {
            InitializeComponent();
        }
        public void username(string a)
        {
            aa = a;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textPassword.Text != "" && textRPassword.Text != "" && backup.Text != "")
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

                                    string Query = "update Signup set Password= '" + textPassword.Text.ToString() + "', Backuppin= '" + int.Parse(backup.Text.ToString()) +"'where Username= '"+aa+ "'";
                                    SqlCommand cmd = new SqlCommand(Query, con);

                                    cmd.ExecuteNonQuery();
                                    
                                    MessageBox.Show("Successfully updated!!\nNow please Login", "Successful", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                        
                                    Login l = new Login();
                                    this.Hide();
                                    l.Show();

                                   


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
                MessageBox.Show("Please fill up all informations", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            textPassword.isPassword = true;
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            textRPassword.isPassword = true;
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {
            backup.isPassword = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
