using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class email_check : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["load"] == null)
            {
                Response.Redirect("index.aspx");
            }

            else if (Request["load"].ToString().Equals("yes"))
            {
                DataSet1TableAdapters.userTableAdapter uta = new DataSet1TableAdapters.userTableAdapter();
                DataSet1.userDataTable result = new DataSet1.userDataTable();

                result = uta.GetData();
                Int32 count = 0;

                foreach (DataSet1.userRow row in result)
                {
                    string email = row["user_email"].ToString();

                    if (Request["reg_email"].ToString().Equals(email))
                    {
                        count = 1;
                    }


                }

                if (count == 1)
                {
                    Response.Write("EXIST");
                }
                else
                {
                    Response.Write("noooo");
                }
            }
            
        }
    }
}