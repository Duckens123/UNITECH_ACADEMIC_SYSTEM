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
        string currentdate = DateTime.Now.ToString("MM/dd/yy hh:mm:ss");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            conetu.CreerEtudiant(conetu.Creercodeetudiant(tnometu.Text,tprenom.Text),tnometu.Text,tprenom.Text,cmbsexe.Text,tdatenaiss.Text,tlieunaissance.Text,tadresse.Text,tnationalite.Text,cmbcrps.Text,temail.Text,tphone.Text,cmdoption.Text,tdescription.Text,"Duckens",currentdate,conetu.Creerpwdetudiant());

        }
    }
}