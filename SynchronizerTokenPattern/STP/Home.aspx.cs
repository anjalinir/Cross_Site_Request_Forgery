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
        private string _antiXsrfTokenValue;
        private static Hashtable htSessions = new Hashtable();

        public static Hashtable HtSession
        {
            get { return htSessions; }
            set { htSessions = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie sessionId = HttpContext.Current.Request.Cookies.Get("Session_Id");

                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                htSessions.Add(sessionId, _antiXsrfTokenValue);

                hdCsrfToken.Value = _antiXsrfTokenValue;
                Label1.Text = _antiXsrfTokenValue;
            }
        }

        [WebMethod]
        public static string GetCSRFToken(string csrfToken)
        {
            if (HtSession != null)
            {
                foreach(DictionaryEntry session_ in HtSession)
                {
                    HttpCookie sessionId = HttpContext.Current.Request.Cookies.Get("Session_Id");
                    if ((string)session_.Key == sessionId.ToString())
                    {
                        if ((string)session_.Value == csrfToken)
                            return "Success";
                    }

                    else
                    {
                        throw new Exception("Invalid Session");
                    }
                }
            }

            return null;
        }
    }
}