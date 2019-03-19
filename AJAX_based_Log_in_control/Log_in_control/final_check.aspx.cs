using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log_in_control
{
    public partial class final_check : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["timeduration"] != null)
            {
                DateTime currentTime = DateTime.Now;
                DateTime xMinsLater = DateTime.Parse(Session["timeduration"].ToString());

                
                if (currentTime.TimeOfDay <= xMinsLater.TimeOfDay)
                {
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "message", "alert('Login Blocked! 
                    Response.Write("Try After: " + xMinsLater.ToString("HH: mm:ss tt")+" Your Login Is Blocked");


                }
               
            }
        }
    }
}