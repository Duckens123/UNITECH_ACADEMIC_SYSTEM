using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UNITECH_ACADEMEIC_SYSTEME.MODELE
{
    public class Etudiant
    {
        string strcon = ConfigurationManager.ConnectionStrings["DBCONNECT"].ConnectionString;
        private string matricule;
        private string nom;
        private string prenom;
        private string sexe;
        private string datenaissance;
        private string lieunaissance;
        private string nationalite;
        private string createdby;
        private string groupsanguin;
        private string email;
        private string phone;
        private string datecreated;
        private string adresse;
        private string description;
        private string discipline;
        private string password;

        public Etudiant(string matricule,string nom,string prenom,string sexe,string datenaissance,string lieunaissance,string adresse,string nationalite,string groupsanguin,string email,string phone,string discipline,string description,string createdby,string datecreated,string password)
        {

            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.datenaissance = datenaissance;
            this.lieunaissance = lieunaissance;
            this.nationalite = nationalite;
            this.groupsanguin = groupsanguin;
            this.email = email;
            this.phone = phone;
            this.discipline = discipline;
            this.adresse = adresse;
            this.description = description;
            this.createdby = createdby;
            this.datecreated = datecreated;
            this.password = password;
        }

        public Etudiant() : this(null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null)
        {
        }

        public string Matricule
        {
            get { return this.matricule; }
            set { this.matricule = value; }
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }

        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.nom = value; }
        }

        public string Sexe
        {
            get { return this.sexe; }
            set { this.sexe = value; }
        }
        public string Nationalite
        {
            get { return this.nationalite; }
            set { this.nationalite = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Datenaissance
        {
            get { return this.datenaissance; }
            set { this.datenaissance = value; }

        }
        public string Lieunaissance
        {
            get { return this.lieunaissance; }
            set { this.lieunaissance = value; }
        }
        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }
        public string Codeparent
        {
            get { return this.groupsanguin; }
            set { this.groupsanguin = value; }
        }
        public string Discipline
        {
            get { return this.discipline; }
            set { this.discipline = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
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

        public void creerEtudiant()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("INSERT INTO tbetudiant(matricule,nom, prenom,sexe,datenaissance,lieunaissance, adresse,nationalite,grpsanguin,email,phone,discipline,description,createdby,datecreated,password) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", matricule, nom, prenom, sexe, datenaissance, lieunaissance, adresse, nationalite,groupsanguin,email,phone,discipline,description, createdby, datecreated,password);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public string creerCodeEtudiant(string nom, string prenom)
        {
            string nombreetu;
            string codeetu;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM tbetudiant", con);
            con.Open();
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                nombreetu = Convert.ToString(count.ToString());
            }
            else
            {
                nombreetu = "0";
            }
            con.Close();

            codeetu = nom.Substring(0, 1) + prenom.Substring(0, 1) + "-" + nombreetu;
            return codeetu;

        }

        public string Creerpwdetudiant()
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