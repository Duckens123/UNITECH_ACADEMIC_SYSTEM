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

        public Note(string matricule,string niveau,string anneeaccademique)
        {
            this.matricule = matricule;
            this.niveau = niveau;
            this.anneeaccademique = anneeaccademique;
        }

        public Note() : this(null, null,null,null,null,null, null)
        {

        }

        public DataSet Bulletin(string matricule,string niveau,string anneeaca)
        {

            SqlDataAdapter adapter;
            SqlConnection con = new SqlConnection(strcon);
            string command = string.Format("Select * from vnoteetu where matricule ='{0}' AND niveau='{1}' AND anneaccademique='{2}'",matricule,niveau,anneeaca);

            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "vnoteetu");
            con.Close();
            return data;
        }
        public void CreernoteEtudiant()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("INSERT INTO tbnote(cours,matricule,session,anneeaccademique,createdby,niveau,note) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", idcours, matricule, session, anneeaccademique, createdby, niveau,note);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}