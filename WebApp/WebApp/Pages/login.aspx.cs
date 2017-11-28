using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.Models;

namespace WebApp
{
    public partial class login : System.Web.UI.Page
    {
        List<User> userList;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                if (Request.IsAuthenticated && !string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))

                    Response.Redirect("unauthorized.aspx");
            }
            else
            {
                LoadUserList();
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {

            var user = userList.Find(i => i.Username.Equals(UserName.Text));
            if (user != null && user.Authenticate(UserPass.Text))
            {
                if (Application[user.Username] == null)
                {
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                    1, user.Username, DateTime.Now, DateTime.Now.AddMinutes(1), true, user.Roles, FormsAuthentication.FormsCookiePath);
                    string hash = FormsAuthentication.Encrypt(ticket);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);

                    if (ticket.IsPersistent)
                    {
                        cookie.Expires = ticket.Expiration;
                    }
                    Application[user.Username] = user.Username;
                    Session["UserId"] = user.Username;
                    Response.Cookies.Add(cookie);
                    Response.Redirect(FormsAuthentication.GetRedirectUrl(user.Username, false));
                }
                else
                {
                    Msg.Text = "You are already logged in! Please sign-out to continue.";
                }
            }
            else
            {
                Msg.Text = "Invalid User Name and/or Password";
            }
        }

        private void LoadUserList()
        {
            var inputfile = Server.MapPath(@"~/App_Data/user.csv");
            userList = new List<Models.User>();
            string[] fields;

            using (TextFieldParser parser = new TextFieldParser(inputfile))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                while (!parser.EndOfData)
                {
                    fields = parser.ReadFields();
                    userList.Add(new Models.User(fields[0], fields[1], fields[2]));
                }
            }
        }
    }
}