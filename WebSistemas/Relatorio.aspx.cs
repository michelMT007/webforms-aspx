using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSistemas
{
    public partial class Relatorio : System.Web.UI.Page
    {
        String Produto = "Arroz Sete Grãos - Tio João ";
           
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ReportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("Produto", Produto));
            ReportViewer1.LocalReport.Refresh();
        }
    }
}