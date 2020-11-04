<%@ Page Title="Modelos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modelo.aspx.cs" Inherits="Concesionaria.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <asp:GridView ID="GridModelos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Marca">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("Marca")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("Marca")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Modelo">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("Modelo")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("Modelo")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:BoundField DataField="ModeloID" HtmlEncode="False" DataFormatString="<a href='ModeloUpsert.aspx?modeloid={0}'><img src='Icons/Edit.png' width='25px' height='25px'/></a>" />            
            <asp:BoundField DataField="ModeloID" HtmlEncode="False" DataFormatString="<a href='ModeloDelete.aspx?modeloid={0}'><img src='Icons/Delete.png' width='25px' height='25px'/></a>" />            
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <div>
        <br />
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Modelo" OnClick="btnNuevo_Click"/>
    </div>
</asp:Content>
