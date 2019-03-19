using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class reg_1 : System.Web.UI.Page
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

                Response.Write("<h1>Welcome To Registation</h1> ");

                Response.Write("</br>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>First Name</p> ");

                Response.Write("<input type='text' id='fname' placeholder='Enter First Name'>");

                Response.Write("<p id='fnameErr'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>Last Name</p> ");

                Response.Write("<input type='text' id='lname' placeholder='Enter Last Name'>");

                Response.Write("<p id='lnameErr'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p>Email</p> ");

                Response.Write("<input type='text' id='email' placeholder='Enter Email'>");

                Response.Write("<p id='emailErr'></p>");

                Response.Write("<p id='emailexistErr'></p>");

                Response.Write("</td>");

                Response.Write("</tr>");



                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<input type='submit' value='NEXT' onclick='load()' />");

                Response.Write("</td>");

                Response.Write("</tr>");


                Response.Write("</table>");
            }

            
            
        }
    }
}