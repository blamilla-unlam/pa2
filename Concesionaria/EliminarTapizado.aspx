<%@ Page Title="Modelo - Eliminar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarTapizado.aspx.cs" Inherits="Concesionaria.EliminarTapizado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="titulo-pagina">Tapizados - Eliminar</h2>
    <div class="mensaje-contenedor" style="margin-bottom: 30px;">
        <h4>
            <asp:Label ID="lblMensaje" runat="server" ForeColor="White"></asp:Label>
        </h4>
    </div>
    <div class="botones-contenedor text-center">
        <asp:Button ID="btnGuardar" runat="server" Text="Eliminar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click" CssClass="btn btn-default" />
    </div>
    <div class="alert alert-danger error-contenedor" id="errorContenedor" role="alert" runat="server">
        <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
        <span class="sr-only">Error:</span>
        <asp:Label ID="lblMensajeError" runat="server"></asp:Label>
    </div>
</asp:Content>
