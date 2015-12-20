using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace WebSMS
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        MySqlConnection conexion = new MySqlConnection("Data Source=localhost; port=3306; Initial Catalog=sms; User Id=root; password=123456");
        bd_mysql bd = new bd_mysql();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void name_group_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_crt_group_Click(object sender, EventArgs e)
        {
            string user = Session["login_id"].ToString();
            if (bd.addGroup(name_group.Text, user) > 0)
            {
                lbl_result_group.Text = "Se ha creado el grupo exitosamente";
                Server.Transfer("contacts.aspx");
            }
            else
            {
                lbl_result_group.Text = "No se pudo crear el grupo";
            }
        }

        protected void btn_group_Click(object sender, EventArgs e)
        {

        }

       
    }
}