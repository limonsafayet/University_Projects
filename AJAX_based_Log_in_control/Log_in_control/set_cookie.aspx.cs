using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class set_cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["load"] == null && Session["user_email"] == null)
            {
                Response.Redirect("index.aspx");
            }

            else if (Request["load"].ToString().Equals("yes"))
            {
                Response.Write(Session["user_email"].ToString());
                HttpContext.Current.Response.Cookies["userInfo"]["username"] = Session["user_email"].ToString();
                //HttpContext.Current.Response.Cookies["userInfo"]["hashpassword"] = Session["user_pass"].ToString();
                HttpContext.Current.Response.Cookies["userInfo"]["lastVisit"] = DateTime.Now.ToString();
                HttpContext.Current.Response.Cookies["userInfo"].Expires = DateTime.Now.AddDays(365);

                HttpCookie aCookie = new HttpCookie("userInfo");
                aCookie.Values["username"] = Session["user_email"].ToString();
                //aCookie.Values["hashpassword"] = Session["user_pass"].ToString();
                aCookie.Values["lastVisit"] = DateTime.Now.ToString();
                aCookie.Expires = DateTime.Now.AddDays(1);
                HttpContext.Current.Response.Cookies.Add(aCookie);
            }
        }
    }
}