<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashboardEtudiant.aspx.cs" Inherits="UNITECH_ACADEMEIC_SYSTEME.VUE.DashboardEtudiant" %>

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
    <title>Mon portail</title>
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
                <span>Elève</span>
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
                      <span>Ajouter un nouveau élève</span>
                    </a>
                  </li>
                   <li>
                    <a href="#" class="nav-link px-3 menu" data-page="listereleve">
                      <span class="me-2"
                        ><i class="bi bi-list-ol"></i
                      ></span>
                      <span>Liste élève</span>
                    </a>
                  </li>
                  <li>
                    <a href="#" class="nav-link px-3 menu" data-page="dossiereleve">
                      <span class="me-2"
                        ><i class="bi bi-folder"></i
                      ></span>
                      <span>Dossier élève</span>
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
                <span>Charts</span>
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
        <div class="row ">
          Ajouter
         
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
          <!-- Button trigger modal -->
<!-- Button trigger modal -->
<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#staticBackdrop">
  Launch static backdrop modal
</button>

<!-- Modal -->
<div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="staticBackdropLabel">Modal title</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        ...
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Understood</button>
      </div>
    </div>
  </div>
</div>
         
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
