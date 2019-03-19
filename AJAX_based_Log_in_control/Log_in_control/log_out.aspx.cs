using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class log_out : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["load"] == null)
            {
                Response.Redirect("index.aspx");
            }

            else if (Request["load"].ToString().Equals("yes"))
            {
                Session.Abandon();

                if (HttpContext.Current.Request.Cookies["userInfo"] != null)
                {
                    SetCookie("");
                }
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