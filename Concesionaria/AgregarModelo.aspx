<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarModelo.aspx.cs" Inherits="Concesionaria.CrearModelo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="titulo-pagina">Modelos - Creación</h2>
    <div class="form-group col-sm-12" style="margin-bottom: 30px;">
        <h5 class="col-sm-4">
            <asp:Label ID="lblMarca" runat="server">Marca</asp:Label>
        </h5>
        <asp:DropDownList ID="ddlMarca" runat="server" CssClass="form-control col-sm-8"></asp:DropDownList>
    </div>
    <div class="form-group col-sm-12" style="margin-bottom: 30px;">
        <h5 class="col-sm-4">
            <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
        </h5>
        <asp:TextBox ID="txtNombre" runat="server" MaxLength="50" CssClass="form-control col-sm-8"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtNombre" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div class="text-center">
        <asp:Button ID="btnCrear" runat="server" Text="Crear" OnClick="btnCrear_Click" CssClass="btn btn-primary" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click" CssClass="btn btn-default" />
    </div>
</asp:Content>
