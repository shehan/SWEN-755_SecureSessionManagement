using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebApp
{
    /// <summary>
    /// Summary description for UtilService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class UtilService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public bool SetWindowName(string name)
        {
            var session_windowName = HttpContext.Current.Session["WindowName"];
            if (string.IsNullOrEmpty(session_windowName as string))
            {
                HttpContext.Current.Session["WindowName"] = name;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
