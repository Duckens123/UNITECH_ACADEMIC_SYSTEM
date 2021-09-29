using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using UNITECH_ACADEMEIC_SYSTEME.MODELE;

namespace UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE
{
    public class Controlleurepaiement
    {
        Paiement paiement;

       public Controlleurepaiement()
        {
            paiement = new Paiement();
        }
        public string CreercodePaiement(string createdby)
        {
            return paiement.creerCodePaiement(createdby);
        }

        public void CreerPaiement(string codepaiement, string montant, string balance, string matricule, string versement, string datecreated, string createdby, string montantaverser, string montantannuel, string nombreversment, string typemodalite, string devise)
        {
            this.paiement = new Paiement(codepaiement,montant, balance, matricule, versement, datecreated,createdby, montantaverser, montantannuel, nombreversment, typemodalite,devise);
            paiement.CreerPaiement();

        }

        public DataSet GetListeModalite()
        {
            return (paiement.ListerModalite());

        }

    }
}