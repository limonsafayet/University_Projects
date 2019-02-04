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
    public partial class Signup : Form
    {
        int r=10;
       // string DOBText = DateTime.Today.Date.ToString();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
        public Signup()
        {
            InitializeComponent();
        }

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
        void Isintnum(string intnum)
        {
            int a = intnum.Length;
            for (int i = 0; i < a; i++)
            {
                if (!char.IsNumber(intnum[i]))
                {
                   
                    //textBox2.Text = "";
                    r= 0;
                }
                else
                {
                    r= 1;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            textPassword.isPassword = true;
            if (IsValidEmail(textEmail.Text) == false && richTextBox1.Visible == false)
            {
                MessageBox.Show("Please check the signup rules", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Visible = true;
            }
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            textRPassword.isPassword = true;
            if (textPassword.Text.Length < 8 && richTextBox1.Visible == false)
            {
                MessageBox.Show("Please check the signup rules", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {
            backup.isPassword = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                richTextBox1.Visible = true;
                //bunifuTextbox1.Visible = true;
            }
            else
            {
                richTextBox1.Visible = false;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int j = 1;
         //  MessageBox.Show(DOBText);
          // MessageBox.Show(DOB.Value.ToString());
            
            if (textName.Text != "" && textEmail.Text != "" && textPassword.Text != "" && textRPassword.Text != "" && backup.Text != "" && DOB.Value.ToString() != "")
            {
                if (textName.Text.Length >= 6)
                {
                    if (IsValidEmail(textEmail.Text) == true)
                    {
                        if (textPassword.Text.Length >= 8 )
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

                                            string Query = "INSERT INTO Signup(Username,Email,Password,Backuppin,Dateofbirth,isvalid) VALUES('" + textName.Text.ToString() + "','" + textEmail.Text.ToString() + "','"
                                                            + textPassword.Text.ToString() + "','" + int.Parse(backup.Text.ToString()) + "','" + DOB.Value.ToString()+"','" + j + "')";
                                            SqlCommand cmd = new SqlCommand(Query, con);

                                            cmd.ExecuteNonQuery();
                                        
                                            MessageBox.Show("SignUp is done successfully \nThankyou for SignUp\nPlease wait untill verification of your account is not done","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                            this.Hide();
                                            Login l = new Login();
                                            l.Show();
                                            con.Close();
                                            //f1.catchuser(textName.Text);

                                        }
                                        catch 
                                        {
                                            MessageBox.Show("User Name is already exist \nPlease try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            con.Close();
                                        }
                                    }
                                    else
                                    {
                                        backup.Text = "";
                                        MessageBox.Show("Backup pin will be only number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                   
                                }
                                else
                                {
                                    backup.Text = "";
                                    MessageBox.Show("Backup pin must contain 6 number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                textPassword.Text = "";
                                textRPassword.Text = "";
                                MessageBox.Show("Password & Re Password dont match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }
                        else
                        {
                            textPassword.Text = "";
                            MessageBox.Show("Password must containt at least 8 caracter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        textEmail.Text = "";
                        MessageBox.Show("Email is not valid \nEmail will be like [email@example.com]", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    textName.Text = "";
                    MessageBox.Show("User Name must containt at least 6 caracter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill up all informations", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

             
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void textName_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
               // this.femail();
                textEmail.Focus();
                textEmail.Text = "";

            }
            
            
        }

        private void textEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                // this.femail();
                textPassword.Focus();
                textPassword.Text = "";

            }
           
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                // this.femail();
                textRPassword.Focus();
                textRPassword.Text = "";

            }
        }

        private void textRPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                // this.femail();
                backup.Focus();
                backup.Text = "";

            }
        }

        private void textEmail_OnValueChanged(object sender, EventArgs e)
        {
            if (textName.Text.Length < 6 && richTextBox1.Visible == false)
            {
                MessageBox.Show("Please check the signup rules", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Visible = true;

            }
        }

        private void DOB_onValueChanged(object sender, EventArgs e)
        {
            if (backup.Text.Length != 6 && richTextBox1.Visible == false)
            {
                MessageBox.Show("Please check the signup rules", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Visible = true;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

       

       

        

        
    }
}
