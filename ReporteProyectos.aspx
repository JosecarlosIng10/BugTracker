<%@ Page Title="" Language="C#" MasterPageFile="~/Reportes.master" AutoEventWireup="true" CodeBehind="ReporteProyectos.aspx.cs" Inherits="BugTracker.ReporteProyectos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
    <br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CodigoProyecto" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="CodigoProyecto" HeaderText="CodigoProyecto" InsertVisible="False" ReadOnly="True" SortExpression="CodigoProyecto" />
            <asp:BoundField DataField="Workedid" HeaderText="Workedid" SortExpression="Workedid" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Projectid" HeaderText="Projectid" SortExpression="Projectid" />
            <asp:BoundField DataField="Fecha_Inicio" HeaderText="Fecha_Inicio" SortExpression="Fecha_Inicio" />
            <asp:BoundField DataField="Fecha_Fin" HeaderText="Fecha_Fin" SortExpression="Fecha_Fin" />
            <asp:BoundField DataField="MontoPresupuestado" HeaderText="MontoPresupuestado" SortExpression="MontoPresupuestado" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT * FROM [PROYECTO]"></asp:SqlDataSource>

</asp:Content>
