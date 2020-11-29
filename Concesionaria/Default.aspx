<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Concesionaria._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row home-contenedor">
        <div class="col-md-4">
            <div class="home-menu-item-contenedor">
                <a runat="server" href="~/Vehiculos">                        
                    Vehículos
                </a>
            </div>    
        </div>
        <div class="col-md-4">
            <div class="home-menu-item-contenedor">
                <a runat="server" href="~/Marcas">                        
                    Marcas
                </a>
            </div>   
        </div>
        <div class="col-md-4">
            <div class="home-menu-item-contenedor">
                <a runat="server" href="~/Modelos">                        
                    Modelos
                </a>
            </div> 
        </div>
        <div class="col-md-4">
            <div class="home-menu-item-contenedor">
                <a runat="server" href="~/Cajas">                        
                    Cajas
                </a>
            </div> 
        </div>
        <div class="col-md-4">
            <div class="home-menu-item-contenedor">
                <a runat="server" href="~/Colores">
                    Colores
                </a>
            </div> 
        </div>
        <div class="col-md-4">
            <div class="home-menu-item-contenedor">
                <a runat="server" href="~/Tapizados">
                    Tapizados
                </a>
            </div> 
        </div>
    </div>
</asp:Content>
