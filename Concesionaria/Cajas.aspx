<%@ Page Title="Cajas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cajas.aspx.cs" Inherits="Concesionaria.Caja" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="titulo-pagina"><%: Title %></h2>
    <asp:GridView ID="GridCajas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-striped table-hover">
        <AlternatingRowStyle BackColor="#F7F6F3" ForeColor="#284775" />
        <Columns>            
            <asp:TemplateField HeaderText="Descripción">  
                <ItemTemplate>  
                    <asp:Label ID="lblDescripcion" runat="server" Text='<%#Eval("Nombre")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtDescripcion" runat="server" Text='<%#Eval("Nombre")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle></ItemStyle>
            </asp:TemplateField> 
            <asp:BoundField DataField="CajaID" HtmlEncode="False" DataFormatString="<a href='ActualizarCaja.aspx?cajaid={0}'><span class='glyphicon glyphicon-pencil'></span></a>" />
            <asp:BoundField DataField="CajaID" HtmlEncode="False" DataFormatString="<a href='EliminarCaja.aspx?cajaid={0}'><span class='glyphicon glyphicon-trash'></span></a>" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#FFFFFF" Font-Bold="True" ForeColor="Black" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#d9edf7" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <div>
        <asp:Button ID="btnNuevo" runat="server" Text="Nueva Caja" OnClick="btnNuevo_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>
