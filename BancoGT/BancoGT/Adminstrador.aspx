<%@ Page Language="C#" Title="Administrador" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adminstrador.aspx.cs" Inherits="BancoGT.Adminstrador" %>

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
            <div class="alert alert-success ">
                <asp:Label ID="alerta"  class="alert-link" runat="server" Text="Saldo Inicial"></asp:Label>
            </div>
                 
            <div class="dropdown">
                <label>Listado Usuario:</label>
                <asp:ListBox ID="listUsuario" class="btn btn-secondary dropdown-toggle" runat="server"></asp:ListBox>
            </div>
            <br />
            <div class="form-group">
                <label>Monto a Añadir:</label>
                <asp:TextBox type="text" ID="monto" runat="server" class="form-control" placeholder="Monto"></asp:TextBox>
            </div>
            <asp:Button ID="Button2" class="btn btn-white" runat="server" OnClick="montoInicial_click" Text="Agregar" />                            
        </div>
    </div>
    
      <div class="main">          
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
                <asp:GridView ID="GridView1" runat="server" 
                    OnSelectedIndexChanged="GridView1_SelectedIndexChanged1"
                     CssClass="table table-striped">
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Aceptar Credito" ShowHeader="True" ShowSelectButton="True" />
                    </Columns>
                   
                </asp:GridView> 
            </div>
         </div>
      </div>
    <br />
</asp:Content>