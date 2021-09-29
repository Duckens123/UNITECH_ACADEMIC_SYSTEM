using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNITECH_ACADEMEIC_SYSTEME.MODELE;

namespace UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE
{
    public class ControlleureUser
    {
        User user;
        public ControlleureUser()
        {
            user = new User();
        }

        public string Getnom()
        {
            if (user != null)
            {
                return user.Nom;
            }
            else
                return null;
        }
        public string Getprenom()
        {
            if (user != null)
            {
                return user.Prenom;
            }
            else
                return null;
        }

        public string Getpseudo()
        {
            if (user != null)
            {
                return user.Pseudo;
            }
            else
                return null;
        }

        public string GetPass()
        {
            if (user != null)
            {
                return user.Pass;
            }
            else
                return null;
        }
        public string Getfonction()
        {
            if (user != null)
            {
                return user.Fonction;
            }
            else
                return null;
        }

        public bool Rechercheruser(string pseudo,string pass)
        {
            return (user.Rechercher(pseudo, pass));
        }

        public void CreerUser(string nom, string prenom, string pseudo, string pass, string fonction, string createdby, string datecreated)
        {
            this.user = new User(nom, prenom, pseudo, pass, fonction, createdby, datecreated);
            user.creeruser();
        }

        public string CreercodeUser(string nom, string prenom)
        {
            return user.creerCodeUser(nom, prenom);
        }

        public string CreerpwdUser()
        {
            return user.CreerpwdUser();

        }


    }
}