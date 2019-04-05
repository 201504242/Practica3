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
                listUsuario.Items.Add(ds.Tables[0].Rows[i].ItemArray.ElementAt(0).ToString());
            }
            
        }

        public void montoInicial_click(object sender, EventArgs e)
        {
            string usuario = listUsuario.SelectedItem.Value; 
            string txtmonto = monto.Text;
            
            ds = op.IniciarMonto(usuario,txtmonto);

        }

        public void eliminar_click(object sender, EventArgs e)
        {

        }
    }
}