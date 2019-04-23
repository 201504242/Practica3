<%@ Page Title="Transferencias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="BancoGT.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="sidenav">
         <div class="login-main-text">
            <h2>Transferencias <br> Bancarias</h2>
            <p>Traspasos de fondos desde una cuenta a otra</p>
         </div>
      </div>
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
      <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
                <div class="alert alert-success">                  
                    <asp:Label ID="msg" runat="server" Text="LLena los datos..!"></asp:Label>
                </div>

                    
                  <div class="form-group">
                     <label>Numero de Cuenta</label>
                      <asp:TextBox type="text" ID="txtcuenta" runat="server" class="form-control" placeholder="Numero de Cuenta Destino"></asp:TextBox>
                  </div>
                  <div class="form-group">
                     <label>Monto a Transferir</label>
                      <asp:TextBox type="text" ID="txtmonton" runat="server" class="form-control" placeholder="Monto"></asp:TextBox>
                  </div>
                   <asp:Button ID="Button1" class="btn btn-black" runat="server" OnClick="trans_click" Text="Enviar" />                                           
            </div>
         </div>
      </div>
    <br />
</asp:Content>
