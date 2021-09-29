using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UNITECH_ACADEMEIC_SYSTEME.MODELE
{
    public class User
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        private string nom;
        private string prenom;
        private string pseudo;
        private string pass;
        private string fonction;
        private string createdby;
        private string datecreated;


        public User(string nom,string prenom,string pseudo,string pass,string fonction, string createdby, string datecreated)
        {
            
            this.nom = nom;
            this.prenom = prenom;
            this.pseudo = pseudo;
            this.pass = pass;
            this.fonction = fonction;
            this.createdby = createdby;
            this.datecreated = datecreated;
            this.fonction = fonction;

        }
        public User() : this(null,null,null,null,null,null,null)
        {

        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }

        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }

        }
        public string Pseudo
        {
            get { return this.pseudo; }
            set { this.pseudo = value; }
        }
        public string Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }
        public string Fonction
        {
            get { return this.fonction; }
            set { this.Fonction = value; }
        }
        public string Createdby
        {
            get { return this.createdby; }
            set { this.createdby = value; }
        }
        public string Datecreated
        {
            get { return this.datecreated; }
            set { this.datecreated = value; }
        }


        public void creeruser()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("INSERT INTO tbuser(nom,prenom,pseudo,pass,fonction,createdby,datecreated) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", nom, prenom, pseudo, pass, fonction, createdby, datecreated);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public bool Rechercher( string pin,string passu)
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("select * from tbuser where  pseudo='{0}' and pass='{1}'", pin,passu);
            bool trouv = false;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                nom= reader[1].ToString();
                prenom= reader[2].ToString();
                pseudo=reader[3].ToString();
                pass= reader[4].ToString();
                fonction= reader[5].ToString();
                trouv = true;
                reader.Close();
                con.Close();
            }

                
            return trouv;

        }


        public string creerCodeUser(string nom, string prenom)
        {
            string nombreuser;
            string codeuser;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM tbuser", con);
            con.Open();
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                nombreuser = Convert.ToString(count.ToString());
            }
            else
            {
                nombreuser = "0";
            }
            con.Close();

            codeuser = nom.Substring(0, 1) + prenom.Substring(0, 1) + "-" + nombreuser;
            return codeuser;

        }

        public string CreerpwdUser()
        {
            string pwd = "";

            string allowedChars = "";

            allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";

            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";

            allowedChars += "1,2,3,4,5,6,7,8,9,0";

            char[] sep = { ',' };

            string[] arr = allowedChars.Split(sep);

            string passwordString = "";

            string temp = "";

            Random rand = new Random();

            for (int i = 0; i < 5; i++)

            {

                temp = arr[rand.Next(0, arr.Length)];

                passwordString += temp;

            }

            pwd = passwordString;
            return pwd;

        }
    }
}