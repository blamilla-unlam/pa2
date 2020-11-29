<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarVehiculo.aspx.cs" Inherits="Concesionaria.ActualizarVehiculo" %>

<%@ Register Src="~/Customize/ucPatente.ascx" TagPrefix="uc1" TagName="ucPatente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="titulo-pagina">Vehículos - Actualización</h2>
    <div class="form-group col-sm-12">
        <h5 class="col-sm-4">
            <asp:Label ID="lblMarca" runat="server">Marca</asp:Label>
        </h5>
        <asp:DropDownList ID="ddlMarca" runat="server" CssClass="form-control col-sm-8"></asp:DropDownList>
    </div>
    <div class="form-group col-sm-12">
        <h5 class="col-sm-4">
            <asp:Label ID="lblModelo" runat="server">Modelo</asp:Label>
        </h5>
        <asp:DropDownList ID="ddlModelo" runat="server" CssClass="form-control col-sm-8"></asp:DropDownList>
    </div>
    <div class="form-group col-sm-12">
        <h5 class="col-sm-4">
            <asp:Label ID="lblChasis" runat="server">Número de Chasis</asp:Label>
        </h5>
        <asp:TextBox ID="txtChasis" runat="server" MaxLength="50" CssClass="form-control col-sm-8"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvChasis" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtChasis" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group col-sm-12">
        <h5 class="col-sm-4">
            <asp:Label ID="lblCarroceria" runat="server">Número de Carrocería</asp:Label>
        </h5>
        <asp:TextBox ID="txtCarroceria" runat="server" MaxLength="50" CssClass="form-control col-sm-8"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCarroceria" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtCarroceria" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group col-sm-12">
        <h5 class="col-sm-4">
            <asp:Label ID="lblPatente" runat="server">Número de Patente</asp:Label>
        </h5>
        <%--<asp:TextBox ID="txtPatente" runat="server" MaxLength="7" CssClass="form-control col-sm-8"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPatente" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtPatente" ForeColor="#CC0000"></asp:RequiredFieldValidator>--%>
        <uc1:ucPatente runat="server" id="ucPatente" CssClass="col-sm-8"/>
    </div>
    <div class="form-group col-sm-12">
        <h5 class="col-sm-4">
            <asp:Label ID="lblPuertas" runat="server">Número de Puertas</asp:Label>
        </h5>
        <asp:TextBox ID="txtPuertas" runat="server" TextMode="Number" CssClass="form-control col-sm-8"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPuertas" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtPuertas" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group col-sm-12">
        <h5 class="col-sm-4">
            <asp:Label ID="lblColor" runat="server">Color</asp:Label>
        </h5>
        <asp:DropDownList ID="ddlColor" runat="server" CssClass="form-control col-sm-8"></asp:DropDownList>
    </div>
    <div class="form-group col-sm-12">
        <h5 class="col-sm-4">
            <asp:Label ID="lblCaja" runat="server">Caja</asp:Label>
        </h5>
        <asp:DropDownList ID="ddlCaja" runat="server" CssClass="form-control col-sm-8"></asp:DropDownList>
    </div>
    <div class="form-group col-sm-12">
        <h5 class="col-sm-4">
            <asp:Label ID="lblCilindrada" runat="server">Cilindrada</asp:Label>
        </h5>
        <asp:TextBox ID="txtCilindrada" runat="server" TextMode="Number" CssClass="form-control col-sm-8"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCilindrada" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtCilindrada" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group col-sm-12" style="margin-bottom: 30px;">
        <h5 class="col-sm-4">
            <asp:Label ID="lblTapizado" runat="server">Tapizado</asp:Label>
        </h5>
        <asp:DropDownList ID="ddlTapizado" runat="server" CssClass="form-control col-sm-8"></asp:DropDownList>
    </div>
    <div class="text-center">
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click" CssClass="btn btn-default" />
    </div>
</asp:Content>
