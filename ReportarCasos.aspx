<%@ Page Title="" Language="C#" MasterPageFile="~/Reportes.master" AutoEventWireup="true" CodeBehind="ReportarCasos.aspx.cs" Inherits="BugTracker.ReportarCasos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <br />
&nbsp;
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
    <br />
    <br />
<asp:Table ID="Table1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" GridLines="Both">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">Bugs</asp:TableCell>
        <asp:TableCell runat="server">Mejora</asp:TableCell>
        <asp:TableCell runat="server">Investigacion</asp:TableCell>
        <asp:TableCell runat="server">Actividad</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"></asp:TableCell>
        <asp:TableCell runat="server"></asp:TableCell>
        <asp:TableCell runat="server"></asp:TableCell>
        <asp:TableCell runat="server"></asp:TableCell>
    </asp:TableRow>
</asp:Table>
<br />
<asp:Table ID="Table2" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" GridLines="Both">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">Activos</asp:TableCell>
        <asp:TableCell runat="server">Cerrados</asp:TableCell>
        <asp:TableCell runat="server">Resueltos</asp:TableCell>
        <asp:TableCell runat="server">Re Activados</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"></asp:TableCell>
        <asp:TableCell runat="server"></asp:TableCell>
        <asp:TableCell runat="server"></asp:TableCell>
        <asp:TableCell runat="server"></asp:TableCell>
    </asp:TableRow>
</asp:Table>
<br />
<asp:Table ID="Table3" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" GridLines="Both">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">Criticos</asp:TableCell>
        <asp:TableCell runat="server">Deben Arreglarse</asp:TableCell>
        <asp:TableCell runat="server">Arreglarse si hay tiempo</asp:TableCell>
        <asp:TableCell runat="server">No Arreglar</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"></asp:TableCell>
        <asp:TableCell runat="server"></asp:TableCell>
        <asp:TableCell runat="server"></asp:TableCell>
        <asp:TableCell runat="server"></asp:TableCell>
    </asp:TableRow>
</asp:Table>
<br />
<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generar Reporte" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Categoria = 'bug')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Categoria = 'Mejora')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Categoria = 'Investigacion')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Categoria = 'Actividad')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Estado = 'Activo')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Estado = 'Cerrado')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Estado= 'Resuelto')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Estado = 'Re activado')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Prioridad= 'Critica')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Prioridad= 'Debe Arreglarse')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource11" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Prioridad= 'Arreglar si hay tiempo')"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource12" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT COUNT(*) AS BUGS FROM CASO WHERE (Prioridad= 'No arreglar')"></asp:SqlDataSource>
<br />
</asp:Content>
