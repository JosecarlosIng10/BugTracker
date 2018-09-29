<%@ Page Title="" Language="C#" MasterPageFile="~/Proyectos.master" AutoEventWireup="true" CodeBehind="AsignarProyecto.aspx.cs" Inherits="BugTracker.AsignarProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2>Asignar Proyecto a Usuario</h2>
    <p style="margin-left: 40px">WorkerID del Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Workerid" DataValueField="Workerid">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT Workerid FROM USUARIO WHERE (Tipo &lt;&gt; 'SuperUsuario') AND (Tipo &lt;&gt; 'Administrador')"></asp:SqlDataSource>
    </p>
    <p style="margin-left: 40px">ProjectID del Proyecto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Projectid" DataValueField="Projectid">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT [Projectid] FROM [PROYECTO]"></asp:SqlDataSource>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p style="margin-left: 40px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Asignar" />
    </p>
    <p>&nbsp;</p>
</asp:Content>
