using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["load"]==null)
            {
                Response.Redirect("index.aspx");
            }
            else if(Request["load"].ToString().Equals("yes"))
            {
                Response.Write("<table align='center'> ");

                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("<h1>LOGIN</h1>");
                Response.Write("</td>");
                Response.Write("</tr>");
                Response.Write("<tr>");

                Response.Write("<td>");
                Response.Write("<p>User Email</p>");
                Response.Write("<input type='text' id='useremail' placeholder='Enter User Email' />");
                Response.Write("<p id='useremailErr'></p>");
                Response.Write("</td>");
                Response.Write("</tr>");

                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("<p>User Password</p>");
                Response.Write("<input type='password' id='userpass' placeholder='Enter Password' />");
                Response.Write("<p id='userpassErr'></p>");
                Response.Write("</td>");
                Response.Write("</tr>");

                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("<input type='checkbox' id='rememberchk'>" + " " + "Remember Me");
                Response.Write("</td>");
                Response.Write("</tr>");

                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("<p align='center'><input type='submit' value='LOGIN' onclick='logcheck()' /></p>" + "</br>" );
                Response.Write("</td>");
                Response.Write("</tr>");

                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("<p align='center'><input type='submit' value='Forget Password' onclick='forget_pass()' /></p>");
                Response.Write("</td>");
                Response.Write("</tr>");

                Response.Write("<tr>");

                Response.Write("<td>");

                Response.Write("<p align='center'><input type='submit' value='Go To Registation' onclick='registation()' /></p>" + "</br>");

                Response.Write("</td>");

                Response.Write("</tr>");



                Response.Write("</table> ");

                //Session.Abandon();

                //if (HttpContext.Current.Request.Cookies["userInfo"] != null)
                //{
                  //  SetCookie("");
                //}
            }
            

        }

        public void SetCookie(string username)
        {
            HttpContext.Current.Response.Cookies["userInfo"]["username"] = username;
            //HttpContext.Current.Response.Cookies["userInfo"]["hashpassword"] = hashpassword;
            HttpContext.Current.Response.Cookies["userInfo"]["lastVisit"] = DateTime.Now.ToString();
            HttpContext.Current.Response.Cookies["userInfo"].Expires = DateTime.Now.AddDays(365);

            HttpCookie aCookie = new HttpCookie("userInfo");
            aCookie.Values["username"] = username;
            // aCookie.Values["hashpassword"] = hashpassword;
            aCookie.Values["lastVisit"] = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(aCookie);
        }
    }
}