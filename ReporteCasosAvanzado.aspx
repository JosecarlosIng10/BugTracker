<%@ Page Title="" Language="C#" MasterPageFile="~/Reportes.master" AutoEventWireup="true" CodeBehind="ReporteCasosAvanzado.aspx.cs" Inherits="BugTracker.ReporteCasosAvanzado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
        &nbsp;</p>
    <p>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CodigoCaso" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="CodigoCaso" HeaderText="CodigoCaso" ReadOnly="True" SortExpression="CodigoCaso" />
            <asp:BoundField DataField="CodigoProyecto" HeaderText="CodigoProyecto" SortExpression="CodigoProyecto" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:BoundField DataField="Situacion" HeaderText="Situacion" SortExpression="Situacion" />
            <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" SortExpression="Prioridad" />
            <asp:BoundField DataField="FechaEntrega" HeaderText="FechaEntrega" SortExpression="FechaEntrega" />
            <asp:BoundField DataField="Categoria" HeaderText="Categoria" SortExpression="Categoria" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT CodigoCaso, CodigoProyecto, Estado, Situacion, Prioridad, FechaEntrega, Categoria, Descripcion FROM CASO WHERE (Categoria = 'Bug') AND (Estado = 'Activo' OR Estado = 'Re activado') AND (Prioridad = 'Critica' OR Prioridad = 'Debe Arreglarse')"></asp:SqlDataSource>
</p>
</asp:Content>
