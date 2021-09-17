<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="UNITECH_ACADEMEIC_SYSTEME.VUE.Admin" %>

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
        <div class="collapse navbar-collapse" id="topNavBar">
          
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
                <li><a class="dropdown-item" href="#">Profil</a></li>
                <li><a class="dropdown-item" href="#">Deconnection</a></li>
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
                      <span>Ajouter un nouveau étudiant</span>
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
                  <li>
                    <a href="#" class="nav-link px-3 menu" data-page="dossiereleve">
                      <span class="me-2"
                        ><i class="bi bi-folder"></i
                      ></span>
                      <span>Dossier étudiant</span>
                    </a>
                  </li>
                </ul>
              </div>
            </li>
            <li>
              <a href="#" class="nav-link px-3">
                <span class="me-2"><i class="bi bi-calendar-date"></i></span>
                <span>Calendrier</span>
              </a>
            </li>
             <li>
              <a href="#" class="nav-link px-3">
                <span class="me-2"><i class="bi bi-chat"></i></span>
                <span>Messages</span>
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
            
          </div>
           
         </div>
         
        </div>       
      </div>
    </main>
    <!-- Fin Page acceuil -->
    <!-- Page ajouter eleve -->
    <main class="mt-5 pt-3  shadow-lg p-3 mb-5 bg-body rounded page" id="ajoutereleve">
      <div class="container-fluid">
          <div class="row d-flex justify-content-center">
              <div class="col-md-4">
                  <h2>Inscription étudiant</h2>

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
                <asp:DropDownList ID="cmbsexe" runat="server" class="form-control">
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
                <asp:DropDownList ID="cmbcrps" runat="server" class="form-control">
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
                  <asp:DropDownList ID="cmdoption" runat="server" class="form-control">
                    <asp:ListItem>Selectionner option...</asp:ListItem>
                    <asp:ListItem>Sciences informatiques</asp:ListItem>
                    <asp:ListItem>Sciences infirmière</asp:ListItem>
                      <asp:ListItem>Sciences politiques</asp:ListItem>
                    <asp:ListItem>Ginie civil</asp:ListItem>
                    <asp:ListItem>Administration</asp:ListItem>
                </asp:DropDownList>

              </div>
              <div class="col-md-3">
                  <label>Description</label>
                  <asp:TextBox ID="tdescription" CssClass="form-control" runat="server"></asp:TextBox>

              </div>

          </div>
          <div class="row d-flex justify-content-between">
              <div class="col-md-3">
                  <asp:Button ID="btncancel" runat="server" Text="Anuller" />

              </div>
               <div class="col-md-3">
                   <asp:Button ID="btnsave" runat="server" Text="Sauvegarder" OnClick="btnsave_Click" />
              </div>

          </div>
      </div>
    </main>
    <!-- Fin Page ajouter eleve -->
     <!-- Page lister eleve -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="listereleve">
      <div class="container-fluid">
        <div class="row ">
         Lister
         
        </div>       
      </div>
    </main>
    <!-- Fin Page lister eleve -->
     <!-- Page dossier eleve -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded page" id="dossiereleve">
      <div class="container-fluid">
        <div class="row ">
          dossier
         
        </div>       
      </div>
    </main>
    <!-- Fin Page dossier eleve -->

<!-- Fin des Pages -->
    <script src="./js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/chart.js@3.0.2/dist/chart.min.js"></script>
    <script src="./js/jquery-3.5.1.js"></script>
    <script src="./js/jquery.dataTables.min.js"></script>
    <script src="./js/dataTables.bootstrap5.min.js"></script>
    <script src="./js/script.js"></script>

    </form>
</body>
</html>
