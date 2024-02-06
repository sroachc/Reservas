<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ListaClientes.aspx.cs" Inherits="GestionReservas.ListaClientes1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:GridView ID="GrdClientes" runat="server"></asp:GridView>
        <asp:LinkButton ID="LnkHome" runat="server" OnClick="LnkHome_Click">Volver</asp:LinkButton>
</asp:Content>
