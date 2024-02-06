<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ListaReservas.aspx.cs" Inherits="GestionReservas.ListaReservas1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:GridView ID="GrdReservas" runat="server"></asp:GridView>
        <asp:LinkButton ID="LnkHome" runat="server" OnClick="LnkHome_Click">Volver</asp:LinkButton>
</asp:Content>
