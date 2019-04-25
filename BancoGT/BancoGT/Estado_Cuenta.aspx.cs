using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;

namespace BancoGT
{
    public partial class Estado_Cuenta : System.Web.UI.Page
    {
        Operaciones op = new Operaciones();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ccuenta = System.Web.HttpContext.Current.Session["cuenta"].ToString();
            ds = op.EstadoCuenta(Convert.ToInt32(ccuenta));
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ConvertorPDF()
    {

        string attachment = "attachment; filename=EstadoCuenta.pdf";

        Response.ClearContent();

        Response.AddHeader("content-disposition", attachment);

        Response.ContentType = "application/pdf";

        StringWriter stw = new StringWriter();

        HtmlTextWriter htextw = new HtmlTextWriter(stw);

        GridView1.RenderControl(htextw);

        Document document = new Document();

        PdfWriter.GetInstance(document, Response.OutputStream);

        document.Open();       

        StringReader str = new StringReader(stw.ToString());

        HTMLWorker htmlworker = new HTMLWorker(document);

        htmlworker.Parse(str);

        document.Close();

        Response.Write(document);

        Response.End(); 
        }

        protected void imprimir_Click(object sender, EventArgs e)
        {
            ConvertorPDF();
        }

        public override void VerifyRenderingInServerForm(Control control)
        { }
    }
}