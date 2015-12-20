using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSMS
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        bd_mysql bases = new bd_mysql();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["login_id"]==null)
            {
                lbl_error.Text = "No se ha iniciado sesión. Por favor ingrese nuevamente.";
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (txb_user.Text == "" & txb_pass.Text == "")
            {
                lbl_error.Text="Los campos usuario y contraseña se encuentran vacíos. Intente nuevamente.";
            }
            else
            {
                if (bases.login(txb_user.Text, txb_pass.Text) > 0)
                {
                    Session["login_id"] = txb_user.Text;
                    Server.Transfer("index.aspx");
                }
                else
                {
                    lbl_error.Text="No existe el usuario en el sistema" + "\nPor favor cree uno nuevo o intente nuevamente";
                }
            }
        }

        protected void txb_user_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Server.Transfer("registro.aspx");
        }
    }
}