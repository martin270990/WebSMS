using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace WebSMS
{
    class bd
    {
        SqlConnection conexion;
        SqlCommand cmd;


        public void conectar()
        {
            conexion= new SqlConnection("server=MARTIN-PC\\SQLEXPRESS ; database=sms ; integrated security = true");
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public int addMsg(String descp, String msg)
        {
            int res = 0;
            conectar();
            cmd = new SqlCommand("addMsg", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@descripcion", SqlDbType.Char, 60);
            cmd.Parameters.Add("@mensaje", SqlDbType.Char, 200);
            cmd.Parameters["@descripcion"].Value = descp;
            cmd.Parameters["@mensaje"].Value = msg;
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

        public int addUser(String name, String lastname, String mail, String user, String pass)
        {

            int res = 0;
            conectar();
            cmd = new SqlCommand("addUser", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre", SqlDbType.Char, 50);
            cmd.Parameters.Add("@apellido", SqlDbType.Char, 50);
            cmd.Parameters.Add("@mail", SqlDbType.Char, 200);
            cmd.Parameters.Add("@usuario", SqlDbType.Char, 30);
            cmd.Parameters.Add("@pass", SqlDbType.Char, 300);
            cmd.Parameters["@nombre"].Value = name;
            cmd.Parameters["@apellido"].Value = lastname;
            cmd.Parameters["@mail"].Value = mail;
            cmd.Parameters["@usuario"].Value = user;
            cmd.Parameters["@pass"].Value = pass;
            res = cmd.ExecuteNonQuery();
            conexion.Close();
            return res;
        }

        public int login(String user, String pass)
        {

            int res = 0;
            conectar();
            cmd = new SqlCommand("verifyLogin", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usuario", SqlDbType.Char, 50);
            cmd.Parameters.Add("@pass", SqlDbType.Char, 200);
            cmd.Parameters["@usuario"].Value = user;
            cmd.Parameters["@pass"].Value = pass;
            res = Convert.ToInt32(cmd.ExecuteScalar());
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