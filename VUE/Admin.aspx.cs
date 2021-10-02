
using OfficeOpenXml;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE;

namespace UNITECH_ACADEMEIC_SYSTEME.VUE
{
    public partial class Admin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        ControlleureEtudiant conetu = new ControlleureEtudiant();
        ControlleureUser conuser = new ControlleureUser();
        ControlleurCours controcours = new ControlleurCours();
        ControlleurFaculte controfacul = new ControlleurFaculte();
        Controlleurepaiement conpaie = new Controlleurepaiement();
        Controlleurnote contronote = new Controlleurnote();
        StringBuilder table = new StringBuilder();
        string currentdate = DateTime.Now.ToString("MM/dd/yy hh:mm:ss");
        public void RechercherModifierEtudiant()
        {
            {
                bool trouv = conetu.Rechercheretudiant(tmatricule.Text);

                if (!trouv)
                {
                   // lmsg.Text = "Cet etudiant n'existe pas!";
                }
                else
                {
                    tnometu.Text = conetu.Getnom();
                    tprenom.Text = conetu.Getprenom();
                    tlieunaissance.Text = conetu.Getlieunaissance();
                    tadresse.Text = conetu.Getadresse();
                    tnationalite.Text = conetu.Getnationalite();
                    temail.Text = conetu.Getemail();
                    tphone.Text = conetu.Getphone();
                    tdescription.Text = conetu.Getdescription();
                    tdatenaiss.Text = conetu.Getdatenaissance();
                    cmbsexe.Text = conetu.GetSexe();
                    btnsave.Visible = false;
                    btnupdate.Visible = true;

                }
            }
        }

        public void RechercherEtudiant()
        {
            {
                bool trouv = conetu.Rechercheretudiant(trecheretunote.Text);

                if (!trouv)
                {
                    // lmsg.Text = "Cet etudiant n'existe pas!";
                }
                else
                {
                    tnometu.Text = conetu.Getnom();
                    tprenom.Text = conetu.Getprenom();
                    nomcompletnote.Text = conetu.Getprenom() + " " + conetu.Getnom();

                }
            }
        }


        public void RechercherEtudiantNote()
        {
            {
                bool trouv = conetu.Rechercheretudiant(trecheretunote.Text);

                if (!trouv)
                {
                    // lmsg.Text = "Cet etudiant n'existe pas!";
                }
                else
                {
                    nomcompletnote.Text = conetu.Getnom() + " " + conetu.Getprenom();
                    tdiscipline.Text = conetu.Getdiscipline();
                }
            }
        }

        public void ListeDropdown()
        {


            cmdoption.DataSource = controfacul.GetListerFaculte();
            cmdoption.DataBind();
            cmdoption.DataTextField = "nomfaculte";
            cmdoption.DataValueField = "idfaculte";
            cmdoption.DataBind();

            ddoptionnote.DataSource = controfacul.GetListerFaculte();
            ddoptionnote.DataBind();
            ddoptionnote.DataTextField = "nomfaculte";
            ddoptionnote.DataValueField = "idfaculte";
            ddoptionnote.DataBind();

            cmdfaculter.DataSource = controfacul.GetListerFaculte();
            cmdfaculter.DataBind();
            cmdfaculter.DataTextField = "nomfaculte";
            cmdfaculter.DataValueField = "idfaculte";
            cmdfaculter.DataBind();

            ddoption.DataSource = controfacul.GetListerFaculte();
            ddoption.DataBind();
            ddoption.DataTextField = "nomfaculte";
            ddoption.DataValueField = "idfaculte";
            ddoption.DataBind();


            cmdanneeaca.DataSource = conetu.GetListeAnneeaccademique();
            cmdanneeaca.DataBind();
            cmdanneeaca.DataTextField = "anneaccademique";
            cmdanneeaca.DataValueField = "idanneeaccademique";
            cmdanneeaca.DataBind();

            ddannee.DataSource = conetu.GetListeAnneeaccademique();
            ddannee.DataBind();
            ddannee.DataTextField = "anneaccademique";
            ddannee.DataValueField = "idanneeaccademique";
            ddannee.DataBind();


            ddanneese.DataSource = conetu.GetListeAnneeaccademique();
            ddanneese.DataBind();
            ddanneese.DataTextField = "anneaccademique";
            ddanneese.DataValueField = "idanneeaccademique";
            ddanneese.DataBind();

            ddanneeaca.DataSource = conetu.GetListeAnneeaccademique();
            ddanneeaca.DataBind();
            ddanneeaca.DataTextField = "anneaccademique";
            ddanneeaca.DataValueField = "idanneeaccademique";
            ddanneeaca.DataBind();


            cmbmodalite.DataSource = conpaie.GetListeModalite();
            cmbmodalite.DataBind();
            cmbmodalite.DataTextField = "typemodalite";
            cmbmodalite.DataValueField = "idmodalite";
            cmbmodalite.DataBind();


            cmbcours.DataSource = controcours.GetListecours();
            cmbcours.DataBind();
            cmbcours.DataTextField = "titrecours";
            cmbcours.DataValueField = "idcours";
            cmbcours.DataBind();


        }

        public void Tableetudiant()
        {
            if (!this.IsPostBack)
            {
                gridEtudiant.DataSource = conetu.GetlisteStudent();
                gridEtudiant.DataBind();
                //Populating a DataTable from database.
                DataTable dt = conetu.GetlisteStudent();

                //Building an HTML string.
                StringBuilder html = new StringBuilder();

                //Table start.
                html.Append("<table class='table table-striped table-hover' ID='tableetu'>");

                //Building the Header row.
                html.Append("<tr>");
                html.Append("<th>");
                html.Append("Matricule");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Nom");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Prénom");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Sexe");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Email");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Niveau");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Option");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Modalité");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Année accademique");
                    html.Append("</th>");
                
                html.Append("</tr>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }
                

                //Table end.
                html.Append("</table>");

                //Append the HTML string to Placeholder.
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
        }
        private void BindGridData()
        {
           
            gridEtudiant.DataSource = conetu.GetlisteStudent();
            gridEtudiant.DataBind();
            gridEtudiant.Attributes.Add("bordercolor", "black");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["pseudo"] != null)
            {
                profil.Text =Session["pseudo"].ToString();
            }

            Tableetudiant();
            Response.Redirect("Loginadmin.aspx");
            if (!IsPostBack)
            {            
                this.BindGridData();
                ListeDropdown();
            }
            
        }
        

        public void videretudiant()
        {
            tnometu.Text = "";
            tprenom.Text = "";
            tlieunaissance.Text = "";
            tadresse.Text = "";
            tnationalite.Text = "";
            cmbcrps.Text = "";
            temail.Text = "";
            tphone.Text = "";
            tdescription.Text = "";
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                string codeetudiant = conetu.Creercodeetudiant(tnometu.Text, tprenom.Text);
                string passetu = conetu.Creerpwdetudiant();
                
                conetu.CreerEtudiant(codeetudiant, tnometu.Text, tprenom.Text, cmbsexe.Text, tdatenaiss.Text, tlieunaissance.Text, tadresse.Text, tnationalite.Text, cmbcrps.Text, temail.Text, tphone.Text, cmdoption.SelectedValue, tdescription.Text, profil.Text, currentdate, passetu, cmdanneeaca.SelectedValue, cmbniveau.Text, cmbmodalite.SelectedValue);
                letudiansuc.Text = "Inscription effectué avec success, Le matricule de l'etudiant est: "+codeetudiant+ " et son mot de passe est: "+passetu;
                letudiansuc.Visible = true;
                videretudiant();
            }
            catch
            {

                letudiantech.Text = "Echec loes de l'inscription.";
                letudiantech.Visible = true;
                videretudiant();
            }

        }
        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Loginadmin.aspx");
        }

        protected void btnenregistrer_Click(object sender, EventArgs e)
        {
            conuser.CreerUser(tnomuser.Text, tprenomuser.Text, conuser.CreercodeUser(tnomuser.Text, tprenomuser.Text), conuser.CreerpwdUser(), cmbfonction.Text, profil.Text, currentdate);
        }



        protected void btnsear_Click(object sender, EventArgs e)
        {
           // RechercherEtudiant();
           
        }
        

        protected void btnrecherchen_Click(object sender, EventArgs e)
        {
            RechercherEtudiant();
            
        }

        protected void btnsavecours_Click(object sender, EventArgs e)
        {
           
            controcours.Creercours(ttitrecours.Text, coef.Text, cmdfaculter.SelectedValue, tprof.Text, cmdsession.Text,cmbniveaucours.Text);
            ttitrecours.Text = "";
            coef.Text = "";
            tprof.Text = "";
            ListeDropdown();
        }

        protected void btnsavefaculte_Click(object sender, EventArgs e)
        {
            controfacul.Creerfaculte(tnomfaculte.Text, tnbannee.Text);
            tnomfaculte.Text = "";
            tnbannee.Text = "";
            

        }

        protected void btnsaveanneaca_Click(object sender, EventArgs e)
        {
            conetu.CreerAnneeAca(tanneedeb.Text, tanneefin.Text, (tanneedeb.Text +"-"+ tanneefin.Text));
            tanneedeb.Text = "";
            tanneefin.Text = "";
           
        }

       

        protected void btnrecherupdate_Click(object sender, EventArgs e)
        {
            RechercherModifierEtudiant();
           
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            conetu.updateEtudiant(tmatricule.Text, tnometu.Text, tprenom.Text, cmbsexe.Text, tdatenaiss.Text, tlieunaissance.Text, tadresse.Text, tnationalite.Text, cmbcrps.Text, temail.Text, tphone.Text, tdescription.Text, profil.Text, currentdate, cmbmodalite.SelectedValue);
            btnupdate.Visible = false;
            btnsave.Visible = true;
            videretudiant();
           

        }

       
        protected void Button1_Click1(object sender, EventArgs e)
        {

           // ReportDocument crp = new ReportDocument();
            //crp.Load(Server.MapPath("crlistetudiants.rpt"));
            //crp.SetDataSource(conetu.GetListeEtudiant().Tables["vetudiant"]);
           // crlisteetu.ReportSource = crp;
            //crp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "List etudiants");
            //crp.ExportToHttpResponse(ExportFormatType.ExcelWorkbook, Response, false, "Etudian");
        }

        protected void btnsavenote_Click(object sender, EventArgs e)
        {
            contronote.Creernote(cmbcours.SelectedValue, trecheretunote.Text,cmbsession.Text,ddannee.Text,profil.Text,cmbniveaunote.Text,tnote.Text);
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
        }

        public void ExportExcel()
        {
            //gridEtudiant.Columns[1].Visible = false;


            var etus = conetu.GetlisteStudent();
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("etudiant");
            var totalCols = etus.Columns.Count;
            var totalRows = etus.Rows.Count;

            for (var col = 1; col <= totalCols; col++)
            {
                workSheet.Cells[1, col].Value = etus.Columns[col - 1].ColumnName;
            }
            for (var row = 1; row <= totalRows; row++)
            {
                for (var col = 0; col < totalCols; col++)
                {
                    workSheet.Cells[row + 1, col + 1].Value = etus.Rows[row - 1][col];
                }
            }
            using (var memoryStream = new MemoryStream())
            {
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment;  filename=liste_etudiant.xlsx");
                excel.SaveAs(memoryStream);
                memoryStream.WriteTo(Response.OutputStream);
                Response.Flush();
                Response.End();
            }
        }

        protected void btnexcel_Click(object sender, EventArgs e)
        {
            ExportExcel();

        }

        public void Tableetudiantby()
        {
           
                gridEtudiant.DataSource = conetu.GetlisteStudentBy(ddanneeaca.Text,ddoption.Text);
                gridEtudiant.DataBind();
                //Populating a DataTable from database.
                DataTable dt = conetu.GetlisteStudentBy(ddanneeaca.SelectedItem.ToString(), ddoption.SelectedItem.ToString());

            //Building an HTML string.
            StringBuilder html = new StringBuilder();

                //Table start.
                html.Append("<table class='table table-striped table-hover' ID='tableetu'>");

                //Building the Header row.
                html.Append("<tr>");
                html.Append("<th>");
                html.Append("Matricule");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Nom");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Prénom");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Sexe");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Email");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Niveau");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Option");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Modalité");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Année accademique");
                html.Append("</th>");

                html.Append("</tr>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }

                //Table end.
                html.Append("</table>");

                //Append the HTML string to Placeholder.
                PlaceHolder2.Controls.Add(new Literal { Text = html.ToString() });

        }

        public void NotebySSAA()
        {


            gridEtudiant.DataSource = contronote.Getmynote(ddanneese.SelectedItem.ToString(), ddsesseionan.SelectedItem.ToString());
            gridEtudiant.DataBind();
            //Populating a DataTable from database.
            DataTable dt = contronote.Getmynote(ddanneese.SelectedItem.ToString(), ddsesseionan.SelectedItem.ToString());
            object moyenne;

            //Building an HTML string.
            StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table class='table table-striped table-hover' ID='tableetu'>");

            //Building the Header row.
            html.Append("<tr>");
            html.Append("<th>");
            html.Append("Matricule");
            html.Append("</th>");
            html.Append("<th>");
            html.Append("Nom");
            html.Append("</th>");
            html.Append("<th>");
            html.Append("Prénom");
            html.Append("</th>");
            html.Append("<th>");
            html.Append("Niveau");
            html.Append("</th>");
            html.Append("<th>");
            html.Append("Note");
            html.Append("</th>");
            html.Append("<th>");
            html.Append("Cours");
            html.Append("</th>");
            html.Append("<th>");
            html.Append("Sur");
            html.Append("</th>");
            html.Append("<th>");
            html.Append("Session");
            html.Append("</th>");
            html.Append("<th>");
            html.Append("Année accademique");
            html.Append("</th>");
            html.Append("<th>");
            html.Append("Faculté");
            html.Append("</th>");

            html.Append("</tr>");

            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
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
            phanneesession.Controls.Add(new Literal { Text = html.ToString() });

        }

        public void Notebyoption()
        {
           

                gridEtudiant.DataSource = contronote.Getmynote(ddoptionnote.SelectedItem.ToString());
                gridEtudiant.DataBind();
                //Populating a DataTable from database.
                DataTable dt = contronote.Getmynote(ddoptionnote.SelectedItem.ToString());
            object moyenne;

            //Building an HTML string.
            StringBuilder html = new StringBuilder();

                //Table start.
                html.Append("<table class='table table-striped table-hover' ID='tableetu'>");

                //Building the Header row.
                html.Append("<tr>");
                html.Append("<th>");
                html.Append("Matricule");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Nom");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Prénom");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Niveau");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Note");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Cours");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Sur");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Session");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Année accademique");
                html.Append("</th>");
                html.Append("<th>");
                html.Append("Faculté");
                html.Append("</th>");

                html.Append("</tr>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
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
                phnoteoption.Controls.Add(new Literal { Text = html.ToString() });

        }
        protected void btnnoteoptio_Click(object sender, EventArgs e)
        {

            Notebyoption();
        }

        protected void btnfilter_Click(object sender, EventArgs e)
        {
            Tableetudiantby();
            PlaceHolder1.Visible = false;
        }

        protected void btnanneesession_Click(object sender, EventArgs e)
        {
            NotebySSAA();
        }

        
    }
}