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
    public partial class insert_value : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["load"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else if (Request["load"].ToString().Equals("yes"))
            {
                string hash = GetMd5HashData(Request["reg_pass"].ToString());

                DataSet1TableAdapters.userTableAdapter uinfo = new DataSet1TableAdapters.userTableAdapter();

                DataSet1.userDataTable res = new DataSet1.userDataTable();

                uinfo.InsertQuery(Request["reg_email"].ToString(), Request["reg_firstname"].ToString(), Request["reg_lastname"].ToString(), Request["reg_phone"].ToString(), Request["reg_ans_1"].ToString(), Request["reg_ans_2"].ToString(), hash, Request["reg_type"].ToString());
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