using STP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STP
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    HttpCookie sessionId = HttpContext.Current.Request.Cookies.Get("Session_Id");

            //    foreach(DictionaryEntry entry in Session_.HtSessions)
            //    {
            //        if(entry.Key.ToString() == sessionId.Value)
            //        {
            //            csrfToken = entry.Value.ToString();

            //            hdCsrfToken.Value = csrfToken;
            //            Label1.Text = csrfToken;
            //        }
            //    }                
            //}
        }

        [WebMethod]
        public static string OnSubmit()
        {
            return "it worked";
        }

        [WebMethod]
        public static string GetCSRFToken()
        {
            string csrfToken = string.Empty;
            HttpCookie sessionId = HttpContext.Current.Request.Cookies.Get("Session_Id");

            foreach (DictionaryEntry entry in Session_.HtSessions)
            {
                if (entry.Key.ToString() == sessionId.Value)
                {
                    csrfToken = entry.Value.ToString();
                    return csrfToken;                   
                }
            }

            throw new Exception("Invalid Session");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session_.HtSessions != null)
            {
                foreach (DictionaryEntry session in Session_.HtSessions)
                {
                    HttpCookie current_ssid = HttpContext.Current.Request.Cookies.Get("Session_Id");
                    string current_csrf = hdCsrfToken.Value;

                    if ((string)session.Key == current_ssid.Value.ToString())
                    {
                        if ((string)session.Value == current_csrf)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Success!');", true);
                        }

                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Fail!');", true);
                        }                            
                    }
                }
            }
        }
    }
}