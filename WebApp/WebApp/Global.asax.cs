using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    if (HttpContext.Current.User.Identity is FormsIdentity)
                    {
                        FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
                        FormsAuthenticationTicket ticket = id.Ticket;
                        string userData = ticket.UserData;
                        string[] roles = userData.Split(',');
                        HttpContext.Current.User = new GenericPrincipal(id, roles);
                    }
                }
            }
        }

        void Application_AcquireRequestState(object sender, EventArgs e)
        {           
            if (this.Context.User.Identity.Name == string.Empty
                && !this.Context.User.Identity.IsAuthenticated)
            {
                try
                {
                    string username = string.Empty;
                    if (Session != null)
                        username = Session["UserId"] as string;
                    Session.Clear();
                    Session.RemoveAll();
                    Application.Contents.Remove(username);
                }
                catch(Exception error)
                {
                    Console.WriteLine(error);
                }

            }
        }

        void Session_End(object sender, EventArgs e)
        {
            string username = Session["UserId"] as string;
            if (Application[username] != null)
            {
                if (Convert.ToString(Application[username]) == username)
                {
                    Session.Clear();
                    Session.RemoveAll();
                    Application.Contents.Remove(username);
                }
            }
        }
    }
}