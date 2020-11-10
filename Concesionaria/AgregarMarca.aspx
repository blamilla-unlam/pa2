<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarMarca.aspx.cs" Inherits="Concesionaria.CrearMarca" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Marcas - Creación</h2>
    <div>
        <asp:Label ID="lblDescripcion" runat="server">Descripción</asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server" MaxLength="50"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtDescripcion" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Button ID="btnCrear" runat="server" Text="Crear" OnClick="btnCrear_Click"/>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click"/>
    </div>
</asp:Content>
