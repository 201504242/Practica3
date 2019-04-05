<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adminstrador.aspx.cs" Inherits="BancoGT.Adminstrador" %>

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
            <h2>Creditos <br> Bancarios</h2>
            <p>Solicitud al banco un crédito bancario, recibiendo cierta suma o valor
extra de dinero que deberá devolver (pagar) al finalizar el período de tiempo acordado por el
banco.</p>
         </div>
      </div>
      <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
               
                  <div class="form-group">
                     <label>Descripción de la razón para solicitar el crédito:</label>
                      <asp:TextBox type="text" ID="txtdescripcion" runat="server" class="form-control" placeholder="Descripcion"></asp:TextBox>
                  </div>
                  <div class="form-group">
                     <label>Monto del Credito</label>
                      <asp:TextBox type="text" ID="txtmonto_credito" runat="server" class="form-control" placeholder="Monto"></asp:TextBox>
                  </div>
                   <asp:Button ID="Button1" class="btn btn-black" runat="server" OnClick="debito_click" Text="Enviar" />                            
                  
               
            </div>
         </div>
      </div>
    <br />
</asp:Content>