<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="BancoGT.Inicio" %>
<html>
<head runat="server">
    <style type="text/css">
        body,
		html {
            padding-top:4.2rem;
		    padding-bottom:4.2rem;
		    background:rgba(0, 0, 0, 0.76);
		}
        .login-container{
        margin-top: 5%;
        margin-bottom: 5%;
        }
        .login-form-1{
            padding: 5%;
            box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
        }
        .login-form-1 h3{
            text-align: center;
            color: #333;
        }
        .login-form-2{
            padding: 5%;
            background: #0062cc;
            box-shadow: 0 5px 8px 0 rgba(0, 0, 0, 0.2), 0 9px 26px 0 rgba(0, 0, 0, 0.19);
        }
        .login-form-2 h3{
            text-align: center;
            color: #fff;
        }
        .login-container form{
            padding: 10%;
        }
        .btnSubmit
        {
            width: 50%;
            border-radius: 1rem;
            padding: 1.5%;
            border: none;
            cursor: pointer;
        }
        .login-form-1 .btnSubmit{
            font-weight: 600;
            color: #fff;
            background-color: #0062cc;
        }
        .login-form-2 .btnSubmit{
            font-weight: 600;
            color: #0062cc;
            background-color: #fff;
        }
        .login-form-2 .ForgetPwd{
            color: #fff;
            font-weight: 600;
            text-decoration: none;
        }
        .login-form-1 .ForgetPwd{
            color: #0062cc;
            font-weight: 600;
            text-decoration: none;
        }
    </style>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <title>Login</title>
  </head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="respond" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>
  
    <div class="container login-container">
            <div class="row">
                <div class="col-md-6 login-form-1">
                    <h3>Login</h3> 
                    <center>
                        <div class="form-group">
                            <asp:TextBox type="text" ID="login_codigo" runat="server" class="form-control" placeholder="Codigo de Usuario"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox type="text" ID="login_usuario" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox type="password" ID="login_contra" runat="server" class="form-control" placeholder="Contraseñ"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="Button2" class="btnSubmit" runat="server" OnClick="login_click" Text="Enviar" />                            
                        </div>    
                    </center>                                  
                </div>
                <div class="col-md-6 login-form-2">
                    <h3>Registrar</h3>
                    <center>
                    <div class="form-group">
                        <asp:TextBox type="text" ID="txtnombre" runat="server" class="form-control" placeholder="Nombre Completo"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox type="text" ID="txtusuario" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox type="text" ID="txtcorreo" runat="server" class="form-control" placeholder="Correo Electronico"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox type="password" ID="txtcontra" runat="server" class="form-control" placeholder="Contraseña"></asp:TextBox>
                    </div>
                        
                    <div class="form-group">
                        <asp:Button ID="Button1" class="btnSubmit" runat="server" OnClick="registro_click" Text="Registrar Datos" />                            
                    </div> 
                    </center>                        
                </div>
            </div>
        </div>
    </form>
</body>
</html>