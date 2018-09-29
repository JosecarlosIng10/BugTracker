<%@ Page Title="" Language="C#" MasterPageFile="~/Usuarios.master" AutoEventWireup="true" CodeBehind="EliminarUsuarios.aspx.cs" Inherits="BugTracker.EliminarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2>Eliminar Usuario</h2>
    <p>WorkerId del Usuario&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Eliminar" />
    </p>
</asp:Content>
