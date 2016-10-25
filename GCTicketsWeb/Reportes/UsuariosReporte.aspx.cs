using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using BLL;

namespace GCTicketsWeb.Reportes
{
    public partial class UsuariosReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Reportes(ReportViewer1);
        }
        }

        private void Reportes(ReportViewer rv)
        {
            rv.LocalReport.DataSources.Clear();
            rv.ProcessingMode = ProcessingMode.Local;
            rv.LocalReport.ReportPath = @"Reportes\UsuariosReport.rdlc";
            ReportDataSource sourse = new ReportDataSource("Usuarios", UsuariosClass.ListadoDt("1=1"));
            rv.LocalReport.DataSources.Add(sourse);
            rv.LocalReport.Refresh();
        }
    }
}