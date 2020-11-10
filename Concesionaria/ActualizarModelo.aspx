<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarModelo.aspx.cs" Inherits="Concesionaria.ActualizarModelo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Modelos - Actualización</h2>
    <%--<p>Use this area to provide additional information.</p>--%>
    <div>
        <asp:Label ID="lblMarca" runat="server">Nombre</asp:Label>
        <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" MaxLength="50"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtNombre" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click"/>
    </div>
</asp:Content>
