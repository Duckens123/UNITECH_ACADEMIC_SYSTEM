using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace UNITECH_ACADEMEIC_SYSTEME.MODELE
{
    public class Faculte
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        private string nomfaculte, nombreannee,idfaculte;
        private DataSet data;

        public Faculte(string idfaculte,string nomfaculte,string nombreannee)
        {
            this.nomfaculte = nomfaculte;
            this.nombreannee = nombreannee;
        }
        public Faculte(string nomfaculte, string nombreannee)
        {
            this.nomfaculte = nomfaculte;
            this.nombreannee = nombreannee;
        }
        public Faculte() : this(null,null, null)
        {

        }
        public string Nomfaculte
        {
            get { return this.nomfaculte; }
            set { this.nomfaculte = value; }
        }
        public string Nombreannee
        {
            get {return this.nombreannee; }
            set { this.nombreannee = value; }
        }
        public string Idfaculte
        {
            get { return this.idfaculte; }
            set { this.idfaculte = value; }
        }

        public void Creerfaculte()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("INSERT INTO tbfaculte(nomfaculte,nombreannee) VALUES('{0}','{1}')", nomfaculte,nombreannee);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public bool Listerfaculte()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("select * from tbfaculte");
            bool trouv = false;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                idfaculte = reader[0].ToString();
                nomfaculte = reader[1].ToString();
                nombreannee = reader[2].ToString();
               trouv = true;
                reader.Close();
                con.Close();
            }


            return trouv;
        }

        public DataSet ListerFaculte()
        {

            SqlDataAdapter adapter;
            SqlConnection con = new SqlConnection(strcon);
            string command = string.Format("Select * from tbfaculte");

                con.Open();
                adapter = new SqlDataAdapter(command, con);
                SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
                data = new DataSet();
                adapter.Fill(data, "tbfaculte");
                con.Close();
                return data;                   
        }
    }
}