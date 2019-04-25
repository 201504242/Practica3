<%@ Page Title="Estado_Cuenta" Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Estado_Cuenta.aspx.cs" Inherits="BancoGT.Estado_Cuenta" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        body {
            font-family: "Lato", sans-serif;
        }
        .main-head{
            height: 150px;
            background: #FFF;
   
        }

        .sidenav {
            height: 100%;
            background-color: #000;
            overflow-x: hidden;
            padding-top: 20px;
        }


        .main {
            padding: 0px 10px;
        }

        @media screen and (max-height: 450px) {
            .sidenav {padding-top: 15px;}
        }

        @media screen and (max-width: 450px) {
            .login-form{
                margin-top: 10%;
            }

            .register-form{
                margin-top: 10%;
            }
        }

        @media screen and (min-width: 768px){
            .main{
                margin-left: 40%; 
            }

            .sidenav{
                width: 40%;
                position: fixed;
                z-index: 1;
                top: 0;
                left: 0;
            }

            .login-form{
                margin-top: 80%;
            }

            .register-form{
                margin-top: 20%;
            }
        }


        .login-main-text{
            margin-top: 20%;
            padding: 60px;
            color: #fff;
        }

        .login-main-text h2{
            font-weight: 300;
        }

        .btn-black{
            background-color: #000 !important;
            color: #fff;
        }
    </style>
    <div class="sidenav">
         <div class="login-main-text">
            <h2>Estado de cuenta</h2>
            <p>&nbsp;Se muestran todos los movimientos que se han realizado en la cuenta.</p>
         </div>
      </div>
      <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
               
                  <div class="form-group">
                     &nbsp;<asp:GridView ID="GridView1" runat="server" Width="745px">
                      </asp:GridView>
                      <br />
                      <asp:Button ID="imprimir" runat="server" OnClick="imprimir_Click" Text="Imprimir" />
                  </div>
                  
               
            </div>
         </div>
      </div>
    <div>
    </div>
    <br />
<br />
<br />
<asp:Label ID="Total" runat="server"></asp:Label>
<br />
<br />
    <br />
</asp:Content>