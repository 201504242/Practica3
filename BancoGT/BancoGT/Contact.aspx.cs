using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoGT
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void credito_click(object sender, EventArgs e)
        {
            string monto = txtmonto_credito.Text;
            string descripcion = txtdescripcion.Text;

            // codigo para verificaciones
        }
    }
}