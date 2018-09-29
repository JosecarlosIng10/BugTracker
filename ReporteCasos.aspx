<%@ Page Title="" Language="C#" MasterPageFile="~/Casos.master" AutoEventWireup="true" CodeBehind="ReporteCasos.aspx.cs" Inherits="BugTracker.ReporteCasos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2>Reporte de casos </h2>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        ProjectID del Proyecto:&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Projectid" DataValueField="Projectid" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT [Projectid] FROM [PROYECTO]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="372px" DataKeyNames="CodigoCaso" DataSourceID="SqlCasos">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="CodigoCaso" DataField="CodigoCaso" ReadOnly="True" SortExpression="CodigoCaso" />
                <asp:BoundField HeaderText="Estado" DataField="Estado" SortExpression="Estado" />
                <asp:BoundField HeaderText="Situacion" DataField="Situacion" SortExpression="Situacion" />
                <asp:BoundField HeaderText="FechaEntrega" DataField="FechaEntrega" SortExpression="FechaEntrega" />
                <asp:BoundField HeaderText="Prioridad" DataField="Prioridad" SortExpression="Prioridad" />
                <asp:BoundField HeaderText="Categoria" DataField="Categoria" SortExpression="Categoria" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" SortExpression="Descripcion" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlCasos" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT CASO.CodigoCaso,CASO.Estado, CASO.Situacion, CASO.FechaEntrega, CASO.Prioridad, CASO.Categoria, CASO.Descripcion FROM CASO INNER JOIN PROYECTO ON CASO.CodigoProyecto = PROYECTO.CodigoProyecto WHERE (PROYECTO.Projectid = @cc)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="cc" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
