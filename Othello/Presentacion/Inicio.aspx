<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Presentacion.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="resources/css/estilos.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
</head>
<body>
    <div class="container well contenedor">
        <div class="row">
            <div class="col-sm-12">
                <h1>Othello</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <h3>Inicie sesión para continuar.</h3>
            </div>
        </div>
        <form runat="server" class="form-horizontal">

            <div class="form-group">
                <asp:Label ID="lblUser" runat="server" Text="Usuario" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtUser" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div> 

            <div class="form-group">
                <asp:Label ID="lblPassword" runat="server" Text="Contraseña" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox> 
                </div>
            </div>

            <div class="form-group">
                <asp:Button ID="btnIniciar" runat="server" Text="Iniciar sesión" OnClick="Iniciar_Click" CssClass="form-control btn btn-primary"/>
            </div>            
                        
    </form>        
    </div>   
</body>
</html>
