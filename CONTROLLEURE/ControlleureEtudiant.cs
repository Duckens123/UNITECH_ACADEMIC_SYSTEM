using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNITECH_ACADEMEIC_SYSTEME.MODELE;

namespace UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE
{
    public class ControlleureEtudiant
    {
        private Etudiant etu;

        public ControlleureEtudiant()
        {
            etu = new Etudiant();
        }
        public void CreerEtudiant(string matricule, string nom, string prenom, string sexe, string datenaissance, string lieunaissance, string adresse, string nationalite, string groupsanguin, string email, string phone, string discipline, string description, string createdby, string datecreated,string password)
        {
            this.etu = new Etudiant(matricule, nom, prenom, sexe, datenaissance, lieunaissance, adresse, nationalite, groupsanguin, email, phone, discipline, description, createdby, datecreated,password);
            etu.creerEtudiant();
        }

        public string Creercodeetudiant(string nom, string prenom)
        {
            return etu.creerCodeEtudiant(nom, prenom);
        }

        public string Creerpwdetudiant()
        {
            return etu.Creerpwdetudiant();

        }


    }
}