using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UNITECH_ACADEMEIC_SYSTEME.MODELE
{
    public class Note
    {
        public DataSet data;
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        private string idcours,  niveau, matricule, session, anneeaccademique, createdby, note;

        public Note(string idcours,string matricule,string session, string anneeaccademique,string createdby,string niveau,string note)
        {
            this.idcours = idcours;
            this.niveau = niveau;
            this.matricule = matricule;
            this.session = session;
            this.anneeaccademique = anneeaccademique;
            this.createdby = createdby;
            this.note = note;
           

        }

        public Note() : this(null, null,null,null,null,null, null)
        {

        }
        public void CreernoteEtudiant()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("INSERT INTO tbnote(idcours,matricule,session,anneeaccademique,createdby,niveau,note) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", idcours, matricule, session, anneeaccademique, createdby, niveau,note);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}