<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="GCTicketsWeb.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <br/>
    <br/>

    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Both" RepeatColumns="2" RepeatDirection="Horizontal">
         <FooterStyle BackColor="White" ForeColor="#000066" />
         <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
         <ItemStyle ForeColor="#000066" />
         <ItemTemplate>
             <table class="auto-style2">
               <tr>
                <td><asp:Label ID="NombreEventoLabel" runat="server" Text='<%# Eval("NombreEvento") %>'></asp:Label></td>
               </tr>
                 <tr>
                     <td><h3> <%# Eval("FechaEvento")  %></h3></td>
                 </tr>
                 <tr>
                     <td><h3> <%# Eval("LugarEvento")  %></h3></td>
                 </tr>
                  <tr>
                     <td>
                         <asp:LinkButton runat="server" CssClass="btn btn-success" Text ="Comprar" CommandName="Select" ></asp:LinkButton> 
                  </tr>
             </table>
             </ItemTemplate>
         <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
</asp:Content>
