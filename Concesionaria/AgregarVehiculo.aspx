<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarVehiculo.aspx.cs" Inherits="Concesionaria.CrearVehiculo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Vehículos - Creación</h2>
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
        <asp:Label ID="lblCarroceria" runat="server">Número de Carrocería</asp:Label>
        <asp:TextBox ID="txtCarroceria" runat="server" MaxLength="50"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCarroceria" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtCarroceria" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblPatente" runat="server">Número de Patente</asp:Label>
        <asp:TextBox ID="txtPatente" runat="server" MaxLength="7"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPatente" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtPatente" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblPuertas" runat="server">Número de Puertas</asp:Label>
        <asp:TextBox ID="txtPuertas" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPuertas" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtPuertas" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblColor" runat="server">Color</asp:Label>
        <asp:DropDownList ID="ddlColor" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="lblCaja" runat="server">Caja</asp:Label>
        <asp:DropDownList ID="ddlCaja" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="lblCilindrada" runat="server">Cilindrada</asp:Label>
        <asp:TextBox ID="txtCilindrada" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCilindrada" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtCilindrada" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblTapizado" runat="server">Tapizado</asp:Label>
        <asp:DropDownList ID="ddlTapizado" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click"/>
    </div>
</asp:Content>
