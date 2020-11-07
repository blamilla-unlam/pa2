<%@ Page Title="Vehículo - Eliminar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VehiculoDelete.aspx.cs" Inherits="Concesionaria.VehiculoDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Vehículos - Eliminar</h2>
    <p>Use this area to provide additional information.</p>
    <div>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Button ID="btnGuardar" runat="server" Text="Eliminar" OnClick="btnGuardar_Click"/>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click"/>
    </div>
</asp:Content>
