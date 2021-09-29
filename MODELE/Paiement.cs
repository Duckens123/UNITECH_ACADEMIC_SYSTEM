using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UNITECH_ACADEMEIC_SYSTEME.MODELE
{
    public class Paiement
    {
        private DataSet data;
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        private string codepaiement;
        private string montant;
        private string balance;
        private string matricule;
        private string versement;
        private string datecreated;
        private string createdby;
        private string montantaverser;
        private string nombreversment;
        private string typemodalite;
        private string devise;
        private string montantannuel;

        public Paiement(string codepaiement, string montant, string balance, string matricule, string versement, string datecreated, string createdby, string montantaverser, string montantannuel, string nombreversment, string typemodalite, string devise)
        {
            this.codepaiement = codepaiement;
            this.montant = montant;
            this.balance = balance;
            this.matricule = matricule;
            this.versement = versement;
            this.datecreated = datecreated;
            this.createdby = createdby;
            this.montantaverser = montantaverser;
            this.nombreversment = nombreversment;
            this.typemodalite = typemodalite;
            this.devise = devise;
            this.montantannuel= montantannuel;

        }
        public Paiement() : this(null, null, null, null, null, null, null, null, null, null, null, null)
        {

        }

        public string Montantaverser
        {
            get { return this.montantaverser; }
            set { this.montantaverser = value; }
        }
        public string  Nombreversement{
            get { return this.nombreversment; }
            set { this.nombreversment = value; }
            }
        public string Typemodalite
        {
            get { return this.typemodalite; }
            set { this.typemodalite = value; }
        }
        public string Devise
        {
            get { return this.devise; }
            set { this.devise = value; }
        }

        public string Codepaiement
        {
            get { return this.matricule; }
            set { this.codepaiement = value; }
        }
        public string Montant
        {
            get { return this.montant; }
            set { this.montant = value; }
        }
        public string Montantannuel
        {
            get { return this.montantannuel; }
            set { this.montantannuel = value; }

        }
        public string Versement
        {
            get { return this.versement; }
            set { this.Versement = value; }
        }
        public string Datecreated
        {
            get { return this.datecreated;}
            set { this.datecreated=value; }
        }
        public string Createdby
        {
            get { return this.createdby; }
            set { this.createdby = value; }
        }
        public string Matricule
        {
            get { return this.matricule; }
            set { this.matricule = value; }
        }

        public void CreerPaiement()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("INSERT INTO tbpaiement(codepaiement,datepaiement,montant,createdby) VALUES('{0}','{1}','{2}','{3}')", codepaiement, datecreated, montant, createdby);
            string query2 = string.Format("INSERT INTO tbdetailpaiement(codepaiement,matricule,balance,versement) VALUES('{0}','{1}','{2}','{3}')", codepaiement, matricule, balance, versement);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public bool Rechercher(string matricule)
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("select * from vtopay where  matricule='{0}'", matricule);
            bool trouv = false;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               montantaverser= reader[0].ToString();
                nombreversment = reader[1].ToString();
               createdby = reader[14].ToString();
                datecreated = reader[15].ToString();
                trouv = true;
                reader.Close();
                con.Close();
            }


            return trouv;

        }

        public string creerCodePaiement(string createdby)
        {
            string nombrepaiement;
            string codepaiement;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM tbpaiement", con);
            con.Open();
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                nombrepaiement = Convert.ToString(count.ToString());
            }
            else
            {
                nombrepaiement = "0";
            }
            con.Close();

            codepaiement = createdby.Substring(0, 2) + "-" + nombrepaiement;
            return codepaiement;

        }

        public DataSet ListerModalite()
        {

            SqlDataAdapter adapter;
            SqlConnection con = new SqlConnection(strcon);
            string command = string.Format("Select * from tbmodalite");

            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "tbmodalite");
            con.Close();
            return data;
        }

    }
}