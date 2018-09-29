<%@ Page Title="" Language="C#" MasterPageFile="~/Reportes.master" AutoEventWireup="true" CodeBehind="CasosPorUsuario.aspx.cs" Inherits="BugTracker.CasosPorUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Workerid&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Workerid" DataValueField="Workerid" AutoPostBack="True" >
</asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT [Workerid] FROM [USUARIO]"></asp:SqlDataSource>
&nbsp;
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
<br />
    <br />
&nbsp;Casos Activos:<br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="372px" DataKeyNames="CodigoCaso" DataSourceID="SqlCasos">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="CodigoCaso" DataField="CodigoCaso" ReadOnly="True" SortExpression="CodigoCaso" />
                <asp:BoundField HeaderText="CodigoProyecto" DataField="CodigoProyecto" SortExpression="CodigoProyecto" />
                <asp:BoundField HeaderText="Estado" DataField="Estado" SortExpression="Estado" />
                <asp:BoundField HeaderText="Situacion" DataField="Situacion" SortExpression="Situacion" />
                <asp:BoundField HeaderText="Prioridad" DataField="Prioridad" SortExpression="Prioridad" />
                <asp:BoundField HeaderText="FechaEntrega" DataField="FechaEntrega" SortExpression="FechaEntrega" />
                <asp:BoundField HeaderText="Categoria" DataField="Categoria" SortExpression="Categoria" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
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
        <br />
&nbsp;Casos Re Activos:<br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CodigoCaso" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
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
    <br />
&nbsp;Casos Cerrados:<br />
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CodigoCaso" DataSourceID="SqlDataSource3" ForeColor="#333333" GridLines="None">
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
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT        CASO.CodigoCaso, CASO.CodigoProyecto, CASO.Estado, CASO.Situacion, CASO.Prioridad, CASO.FechaEntrega, CASO.Categoria, CASO.Descripcion
FROM            CASO INNER JOIN
                         CASO_USUARIO ON CASO.CodigoCaso = CASO_USUARIO.CodigoCaso INNER JOIN
                         USUARIO ON CASO_USUARIO.CodigoUsuario = USUARIO.CodigoUsuario
WHERE        (USUARIO.Workerid = @cc) AND (CASO.Estado = 'Cerrado') ">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList2" Name="cc" PropertyName="SelectedValue" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT        CASO.CodigoCaso, CASO.CodigoProyecto, CASO.Estado, CASO.Situacion, CASO.Prioridad, CASO.FechaEntrega, CASO.Categoria, CASO.Descripcion
FROM            CASO INNER JOIN
                         CASO_USUARIO ON CASO.CodigoCaso = CASO_USUARIO.CodigoCaso INNER JOIN
                         USUARIO ON CASO_USUARIO.CodigoUsuario = USUARIO.CodigoUsuario
WHERE        (USUARIO.Workerid = @cc) AND (CASO.Estado = 'Re activado') ">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList2" Name="cc" PropertyName="SelectedValue" />
        </SelectParameters>
    </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlCasos" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT CASO.CodigoCaso, CASO.CodigoProyecto, CASO.Estado, CASO.Situacion, CASO.Prioridad, CASO.FechaEntrega, CASO.Categoria, CASO.Descripcion FROM CASO INNER JOIN CASO_USUARIO ON CASO.CodigoCaso = CASO_USUARIO.CodigoCaso INNER JOIN USUARIO ON CASO_USUARIO.CodigoUsuario = USUARIO.CodigoUsuario WHERE (USUARIO.Workerid = @cc) AND (CASO.Estado = 'Activo')">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList2" Name="cc" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
    </asp:Content>
