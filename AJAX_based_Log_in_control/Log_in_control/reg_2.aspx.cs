using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class reg_2 : System.Web.UI.Page
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

                Response.Write("<p>Phone</p> ");

                Response.Write("<input type='text' id='phone' placeholder='Enter Phone Number'>");

                Response.Write("<p id='phoneErr'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>Question 1 : Who was your first school friend?</p> ");

                Response.Write("<input type='text' id='question1' placeholder='Enter The Answer'>");

                Response.Write("<p id='question1Err'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>Question 2 : What is the first name of your oldest niece?</p> ");

                Response.Write("<input type='text' id='question2' placeholder='Enter The Answer'>");

                Response.Write("<p id='question2Err'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>Password</p> ");

                Response.Write("<input type='password' id='pass' placeholder='Enter Password'>");

                Response.Write("<p id='passErr'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>Confirm Password</p> ");

                Response.Write("<input type='password' id='cpass' placeholder='Enter Confirm Password'>");

                Response.Write("<p id='cpassErr'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");



                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<input type='submit' value='SUBMIT' onclick='load_reg_2()' />");

                Response.Write("</td>");

                Response.Write("</tr>");

                Response.Write("</table>");
            }


            
        }
    }
}