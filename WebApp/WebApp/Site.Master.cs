using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();

            System.Web.Security.FormsAuthentication.SignOut();
            Response.Redirect("login.aspx");
        }
    }
}