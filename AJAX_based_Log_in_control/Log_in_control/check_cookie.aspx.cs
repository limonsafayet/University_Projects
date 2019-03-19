using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class check_cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["load"] == null && Session["user_email"] == null)
            {
                Response.Redirect("index.aspx");
            }

            else if (Request["load"].ToString().Equals("yes"))
            {
                try
                {
                    if (HttpContext.Current.Request.Cookies["userInfo"]["username"] == null)
                    {
                        Response.Redirect("index.aspx");
                    }
                    else
                    {
                        string cookie_username = HttpContext.Current.Server.HtmlEncode(HttpContext.Current.Request.Cookies["userInfo"]["username"]);
                        if (cookie_username.Equals(""))
                        {
                            Response.Write("empty");
                        }
                        else
                        {
                            DataSet1TableAdapters.userTableAdapter uta = new DataSet1TableAdapters.userTableAdapter();
                            DataSet1.userDataTable result = new DataSet1.userDataTable();
                            result = uta.GetData();
                            Int32 counter1 = 0;
                            Int32 counter2 = 0;
                            string type1 = "user";
                            string type2 = "admin";
                            foreach (DataSet1.userRow row in result)
                            {
                                // Response.Write("q");
                                // Response.Write(cookie_username);
                                //Response.Write(cookie_password);
                                if (cookie_username.Equals(row["user_email"].ToString()) && type1.Equals(row["user_type"].ToString()))
                                {
                                    //Response.Write("hhhhhh");
                                    counter1 = 1;
                                }

                                if (cookie_username.ToString().Equals(row["user_email"].ToString()) && type2.Equals(row["user_type"].ToString()))
                                {

                                    counter2 = 1;
                                }
                            }
                            if (counter1 == 1)
                            {
                                Session.Add("user_email", cookie_username);
                                //Session.Add("user_pass", cookie_password);
                                Session.Add("user_type", "user");
                                Response.Write("users");
                            }
                            if (counter2 == 1)
                            {
                                Session.Add("user_email", cookie_username);
                                //Session.Add("user_pass", cookie_password);
                                Session.Add("user_type", "admin");
                                Response.Write("admin");
                            }
                        }
                    }

                }
                catch (Exception)
                {
                    Response.Redirect("index.aspx");
                }
                
                
                //string cookie_username = HttpContext.Current.Server.HtmlEncode(HttpContext.Current.Request.Cookies["userInfo"]["username"]);
                //tring cookie_password = HttpContext.Current.Server.HtmlEncode(HttpContext.Current.Request.Cookies["userInfo"]["hashpassword"]);

                //Response.Write(cookie_username);
                //Response.Write(cookie_password);
                
            }
            
        }
    }
}