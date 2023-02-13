using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSistemas
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = "110022";
            string Nome = "Sorvete";
            string Descricao = "Sorvete Napolitano morango, chocolate, creme";
            string Preco = "129,99";

            List<ReportParameter> lstParam = new List<ReportParameter>();

            lstParam.Add(new ReportParameter("Nome", Nome));
            lstParam.Add(new ReportParameter("Id", id));
            lstParam.Add(new ReportParameter("Descricao", Descricao));
            lstParam.Add(new ReportParameter("Preco", Preco));
            DataSet dataset = new DataSet();
           
            //ReportParameter param = List<new ReportParameter>();
        }
    }
}