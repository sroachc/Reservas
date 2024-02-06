<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="BuscarReserva.aspx.cs" Inherits="GestionReservas.BuscarReserva1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
            <asp:TextBox ID="TxtBuscar" placeholder="Buscar por Código" runat="server"></asp:TextBox>
            <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" />
            <asp:Label ID="LbMensaje1" runat="server" Text=""></asp:Label>

            <br />
            <br />
            <asp:Panel ID="PanelReserva" CssClass="auto-style1" Visible="false" runat="server" Width="736px" BorderStyle="Ridge">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2" colspan="2"><strong>Datos de Reserva</strong></td>
                    </tr>
                    <tr>                   
                        <td class="auto-style4">Codigo:</td>
                        <td class="auto-style5">
                            <asp:Label ID="LbCodigo" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Cancha:</td>
                        <td class="auto-style5">
                            <asp:Label ID="LbCancha" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Cliente:</td>
                        <td class="auto-style5">
                            <asp:Label ID="LbCliente" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Profesor:</td>
                        <td class="auto-style7">
                            <asp:Label ID="LbProfesor" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Fecha:</td>
                        <td class="auto-style7">
                            <asp:Label ID="LbFecha" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Hora de Inicio:</td>
                        <td class="auto-style7">
                            <asp:Label ID="LbHora_ini" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Hora de Fin:</td>
                        <td class="auto-style7">
                            <asp:Label ID="LbHora_fin" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style5">
                            <asp:LinkButton ID="LnkEditar" runat="server" OnClick="LnkEditar_Click">Editar Reserva</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
</asp:Content>
