using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UNITECH_ACADEMEIC_SYSTEME.MODELE
{
    public class Etudiant
    {
        private DataSet data;
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
        private string niveau;
        private string typemodalite;
        private string anneeaccademique,datedebut,datefin;

        public Etudiant(string matricule,string nom,string prenom,string sexe,string datenaissance,string lieunaissance,string adresse,string nationalite,string groupsanguin,string email,string phone,string discipline,string description,string createdby,string datecreated,string password, string anneeaccademique,string niveau, string typemodalite)
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
            this.niveau = niveau;
            this.anneeaccademique = anneeaccademique;
            this.typemodalite = typemodalite;
        }
        public Etudiant(string nom, string prenom, string sexe, string datenaissance, string lieunaissance, string adresse, string nationalite, string groupsanguin, string email, string phone, string discipline, string description, string createdby, string datecreated,string anneeaccademique, string niveau, string typemodalite,string matricule)
        {

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
            this.matricule = matricule;
            this.datecreated = datecreated;
            this.niveau = niveau;
            this.anneeaccademique = anneeaccademique;
            this.typemodalite = typemodalite;
        }

        public Etudiant() : this(null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null)
        {
        }
        public Etudiant(string datedebut,string datefin,string anneeaccademique)
        {
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.anneeaccademique = anneeaccademique;
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
        public string Typemodalite
        {
            get { return this.typemodalite; }
            set { this.typemodalite = value; }
        }
        public string Groupsanguin
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
            string query = string.Format("INSERT INTO tbetudiant(matricule,nom, prenom,sexe,datenaissance,lieunaissance, adresse,nationalite,grpsanguin,email,phone,idfaculte,description,createdby,datecreated,password,idmodalite) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')", matricule, nom, prenom, sexe, datenaissance, lieunaissance, adresse, nationalite,groupsanguin,email,phone,discipline,description, createdby, datecreated,password,typemodalite);
            string query2 = string.Format("INSERT INTO tbniveauetudiant(matricule,niveau,idanneeaccademique) values('{0}','{1}','{2}')", matricule,niveau,anneeaccademique);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();

        }

        public void UpdateEtudiant(string matricule,string nom, string prenom, string sexe, string datenaissance, string lieunaissance, string adresse, string nationalite, string groupsanguin, string email, string phone, string description, string createdby, string datecreated, string typemodalite)
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("UPDATE tbetudiant SET nom='{1}', prenom='{2}',sexe='{3}',datenaissance='{4}',lieunaissance='{5}', adresse='{6}',nationalite='{7}',grpsanguin='{8}',email='{9}',phone='{10}',description='{11}',createdby='{12}',datecreated='{13}',idmodalite='{14}' where matricule='{0}'", matricule, nom , prenom, sexe, datenaissance, lieunaissance, adresse, nationalite, groupsanguin, email, phone, description, createdby, datecreated, typemodalite);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void creerAnneeAca()
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("INSERT INTO tbanneeaccademique(datedebut,datefin,anneaccademique) VALUES('{0}','{1}','{2}')", datedebut,datefin,anneeaccademique);
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

        public DataSet ListerEtudiants()
        {
            SqlDataAdapter adapter;
            SqlConnection con = new SqlConnection(strcon);
            string command = string.Format("Select * from vetudiant");

            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "vetudiant");
            con.Close();
            return data;
        }

        public DataSet ListerAnneeacademique()
        {
            SqlDataAdapter adapter;
            SqlConnection con = new SqlConnection(strcon);
            string command = string.Format("Select * from tbanneeaccademique");

            con.Open();
            adapter = new SqlDataAdapter(command, con);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "tbanneeaccademique");
            con.Close();
            return data;
        }

        public bool Rechercher(string matricule)
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("select * from tbetudiant where  matricule='{0}'", matricule);
            bool trouv = false;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                nom = reader[2].ToString();
                prenom = reader[3].ToString();
                sexe = reader[4].ToString();
                datenaissance = reader[5].ToString();
                lieunaissance = reader[6].ToString();
                adresse=reader[7].ToString();
                nationalite= reader[8].ToString();
                groupsanguin= reader[9].ToString();
                email= reader[10].ToString();
                phone= reader[11].ToString();
                description= reader[12].ToString();
                discipline = reader[13].ToString();
                createdby= reader[14].ToString();
                datecreated = reader[15].ToString();
                trouv = true;
                reader.Close();
                con.Close();
            }


            return trouv;

        }


        public bool RechercherLoginetudiant(string matricule,string password)
        {
            SqlConnection con = new SqlConnection(strcon);
            string query = string.Format("select * from tbetudiant where  matricule='{0}' AND password='{1}'", matricule,password);
            bool trouv = false;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                matricule = reader[1].ToString();
                nom = reader[2].ToString();
                prenom = reader[3].ToString();
 
                trouv = true;
                reader.Close();
                con.Close();
            }


            return trouv;

        }

    }
    
}