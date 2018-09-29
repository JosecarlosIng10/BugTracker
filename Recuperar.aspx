<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Recuperar.aspx.cs" Inherits="BugTracker.Recuperar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContextual" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2>Recuperar Contraseña</h2>
    <p>Correo&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="182px"></asp:TextBox>
    </p>
    <p>Contraseña SuperUsuario&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2"  TextMode="Password"  runat="server"></asp:TextBox>
    </p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Recuperar" />
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
<p>&nbsp;</p>
</asp:Content>
