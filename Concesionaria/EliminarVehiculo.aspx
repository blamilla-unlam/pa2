<%@ Page Title="Vehículo - Eliminar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarVehiculo.aspx.cs" Inherits="Concesionaria.EliminarVehiculo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Vehículos - Eliminar</h2>
    <div>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Button ID="btnGuardar" runat="server" Text="Eliminar" OnClick="btnGuardar_Click"/>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click"/>
    </div>
</asp:Content>
