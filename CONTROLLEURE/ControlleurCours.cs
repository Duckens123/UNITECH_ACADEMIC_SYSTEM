using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using UNITECH_ACADEMEIC_SYSTEME.MODELE;

namespace UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE
{
    public class ControlleurCours
    {
        Cours cours;

        public ControlleurCours()
        {
            cours = new Cours();
        }

        public void Creercours(string titre, string coef, string faculte, string professeur, string session,string niveau)
        {
            this.cours = new Cours(titre,coef,faculte,professeur,session,niveau);
            cours.CreerCours();
        }
        

        public DataSet GetListecours()
        {
            return (cours.Listercours());

        }
    }
}