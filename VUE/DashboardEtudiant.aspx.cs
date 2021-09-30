using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNITECH_ACADEMEIC_SYSTEME.VUE
{
    public partial class DashboardEtudiant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnbulletin_Click(object sender, EventArgs e)
        {
            ReportDocument crp = new ReportDocument();
            crp.Load(Server.MapPath("crNotes.rpt"));
            rpbulletin.ReportSource = crp;
            crp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Bulletin");

        }
    }
}