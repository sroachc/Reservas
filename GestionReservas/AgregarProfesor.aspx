<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarProfesor.aspx.cs" Inherits="GestionReservas.AgregarProfesor1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>        
            <asp:TextBox ID="TxtCodigo" runat="server" placeholder="Codigo"></asp:TextBox><br />
            <asp:TextBox ID="TxtRut" runat="server" placeholder="Rut"></asp:TextBox><br />
            <asp:TextBox ID="TxtNombre" runat="server" placeholder="Nombre"></asp:TextBox><br />
            <asp:TextBox ID="TxtApellido" runat="server" placeholder="Apellido"></asp:TextBox><br />
            <asp:TextBox ID="TxtTelefono" runat="server" placeholder="Telefono"></asp:TextBox><br />
            <asp:TextBox ID="TxtDireccion" runat="server" placeholder="Direccion"></asp:TextBox><br />
            <asp:TextBox ID="TxtCorreo" runat="server" placeholder="Correo"></asp:TextBox><br />
            <asp:TextBox ID="TxtContraseña" runat="server" placeholder="Contraseña"></asp:TextBox><br />
            <asp:Button ID="BttnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" /><br />
            <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label><br />
            <asp:LinkButton ID="LnkLista" runat="server" OnClick="LnkLista_Click">Ver Profesores</asp:LinkButton><br />
            <asp:LinkButton ID="LnkHome" runat="server" OnClick="LnkHome_Click">Volver</asp:LinkButton>
        </div>
</asp:Content>