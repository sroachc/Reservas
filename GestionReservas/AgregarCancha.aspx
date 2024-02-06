<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarCancha.aspx.cs" Inherits="GestionReservas.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
            <asp:TextBox ID="TxtCodigo" runat="server" placeholder="Codigo"></asp:TextBox><br />
            <asp:TextBox ID="TxtNombre" runat="server" placeholder="Nombre"></asp:TextBox><br />
            <asp:Button ID="BttnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" /><br />
            <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label><br />
            <asp:LinkButton ID="LnkLista" runat="server" OnClick="LnkLista_Click">Ver Canchas</asp:LinkButton><br />
            <asp:LinkButton ID="LnkHome" runat="server" OnClick="LnkHome_Click">Volver</asp:LinkButton>
        </div>

</asp:Content>
