﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Text;
using System.Collections;

public partial class Inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Web.HttpContext.Current.Session["usuario"] = "USU";
        System.Web.HttpContext.Current.Session["cuenta"] = "00000";
        System.Web.HttpContext.Current.Session["codigo"] = "----";
     }

    protected void registro_click(object sender, EventArgs e)
    {
        string usuario = txtusuario.Text;
        string contra = txtcontra.Text;
        string correo = txtcorreo.Text;
        string nombre = txtnombre.Text;
        // codigo para verificaciones
    }

    protected void login_click(object sender, EventArgs e)
    {
        string usuario = login_usuario.Text;
        string contra = login_contra.Text;
        string codigo = login_codigo.Text;
        // codigo para verificaciones
    }

}