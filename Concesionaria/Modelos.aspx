<%@ Page Title="Modelos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modelos.aspx.cs" Inherits="Concesionaria.Modelo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="titulo-pagina"><%: Title %></h2>
    <asp:GridView ID="GridModelos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-striped table-hover">
        <AlternatingRowStyle BackColor="#F7F6F3" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="Marca">  
                <ItemTemplate>  
                    <asp:Label ID="lblMarca" runat="server" Text='<%#Eval("Marca")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtMarca" runat="server" Text='<%#Eval("Marca")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="Modelo">  
                <ItemTemplate>  
                    <asp:Label ID="lblModelo" runat="server" Text='<%#Eval("Nombre")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtModelo" runat="server" Text='<%#Eval("Nombre")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle></ItemStyle>
            </asp:TemplateField> 
            <asp:BoundField DataField="ModeloID" HtmlEncode="False" DataFormatString="<a href='ActualizarModelo.aspx?modeloid={0}'><span class='glyphicon glyphicon-pencil'></span></a>" />
            <asp:BoundField DataField="ModeloID" HtmlEncode="False" DataFormatString="<a href='EliminarModelo.aspx?modeloid={0}'><span class='glyphicon glyphicon-trash'></span></a>" />
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
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Modelo" OnClick="btnNuevo_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>
