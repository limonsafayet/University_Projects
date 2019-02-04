using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Data.SqlClient;

namespace Smart_Assistant
{
    public partial class Form6 : Form
    {
        SpeechSynthesizer speechsynth = new SpeechSynthesizer();
        public Form6()
        {
            InitializeComponent();
        }
        string a;
        public void catchuser(string u)
        {
            a = u;
        }
        public void close(int a)
        {
            if (a == 1)
            {
                Application.Exit();
            }
            else if (a == 2)
            {
                Login l = new Login();
                this.Hide();
                l.Show();
            }
            
        }

        public void showcommmand(int j)
        {
            if (j == 1)
            {
               
                richTextBox1.Visible = true;

                richTextBox1.Text = "Hi\n" + "Hello\n" +"How are you\n"+ "What are you doing\n" + "Thank you\n" + "Tell my name\n" + "What is my name\n" + "Who are you\n" + "What time it is\n" +
                                    "What is the current time\n"+"Tell the time\n"+"Tell me date of today\n"+"Tell me the date\n"+"Tell the date\n"+"Open chrome\n"+"Open notepad\n"+
                                    "Open calculator\n" + "Open paint\n" + "Open aiub\n" + "Shut down my laptop\n" + "Close the program\n" + "Yes i am\n" + "Open facebook\n" + "Open youtube\n" + "Logout\n" + "Change voice to female\n"
                                    +"Change voice to male\n"+"Tell my date of birth\n"+"Show all commands\n"+"Hide all commands";
            }
            else if (j == 2)
            {
                richTextBox1.Visible = false;
            }
        }
        public void crome(int i)
        {
            Process proc = new Process();
            if (i == 1)
            {

            }
            Process.Start("chrome");
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
        public void work(string tex)
        {
            string text = tex.ToLower();

            if (chattext.Text != "")
            {
                if (text == "hi" || text == "hello")
                {
                    textBox1.Text = "Hello " + a;
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";
                }
                else if (text == "how are you")
                {
                    textBox1.Text = "I am fine and you?";
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";

                }
                else if (text == "what are you doing")
                {
                    textBox1.Text = "Waiting for your command master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";

                }
                else if (text == "thankyou" || text == "thank you")
                {
                    textBox1.Text = "Welcome";
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";

                }
                else if (text == "tell my name" || text == "what is my name")
                {

                    textBox1.Text = "Your are " + a;
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";
                }
                else if (text == "who are you")
                {

                    textBox1.Text = "I am your smart assistant";
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";
                }
                else if (text == "what time it is" || text == "what is the current time" || text == "tell me the current time" || text == "tell the time")
                {

                    textBox1.Text = "Right now it is " + DateTime.Now.ToLongTimeString();
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";
                }
                else if (text == "tell me date of today" || text == "tell me the date" || text == "tell the date")
                {

                    textBox1.Text = "Today is " + DateTime.Now.ToShortDateString();
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";
                }
                else if (text == "open chrome" || text == "open the chrome")
                {

                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    Process.Start("chrome");
                    chattext.Text = "";
                }
                else if (text == "open notepad")
                {

                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    Process.Start("notepad");

                    chattext.Text = "";
                }

                else if (text == "open calculator")
                {

                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    Process.Start("calc");
                    chattext.Text = "";
                }
                else if (text == "open paint")
                {

                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    Process.Start("mspaint");
                    chattext.Text = "";
                }

                else if (text == "shutdown my laptop")
                {

                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    //Process.Start("mspaint");
                    Process.Start("shutdown", "/s /t 0");
                    chattext.Text = "";
                }

                else if (text == "close the program" || text == "close program")
                {

                    textBox1.Text = "Are you sure master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";
                    nn = 1;


                }
                else if (text == "yes i am" || text == "yes")
                {
                    textBox1.Text = "Good bye master see you later";
                    speechsynth.SpeakAsync(textBox1.Text);
                    //Application.Exit();
                    this.close(nn);
                    nn = 100;
                }
                else if (text == "open facebook")
                {

                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    Process.Start("chrome", "https://www.facebook.com/");
                    chattext.Text = "";
                }
                else if (text == "open aiub")
                {

                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    Process.Start("chrome", "http://www.aiub.edu/");
                    chattext.Text = "";
                }
                else if (text == "open youtube")
                {

                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    Process.Start("chrome", "https://www.youtube.com/");
                    chattext.Text = "";
                }
                else if (text == "logout")
                {

                    textBox1.Text = "Are you sure master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    // Process.Start("chrome", "https://www.youtube.com/");
                    chattext.Text = "";
                    nn = 2;
                }
                else if (text == "change voice to female" || text == "change to female")
                {


                    speechsynth.SelectVoiceByHints(VoiceGender.Female);
                    textBox1.Text = "Changed master";
                    speechsynth.SpeakAsync(textBox1.Text);

                    chattext.Text = "";
                }
                else if (text == "change voice to male" || text == "change to male")
                {


                    speechsynth.SelectVoiceByHints(VoiceGender.Male);
                    textBox1.Text = "Changed master";
                    speechsynth.SpeakAsync(textBox1.Text);

                    chattext.Text = "";
                }
                else if (text == "tell my date of birth" || text == "tell my birthday")
                {

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("Select Dateofbirth From Signup where Username='" + a + "'", conn);


                    DataTable dt = new DataTable();
                    conn.Open();
                    sda.Fill(dt);
                    string p = dt.Rows[0][0].ToString();
                    p = p.Replace(" 12:00:00 AM", " ");  
                    textBox1.Text = p;
                   
                    speechsynth.SpeakAsync(textBox1.Text);
                    chattext.Text = "";

                }
                else if (text == "show commands" || text == "show all commands")
                {
                    //speechsynth.SelectVoiceByHints(VoiceGender.Male);
                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    this.showcommmand(1);
                    chattext.Text = "";
                }
                else if (text == "hide commands" || text == "hide" || text == "hide all commands")
                {
                    //speechsynth.SelectVoiceByHints(VoiceGender.Male);
                    textBox1.Text = "Ok master";
                    speechsynth.SpeakAsync(textBox1.Text);
                    this.showcommmand(2);
                    chattext.Text = "";
                }
                else
                {
                    textBox1.Text = "I don't understand master";
                    speechsynth.SpeakAsync(textBox1.Text);
                }

            }
            else
            {
                MessageBox.Show("Please write something first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       static int nn=100;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            work(chattext.Text);
            //string text = chattext.Text.ToLower();

            //if (chattext.Text != "")
            //{
            //    if (text == "hi" || text=="hello")
            //    {
            //        textBox1.Text = "Hello "+a;
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = ""; 
            //    }
            //    else if (text == "how are you")
            //    {
            //        textBox1.Text = "I am fine and you?";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = ""; 

            //    }
            //    else if (text == "what are you doing")
            //    {
            //        textBox1.Text = "Waiting for your command master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = "";

            //    }
            //    else if (text == "thankyou" || text == "thank you")
            //    {
            //        textBox1.Text = "Welcome";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = "";

            //    }
            //    else if (text == "tell my name" || text == "what is my name")
            //    {
                    
            //        textBox1.Text = "Your are " + a;
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = ""; 
            //    }
            //    else if (text == "who are you")
            //    {

            //        textBox1.Text = "I am your smart assistant";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = "";
            //    }
            //    else if (text == "what time it is" || text == "what is the current time" || text == "tell me the current time" || text=="tell the time")
            //    {

            //        textBox1.Text = "Right now it is " + DateTime.Now.ToLongTimeString();
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = "";
            //    }
            //    else if (text == "tell me date of today" || text=="tell me the date" || text=="tell the date")
            //    {

            //        textBox1.Text = "Today is " + DateTime.Now.ToShortDateString();
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = "";
            //    }
            //    else if (text == "open chrome" || text == "open the chrome")
            //    {

            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        Process.Start("chrome");
            //        chattext.Text = "";
            //    }
            //    else if (text == "open notepad")
            //    {

            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        Process.Start("notepad");
                   
            //        chattext.Text = "";
            //    }
                
            //    else if (text == "open calculator")
            //    {

            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        Process.Start("calc");
            //        chattext.Text = "";
            //    }
            //    else if (text == "open paint")
            //    {

            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        Process.Start("mspaint");
            //        chattext.Text = "";
            //    }
                    
            //    else if (text == "shutdown my laptop")
            //    {

            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        //Process.Start("mspaint");
            //        Process.Start("shutdown", "/s /t 0");
            //        chattext.Text = "";
            //    }
                    
            //    else if (text == "close the program" || text =="close program")
            //    {

            //        textBox1.Text = "Are you sure master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = "";
            //        nn = 1;

                    
            //    }
            //   else if (text == "yes i am" || text=="yes")
            //    {
            //        textBox1.Text = "Good bye master see you later";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        //Application.Exit();
            //        this.close(nn);
            //        nn = 100;
            //    }
            //    else if (text == "open facebook")
            //    {

            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        Process.Start("chrome","https://www.facebook.com/");
            //        chattext.Text = "";
            //    }
            //    else if (text == "open aiub")
            //    {

            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        Process.Start("chrome", "http://www.aiub.edu/");
            //        chattext.Text = "";
            //    }
            //    else if (text == "open youtube")
            //    {

            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        Process.Start("chrome", "https://www.youtube.com/");
            //        chattext.Text = "";
            //    }
            //    else if (text == "log out")
            //    {

            //        textBox1.Text = "Are you sure master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //       // Process.Start("chrome", "https://www.youtube.com/");
            //        chattext.Text = "";
            //        nn = 2;
            //    }
            //    else if (text == "change voice to female" || text == "change to female")
            //    {

                    
            //        speechsynth.SelectVoiceByHints(VoiceGender.Female);
            //        textBox1.Text = "Changed master";
            //        speechsynth.SpeakAsync(textBox1.Text);

            //        chattext.Text = "";
            //    }
            //    else if (text == "change voice to male" || text == "change to male")
            //    {


            //        speechsynth.SelectVoiceByHints(VoiceGender.Male);
            //        textBox1.Text = "Changed master";
            //        speechsynth.SpeakAsync(textBox1.Text);

            //        chattext.Text = "";
            //    }
            //    else if (text == "tell my date of birth" || text=="tell my birthday")
            //    {

            //        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
            //        SqlDataAdapter sda = new SqlDataAdapter("Select Dateofbirth From Signup where Username='" + a + "'", conn);


            //        DataTable dt = new DataTable();
            //        conn.Open();
            //        sda.Fill(dt);
            //        string p = dt.Rows[0][0].ToString();
            //        textBox1.Text = p;
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        chattext.Text = "";

            //    }
            //    else if (text == "show commands" || text == "show all commands")
            //    {
            //           //speechsynth.SelectVoiceByHints(VoiceGender.Male);
            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        this.showcommmand(1);
            //        chattext.Text = "";
            //    }
            //    else if (text == "hide commands" || text == "hide" || text == "hide all commands")
            //    {
            //           //speechsynth.SelectVoiceByHints(VoiceGender.Male);
            //        textBox1.Text = "Ok master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //        this.showcommmand(2);
            //        chattext.Text = "";
            //    }
            //    else
            //    {
            //        textBox1.Text = "I don't understand master";
            //        speechsynth.SpeakAsync(textBox1.Text);
            //    }
               
            //}
            //else
            //{
            //    MessageBox.Show("Please write something first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //setting
            Form8 f8 = new Form8();
            f8.Show();
            f8.back(this, a);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.catchuser(a);

            this.Hide();
            f1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void chattext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chattext_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void chattext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("You pressed enter! Good job!");
               // bunifuThinButton21.Handle;
                work(chattext.Text);
            }
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                chattext.Text = richTextBox1.SelectedText;
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            chattext.Text = richTextBox1.SelectedText;
        }
    }
}
