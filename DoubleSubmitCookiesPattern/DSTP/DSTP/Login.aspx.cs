using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DSTP
{
    public partial class Login : System.Web.UI.Page
    {
        private const string SessionCookie = "_SessionCookie";

        protected void Page_Load(object sender, EventArgs e)
        {
            divFail.Visible = false;
            lblFail.Visible = false;
            lblFail.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "Test") && (txtPassword.Text == "123"))
            {
                SessionIDManager manager = new SessionIDManager();
                string sessionId = manager.CreateSessionID(HttpContext.Current);

                HttpCookie sessionCookie = new HttpCookie("Session_Id");
                sessionCookie.Value = sessionId;
                Response.Cookies.Add(sessionCookie);

                HttpCookie csrfCookie = new HttpCookie("CSRF_Token");
                csrfCookie.Value = Guid.NewGuid().ToString("N");
                Response.Cookies.Add(csrfCookie);
                
                Response.Redirect("Home.aspx");
            }

            else
            {
                divFail.Visible = true;
                lblFail.Visible = true;
                lblFail.Text = "Invalid Credintials";
            }
        }
    }
}