<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuDataList.aspx.cs" Inherits="GCTicketsWeb.MenuDataList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <br/>
    <br/>
    <div>
        <asp:DataList ID="MenuDataList1" runat="server" CellPadding="4" ForeColor="#333333">
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                <table>
                    <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Fecha</th>
                        <th>Lugar</th>
                    </tr>
                    </thead>
               <tbody>
            </HeaderTemplate>

            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />

            <ItemTemplate>
                <tr>
                    <td><%#Eval("NombreEvento") %></td>
                    <td><%#Eval("FechaEvento") %></td>
                    <td><%#Eval("LugarEvento") %></td>
                </tr>
            </ItemTemplate>
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <FooterTemplate>
                </tbody>
                 </table>
            </FooterTemplate>
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    </div>
</asp:Content>
