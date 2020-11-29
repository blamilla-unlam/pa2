﻿<%@ Page Title="Vehículos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="Concesionaria.Vehiculos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="titulo-pagina"><%: Title %></h2>
    <asp:GridView ID="GridVehiculos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-striped">
        <AlternatingRowStyle BackColor="#F7F6F3" ForeColor="#284775" />
        <Columns>            
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Marca">  
                <ItemTemplate>  
                    <asp:Label ID="lblMarca" runat="server" Text='<%#Eval("Marca")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtMarca" runat="server" Text='<%#Eval("Marca")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Modelo">  
                <ItemTemplate>  
                    <asp:Label ID="lblModelo" runat="server" Text='<%#Eval("Modelo")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtModelo" runat="server" Text='<%#Eval("Modelo")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="# Chasis">  
                <ItemTemplate>  
                    <asp:Label ID="lblChasis" runat="server" Text='<%#Eval("NumeroChasis")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtChasis" runat="server" Text='<%#Eval("NumeroChasis")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="# Carrocería">  
                <ItemTemplate>  
                    <asp:Label ID="lblCarroceria" runat="server" Text='<%#Eval("NumeroCarroceria")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtCarroceria" runat="server" Text='<%#Eval("NumeroCarroceria")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Patente">  
                <ItemTemplate>  
                    <asp:Label ID="lblPatente" runat="server" Text='<%#Eval("Patente")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtPatente" runat="server" Text='<%#Eval("Patente")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="# Puertas">  
                <ItemTemplate>  
                    <asp:Label ID="lblPuertas" runat="server" Text='<%#Eval("NumeroPuertas")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtPuertas" runat="server" Text='<%#Eval("NumeroPuertas")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Color">  
                <ItemTemplate>  
                    <asp:Label ID="lblColor" runat="server" Text='<%#Eval("Color")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtColor" runat="server" Text='<%#Eval("Color")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Caja">  
                <ItemTemplate>  
                    <asp:Label ID="lblCaja" runat="server" Text='<%#Eval("Caja")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtCaja" runat="server" Text='<%#Eval("Caja")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Cilindrada">  
                <ItemTemplate>  
                    <asp:Label ID="lblCilindrada" runat="server" Text='<%#Eval("Cilindrada")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtCilindrada" runat="server" Text='<%#Eval("Cilindrada")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:TemplateField ItemStyle-Width="600px" HeaderText="Tapizado">  
                <ItemTemplate>  
                    <asp:Label ID="lblTapizado" runat="server" Text='<%#Eval("Tapizado")%>'></asp:Label>  
                </ItemTemplate>  
                <EditItemTemplate>  
                    <asp:TextBox ID="txtTapizado" runat="server" Text='<%#Eval("Tapizado")%>'></asp:TextBox>  
                </EditItemTemplate>  
                <ItemStyle Width="300px"></ItemStyle>
            </asp:TemplateField> 
            <asp:BoundField DataField="VehiculoID" HtmlEncode="False" DataFormatString="<a href='ActualizarVehiculo.aspx?vehiculoid={0}'><span class='glyphicon glyphicon-pencil'></span></a>" />            
            <asp:BoundField DataField="VehiculoID" HtmlEncode="False" DataFormatString="<a href='EliminarVehiculo.aspx?vehiculoid={0}'><span class='glyphicon glyphicon-trash'></span></a>" />            
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
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Vehículo" OnClick="btnNuevo_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>
