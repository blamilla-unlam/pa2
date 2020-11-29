<%@ Page Title="Vehículo - Eliminar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarVehiculo.aspx.cs" Inherits="Concesionaria.EliminarVehiculo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="titulo-pagina">Vehículos - Eliminar</h2>
    <div style="margin-bottom: 30px;">
        <h4>
            <asp:Label ID="lblMensaje" runat="server" ForeColor="White"></asp:Label>
        </h4>
    </div>
    <div class="text-center">
        <asp:Button ID="btnGuardar" runat="server" Text="Eliminar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click" CssClass="btn btn-default" />
    </div>
</asp:Content>
