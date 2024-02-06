<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarReserva.aspx.cs" Inherits="GestionReservas.AgregarReserva1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>                       
            <asp:TextBox ID="TxtCodigo" runat="server" placeholder="Codigo"></asp:TextBox><br />
            <asp:Label ID="Label1" runat="server" Text="Seleccione una Cancha:"></asp:Label><br />
            <asp:DropDownList ID="DropCancha" runat="server"></asp:DropDownList><br />
            <asp:Label ID="Label2" runat="server" Text="Seleccione un Cliente:"></asp:Label><br />
            <asp:DropDownList ID="DropCliente" runat="server"></asp:DropDownList><br />
            <asp:Label ID="Label3" runat="server" Text="Seleccione un Profesor:"></asp:Label><br />
            <asp:DropDownList ID="DropProfesor" runat="server"></asp:DropDownList><br />  
            <asp:Label ID="Label4" runat="server" Text="Seleccione la fecha de reserva:"></asp:Label><br />
            
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <asp:Label ID="LbFecha" runat="server" Text=""></asp:Label><br />
            
            <asp:TextBox ID="TxtHora_ini" runat="server" placeholder="Hora Inicio"></asp:TextBox><br />
            <asp:TextBox ID="TxtHora_fin" runat="server" placeholder="Hora fin"></asp:TextBox><br />
            <asp:Button ID="BttnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" /><br />
            <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label><br />
            <asp:LinkButton ID="LnkLista" runat="server" OnClick="LnkLista_Click">Ver Reservas</asp:LinkButton><br />
            <asp:LinkButton ID="LnkHome" runat="server" OnClick="LnkHome_Click">Volver</asp:LinkButton><br />
        </div>
</asp:Content>
