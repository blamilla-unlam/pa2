<%@ Page Title="Modelo - Eliminar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarColor.aspx.cs" Inherits="Concesionaria.EliminarColor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Colores - Eliminar</h2>
    <div>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Button ID="btnGuardar" runat="server" Text="Eliminar" OnClick="btnGuardar_Click"/>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click"/>
    </div>
</asp:Content>
