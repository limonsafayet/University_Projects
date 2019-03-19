using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class block_check : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //  Response.Write(Session["count"].ToString());
            // }
            //Response.Write(Session["count"].ToString());

            int counter = Convert.ToInt32(Session["count"]);
            if(counter>2)
            {
                DateTime current_time = DateTime.Now;
                DateTime after;
                if(counter==3)
                {
                    Session["block"] = 1;
                    after = current_time.AddMinutes(5);
                    Session["timeduration"] = after.ToString("HH:mm:ss tt");
                    //Response.Write("3 times fail");
                    // Response.End();
                   // Session["time"] = 1;
                }
                if(counter==6)
                {
                    Session["block"] = 2;
                    after = current_time.AddMinutes(15);
                    Session["timeduration"] = after.ToString("HH:mm:ss tt");
                    // Response.Write("3 times fail");
                  //  Session["time"] = 1;
                }
                else
                {
                    //Session["time"] = 0;
                    Response.Write("noooo");
                }

            }
            else
            {
                Response.Write("noooo");
              //  Session["timeduration"] = 0;
            }
        }
    }
}