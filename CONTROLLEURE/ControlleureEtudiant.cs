using System;
using System.Collections.Generic;
using System.Data;
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
        public string Getnom()
        {
            if (etu != null)
            {
                return etu.Nom;
            }
            else
                return null;
        }
        public string Getprenom()
        {
            if (etu != null)
            {
                return etu.Prenom;
            }
            else
                return null;
        }
        public string GetSexe()
        {
            if (etu != null)
            {
                return etu.Sexe;
            }
            else
                return null;
        }
        public string Getdatenaissance()
        {
            if (etu != null)
            {
                return etu.Datenaissance;
            }
            else
                return null;
        }
        public string Getlieunaissance()
        {
            if (etu != null)
            {
                return etu.Lieunaissance;
            }
            else
                return null;
        }
        public string Getmodalite()
        {
            if (etu != null)
            {
                return etu.Typemodalite;
            }
            else
                return null;
        }
        public string Getadresse()
        {
            if (etu != null)
            {
                return etu.Adresse;
            }
            else
                return null;
        }
        public string Getnationalite()
        {
            if (etu != null)
            {
                return etu.Nationalite;
            }
            else
                return null;
        }
        public string Getemail()
        {
            if (etu != null)
            {
                return etu.Email;
            }
            else
                return null;
        }
        public string Getphone()
        {
            if (etu != null)
            {
                return etu.Phone;
            }
            else
                return null;
        }
        public string Getgroupsanguin()
        {
            if (etu != null)
            {
                return etu.Groupsanguin;
            }
            else
                return null;
        }
        public string Getdiscipline()
        {
            if (etu != null)
            {
                return etu.Discipline;
            }
            else
                return null;
        }
        public string Getcreatedby()
        {
            if (etu != null)
            {
                return etu.Createdby;
            }
            else
                return null;
        }
        public string Getdescription()
        {
            if (etu != null)
            {
                return etu.Description;
            }
            else
                return null;
        }
        public bool Rechercheretudiant(string matricule)
        {
            return (etu.Rechercher(matricule));
        }
        public bool RechercherLoginetudiant(string matricule, string password)
        {
            return (etu.RechercherLoginetudiant(matricule,password));
        }

        public void CreerEtudiant(string matricule, string nom, string prenom, string sexe, string datenaissance, string lieunaissance, string adresse, string nationalite, string groupsanguin, string email, string phone, string discipline, string description, string createdby, string datecreated,string password, string anneeaccademique, string niveau, string typemodalite)
        {
            this.etu = new Etudiant(matricule, nom, prenom, sexe, datenaissance, lieunaissance, adresse, nationalite, groupsanguin, email, phone, discipline, description, createdby, datecreated,password,anneeaccademique,niveau,typemodalite);
            etu.creerEtudiant();
        }

        public void updateEtudiant(string matricule, string nom , string prenom, string sexe, string datenaissance, string lieunaissance, string adresse, string nationalite, string groupsanguin, string email, string phone, string description, string createdby, string datecreated, string typemodalite)
        {
            etu.UpdateEtudiant(matricule, nom, prenom, sexe, datenaissance, lieunaissance, adresse, nationalite, groupsanguin, email, phone, description, createdby, datecreated, typemodalite);
        }

        public void CreerAnneeAca(string datedebut, string datefin, string anneeaccademique)
        {
            this.etu = new Etudiant(datedebut,datefin,anneeaccademique);
            etu.creerAnneeAca();
        }

        public string Creercodeetudiant(string nom, string prenom)
        {
            return etu.creerCodeEtudiant(nom, prenom);
        }


        public string Creerpwdetudiant()
        {
            return etu.Creerpwdetudiant();

        }

        public DataSet GetListeAnneeaccademique()
        {
            return (etu.ListerAnneeacademique());

        }

        public DataTable GetlisteStudent()
        {
            return etu.GetListeStudent();
        }
        public DataTable GetlisteStudentBy(string anneeaca, string option)
        {
            return etu.GetListeStudentBy(anneeaca, option);
        }

        public DataSet GetListeEtudiant()
        {
            return (etu.ListerEtudiants());

        }

    }
}