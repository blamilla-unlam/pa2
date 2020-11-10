<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarModelo.aspx.cs" Inherits="Concesionaria.CrearModelo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Modelos - Creación</h2>
    <%--<p>Use this area to provide additional information.</p>--%>
    <div>
        <asp:Label ID="lblMarca" runat="server">Marca</asp:Label>
        <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" MaxLength="50"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtNombre" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Button ID="btnCrear" runat="server" Text="Crear" OnClick="btnCrear_Click"/>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click"/>
    </div>
</asp:Content>
