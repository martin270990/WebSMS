using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Ports at = new Ports();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txb_numLinea_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_sendmsg_Click(object sender, EventArgs e)
        {
            at.AbrirPuertoSerie();
            if (at.enviarMensaje(txb_numLinea.Text, Txb_mensaje.Text) > 0)
            {
                lbl_result_msg.Text = "Resultado del envio: Exitoso";
                lbl_result_msg.ForeColor = System.Drawing.Color.Green;
            }
            else{
                lbl_result_msg.Text = "Resultado del envio: Fallido";
                lbl_result_msg.ForeColor = System.Drawing.Color.Red;
            }
            at.cerrarpuert();
        }
    }
}