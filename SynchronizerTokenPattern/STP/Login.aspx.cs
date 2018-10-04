using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STP
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

                ///testing..................
                ///

                HttpCookie sessionCookie = new HttpCookie("Session_Id");
                sessionCookie.Value = sessionId;
                Response.Cookies.Add(sessionCookie);
                Response.Redirect("Home.aspx");


                //HttpCookie sessionCookie = new HttpCookie("sessionID", SessionCookie);
                //sessionCookie.Value = sessionId;
                //HttpCookie userCookie = new HttpCookie("username", txtUsername.Text);
                //sessionCookie.Value = sessionId;
                ////////////
                //Response.AddHeader("username", txtUsername.Text);
                //Response.AddHeader("sessionID", sessionId);
                
                //_antiXsrfTokenValue = Guid.NewGuid().ToString("N");

                //htSessions.Add(sessionId, _antiXsrfTokenValue);
                
                //Response.Redirect("Home.aspx");
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