﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="GCTicketsWeb.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <br/>
    <br/>

       <!-- Page Head -->
        <div class="row">
             <div class="text-center">
                <div class="col-md-12">
                   <h1 class="page-header"> Eventos </h1>               
            </div>
         </div>  
        </div> 

         <%--Menu de eventos  --%> 
        <div class="text-center">
            <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Both" RepeatColumns="2" RepeatDirection="Horizontal" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <ItemStyle ForeColor="#000066" />
                 <ItemTemplate>
                     <table class="auto-style2">
                          <tr>
                             <td><h3> <%# Eval("NombreEvento")  %></h3></td>
                          </tr>
                         <tr>                            
                             <td><asp:Label ID="FechaEventoLabel" runat="server" Text="Fecha del evento"></asp:Label></td>
                         </tr>
                          <tr>
                             <td><h2> <%# Eval("FechaEvento")  %></h2></td>
                          </tr>
                         <tr>                            
                            <td><asp:Label ID="LugarEventoLabel" runat="server" Text="Lugar del evento"></asp:Label></td>
                         </tr>
                          <tr>
                            <td><h2> <%# Eval("LugarEvento")  %></h2></td>
                         </tr>
                         <tr>
                         <td>
                            <li>
                                <a href="/Registros/VentasForm.aspx" class="btn btn-success">Comprar<i class="fa fa-ticket"></i></a>
                            </li>  
                         </td>
                         </tr>
                  </table>
               </ItemTemplate>
             <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            </asp:DataList>
        </div> 
</asp:Content>
