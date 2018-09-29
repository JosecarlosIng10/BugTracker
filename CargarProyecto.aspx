<%@ Page Title="" Language="C#" MasterPageFile="~/Proyectos.master" AutoEventWireup="true" CodeBehind="CargarProyecto.aspx.cs" Inherits="BugTracker.CargarProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <p>
        <br />
&nbsp;
        <asp:FileUpload ID="FileUploadControl" runat="server" />
    </p>
    <p>
        <asp:TextBox ID="TextBox1" TextMode="MultiLine" runat="server" Height="238px" Width="602px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Leer" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cargar Proyectos" />
    </p>
    <p>
    </p>
</asp:Content>
