using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoGT
{
    public partial class Usuarios : System.Web.UI.Page
    {
        Operaciones op = new Operaciones();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = op.usua();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            int correlativo = Convert.ToInt32(row.Cells[1].Text);
            string usuari = Convert.ToString(row.Cells[3].Text);
            op.Eliminar_Usuario(correlativo);
            Response.Redirect("Usuarios");
            alerta.Text = "EL usuario" + usuari + "se elimino correctamente";
        }
    }
}