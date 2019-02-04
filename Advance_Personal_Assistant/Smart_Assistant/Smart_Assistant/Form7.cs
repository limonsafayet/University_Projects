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
    public partial class Form7 : Form
    {
        SpeechSynthesizer speechsynth1 = new SpeechSynthesizer();
        SpeechRecognitionEngine receng = new SpeechRecognitionEngine();
        Choices choice = new Choices();

        SpeechRecognitionEngine receng1 = new SpeechRecognitionEngine();
        Choices choice1 = new Choices();
        public void showcommmand(int j)
        {
            if (j == 1)
            {

                richTextBox1.Visible = true;

                richTextBox1.Text = "Hi\n" + "Hello\n" +"How are you\n"+ "What are you doing\n" + "Thank you\n" + "Tell my name\n" + "What is my name\n" + "Who are you\n" + "What time it is\n" +
                                    "What is the current time\n" + "Tell the time\n" + "Tell me date of today\n" + "Tell me the date\n" + "Tell the date\n" + "Open chrome\n" + "Open notepad\n" +
                                    "Open calculator\n" + "Open paint\n" + "Open aiub\n" + "Shut down my laptop\n" + "Close the program\n" + "Yes i am\n" + "Open facebook\n" + "Open youtube\n" + "Logout\n" + "Change voice to female\n"
                                    + "Change voice to male\n" + "Tell my date of birth\n" + "Show all commands\n" + "Hide all commands\n"+"Pause";
            }
            else if (j == 2)
            {
                richTextBox1.Visible = false;
            }
        }
        public Form7()
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
        private void Form7_Load(object sender, EventArgs e)
        {
            
        }
       
            //choice1.Add(new string[] { "start", "pause" });
            //GrammarBuilder gr1 = new GrammarBuilder();
            //gr1.Append(choice1);
            //Grammar grr1 = new Grammar(gr1);
            //receng1.LoadGrammar(grr1);
            //receng1.SetInputToDefaultAudioDevice();
            ////receng.SpeechRecognized += receng_SpeechRecognized;
            //receng1.SpeechRecognized += receng1_SpeechRecognized;
            //receng1.RecognizeAsync(RecognizeMode.Multiple);
        
        //void receng1_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //    //throw new NotImplementedException()
        //    string text = e.Result.Text.ToLower();
        //    if (text == "start")
        //    {
        //        //textBox1.Text = "Hello " + a;
        //       // speechsynth1.SpeakAsync("hi" + a);
        //        // chattext.Text = "";
        //        change();
        //    }
        //    else if (text == "pause")
        //    {
        //        //speechsynth1.SpeakAsync("i am fine and you ");
        //        change();

        //    }
        //}

       

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        static int num = 1;
        public void change()
        {
            if (num == 1)
            {
                bunifuThinButton21.ButtonText = "Pause";
                pictureBox2.Visible = true;

                num = 2;
            }
            else if (num == 2)
            {
                bunifuThinButton21.ButtonText = "Start";
                pictureBox2.Visible = false;
                num = 1;
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //num = 1;
            change();
           
            if (bunifuThinButton21.ButtonText == "Pause")
            {
               // MessageBox.Show("hshsh");
               // speechsynth1.SpeakAsync("hai user");

                choice.Add(new string[] { "hello", "how are you", "thank you", "close", "who are you", "tell my name", "what time it is", "what is the current time",
                           "tell me the current time","tell me date of today","tell me the date","open chrome","open notepad","open calculator","open paint",
                           "shutdown my laptop","close the program","yes i am","open facebook","open youtube","change voice to female","change voice to male",
                           "tell my date of birth","hi","what are you doing","what is my name","tell the time","tell the date","close program","change to female","change to male",
                           "tell my birthday","show commands","show all commands","pause","hide commands","hide","hide all commands","yes","open aiub"});
                GrammarBuilder gr = new GrammarBuilder();
                gr.Append(choice);
                Grammar grr = new Grammar(gr);
                receng.LoadGrammar(grr);
                receng.SetInputToDefaultAudioDevice();
                receng.SpeechRecognized += receng_SpeechRecognized;
                receng.RecognizeAsync(RecognizeMode.Multiple);
               // choice.Add(new string[] { "hello", "how are you", "what is the current time", "open blog", "thank you", "close", "what is your name", "tell me date of today" });
                //Grammar gr = new Grammar(new GrammarBuilder(choice));
              /*  try
                {
                    speechsynth1.SpeakAsync("inside");
                    receng.RequestRecognizerUpdate();
                  //  receng.LoadGrammar(gr);
                    receng.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(receng_SpeechRecognized);
                    receng.SetInputToDefaultAudioDevice();
                    receng.RecognizeAsync(RecognizeMode.Multiple);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }*/
            }
            else
            {
                receng.RecognizeAsyncStop();
            }
            
        }
        
       static int nn=100;
        void receng_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();
            //speechsynth1.SpeakAsync("dukseyyy");
           // textBox1.Text = e.Result.Text;
            string text = e.Result.Text.ToLower();
            if (text == "hello" || text=="hi")
            {
                //textBox1.Text = "Hello " + a;
                speechsynth1.SpeakAsync("hi"+a);
               // chattext.Text = "";
            }
            else if (text == "how are you")
            {
                speechsynth1.SpeakAsync("i am fine and you ");

            }
            else if (text == "what are you doing")
            {
                speechsynth1.SpeakAsync("nothing waiting for your commands master");

            }
            else if (text == "thank you")
            {
                speechsynth1.SpeakAsync("welcome");

            }
            else if (text == "tell my name" || text=="what is my name")
            {
                    
                speechsynth1.SpeakAsync( "Your are " + a);         
            }
            else if (text == "who are you")
            {

                speechsynth1.SpeakAsync("I am your smart assistant ");
                   
            }
            else if (text == "what time it is" || text == "what is the current time" || text == "tell me the current time" || text == "tell the time")
            {

                speechsynth1.SpeakAsync( "Right now it is " + DateTime.Now.ToLongTimeString());
                    
            }
            else if (text == "tell me date of today" || text == "tell me the date" || text == "tell the date")
            {

                speechsynth1.SpeakAsync("Today is " + DateTime.Now.ToShortDateString());
                    
            }
            else if (text == "open chrome")
            {

                speechsynth1.SpeakAsync("Ok master");
                Process.Start("chrome");
              
            }
            else if (text == "pause")
            {

                speechsynth1.SpeakAsync("Ok master");
                //Process.Start("chrome");
                change();

            }
            else if (text == "open notepad")
            {

                speechsynth1.SpeakAsync("Ok master");
                Process.Start("notepad");
            }
            else if (text == "open calculator")
            { 
                speechsynth1.SpeakAsync("Ok master");
                Process.Start("calc");
            }
            else if (text == "open paint")
            { 
                speechsynth1.SpeakAsync("Ok master");
                Process.Start("mspaint");
            }
            else if (text == "shutdown my laptop")
            { 
                speechsynth1.SpeakAsync( "Ok master");
                Process.Start("shutdown", "/s /t 0");
            }
            else if (text == "close the program" || text == "close" || text == "close program")
            { 
                speechsynth1.SpeakAsync( "Are you sure master");
                nn = 1;
            }
            else if (text == "yes i am" || text=="yes")
            {
                speechsynth1.SpeakAsync("Good bye master see you later");
                this.close(nn);
                nn = 100;
            }
            else if (text == "open facebook")
            {
                speechsynth1.SpeakAsync("Ok master");
                Process.Start("chrome","https://www.facebook.com/");
            }
            else if (text == "open youtube")
            {
                speechsynth1.SpeakAsync("Ok master");
                Process.Start("chrome", "https://www.youtube.com/");
            }
            else if (text == "log out")
            {
                speechsynth1.SpeakAsync("Are you sure master");
                nn = 2;
            }
            else if (text == "change voice to female" || text == "change to female")
            {
                speechsynth1.SelectVoiceByHints(VoiceGender.Female);
                speechsynth1.SpeakAsync("Changed master");
            }
            else if (text == "change voice to male" || text == "change to male")
            {
                speechsynth1.SelectVoiceByHints(VoiceGender.Male);
                 speechsynth1.SpeakAsync("Changed master");
            }
            else if (text == "tell my date of birth" || text=="tell my birthday")
            {
               // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=smartassistant;Integrated Security=True");
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CU4B5J7;Initial Catalog=projectsmartassistant;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select Dateofbirth From Signup where Username='" + a + "'", conn);
               
                DataTable dt = new DataTable();
                conn.Open();
                sda.Fill(dt);
                string p = dt.Rows[0][0].ToString();
                p = p.Replace(" 12:00:00 AM", " ");  
                speechsynth1.SpeakAsync(p);
            }
            else if (text == "show commands" || text == "show all commands")
            {
                //speechsynth.SelectVoiceByHints(VoiceGender.Male);
                speechsynth1.SpeakAsync("Ok master");
                this.showcommmand(1);
            }
            else if (text == "hide commands" || text == "hide" || text == "hide all commands")
            {
                //speechsynth.SelectVoiceByHints(VoiceGender.Male);
                speechsynth1.SpeakAsync("Ok master");
                this.showcommmand(2);
            }
            else if (text == "open aiub")
            {

                speechsynth1.SpeakAsync("Ok master");
                Process.Start("chrome", "http://www.aiub.edu/");
                //chattext.Text = "";
            }
            else
            {
                speechsynth1.SpeakAsync("I don't understand master");
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

        private void label1_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.catchuser(a);

            this.Hide();
            f1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            f8.back(this, a);
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
