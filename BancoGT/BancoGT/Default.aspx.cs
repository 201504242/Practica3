using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoGT
{
    public partial class _Default : Page
    {
        Operaciones op = new Operaciones();
        DataSet ds = new DataSet();

            
        protected void Page_Load(object sender, EventArgs e)
        {
            string ss = op.Saldito(System.Web.HttpContext.Current.Session["usuario"].ToString());
            saldo.Text = " Saldo:" +ss ;
        }
    }
}