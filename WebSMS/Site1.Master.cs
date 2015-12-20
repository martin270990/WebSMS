using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSMS
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_id"]==null)
            {
                Server.Transfer("login.aspx");
            }
            else
            {
                id_login.Text = "Bienvenido: " + Session["login_id"];
            }
        }
    }
}