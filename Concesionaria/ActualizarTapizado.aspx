<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarTapizado.aspx.cs" Inherits="Concesionaria.ActualizarTapizado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="titulo-pagina">Tapizados - Actualización</h2>
    <div class="form-group col-sm-12" style="margin-bottom: 30px;">
        <h5 class="col-sm-4">
            <asp:Label ID="lblDescripcion" runat="server">Descripción</asp:Label>
        </h5>
        <asp:TextBox ID="txtDescripcion" runat="server" MaxLength="50" CssClass="form-control col-sm-8"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtDescripcion" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </div>
    <div class="text-center">
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CausesValidation="False" OnClick="btnVolver_Click" CssClass="btn btn-default" />
    </div>
</asp:Content>
