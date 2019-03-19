using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography;

namespace Log_in_control
{
    public partial class validation_check : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["load"] == null && Request["user_email"]==null)
            {
                Response.Redirect("index.aspx");
            }

            else if (Request["load"].ToString().Equals("yes"))
            {
                // Response.Write("yes");
                if (Session["count"] == null)
                {
                    Session["count"] = 0;
                }
                string hash = GetMd5HashData(Request["user_pass"].ToString());
                DataSet1TableAdapters.userTableAdapter uta = new DataSet1TableAdapters.userTableAdapter();
                DataSet1.userDataTable result = new DataSet1.userDataTable();
                result = uta.GetData();
                Int32 counter1 = 0;
                Int32 counter2 = 0;
                string type1 = "user";
                string type2 = "admin";
                foreach (DataSet1.userRow row in result)
                {
                    if (Request["user_email"].ToString().Equals(row["user_email"].ToString()) && hash.Equals(row["user_pass"].ToString()) && type1.Equals(row["user_type"].ToString()))
                    {

                        counter1 = 1;
                    }

                    if (Request["user_email"].ToString().Equals(row["user_email"].ToString()) && hash.Equals(row["user_pass"].ToString()) && type2.Equals(row["user_type"].ToString()))
                    {

                        counter2 = 1;
                    }
                }
                if(counter1==1)
                {
                    Session["count"] = 0;
                    Session.Add("user_email", Request["user_email"].ToString());
                   // Session.Add("user_pass", hash);
                    Session.Add("user_type", "user");
                    Response.Write("users");
                }
                else if(counter2==1)
                {
                    Session["count"] = 0;
                    Session.Add("user_email", Request["user_email"].ToString());
                    //Session.Add("user_pass", hash);
                    Session.Add("user_type", "admin");
                    Response.Write("admin");
                }
                else
                {
                    //Response.Write("wrong");
                    int counter = Convert.ToInt32(Session["count"]);
                    Session["count"] = ++counter;
                    Response.Write(Session["count"]);

                }
            }
        }

        public static string GetMd5HashData(string hashstring)
        {
            MD5CryptoServiceProvider test = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(hashstring);
            data = test.ComputeHash(data);
            string md5Hash = Encoding.ASCII.GetString(data);

            return md5Hash;
        }
    }
}