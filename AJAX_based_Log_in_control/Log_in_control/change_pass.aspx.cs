using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class change_pass : System.Web.UI.Page
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

                Response.Write("<p>New Password</p> ");

                Response.Write("<input type='password' id='forget_pass' placeholder='Enter New Password'>");

                Response.Write("<p id='forget_passErr'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>New Confirm Password</p> ");

                Response.Write("<input type='password' id='forget_cpass' placeholder='Enter New Confirm Password'>");

                Response.Write("<p id='forget_cpassErr'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");



                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<input type='submit' value='SUBMIT' onclick='change_pass_new()' />");

                Response.Write("</td>");

                Response.Write("</tr>");

                Response.Write("</table>");
            }
        }
    }
}