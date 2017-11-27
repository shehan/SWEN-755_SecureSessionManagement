using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class User
    {
        string username;
        string password;
        string roles;
        //List<Role> roles = new List<Role>();

        public User(string username, string password, string roles)
        {
            this.username = username;
            this.password = password;
            this.roles = roles;
            //var roleSet = roles.Split(';');
            //foreach(var role in roleSet)
            //{
            //    switch (role)
            //    {
            //        case "hr": this.roles.Add(Role.HR);break;
            //        case "finance": this.roles.Add(Role.FINANCE); break;
            //        case "sales": this.roles.Add(Role.SALES); break;
            //        case "admin": this.roles.Add(Role.ADMIN); break;
            //    }
            //}
        }

        public bool Authenticate(string password)
        {
            return this.password.Equals(password);
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        //public List<Role> Roles { get => roles; set => roles = value; }
        public string Roles { get => roles; set => roles = value; }
    }

    public enum Role
    {
        HR,
        FINANCE,
        SALES,
        ADMIN
    }
}