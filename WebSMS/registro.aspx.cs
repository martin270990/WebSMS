using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSMS
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        bd_mysql bases = new bd_mysql();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Server.Transfer("login.aspx");
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
                int resultado = bases.addUser(txb_nombre.Text, txb_apellido.Text,txb_correo.Text, txb_usuario.Text, txb_pass.Text);
                if (resultado > 0)
                {
                    lbl_error.Text="El Usuario ha sido creado correctamente en el sistema";
                }
                else
                {
                    lbl_error.Text="Error: No se pudo crear el usuario en el sistema, intente nuevamente";
                }
            
        }

        protected void txb_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txb_nombre_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}