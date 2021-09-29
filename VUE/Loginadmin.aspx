<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginadmin.aspx.cs" Inherits="UNITECH_ACADEMEIC_SYSTEME.VUE.Loginadmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Connection administration</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link
      rel="stylesheet"
      href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css"
    />
</head>
<body>
    <form id="form1" runat="server">
        <section class="vh-100">
            <div class="d-flex flex-column flex-md-row text-center text-md-start justify-content-center mb-5 py-4 px-4 px-xl-5 bg-primary">
    <!-- Copyright -->
    <div class="text-white mb-3 mb-md-0">
      UNITECH ACADEMIC SYSTEM
    </div>
    <!-- Copyright -->   
  </div>
  <div class="container-fluid h-custom ">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-md-9 col-lg-6 col-xl-5">
          <asp:Image ID="Image1" class="img-fluid" runat="server" ImageUrl="~/VUE/Images/logo.png" />
      </div>
      <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1 mt-3">
       
         
          <!-- PIN input -->
          <div class="form-outline mb-4">
              <asp:TextBox ID="tpinuser" runat="server"  placeholder="Entrer un PIN valide" class="form-control form-control-lg"></asp:TextBox>
            <label class="form-label" for="form3Example3">PIN</label>
          </div>

          <!-- Password input -->
          <div class="form-outline mb-3">
              <asp:TextBox ID="tpassuser" runat="server" TextMode="Password" placeholder="Entrer mot de passe" class="form-control form-control-lg" MaxLength="5"></asp:TextBox>
            <label class="form-label" for="form3Example4">Mot de passe</label>
          </div>
           <asp:Label ID="lmsg" runat="server" Text=""></asp:Label>

          <div class="d-flex justify-content-between align-items-center">
            <!-- Checkbox -->
            <div class="form-check mb-0">
              <input class="form-check-input me-2" type="checkbox" value="" id="form2Example3" />
              <label class="form-check-label" for="form2Example3">
                Remember me
              </label>
            </div>
             
            <a href="#!" class="text-body">Mot de passe oublié?</a>
          </div>

          <div class="text-center text-lg-start mt-4 pt-2">
              <asp:Button ID="Button1" runat="server" Text="Connecter" class="btn btn-primary btn-lg"
              style="padding-left: 2.5rem; padding-right: 2.5rem;" OnClick="Button1_Click"/>
          </div>

      </div>
    </div>
  </div>
  <div class="d-flex flex-column flex-md-row text-center text-md-start justify-content-center mt-5 py-4 px-4 px-xl-5 bg-primary">
    <!-- Copyright -->
    <div class="text-white mb-3 mb-md-0">
      Copyright © 2020. All rights reserved.
    </div>
    <!-- Copyright -->   
  </div>
</section>
         <script src="./js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/chart.js@3.0.2/dist/chart.min.js"></script>
    <script src="./js/jquery-3.5.1.js"></script>
    <script src="./js/jquery.dataTables.min.js"></script>
    <script src="./js/dataTables.bootstrap5.min.js"></script>
    <script src="./js/script.js"></script>
    </form>
</body>
</html>
