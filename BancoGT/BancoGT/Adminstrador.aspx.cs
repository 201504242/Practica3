using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoGT
{
    public partial class Adminstrador : System.Web.UI.Page
    {
        Operaciones op = new Operaciones();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = op.ListadoUsuario();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string usuario = ds.Tables[0].Rows[i].ItemArray.ElementAt(0).ToString();
                string cuenta = ds.Tables[0].Rows[i].ItemArray.ElementAt(1).ToString();
                listUsuario.Items.Add(usuario + " , " + cuenta);
            }
            ds = op.listadoCreditos();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        public void montoInicial_click(object sender, EventArgs e)
        {
            string usuario = listUsuario.SelectedItem.Value;
            int cuenta = Convert.ToInt32(usuario.Split(',').ElementAt(1));
            ds = op.Buscarusua(cuenta);
            string encontro = Convert.ToString(ds.Tables[0].Rows[0][0]);
            ds = op.depositarAdmin(Convert.ToInt32(monto.Text), cuenta);
            alerta.Text = "Se han Cargado Q" + monto.Text;
            Response.Redirect("Administrador");
        }

        public void eliminar_click(object sender, EventArgs e)
        {

        }
        

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            int correlativo = Int32.Parse(row.Cells[1].Text);
            int cuenta = Int32.Parse(row.Cells[2].Text);
            double monton = Double.Parse(row.Cells[3].Text);
            op.aceptarCredito(correlativo,cuenta,monton);
            Response.Redirect("Adminstrador");
            alerta.Text = "Se han Cargado Q" + monton;
            

        }
    }
}