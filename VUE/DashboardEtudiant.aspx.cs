using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE;

namespace UNITECH_ACADEMEIC_SYSTEME.VUE
{
    public partial class DashboardEtudiant : System.Web.UI.Page
    {
        Controlleurnote connote = new Controlleurnote();
        public void Tableetudiant()
        {
            
                DataTable dt = connote.Getmynotestu(profil.Text, ddsession.SelectedItem.ToString());
            object moyenne;
                //Building an HTML string.
                StringBuilder html = new StringBuilder();

                //Table start.
                html.Append("<table class='table table-striped table-hover'>");

                //Building the Header row.
                html.Append("<tr>");
                html.Append("<th>");
                html.Append("Cours");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Note");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Sur");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Session");
                html.Append("</th>");


                html.Append("</tr>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                        html.Append("<td>");
                        html.Append(row["titrecours"]);
                        html.Append("</td>");
                        html.Append("<td>");
                        html.Append(row["note"]);
                        html.Append("</td>");
                        html.Append("<td>");
                        html.Append(row["coef"]);
                        html.Append("</td>");
                        html.Append("<td>");
                        html.Append(row["session"]);
                        html.Append("</td>");
                    html.Append("</tr>");
                }
            moyenne = dt.Compute("Avg(note)", "");
            html.Append("</tr>");
            html.Append("<td>");
            html.Append("<h5> Moyenne </h5>");
            html.Append("</td>");
            html.Append("<td>");
            html.Append("<h5> " + moyenne.ToString() + "</h5>");
            html.Append("</td>");
            html.Append("</tr>");


            //Table end.
            html.Append("</table>");

                //Append the HTML string to Placeholder.
                tablebulletin.Controls.Add(new Literal { Text = html.ToString() });
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["pseudo"] != null)
            {
                profil.Text = Session["pseudo"].ToString();
            }

            
            //Response.Redirect("Loginetudiant.aspx");

            ReportDocument crpt = new ReportDocument();
            crpt.Load(Server.MapPath("crNotes.rpt"));
            crpnoteetu.ReportSource = crpt;

        }

        protected void btnbulletin_Click(object sender, EventArgs e)
        {
            ReportDocument crp = new ReportDocument();
            crp.Load(Server.MapPath("crNotes.rpt"));
            rpbulletin.ReportSource = crp;
            crp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Bulletin");

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Tableetudiant();
        }
    }
}