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

        public void Creercours(string titre, string coef, string idfaculte, string professeur, string session,string niveau)
        {
            this.cours = new Cours(titre,coef,idfaculte,professeur,session,niveau);
            cours.CreerCours();
        }
        public void Creernote(string titre,string matricule,string session,string anneeaccademique,string createdby,string datecreated, string niveau)
        {
            this.cours = new Cours(titre, matricule, session, anneeaccademique, createdby,datecreated, niveau);
            cours.Creernote();

        }

        public DataSet GetListecours()
        {
            return (cours.Listercours());

        }
    }
}