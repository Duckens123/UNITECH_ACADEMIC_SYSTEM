<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashboardEtudiant.aspx.cs" Inherits="UNITECH_ACADEMEIC_SYSTEME.VUE.DashboardEtudiant" %>

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
                <li class="btn btn-danger"> <asp:Button ID="btnlogout" class="dropdown-item" runat="server" Text="Deconnection" /></li>
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
                <span>Info</span>
                <span class="ms-auto">
                  <span class="right-icon">
                    <i class="bi bi-chevron-down"></i>
                  </span>
                </span>
              </a>
              <div class="collapse" id="layouts">
                <ul class="navbar-nav ps-3">
                  
                   <li>
                    <a href="#" class="nav-link px-3 menu" >
                      <span class="me-2"
                        ><i class="bi bi-list-ol"></i
                      ></span>
                      <span>
                          <asp:Button ID="btnbulletin" CssClass="btn btn-light" runat="server" Text="Bulletin" OnClick="btnbulletin_Click" />

                      </span>
                    </a>
                  </li>
                  <li>
                    <a href="#" class="nav-link px-3 menu" >
                      <span class="me-2"
                        ><i class="bi bi-folder"></i
                      ></span>
                      <span>Mon dossier</span>
                    </a>
                  </li>
                </ul>
              </div>
            </li>
            
          </ul>
        </nav>
      </div>
    </div>
    <!-- offcanvas -->
    <!-- Les Pages -->
     <!-- Page acceuil -->
    <main class="mt-5 pt-3 shadow-lg p-3 mb-5 bg-body rounded">
      <div class="container-fluid">
        <div class="row d-flex justify-content-evenly">
         <div class="row d-flex justify-content-between">
             <asp:DropDownList ID="ddsession" AutoPostBack="true" runat="server" >
                 <asp:ListItem>I</asp:ListItem>
                 <asp:ListItem>II</asp:ListItem>
             </asp:DropDownList>
             <asp:Button ID="Button1" runat="server" Text="Rechercher" OnClick="Button1_Click" />
             <asp:PlaceHolder ID="tablebulletin" runat="server"></asp:PlaceHolder>
             <CR:CrystalReportViewer ID="crpnoteetu" runat="server" AutoDataBind="true" />
                      
             <CR:CrystalReportViewer ID="rpbulletin" runat="server" Visible="true" AutoDataBind="true" OnDataBinding="Page_Load" OnInit="Page_Load" />
           
         </div>
         
        </div>       
      </div>
    </main>
    <!-- Fin Page acceuil -->

         
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
