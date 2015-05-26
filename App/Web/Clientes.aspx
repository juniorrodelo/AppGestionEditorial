<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="App.Web.Crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" role="form" class="form-horizontal">
    <div class="jumbotron">
        <h2>Crear Clientes</h2>
             <div class="form-group">
                <label class="control-label">Id</label>
                <asp:TextBox ID="txtId" runat="server" class="form-control" ></asp:TextBox>
         </div>
             <div class="form-group">
                <label class="control-label">Nombres</label>
                 <asp:TextBox ID="txtNombres" runat="server" class="form-control" ></asp:TextBox> 
          </div>       
             <div class="form-group">
                <label class="control-label" >Apellidos</label>
                <asp:TextBox ID="txtApellidos" runat="server" class="form-control" ></asp:TextBox> 
           </div>
             <div class="form-group">
                <label class="control-label" >Email</label>
                 <asp:TextBox ID="txtEmail" runat="server" class="form-control"  ></asp:TextBox>
             </div>

             <div class="form-group">
                <label class="control-label" >Telefono</label>
                 <asp:TextBox ID="txtTelefono" runat="server" class="form-control"  ></asp:TextBox>
             </div>
             <div class="form-group">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-group-lg btn-success" OnClick="btnGuardar_Click"/>
             </div>  
    </div>
    </form>
</asp:Content>
