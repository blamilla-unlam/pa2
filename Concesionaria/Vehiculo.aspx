<%@ Page Title="Vehiculos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculo.aspx.cs" Inherits="Concesionaria.Vehiculos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <asp:GridView ID="GridVehiculos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Vehículo">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("Vehiculo")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("Vehiculo")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
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
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="# Chasis">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("NumeroChasis")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("NumeroChasis")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="# Carrocería">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("NumeroCarroceria")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("NumeroCarroceria")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Patente">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("Patente")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("Patente")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="# Puertas">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("NumeroPuertas")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("NumeroPuertas")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Color">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("Color")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("Color")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Caja">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("Caja")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("Caja")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Cilindrada">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("Cilindrada")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("Cilindrada")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Tapizado">  
                <ItemTemplate>  
                    <asp:Label ID="lblService" runat="server" Text='<%#Eval("Tapizado")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("Tapizado")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:BoundField DataField="VehiculoID" HtmlEncode="False" DataFormatString="<a href='VehiculoUpsert.aspx?vehiculoid={0}'><img src='Icons/Edit.png' width='25px' height='25px'/></a>" />            
            <asp:BoundField DataField="VehiculoID" HtmlEncode="False" DataFormatString="<a href='VehiculoDelete.aspx?vehiculoid={0}'><img src='Icons/Delete.png' width='25px' height='25px'/></a>" />            
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
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Vehiculo" OnClick="btnNuevo_Click"/>
    </div>
</asp:Content>
