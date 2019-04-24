
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
        //la tuya
        String conexion = "data source=DESKTOP-N6I4NNI\\SQLEXPRESS;Initial Catalog=practica35;Integrated Security=True";
        //esta es la mia
       // String conexion = "data source=LAPTOP-L3B97VHK\\SQLEXPRESS;Initial Catalog=practica35;Integrated Security=True";
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

        public string Saldito(string usuario)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("Saldito", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {

            }
            try
            {
                return ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "";
            }
            
        }

        public DataSet listadoCreditos()
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("listadoCreditos", con);
                cmd.CommandType = CommandType.StoredProcedure;

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

        public DataSet listadoDebito()
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("Listado_Debito", con);
                cmd.CommandType = CommandType.StoredProcedure;

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

        public DataSet usua()
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("Usuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;

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

        public DataSet Eliminar_Usuario(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("Eliminar_Usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", id);
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

        public DataSet ListadoUsuario()
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("ListadoUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

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

        public DataSet obtener_cuenta(string usuario)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("Obtener_cuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);

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

        public DataSet aceptarCredito(int correlativo, int cuenta, double monton)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("aceptarCredito", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@monto", monton);
                cmd.Parameters.AddWithValue("@id_cuenta", cuenta);
                cmd.Parameters.AddWithValue("@correlativo", correlativo);
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(ds);
                con.Close();
            }
            catch (Exception e)
            {
                
            }

            return ds;
        }

        public DataSet debitar(int cuenta, double monton, int correlativo)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("Debitar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@monto", monton);
                cmd.Parameters.AddWithValue("@cuenta", cuenta);
                cmd.Parameters.AddWithValue("@correlativo", correlativo);
                cmd.Connection = con;
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                datapter.Fill(ds);
                con.Close();
            }
            catch (Exception e)
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
                SqlCommand cmd = new SqlCommand("Crear_Usuario2", con);
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

        public DataSet depositarAdmin(int monto, int cuenta)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("DepositoAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@cuenta", cuenta);
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

        public DataSet Buscarusua(int id_cuenta)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("buscar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cuenta", id_cuenta);
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

        public void insertaCredito(string descripcion,string usuario,int monto)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("insertaCredito", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        //TRANFERENCIA
        public DataSet transferir(decimal monto, int cuentaAtrans, int micuenta)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("transferir", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cuentaAtrans", cuentaAtrans);
                cmd.Parameters.AddWithValue("@micuenta", micuenta);
                cmd.Parameters.AddWithValue("@monto", monto);
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

        public DataSet EstadoCuenta(int cuenta)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("Estado_cuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cuenta", cuenta);
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

        public DataSet consultar_cuenta(int cuenta)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("consultar_cuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cuenta", cuenta);
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

        public DataSet BuscarcuentaTrans(string usuario)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("BuscarCuentaTransferir", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ususario", usuario);
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

        public DataSet saldoMayor(int cuenta, decimal monto)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("saldoMayor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cuenta", cuenta);
                cmd.Parameters.AddWithValue("@monto", monto);
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

    }
}
