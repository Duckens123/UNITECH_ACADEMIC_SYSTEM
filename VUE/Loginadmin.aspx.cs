using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE;

namespace UNITECH_ACADEMEIC_SYSTEME.VUE
{
    public partial class Loginadmin : System.Web.UI.Page
    {
        ControlleureUser conuser = new ControlleureUser();
        Admin adm = new Admin();
        
        void Connecter()
        {
            bool trouv = conuser.Rechercheruser(tpinuser.Text, tpassuser.Text);

            if (!trouv)
            {
                lmsg.Text = "PIN ou mot de passe incorrect";
            }
            else
            {
                Session["pseudo"] = tpinuser.Text;
                Response.Redirect("Admin.aspx");
                adm.ListeDropdown();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Connecter();
        }
    }
}