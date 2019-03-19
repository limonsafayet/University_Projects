using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class check_forget_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["load"] == null && Request["forget_email"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else if (Request["load"].ToString().Equals("yes"))
            {
                DataSet1TableAdapters.userTableAdapter uta = new DataSet1TableAdapters.userTableAdapter();
                DataSet1.userDataTable result = new DataSet1.userDataTable();

                result = uta.GetData();
                Int32 counter = 0;
                
                foreach (DataSet1.userRow row in result)
                {
                    if (Request["forget_email"].ToString().Equals(row["user_email"].ToString()) && Request["forget_ans1"].ToString().Equals(row["user_ans1"].ToString()) && Request["forget_ans2"].ToString().Equals(row["user_ans2"].ToString()))
                    {

                        counter = 1;
                    }

                }
                if(counter==1)
                {
                    Response.Write("valid");
                    Session.Add("forget_email", Request["forget_email"].ToString());
                }
                else
                {
                    Response.Write("wrong");
                }
            }
             
        }
    }
}