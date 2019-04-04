<%@ Page Title="BancoGT" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>BancoGT</h1>
        <p class="lead">El Banco de Guatemala (BANCOGT) es el banco central de la República de Guatemala. Es una entidad estatal autónoma con patrimonio propio capaz de adquirir derechos y contraer obligaciones</p>
        <p>
            <center><img src="image/fondo.jpg" class="img-thumbnail" alt="fondo" height="250" width="500"/></center>
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Transferencia Bancarias</h2>
            <p>
                <center><img src="image/trans.jpg" class="img-rounded" alt="trans" height="200" width="200"/></center>
                <br />
                La transferencia electrónica de dinero de una cuenta bancaria a otra, ya sea en 
                una sola institución financiera o en varias instituciones, a través de los sistemas
                 basados en ordenador y sin la intervención directa del personal del banco
            </p>
            <p>
                <a class="btn btn-default" href="Contact">Ir a Transferencias &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Creditos</h2>
            <p>
                <center><img src="image/cretido.jpg" class="img-rounded" alt="credito" height="100" width="200"/></center>
                <br />
                El crédito o contrato de crédito es una operación financiera en la que una persona (el acreedor) realiza un préstamo por una cantidad determinada de dinero a otra persona 
            </p>
            <p>
                <a class="btn btn-default" href="About">Ir a Creditos &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Debitos</h2>
            <p>
                <center><img src="image/debito.jpg" class="img-rounded" alt="debito" height="150" width="200"/></center>
                <br />
                El débito contable es una constancia que sirve para comprobar que se ha cumplido con el pago o solución de una obligación o prestación de un servicio o producto.
            </p>
            <p>
                <a class="btn btn-default" href="Debito">Ir Debito &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
