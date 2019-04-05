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
                listUsuario.Items.Add(usuario +" , "+cuenta);
            }            
        }

        public void montoInicial_click(object sender, EventArgs e)
        {
            string usuario = listUsuario.SelectedItem.Value;
            int cuenta = Convert.ToInt32(usuario.Split(',').ElementAt(1));
            ds = op.Buscarusua(cuenta);
            string encontro = Convert.ToString(ds.Tables[0].Rows[0][0]);
            ds = op.depositarAdmin(Convert.ToInt32(monto.Text),cuenta);
            alerta.Text = "Se han Cargado Q" + monto.Text;
        }

        public void eliminar_click(object sender, EventArgs e)
        {

        }
    }
}