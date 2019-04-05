using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoGT
{
    public partial class About : Page
    {
        Operaciones op = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void trans_click(object sender, EventArgs e)
        {            
            DataSet ds2 = new DataSet();
            DataSet ds1 = new DataSet();
            string ccuenta = System.Web.HttpContext.Current.Session["cuenta"].ToString();
            ds2 = op.saldoMayor(Convert.ToInt32(ccuenta), Convert.ToDecimal(txtmonton.Text));
            ds1 = op.consultar_cuenta(Convert.ToInt32(txtcuenta.Text));
            if (Convert.ToInt32(txtmonton.Text) > 0)
            {
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToInt32(ds2.Tables[0].Rows[0][0]) >= 0)
                    {
                        DataSet ds = new DataSet();
                        ds = op.transferir(Convert.ToDecimal(txtmonton.Text), Convert.ToInt32(txtcuenta.Text), Convert.ToInt32(ccuenta));
                        msg.Text = ("Exito! Transferencia Realizada a"+txtcuenta.Text);
                    }
                    else
                    {
                        msg.Text = ("Error, el monto es mayor que el saldo actual");
                        Console.WriteLine("Error, el monto es mayor que el saldo actual");
                    }
                }

            }
            else
            {
                msg.Text =("Error, la cuenta no existe");
            }
        }
    }
}