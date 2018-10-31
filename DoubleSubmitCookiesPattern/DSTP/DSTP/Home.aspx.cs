using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DSTP
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie csrfCookie = Request.Cookies["CSRF_Token"];
            string csrfToken = Server.HtmlEncode(csrfCookie.Value);

            if (hdCsrfToken.Value == csrfToken)
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