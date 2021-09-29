<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="UNITECH_ACADEMEIC_SYSTEME.VUE.Admin" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link
      rel="stylesheet"
      href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css"
    />
    <link rel="stylesheet" href="css/dataTables.bootstrap5.min.css" />
    <link rel="stylesheet" href="css/style.css" />
    <title>Admin</title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
          <!-- top navigation bar -->
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="navtop">
      <div class="container-fluid">
        <button
          class="navbar-toggler"
          type="button"
          data-bs-toggle="offcanvas"
          data-bs-target="#sidebar"
          aria-controls="offcanvasExample"
        >
          <span class="navbar-toggler-icon" data-bs-target="#sidebar"></span>
        </button>
        <a
          class="navbar-brand me-auto ms-lg-0 ms-3 text-uppercase fw-bold"
          href="#"
          >UNITECH ACADEMIC SYSTEM</a
        >
        <button
          class="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#topNavBar"
          aria-controls="topNavBar"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse justify-content-end" id="topNavBar">
          
          <ul class="navbar-nav">
              
            <li class="nav-item dropdown">
              <a
                class="nav-link dropdown-toggle ms-2"
                href="#"
                role="button"
                data-bs-toggle="dropdown"
                aria-expanded="false"
              >
                <i class="bi bi-person-fill"></i>
              </a>
              <ul class="dropdown-menu dropdown-menu-end">                 
                <li><asp:Label ID="profil" class="dropdown-item" runat="server" Text="Profil"></asp:Label></li>                 
                <li class="btn btn-danger"> <asp:Button ID="btnlogout" class="dropdown-item" runat="server" Text="Deconnection" OnClick="btnlogout_Click"/></li>
              </ul>
            </li>
          </ul>
        </div>
      </div>
    </nav>
          
    <!-- top navigation bar -->
    <!-- offcanvas -->
    <div
      class="offcanvas offcanvas-start sidebar-nav"
      tabindex="-1"
      id="sidebar"
    >
      <div class="offcanvas-body p-0">
        <nav class="navbar-dark">
          <ul class="navbar-nav">
            <li>
              <a href="#" class="nav-link px-3 menu" data-page="acceuil">
                <span class="me-2"><i class="bi bi-speedometer2"></i></span>
                <span>Tableau de bord</span>
              </a>
            </li>
            <li class="my-4"><hr class="dropdown-divider bg-light" /></li>
            <li>
              <div class="text-muted small fw-bold text-uppercase px-3 mb-3">
                Interface
              </div>
            </li>
            <li>
              <a
                class="nav-link px-3 sidebar-link"
                data-bs-toggle="collapse"
                href="#layouts"
              >
                <span class="me-2"><i class="bi bi-person-fill"></i></span>
                <span>Etudiant</span>
                <span class="ms-auto">
                  <span class="right-icon">
                    <i class="bi bi-chevron-down"></i>
                  </span>
                </span>
              </a>
              <div class="collapse" id="layouts">
                <ul class="navbar-nav ps-3">
                  <li>
                    <a href="#" class="nav-link px-3 menu" data-page="ajoutereleve">
                      <span class="me-2"
                        ><i class="bi bi-person-fill"></i
                      ></span>
                      <span>Dossier étudiant</span>
                    </a>
                  </li>
                   <li>
                    <a href="#" class="nav-link px-3 menu" data-page="listereleve">
                      <span class="me-2"
                        ><i class="bi bi-list-ol"></i
                      ></span>
                      <span>Liste étudiant</span>
                    </a>
                  </li>
                 
                </ul>
              </div>
            </li>
              <li>
              <a
                class="nav-link px-3 sidebar-link"
                data-bs-toggle="collapse"
                href="#layout"
              >
                <span class="me-2"><i class="bi bi-person"></i></span>
                <span>Utilisateurs</span>
                <span class="ms-auto">
                  <span class="right-icon">
                    <i class="bi bi-chevron-down"></i>
                  </span>
                </span>
              </a>
              <div class="collapse" id="layout">
                <ul class="navbar-nav ps-3">
                  <li>
                    <a href="#" class="nav-link px-3 menu" data-page="ajouteruser">
                      <span class="me-2"
                        ><i class="bi bi-person-fill"></i
                      ></span>
                      <span>Ajouter un utilisateur</span>
                    </a>
                  </li>
                   <li>
                    <a href="#" class="nav-link px-3 menu" data-page="listeruser">
                      <span class="me-2"
                        ><i class="bi bi-list-ol"></i
                      ></span>
                      <span>Liste utilisateur</span>
                    </a>
                  </li>
                  <li>
                    <a href="#" class="nav-link px-3 menu" data-page="dossieruser">
                      <span class="me-2"
                        ><i class="bi bi-folder"></i
                      ></span>
                      <span>Dossier utilisateur</span>
                    </a>
                  </li>

                </ul>
              </div>
            </li>
               <li>
              <a
                class="nav-link px-3 sidebar-link"
                data-bs-toggle="collapse"
                href="#note"
              >
                <span class="me-2"><i class="bi bi-book"></i></span>
                <span>Note</span>
                <span class="ms-auto">
                  <span class="right-icon">
                    <i class="bi bi-chevron-down"></i>
                  </span>
                </span>
              </a>
              <div class="collapse" id="note">
                <ul class="navbar-nav ps-3">
                  <li>
                    <a href="#" class="nav-link px-3 menu" data-page="addnote">
                      <span class="me-2"
                        ><i class="bi bi-person-fill"></i
                      ></span>
                      <span>Entrer notes</span>
                    </a>
                  </li>
                   <li>
                    <a href="#" class="nav-link px-3 menu" data-page="editnote">
                      <span class="me-2"
                        ><i class="bi bi-list-ol"></i
                      ></span>
                      <span>Modifier</span>
                    </a>
                  </li>
                  <li>
                    <a href="#" class="nav-link px-3 menu" data-page="dossiereleve">
                      <span class="me-2"
                        ><i class="bi bi-folder"></i
                      ></span>
                      <span></span>
                    </a>
                  </li>
                </ul>
              </div>
            </li>

              <li>
              <a href="#" class="nav-link px-3 menu" data-page="pay">
                <span class="me-2" ><i class="bi bi-cash"></i></span>
                <span>Paiement</span>
              </a>
            </li>

            <li>
              <a href="#" class="nav-link px-3 menu" data-page="cours">
                <span class="me-2"><i class="bi bi-calendar-date"></i></span>
                <span>Cours</span>
              </a>
            </li>
             <li>
              <a href="#" class="nav-link px-3 menu" data-page="faculte">
                <span class="me-2"><i class="bi bi-chat"></i></span>
                <span>Faculté</span>
              </a>
            </li>
              <li>
                    <a href="#" class="nav-link px-3 menu" data-page="newyear">
                      <span class="me-2"
                        ><i class="bi bi-person-fill"></i
                      ></span>
                      <span>Nouvelle année accademique</span>
                    </a>
                  </li>
            <li class="my-4"><hr class="dropdown-divider bg-light" /></li>
            <li>
              <div class="text-muted small fw-bold text-uppercase px-3 mb-3">
                Rapport
              </div>
            </li>
            <li>
              <a href="#" class="nav-link px-3">
                <span class="me-2"><i class="bi bi-graph-up"></i></span>
                <span>Rapport</span>
              </a>
            </li>
            <li>
              <a href="#" class="nav-link px-3">
                <span class="me-2"><i class="bi bi-table"></i></span>
                <span>Tableau</span>
              </a>
            </li>
          </ul>
        </nav>
      </div>
    </div>
    <!-- offcanvas -->
    <!-- Les Pages -->
     <!-- Page acceuil -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="acceuil">
      <div class="container-fluid">
        <div class="row d-flex justify-content-evenly">
         <div class="row d-flex justify-content-between">
          <div class="col-md-3">
            
          </div>
          <div class="col-md-3">
            
          </div>
          <div class="col-md-3">
            <p>Home</p>
          </div>
           
         </div>
         
        </div>       
      </div>
    </main>
    <!-- Fin Page acceuil -->
    <!-- Page ajouter eleve -->
    <main class="mt-5 pt-3  shadow-lg p-3 mb-5 bg-body rounded page" id="ajoutereleve">
        <asp:UpdatePanel runat="server" ID="savestu"> <ContentTemplate>
      <div class="container-fluid">
          <div class="row d-flex justify-content-center">
              <div class="col-md-4">
                  <asp:TextBox ID="tmatricule" CssClass="form-control" runat="server"></asp:TextBox>
              </div>
              <div class="col-md-4">
                  <asp:Button ID="btnsearchupdate" CssClass="btn btn-outline-info" Onclick="btnrecherupdate_Click"  runat="server" Text="Modifier Un etudiant" />
              </div>
          </div>
          <div class="row d-flex justify-content-center">
              <asp:Label ID="letudiansuc" class="alert alert-success mt-2 col-md-12"  runat="server" Text="" Visible="False">
                  <asp:Button ID="Button2" runat="server" Text="Ok" />
              </asp:Label>
          <asp:Label ID="letudiantech" class="alert alert-danger mt-2"  runat="server" Text="" Visible="False"></asp:Label>
          </div>
          <div class="row d-flex justify-content-center">
              <div class="col-md-4">
                  <h2>Etudiant</h2>

              </div>

          </div>
        <div class="row d-flex justify-content-between">
          <div class="col-md-3">
              <label>Nom</label>
              <asp:TextBox ID="tnometu" runat="server" class="form-control" placeholder="Nom"></asp:TextBox>
          </div>
            <div class="col-md-3">
                <label>Prenom</label>
                <asp:TextBox ID="tprenom" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
             <div class="col-md-3">
                <label>Sexe</label>
                <asp:DropDownList ID="cmbsexe" runat="server" class="form-select">
                    <asp:ListItem>Selectionner le sexe...</asp:ListItem>
                    <asp:ListItem>Masculin</asp:ListItem>
                    <asp:ListItem>Féminin</asp:ListItem>
                </asp:DropDownList>

            </div>
         
        </div>    
          
           <div class="row d-flex justify-content-between">
          <div class="col-md-3">
              <label>Date naissance</label>
              <asp:TextBox ID="tdatenaiss" TextMode="Date" class="form-control" runat="server"></asp:TextBox>
          </div>
            <div class="col-md-3">
                <label>Lieu de naissance</label>
                <asp:TextBox ID="tlieunaissance" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
             <div class="col-md-3">
                 <label>Groupe sanguin</label>
                <asp:DropDownList ID="cmbcrps" runat="server" class="form-select">
                    <asp:ListItem>Selectionner groupe sanguin...</asp:ListItem>
                    <asp:ListItem>O+</asp:ListItem>
                    <asp:ListItem>O-</asp:ListItem>
                    <asp:ListItem>A+</asp:ListItem>
                    <asp:ListItem>B-</asp:ListItem>
                    <asp:ListItem>AB+</asp:ListItem>
                    <asp:ListItem>AB-</asp:ListItem>
                </asp:DropDownList>
            </div>
         
        </div> 
          <div class="row d-flex justify-content-between">
              <div  class="col-md-3">
                  <label>Telephone</label>
                 <asp:TextBox ID="tphone" CssClass="form-control" runat="server"></asp:TextBox>

              </div>
               <div  class="col-md-3">
                   <label>Email</label>
                 <asp:TextBox ID="temail" CssClass="form-control" runat="server"></asp:TextBox>

              </div>
               <div  class="col-md-3">
                   <label>Adresse</label>
                 <asp:TextBox ID="tadresse" CssClass="form-control" runat="server"></asp:TextBox>
              </div>

          </div>

          <div class="row d-flex justify-content-between">
              <div class="col-md-3">
                  <label>Nationalité</label>
                  <asp:TextBox ID="tnationalite" CssClass="form-control" runat="server"></asp:TextBox>

              </div>

              <div class="col-md-3">
                  <label>Option</label>
                  <asp:DropDownList ID="cmdoption" runat="server" class="form-select">
                    
                </asp:DropDownList>

              </div>
              <div class="col-md-3">
                  <label>Description</label>
                  <asp:TextBox ID="tdescription" CssClass="form-control" runat="server"></asp:TextBox>

              </div>

          </div>
           <div class="row d-flex justify-content-between">
               <div class="col-md-3">                 
                  <label>Modalité de paiement</label>
                  <asp:DropDownList ID="cmbmodalite" runat="server" class="form-select">
                   
                </asp:DropDownList>
              </div>
               <div class="col-md-3">                 
                  <label>Niveau</label>
                  <asp:DropDownList ID="cmbniveau" runat="server" class="form-select">
                    <asp:ListItem>Selectionner niveau...</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                      <asp:ListItem>3</asp:ListItem>
                      <asp:ListItem>4</asp:ListItem>
                </asp:DropDownList>
              </div>
               <div class="col-md-3">                 
                  <label>Année Academique</label>
                  <asp:DropDownList ID="cmdanneeaca" runat="server" class="form-select">
                   
                </asp:DropDownList>
              </div>

          </div>
          <div class="row d-flex justify-content-between mt-2">
              <div class="col-md-3">
                  <asp:Button ID="btncancel" CssClass="btn btn-warning" runat="server" Text="Anuller" />

              </div>
               <div class="col-md-3">
                    <asp:Button ID="btnupdate" CssClass="btn btn-primary" Visible="false" runat="server" Text="Modifier" OnClick="btnupdate_Click" />
                   <asp:Button ID="btnsave" CssClass="btn btn-primary" runat="server" Text="Sauvegarder" OnClick="btnsave_Click" />
              </div>

          </div>
      </div>
            </ContentTemplate> </asp:UpdatePanel>
    </main>
    <!-- Fin Page ajouter eleve -->
     <!-- Page lister eleve -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="listereleve">
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
        
       
    </main>
    <!-- Fin Page lister eleve -->
    
        <!-- Page ajouter user -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="ajouteruser">
      <div class="container-fluid">
        <div class="row d-flex justify-content-between">
          <div class="col-md-3">

         <label>Nom</label>
              <asp:TextBox ID="tnomuser" runat="server" class="form-control" placeholder="Nom"></asp:TextBox>
          </div>
            <div class="col-md-3">
                <label>Prenom</label>
                <asp:TextBox ID="tprenomuser" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
             <div class="col-md-3">
                <label>Fonction</label>
                <asp:DropDownList ID="cmbfonction" runat="server" class="form-select">
                    <asp:ListItem>Selectionner Option...</asp:ListItem>
                    <asp:ListItem>Administrateur</asp:ListItem>
                    <asp:ListItem>Sécretaire</asp:ListItem>
                    <asp:ListItem>Comptable</asp:ListItem>
                </asp:DropDownList>

            </div>
         
        </div>  
          
          <div class="row d-flex justify-content-center mt-2">

              <div class="col-md-3">
                   <asp:Button ID="btnannuler" CssClass="btn btn-warning" runat="server" Text="Annuler" />
              </div>
              <div class="col-md-3">
                   <asp:Button ID="btnenregistrer" CssClass="btn btn-primary" runat="server" Text="Enregistrer" OnClick="btnenregistrer_Click" />
              </div>
          </div>
      </div>
    </main>
    <!-- Fin Page ajouter -->

         <!-- Page add note -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="addnote">
     
      <div class="container-fluid">
        <div class="row d-flex justify-content-center">
            <div class="col-md-4">
                <asp:TextBox ID="trecheretunote" class="form-control" placeholder="Rechercher un étudiant" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Button ID="btnrecherchen"  class="btn btn-outline-info" runat="server" Text="Rechercher" OnClick="btnrecherchen_Click" /> 
            </div>       
         
        </div> 
          <div class="row d-flex justify-content-between">
              <div class="col-md-3">
                  <label>Nom complet</label>
                 <asp:TextBox ID="nomcompletnote" ReadOnly="true" class="form-control" runat="server"></asp:TextBox>
              </div>
               <div class="col-md-3">
                  <label>Discipline</label>
                 <asp:TextBox ID="tdiscipline"  class="form-control" ReadOnly="true" runat="server"></asp:TextBox>
              </div>
               <div class="col-md-3">                 
                  <label>Niveau</label>
                  <asp:DropDownList AutoPostBack="true" ID="cmbniveaunote" runat="server" class="form-select" >
                    <asp:ListItem>I</asp:ListItem>
                    <asp:ListItem>II</asp:ListItem>
                    <asp:ListItem>III</asp:ListItem>
                    <asp:ListItem>IV</asp:ListItem>
                </asp:DropDownList>

          </div>
      </div>
          <div class="row d-flex justify-content-between">
              <div class="col-md-2">

                  <label>Session</label>
                   <asp:DropDownList ID="cmbsession" AutoPostBack="true" runat="server" class="form-select" >
                       <asp:ListItem>I</asp:ListItem>
                       <asp:ListItem>II</asp:ListItem>
                    
                </asp:DropDownList>
              </div>
              <div class="col-md-2">

                  <label>Session</label>
                   <asp:DropDownList ID="ddannee" AutoPostBack="true" runat="server" class="form-select" >
                                          
                </asp:DropDownList>
              </div>

          <div class="col-md-3">                 
                  <label>Cours</label>
                  <asp:DropDownList ID="cmbcours" runat="server" class="form-select">
                    
                </asp:DropDownList>
          </div>
          <div class="col-md-3">
              <label>Note</label>
              <asp:TextBox ID="tnote" CssClass="form-control" runat="server"></asp:TextBox>

          </div>
              </div>
          <div class="row d-flex justify-content-between">
              <div class="col-md-3">
                  <asp:Button ID="btncancelnote" CssClass="btn btn-danger" runat="server" Text="Annuler" />
                  <asp:Button ID="btnsavenote" runat="server" CssClass="btn btn-primary" Text="Enregistrer" OnClick="btnsavenote_Click" />
              </div>

          </div>

          </div>        
               
     
    </main>

    <!-- Fin Page add note -->

         <!-- Page edit note -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="editnote">
      <div class="container-fluid">
        <div class="row ">
          edit note
         
        </div>       
      </div>
    </main>
    <!-- Fin Page edit note -->

        <!-- Page liste user -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="listeruser">
      <div class="container-fluid">
        <div class="row ">
          list user
         
        </div>       
      </div>
    </main>
    <!-- Fin Page liste user -->

        <!-- Page dossier user -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="dossieruser">
      <div class="container-fluid">
        <div class="row ">
          dossier user
         
        </div>       
      </div>
    </main>
    <!-- Fin Page dossier user -->


            
        <!-- Page nouvelle année accademique -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="newyear">
      <div class="container-fluid">
        <div class="row d-flex justify-content-center ">
            <div class="col-md-3">
                <label>Année debut</label>
                <asp:TextBox ID="tanneedeb" TextMode="Number" CssClass="form-control" MaxLength="4" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <label>Année fin</label>
                <asp:TextBox ID="tanneefin" CssClass="form-control" TextMode="Number" MaxLength="4" runat="server"></asp:TextBox>
            </div>
         
         
        </div>  
          <div class="row d-flex justify-content-center ">
            <div class="col-md-3">
                <asp:Button ID="btnannuleanne" CssClass="btn btn-outline-danger" runat="server" Text="Button" />
            </div>
            <div class="col-md-3">
                <asp:Button ID="btnsaveanneaca" runat="server" CssClass="btn btn-outline-primary" Text="Button" OnClick="btnsaveanneaca_Click" />
            </div>
         
         
        </div>  
      </div>
    </main>
             <!--Fin Page nouvelle année accademique -->

             <!-- Page Cours -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="cours">
         <asp:UpdatePanel UpdateMode="Conditional" ChildrenAsTriggers="true" runat="server" ID="UpdatePanel2">
                    <ContentTemplate>
      <div class="container-fluid">
        <div class="row d-flex justify-content-center">
            <div class="col-md-3">
                <label>Titre cours</label>
                <asp:TextBox ID="ttitrecours" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <label>Coéfficient</label>
                <asp:TextBox ID="coef" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <label>Professeur</label>
                <asp:TextBox ID="tprof" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <label>Discipline</label>
                <asp:DropDownList CssClass="form-select" ID="cmdfaculter" runat="server">
                </asp:DropDownList>

            </div>
            <div class="row d-flex justify-content-center">
                   <div class="col-md-2">
                <label>Session</label>
                <asp:DropDownList CssClass="form-select" ID="cmdsession" runat="server">
                    <asp:ListItem>I</asp:ListItem>
                    <asp:ListItem>II</asp:ListItem>
                    <asp:ListItem>I et II</asp:ListItem>
                </asp:DropDownList>

            </div>
            <div class="col-md-2">
                <label>Niveau</label>
                <asp:DropDownList CssClass="form-select" ID="cmbniveaucours" runat="server">
                     <asp:ListItem>I</asp:ListItem>
                    <asp:ListItem>II</asp:ListItem>
                    <asp:ListItem>III</asp:ListItem>
                    <asp:ListItem>IV</asp:ListItem>
                    <asp:ListItem>V</asp:ListItem>
                </asp:DropDownList>

            </div>

            </div>
        
        </div>
          <div class="row d-flex justify-content-center mt-3">
              <div class="col-md-3">
                  <asp:Button ID="btncancelcours" CssClass="btn btn-danger" runat="server" Text="Annuler" />
                  <asp:Button ID="btnsavecours" CssClass="btn btn-primary" ClientIDMode="AutoID" runat="server" Text="Enregistrer" OnClick="btnsavecours_Click" />
              </div>

          </div>
         
      </div>                  
                        </ContentTemplate>
                </asp:UpdatePanel>
    </main>
    <!-- Fin Page cours -->
             <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="pay">
                <asp:UpdatePanel runat="server" ID="panelfaculte">
                    <ContentTemplate>
      <div class="container-fluid">
        <div class="row d-flex justify-content-center">
            <div class="col-md-4">
                <asp:TextBox ID="tsear" class="form-control" placeholder="Rechercher un étudiant" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Button ID="btnsear"  class="btn btn-outline-info" runat="server" Text="Search" OnClick="btnsear_Click" /> 
            </div>       
         
        </div> 
          <div class="row d-flex justify-content-between">
              <div class="col-md-3">
                  <label>Nom complet</label>
                 <asp:TextBox ID="snomcomplet" ReadOnly="true" class="form-control" runat="server"></asp:TextBox>
              </div>
               <div class="col-md-3">
                  <label>Montant du</label>
                 <asp:TextBox ID="Montant"  class="form-control" ReadOnly="true" runat="server"></asp:TextBox>
              </div>

          </div>
      </div>
                        </ContentTemplate>
                </asp:UpdatePanel>
    </main>

             <!-- Page Faculter -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="faculte">
      <div class="container-fluid">
        <div class="row  d-flex justify-content-between">
            <div class="col-md-3">
                <label>Nom Faculté</label>
                <asp:TextBox ID="tnomfaculte" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <label>Nombre année</label>
                <asp:TextBox ID="tnbannee" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        
         
        </div> 
           <div class="row  d-flex justify-content-between mt-3">
            <div class="col-md-3">
                <asp:Button ID="btncancelfaculte" class="btn btn-danger" runat="server" Text="Annuler" />
            </div>
            <div class="col-md-3">
                <asp:Button ID="btnsavefaculte" class="btn btn-primary" runat="server" Text="Sauvegarder" OnClick="btnsavefaculte_Click" />
            </div>
        
         
        </div> 
      </div>
    </main>
             <!-- fin Page Faculter -->
                 
                   <!-- Modal -->
            <asp:UpdatePanel runat="server" ID="panelmodal"><ContentTemplate>
<div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="staticBackdropLabel">Rechercher etudiant</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        <div class="row d-flex justify-content-between">
          <label>Entrer matricule </label>  
            <asp:TextBox ID="trechere" runat="server" placeholder="Matricule" class="form-control menu"></asp:TextBox>

          </div>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
         <asp:Button ID="btnrechercheretu"  runat="server" class="btn btn-primary" Onclick="btnrecherupdate_Click"  Text="Rechercher" /> 
      </div>
    </div>
  </div>
</div>
                </ContentTemplate></asp:UpdatePanel>
      

        <!--Fin Modal -->

<!-- Fin des Pages -->
    <script src="./js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/chart.js@3.0.2/dist/chart.min.js"></script>
    <script src="./js/jquery-3.5.1.js"></script>
    <script src="./js/jquery.dataTables.min.js"></script>
    <script src="./js/dataTables.bootstrap5.min.js"></script>
    <script src="./js/script.js"></script>
            
       
        </div>

       
    </form>


</body>
</html>
