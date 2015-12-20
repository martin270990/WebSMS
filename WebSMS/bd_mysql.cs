using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace WebSMS
{
    class bd_mysql
    {
        MySqlConnection conexion;
        MySqlCommand cmd;
        

        public void conectar()
        {
            conexion = new MySqlConnection("Data Source=localhost; port=3306; Initial Catalog=sms; User Id=root; password=123456");
            //  conexion = new SqlConnection("server=MARTIN\\SQLEXPRESS ; database=sms ; integrated security = true");
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public int login(String user, String pass)
        {

            int res = 0;
            conectar();
            cmd = new MySqlCommand("verifyLogin", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_usuario", MySqlDbType.VarChar, 50);
            cmd.Parameters.Add("p_pass", MySqlDbType.VarChar, 200);
            cmd.Parameters["p_usuario"].Value = user;
            cmd.Parameters["p_pass"].Value = pass;
            res = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return res;
        }

       

        public int addMsg(String descp, String msg)
        {
            int res = 0;
            conectar();
            cmd = new MySqlCommand("addMsg", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@descripcion", MySqlDbType.String, 60);
            cmd.Parameters.Add("@mensaje", MySqlDbType.String, 200);            
            cmd.Parameters["@descripcion"].Value = descp;
            cmd.Parameters["@mensaje"].Value = msg;            
            res = cmd.ExecuteNonQuery();
            conexion.Close();
            return res;
        }

        public int addUser(String name, String lastname, String mail, String user, String pass)
        {

            int res = 0;
            conectar();
            cmd = new MySqlCommand("addUser", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_nombre", MySqlDbType.String, 50);
            cmd.Parameters.Add("p_apellido", MySqlDbType.String, 50);
            cmd.Parameters.Add("p_mail", MySqlDbType.String, 200);
            cmd.Parameters.Add("p_usuario", MySqlDbType.String, 30);
            cmd.Parameters.Add("p_pass", MySqlDbType.String, 300);
            cmd.Parameters["p_nombre"].Value = name;
            cmd.Parameters["p_apellido"].Value = lastname;
            cmd.Parameters["p_mail"].Value = mail;
            cmd.Parameters["p_usuario"].Value = user;
            cmd.Parameters["p_pass"].Value = pass;
            res = cmd.ExecuteNonQuery();
            conexion.Close();
            return res;
        }

        public int modificar_msg(String descp, String msg, int id)
        {
            int res = 0;
            return res;
        }

        public int eliminar(String descp, String msg, int id)
        {
            int res = 0;
            return res;
        }

        
        public int addGroup(String name_group, String user)
        {

            int res = 0;
            conectar();
            cmd = new MySqlCommand("addGrupos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_nombre_grupo", MySqlDbType.String, 50);
            cmd.Parameters.Add("p_usuario", MySqlDbType.String, 50);
            cmd.Parameters.Add("p_fecha", MySqlDbType.String, 20);
            cmd.Parameters.Add("p_estado_envio", MySqlDbType.String, 30);
            cmd.Parameters.Add("p_cant_contactos", MySqlDbType.String, 30);
            cmd.Parameters.Add("p_cant_exitosos", MySqlDbType.String, 300);
            cmd.Parameters.Add("p_cant_fallidos", MySqlDbType.String, 300);
            cmd.Parameters["p_nombre_grupo"].Value = name_group;
            cmd.Parameters["p_usuario"].Value = user;
            cmd.Parameters["p_estado_envio"].Value = "";
            cmd.Parameters["p_cant_contactos"].Value = "0";
            cmd.Parameters["p_cant_exitosos"].Value = "0";
            cmd.Parameters["p_cant_fallidos"].Value = "0";
            res = cmd.ExecuteNonQuery();
            conexion.Close();
            return res;
        }

        





        public int addCampana(String nomb, String descp, int opc, String pclv)
        {

            return 0;
        }

      /*public void addImei(String num, String port)
        {

            conectar();
            cmd = new SqlCommand("addImei", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@imei", SqlDbType.Char, 50);
            cmd.Parameters.Add("@port", SqlDbType.Char, 200);
            cmd.Parameters["@imei"].Value = num;
            cmd.Parameters["@port"].Value = port;
            cmd.ExecuteNonQuery();
            conexion.Close();
        }/*/

    }
}
