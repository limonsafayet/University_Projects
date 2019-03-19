using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class user_home_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("users");
            if (Request["load"] == null && Session["user_email"] == null)
            {
                Response.Redirect("index.aspx");
            }

            else if (Request["load"].ToString().Equals("yes"))
            {
                if(Session["user_type"].ToString().Equals("user"))
                {
                    Response.Write("<table align='center'>");

                    Response.Write("<tr>");

                    Response.Write("<td>");

                    Response.Write("<h1>User Panel</h1> ");

                    Response.Write("</br>");

                    Response.Write("</td>");

                    Response.Write("</tr>");

                    

                    Response.Write("<tr>");

                    Response.Write("<td>");

                    Response.Write("<input type='submit' value='LOGOUT' onclick='log_out()' />");

                    Response.Write("</td>");

                    Response.Write("</tr>");


                    Response.Write("</table>");
                    if(Application["count"]==null)
                    {
                        Application["count"] = 0;
                    }
                    else
                    {
                        int counter = Convert.ToInt32(Application["count"]);
                        Application["count"] = ++counter;
                    }
                    

                }
            }
        }
    }
}