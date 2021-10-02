using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE;

namespace UNITECH_ACADEMEIC_SYSTEME.VUE
{
    public partial class Loginetudiant : System.Web.UI.Page
    {
        ControlleureEtudiant conetu = new ControlleureEtudiant();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Connecter()
        {
            bool trouv = conetu.RechercherLoginetudiant(tpinstudent.Text, tpassstudent.Text);

            if (!trouv)
            {
                lmsg.Text = "PIN ou mot de passe incorrect";
            }
            else
            {
                Session["pseudo"] = tpinstudent.Text;
                Response.Redirect("DashboardEtudiant.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Connecter();
        }
    }
}