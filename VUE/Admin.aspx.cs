using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE;


namespace UNITECH_ACADEMEIC_SYSTEME.VUE
{
    public partial class Admin : System.Web.UI.Page
    {
        ControlleureEtudiant conetu = new ControlleureEtudiant();
        ControlleureUser conuser = new ControlleureUser();
        ControlleurCours controcours = new ControlleurCours();
        ControlleurFaculte controfacul = new ControlleurFaculte();
        Controlleurepaiement conpaie = new Controlleurepaiement();
        Controlleurnote contronote = new Controlleurnote();
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

            cmdfaculter.DataSource = controfacul.GetListerFaculte();
            cmdfaculter.DataBind();
            cmdfaculter.DataTextField = "nomfaculte";
            cmdfaculter.DataValueField = "idfaculte";
            cmdfaculter.DataBind();

            cmdoption.DataSource = controfacul.GetListerFaculte();
            cmdoption.DataBind();
            cmdoption.DataTextField = "nomfaculte";
            cmdoption.DataValueField = "idfaculte";
            cmdoption.DataBind();


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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["pseudo"] != null)
            {
                profil.Text =Session["pseudo"].ToString();
            }


            // Response.Redirect("Loginadmin.aspx");
            ListeDropdown();
            
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
                conetu.CreerEtudiant(codeetudiant, tnometu.Text, tprenom.Text, cmbsexe.Text, tdatenaiss.Text, tlieunaissance.Text, tadresse.Text, tnationalite.Text, cmbcrps.Text, temail.Text, tphone.Text, cmdanneeaca.SelectedValue, tdescription.Text, profil.Text, currentdate, passetu, cmdanneeaca.SelectedValue, cmbniveau.Text, cmbmodalite.SelectedValue);
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
        }

        protected void btnloadreport_Click(object sender, EventArgs e)
        {
           
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
            contronote.Creernote(cmbcours.SelectedValue, trecheretunote.Text,cmbsession.Text,ddannee.SelectedValue,profil.Text,cmbniveaunote.Text,tnote.Text);
        }
    }
}