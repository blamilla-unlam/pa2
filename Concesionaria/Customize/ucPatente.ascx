<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucPatente.ascx.cs" Inherits="Concesionaria.Customize.ucPatente" %>
<asp:TextBox ID="txtPatente" MaxLength="7" runat="server" CssClass="form-control"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvPatente" runat="server" ControlToValidate="txtPatente" ErrorMessage="Campo obligatorio" ForeColor="#CC0000" ></asp:RequiredFieldValidator>
