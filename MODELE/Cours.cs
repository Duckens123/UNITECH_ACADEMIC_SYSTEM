using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UNITECH_ACADEMEIC_SYSTEME.MODELE
{
    public class Cours
    {
       
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        private string titre, coef, faculte, professeur,niveau, matricule, session, anneeaccademique, createdby,datecreated,notecours;

        public Cours(string titre,string coef,string faculte,string professeur,string session,string anneeaccademique,string niveau,string matricule,string createdby,string datecreated,string notecours)
        {
            this.titre = titre;
            this.faculte = faculte;
            this.professeur = professeur;
            this.session = session;
            this.matricule = matricule;
            this.anneeaccademique = anneeaccademique;
            this.createdby = createdby;
            this.datecreated = datecreated;
            this.notecours = notecours;
            this.coef = coef;
            this.niveau = niveau;

        }

        public Cours(string titre, string coef, string faculte, string professeur, string session,string niveau)
        {
            this.titre = titre;
            this.faculte = faculte;
            this.professeur = professeur;
            this.session = session;
            this.coef = coef;
            this.niveau = niveau;

        }

       
        public DataSet Listercours()
        {
            DataSet data;
            SqlDataAdapter adapter;
            SqlConnection con = new SqlConnection(strcon);
            string command = string.Format("Select * from tbcours");

            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "tbcours");
            con.Close();
            return data;
        }
        public Cours() : this(null,null,null,null,null,null,null,null,null,null,null)
        {

        }
        public void CreerCours()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("INSERT INTO tbcours(titrecours,coef,faculte,professeur,session,niveau) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", titre, coef, faculte, professeur, session, niveau);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
       


    }
}