<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="Presentacion.registro" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro</title>
    <link href="resources/css/estilos.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
</head>
<body>
    <div class="container well formulario">        
        <form id="form1" runat="server" class="form-horizontal">
            <asp:ScriptManager ID="smRegistro" runat="server"></asp:ScriptManager>

            <div class="row">
                <div class="col-sm-12">
                    <h3>Regístrate</h3>
                </div>
            </div>
            <div class="form-group">                
                <asp:Label ID="lblNombre" runat="server" Text="Nombres" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    
                </div>
            </div>

            <div class="form-group">                
                <asp:Label ID="lblApellido" runat="server" Text="Apellidos" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                    
                </div>
            </div>

            <div class="form-group">                
                <asp:Label ID="lblUser" runat="server" Text="Nombre de usuario" CssClass="control-label col-sm-2"></asp:Label>
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
                <asp:Label ID="lblConfirmar" runat="server" Text="Confirmar contraseña" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtConfirmar" runat="server" CssClass="form-control"></asp:TextBox>
                    
                </div>
            </div>

            <div class="form-group">                
                <asp:Label ID="lblDate" runat="server" Text="Fecha de nacimiento" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    
                </div>
            </div>

            <div class="form-group">                
                <asp:Label ID="lblPais" runat="server" Text="Pais" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtPais" runat="server" CssClass="form-control"></asp:TextBox>
                    
                </div>
            </div>

            <div class="form-group">                
                <asp:Label ID="lblCorreo" runat="server" Text="E-mail" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                    
                </div>
            </div>

            <div class="form-group">
                <asp:Button ID="btnRegistrar" runat="server" Text="Completar registro" OnClick="btnRegistrar_Click" CssClass="form-control btn btn-primary"/>                
                <asp:LinkButton ID="lnkLogin" runat="server" OnClick="lnkLogin_Click">¿Ya tienes una cuenta? Inicia sesión</asp:LinkButton>
            </div>
        </form>
    </div>
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>
