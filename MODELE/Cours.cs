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
        public DataSet data;
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        private string titre, coef, idfaculte, professeur,niveau, matricule, session, anneeaccademique, createdby,datecreated,notecours;

        public Cours(string titre,string coef,string idfaculte,string professeur,string session,string anneeaccademique,string niveau,string matricule,string createdby,string datecreated,string notecours)
        {
            this.titre = titre;
            this.idfaculte = idfaculte;
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

        public Cours(string titre, string coef, string idfaculte, string professeur, string session,string niveau)
        {
            this.titre = titre;
            this.idfaculte = idfaculte;
            this.professeur = professeur;
            this.session = session;
            this.coef = coef;
            this.niveau = niveau;

        }

        public Cours(string titre, string matricule, string session, string anneeaccademique, string createdby, string datecreated, string niveau)
        {
            this.titre = titre;
            this.matricule = matricule;
            this.session = session;
            this.anneeaccademique = anneeaccademique;
            this.createdby = createdby;
            this.datecreated = datecreated;
            this.niveau = niveau;


        }

        public DataSet Listercours()
        {

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
            string query = string.Format("INSERT INTO tbcours(titrecours,coef,idfaculte,professeur,session,niveau) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", titre, coef, idfaculte, professeur, session, niveau);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void Creernote()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("INSERT INTO tbnote(idcours,matricule,session,anneeaccademique,createdby,niveau) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", titre,matricule,session,anneeaccademique,createdby,niveau);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
}