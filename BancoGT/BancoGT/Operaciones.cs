using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BancoGT
{
    public class Operaciones
    {
        String conexion = "data source=DESKTOP-N6I4NNI\\SQLEXPRESS;Initial Catalog=practica35;Integrated Security=True";
        SqlConnection con;

        public DataSet consultar_usuario(string usuario, string password, int id_usuario)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("Get_permisos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {

            }
            return ds;
        }

        public DataSet Crear_Usuario(String usuario, String contrasena, string nombre, string correo)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("Crear_Usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", contrasena);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(ds);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, el usuario no se ha podido crear");
            }

            return ds;
        }
    }
}
