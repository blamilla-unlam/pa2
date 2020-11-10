<%@ Page Title="Colores" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Colores.aspx.cs" Inherits="Concesionaria.Color" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <asp:GridView ID="GridColores" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>            
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Descripción">  
                <ItemTemplate>  
                    <asp:Label ID="lblDescripcion" runat="server" Text='<%#Eval("Nombre")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtDescripcion" runat="server" Text='<%#Eval("Nombre")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:BoundField DataField="ColorID" HtmlEncode="False" DataFormatString="<a href='ActualizarColor.aspx?colorid={0}'><img src='Icons/Edit.png' width='25px' height='25px'/></a>" />            
            <asp:BoundField DataField="ColorID" HtmlEncode="False" DataFormatString="<a href='EliminarColor.aspx?colorid={0}'><img src='Icons/Delete.png' width='25px' height='25px'/></a>" />            
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
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Color" OnClick="btnNuevo_Click"/>
    </div>
</asp:Content>
