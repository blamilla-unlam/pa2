<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VehiculoUpsert.aspx.cs" Inherits="Concesionaria.VehiculoUpdate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Vehículos - Actualización</h2>
    <p>Use this area to provide additional information.</p>
    <div>
        <asp:Label ID="lblMarca" runat="server">Marca</asp:Label>
        <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="lblModelo" runat="server">Modelo</asp:Label>
        <asp:DropDownList ID="ddlModelo" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="lblChasis" runat="server">Número de Chasis</asp:Label>
        <asp:TextBox ID="txtChasis" runat="server" MaxLength="50"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvChasis" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtChasis" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server">Número de Chasis</asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" MaxLength="50"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtChasis" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click"/>
    </div>
</asp:Content>
