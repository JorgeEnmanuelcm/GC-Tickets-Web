<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuariosForm.aspx.cs" Inherits="GCTicketsWeb.Registros.UsuariosForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <script src="JQuery/bootstrap.min.js"></script>

    <br/><br/>
    <br/><br/>
    <br/><br/>   
     
   <!-- Page Head -->
        <div class="row">
             <div class="text-center">
                <div class="col-md-12">
                   <h1 class="page-header"> Usuarios </h1>
            </div>
         </div>  
        </div> 

    <%--UsuarioId--%>
         <div class="form-group">
             <div class="col-md-12">
                <asp:Label ID="UsuarioIdLabel" For="UsuarioIdTexBox" runat="server" Font-Bold="True" Text="Usuario Id:"></asp:Label>
              </div>
             <div class="col-md-6 col-xs-8">
                  <asp:TextBox ID="UsuarioIdTextBox" runat="server" CssClass="form-control" placeholder="Usuario Id"></asp:TextBox>
             </div>
         </div>
         <asp:Button ID="BuscarButton" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="BuscarButton_Click"/>
       <br/><br/><br/> 
    
     <%--Nombres--%>
         <div class="form-group">
             <div class="col-md-12">
                <asp:Label ID="NombresLabel" For="NombresTexBox" runat="server" Font-Bold="True" Text="Nombres: "></asp:Label>
              </div>
             <div class="col-md-6 col-xs-8">
                  <asp:TextBox ID="NombresTextBox" runat="server" CssClass="form-control" placeholder="Nombres"></asp:TextBox> 
             </div>
         </div>
        <br/><br/><br/> 

    <%--Apellidos--%>
        <div class="form-group">
             <div class="col-md-12">
                <asp:Label ID="ApellidosLabel" For="ApellidosTexBox" runat="server" Font-Bold="True" Text="Apellidos:"></asp:Label>
              </div>
             <div class="col-md-6 col-xs-8">
                  <asp:TextBox ID="ApellidosTextBox" runat="server" CssClass="form-control" placeholder="Apellidos"></asp:TextBox> 
             </div>
         </div>
        <br/><br/><br/> 

    <%--Telefono--%>
         <div class="form-group">
             <div class="col-md-12">
                <asp:Label ID="TelefonoLabel" For="TelefonoTexBox" runat="server" Font-Bold="True" Text="Telefono:"></asp:Label>
              </div>
             <div class="col-md-6 col-xs-8">
                  <asp:TextBox ID="TelefonoTextBox" runat="server" CssClass="form-control" placeholder="Telefono"></asp:TextBox> 
             </div>
         </div>
        <br/><br/><br/>

    <%--Email--%>
        <div class="form-group">
             <div class="col-md-12">
                <asp:Label ID="EmailLabel" For="EmailTexBox" runat="server" Font-Bold="True" Text="Email:"></asp:Label>
              </div>
             <div class="col-md-6 col-xs-8">
                  <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox> 
             </div>
         </div>
        <br/><br/><br/>

    <%--Direccion--%>
        <div class="form-group">
             <div class="col-md-12">
                <asp:Label ID="DireccionLabel" For="DireccionTexBox" runat="server" Font-Bold="True" Text="Direccion:"></asp:Label>
              </div>
             <div class="col-md-6 col-xs-8">
                  <asp:TextBox ID="DireccionTextBox" runat="server" CssClass="form-control" placeholder="Direccion"></asp:TextBox> 
             </div>
         </div>
        <br/><br/><br/>

    <%--NombreUsuario--%>
        <div class="form-group">
             <div class="col-md-12">
                <asp:Label ID="NombreUsuarioLabel" For="NombreUsuarioTexBox" runat="server" Font-Bold="True" Text="Nombre Usuario:"></asp:Label>
              </div>
             <div class="col-md-6 col-xs-8">
                  <asp:TextBox ID="NombreUsuarioTextBox" runat="server" CssClass="form-control" placeholder="Nombre Usuario"></asp:TextBox> 
             </div>
         </div>
        <br/><br/><br/>

    <%--Contraseña--%>
        <div class="form-group">
             <div class="col-md-12">
                <asp:Label ID="ContraseniaLabel" For="ContraseniaTexBox" runat="server" Font-Bold="True" Text="Contraseña:"></asp:Label>
              </div>
             <div class="col-md-6 col-xs-8">
                  <asp:TextBox ID="ContraseniaTextBox" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox> 
             </div>
         </div>
        <br/><br/><br/>

    <%--Buttons--%>
        <div class="panel-footer">
              <div class="text-center">
                  <div class="form-group" style="display: inline-block">
                   <asp:Button Text="Nuevo" class ="btn btn-warning btn-sm" runat="server" ID="NuevoButton" OnClick="NuevoButton_Click" />
                   <asp:Button Text="Guardar" class ="btn btn-success btn-sm" runat="server" ID="GuardarButton" OnClick="GuardarButton_Click" />  
                   <asp:Button Text="Eliminar" class ="btn btn-danger btn-sm" runat="server" ID="EliminarButton" OnClick="EliminarButton_Click" />        
              </div>
         </div>
        </div>

</asp:Content>
