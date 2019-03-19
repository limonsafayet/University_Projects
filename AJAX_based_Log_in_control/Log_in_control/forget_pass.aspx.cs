using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class forget_pass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["load"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else if (Request["load"].ToString().Equals("yes"))
            {
                Response.Write("<table align='center'>");

                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<h1>Forget Password</h1> ");
                
                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>User Email</p> ");

                Response.Write("<input type='text' id='forget_email' placeholder='Enter User Email'>");

                Response.Write("<p id='forget_emailErr'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>Question 1 : Who was your first school friend?</p> ");

                Response.Write("<input type='text' id='forget_ans1' placeholder='Enter The Answer'>");

                Response.Write("<p id='forget_ans1Err'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>Question 2 : What is the first name of your oldest niece?</p> ");

                Response.Write("<input type='text' id='forget_ans2' placeholder='Enter The Answer'>");

                Response.Write("<p id='forget_ans2Err'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");

                
                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p><input type='submit' value='SUBMIT' onclick='check_forget_pass()' /></p>" + "</br>");

                Response.Write("</td>");

                Response.Write("</tr>");



                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<input type='submit' value='Go To Login' onclick='load_back_login()' />");

                Response.Write("</td>");

                Response.Write("</tr>");

                Response.Write("</table>");
            }

        }
    }
}