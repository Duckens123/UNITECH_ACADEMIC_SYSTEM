using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using UNITECH_ACADEMEIC_SYSTEME.MODELE;

namespace UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE
{
    public class ControlleurFaculte
    {
        Faculte facul;

        public ControlleurFaculte()
        {
            facul = new Faculte();
        }

        public string Getnomfaculte()
        {
            if (facul != null)
            {
                return facul.Nomfaculte;
            }
            else
                return null;
        }
        public string Getidfaculte()
        {
            if (facul != null)
            {
                return facul.Idfaculte;
            }
            else
                return null;
        }

        public string Getnombreannee()
        {
            if (facul != null)
            {
                return facul.Nombreannee;
            }
            else
                return null;
        }
        public bool Listerfaculte()
        {
            return (facul.Listerfaculte());
        }

        public DataSet GetListerFaculte()
        {
            return (facul.ListerFaculte());

        }
        public void Creerfaculte(string nomfaculte, string nombreannee)
        {
            this.facul = new Faculte(nomfaculte, nombreannee);
            facul.Creerfaculte();

        }

    }
}