using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace Log_in_control
{
    public partial class update_pass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["load"] == null && Request["forget_pass"] == null)
            {
                Response.Redirect("index.aspx"); 
            }
            else if (Request["load"].ToString().Equals("yes"))
            {
                string hash = GetMd5HashData(Request["forget_pass"].ToString());
                DataSet1TableAdapters.userTableAdapter uinfo = new DataSet1TableAdapters.userTableAdapter();

                DataSet1.userDataTable res = new DataSet1.userDataTable();



                uinfo.UpdatePassQuery(hash, Session["forget_email"].ToString());
                
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