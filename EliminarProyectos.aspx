<%@ Page Title="" Language="C#" MasterPageFile="~/Proyectos.master" AutoEventWireup="true" CodeBehind="EliminarProyectos.aspx.cs" Inherits="BugTracker.EliminarProyectos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2>Eliminar Proyecto</h2>
    <p>&nbsp; ProjectId del Proyecto&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Eliminar" />
    </p>
</asp:Content>
