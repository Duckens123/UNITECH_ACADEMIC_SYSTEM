using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using UNITECH_ACADEMEIC_SYSTEME.MODELE;

namespace UNITECH_ACADEMEIC_SYSTEME.CONTROLLEURE
{
    public class Controlleurnote
    {
        Note noteetu;

       public  Controlleurnote()
        {
            noteetu = new Note();
        }
        public void Creernote(string idcours, string matricule, string session, string anneeaccademique, string createdby, string niveau, string note)
        {
            this.noteetu = new Note(idcours, matricule, session, anneeaccademique, createdby, niveau,note);
            noteetu.CreernoteEtudiant();

        }

        public DataTable Getmynotestu(string matricule,string session)
        {
            return noteetu.GetBulletinbystu(matricule,session);
        }
        public DataSet GetBulletin(string matricule, string anneeaca,string niveau)
        {
            return noteetu.Bulletin(matricule, anneeaca, niveau);
        }
        public DataTable Getmynote(string option)
        {
            return noteetu.GetBulletin(option);
        }

        public DataTable Getmynote(string anneeaca, string session)
        {
            return noteetu.GetBulletin(anneeaca, session);
        }
        

    }
}