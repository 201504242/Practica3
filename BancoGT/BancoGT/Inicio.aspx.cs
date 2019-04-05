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
            /* if (txt_usuario.Text.Equals("") && txt_contrasena.Text.Equals(""))
             {
                 MessageBox.Show("Error, los campos deben de estar completos");
             }
             else if (txt_usuario.Text.Equals("") && !txt_contrasena.Text.Equals(""))
             {
                 MessageBox.Show("Error, el campo usuario no puede ser vacio");
             }
             else if (!txt_usuario.Text.Equals("") && txt_contrasena.Text.Equals(""))
             {
                 MessageBox.Show("Error, el campo password no puede ser vacio");
             }*/
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
                Console.WriteLine("Error, falta numero o letra");
            }
            else if (ArregloUsua.Length > 12)
            {
                Console.WriteLine("Error");
            }
            else if (ArregloPass.Length != 8)
            {
                Console.WriteLine("Error el password debe de ser de tamanio 8");
            }

            else
            {
                DataSet ds = new DataSet();
                // int id_usuario = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                ds = op.Crear_Usuario(txtusuario.Text, txtcontra.Text, txtnombre.Text, txtcorreo.Text);
                Response.Redirect("Default.aspx");
            }
        }

        protected void registro_click(object sender, EventArgs e)
        {
            /*string usuario = txtusuario.Text;
            string contra = txtcontra.Text;
            string correo = txtcorreo.Text;
            string nombre = txtnombre.Text;
            // codigo para verificaciones
            if (true)
            {
                System.Web.HttpContext.Current.Session["usuario"] = usuario;
                Response.Redirect("Default");
            }*/
            CrearUsuario();
            

        }

        protected void login_click(object sender, EventArgs e)
        {
            string usuario = login_usuario.Text;
            string contra = login_contra.Text;
            string codigo = login_codigo.Text;
            // codigo para verificaciones
        }
    }
}