using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoGT
{
    public partial class Inicio : System.Web.UI.Page
    {

        Operaciones op = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.HttpContext.Current.Session["usuario"] = "USU";
            System.Web.HttpContext.Current.Session["cuenta"] = "00000";
            System.Web.HttpContext.Current.Session["codigo"] = "----";
        }

        public void CrearUsuario()
        {
            String usua = txtusuario.Text;
            String pass = txtcontra.Text;
            var ArregloPass = pass.ToCharArray();
            var ArregloUsua = usua.ToCharArray();
            bool contNum = false;
            bool contString = false;
            foreach (char item in txtusuario.Text)
            {
                if (Char.IsNumber(item))
                {
                    contNum = true;
                }
                else if (Char.IsLetter(item))
                {
                    contString = true;
                }
            }
            if (!contString || !contNum)
            {
                alerta.Text = "Error, falta numero o letra";
                Console.WriteLine("Error, falta numero o letra");
            }
            else if (ArregloUsua.Length > 12)
            {
                alerta.Text = "Error, El nombre de usuario no debe ser mayor a 12 dígitos";
                Console.WriteLine("Error");
            }
            else if (ArregloPass.Length != 8)
            {
                alerta.Text = "Error, Debe ser una contraseña alfanumérica de 8 dígitos.";
                Console.WriteLine("Debe ser una contraseña alfanumérica de 8 dígitos.");
            }

            else
            {
                DataSet ds = new DataSet();
                // int id_usuario = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                ds = op.Crear_Usuario(txtusuario.Text, txtcontra.Text, txtnombre.Text, txtcorreo.Text);
                String dato = ds.Tables[0].Rows[0][0].ToString();
                if (dato.Equals("-1"))
                {
                    alerta.Text = "Error, Usuario ya existe";
                }
                else
                {
                    System.Web.HttpContext.Current.Session["usuario"] = txtusuario.Text;
                    System.Web.HttpContext.Current.Session["codigo"] = dato;
                    System.Web.HttpContext.Current.Session["cuenta"] = ds.Tables[0].Rows[0][1].ToString();
                    System.Web.HttpContext.Current.Session["tipo"] = "1";
                    Response.Redirect("Default.aspx");
                }                
            }
        }

        protected void registro_click(object sender, EventArgs e)
        {
            CrearUsuario();
        }

        protected void login_click(object sender, EventArgs e)
        {
            string usuario = login_usuario.Text;
            string contra = login_contra.Text;
            string codigo = login_codigo.Text;
            // codigo para verificaciones

            int bandera = 1;
            if (usuario.Length <= 0)
            {
                bandera = 0;
                alerta.Text = ("Error, ingrese usuario");
            }
            if (contra.Length <= 0)
            {
                bandera = 0;
                alerta.Text = ("Error, ingrese contrasenia");
            }
            if (codigo.Length <= 0)
            {
                bandera = 0;
                alerta.Text = ("Error, ingrese codigo");
            }
            if (usuario.Length <= 0 && contra.Length <= 0 && codigo.Length <= 0)
            {
                bandera = 0;
                alerta.Text = ("Error, ingrese los datos que se le solicitan");
            }
            if (bandera == 1)
            {
                iniciar_sesion();
            }            
        }

        public void iniciar_sesion()
        {
            DataSet ds = new DataSet();

            ds = op.consultar_usuario(login_usuario.Text, login_contra.Text, Convert.ToInt32(login_codigo.Text));
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][5].ToString() == "2")
                {
                    String rol = Convert.ToString(ds.Tables[0].Rows[0][5]);
                    System.Web.HttpContext.Current.Session["usuario"] = login_usuario.Text;
                    System.Web.HttpContext.Current.Session["codigo"] = login_codigo.Text;
                    ds = op.BuscarcuentaTrans(login_usuario.Text);
                    System.Web.HttpContext.Current.Session["cuenta"] = Convert.ToString(ds.Tables[0].Rows[0][0]);
                    System.Web.HttpContext.Current.Session["tipo"] = "1";
                    Response.Redirect("Default.aspx");
                }
                else if (ds.Tables[0].Rows[0][5].ToString() == "1")
                {
                    String rol = Convert.ToString(ds.Tables[0].Rows[0][5]);
                    System.Web.HttpContext.Current.Session["usuario"] = "Administrador";
                    System.Web.HttpContext.Current.Session["codigo"] = "Admin";
                    System.Web.HttpContext.Current.Session["cuenta"] = "";
                    System.Web.HttpContext.Current.Session["tipo"] = "0";
                    Response.Redirect("Default.aspx");
                }
            }
            else
            {
                alerta.Text = "Usuario o Password incorrecta";
                Console.WriteLine("Usuario o Password incorrecta");
            }
        }



    }
}