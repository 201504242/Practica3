using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoGT
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void trans_click(object sender, EventArgs e)
        {
            string monto = txtmonto.Text;
            string cuenta = txtcuenta.Text;

            // codigo para verificaciones
        }
    }
}