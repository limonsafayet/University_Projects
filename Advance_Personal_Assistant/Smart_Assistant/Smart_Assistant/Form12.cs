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
    public partial class Form12 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
        public Form12()
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

        private void Form12_Load(object sender, EventArgs e)
        {
            //bunifuCustomDataGrid2.DataSource = getdata();
        }
       public void showinfo()
        {
            int a = 2;
            SqlDataAdapter sda = new SqlDataAdapter("Select Username,Email,Dateofbirth,isvalid from Signup where isvalid='" + a + "'", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            string b = "Yes";
            string p;
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                p = dr[2].ToString();
                p = p.Replace(" 12:00:00 AM", " ");
                dataGridView1.Rows[n].Cells[2].Value = p;
                dataGridView1.Rows[n].Cells[3].Value = b;
                //dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                //dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
            }
        }
       static int i = 1;
       private void pictureBox2_Click(object sender, EventArgs e)
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

       private void label1_Click(object sender, EventArgs e)
       {
           Form11 f11 = new Form11();
           this.Hide();
           f11.Show();
       }

       private void pictureBox4_Click(object sender, EventArgs e)
       {
           Login l = new Login();
           this.Hide();
           l.Show();
       }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           //textName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           //textEmail.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           //textBirth.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           //textValid.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); 
       }

       private void bunifuThinButton21_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Do you really want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
           {
               try
               {
                   con.Open();
                   string a = textValid.Text.ToLower();
                   if (a == "yes" || a=="y")
                   {
                       int i = 2;
                       string Query = "update Signup set isvalid= '" + i + "'where Username= '" + textName.Text + "'";
                       SqlCommand cmd = new SqlCommand(Query, con);

                       cmd.ExecuteNonQuery();

                       MessageBox.Show("Successfully updated!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       showinfo();
                       textName.Text = "";
                       textEmail.Text = "";
                       textBirth.Text = "";
                       textValid.Text = "";

                       con.Close();
                   }
                   else if (a == "no" || a=="n")
                   {
                       int i = 1;
                       string Query1 = "update Signup set isvalid= '" + i + "'where Username= '" + textName.Text + "'";
                       SqlCommand cmd1 = new SqlCommand(Query1, con);

                       cmd1.ExecuteNonQuery();

                       MessageBox.Show("Successfully updated!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       showinfo();
                       textName.Text = "";
                       textEmail.Text = "";
                       textBirth.Text = "";
                       textValid.Text = "";

                       con.Close();
                   }

               }
               catch (Exception exp)
               {
                   MessageBox.Show(exp.Message);
               }
           }
       }

       private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
       {
           textName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           textEmail.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           textBirth.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           textValid.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); 
       }

       private void pictureBox1_Click(object sender, EventArgs e)
       {

       }
       
    }
}
