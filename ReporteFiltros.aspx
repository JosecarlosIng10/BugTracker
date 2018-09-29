<%@ Page Title="" Language="C#" MasterPageFile="~/Reportes.master" AutoEventWireup="true" CodeBehind="ReporteFiltros.aspx.cs" Inherits="BugTracker.ReporteFiltros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <br />
&nbsp; Projectid&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Projectid" DataValueField="Projectid" AutoPostBack="True" >
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT [Projectid] FROM [PROYECTO]"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
        <br />
<br />
&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" Font-Bold="True" OnCheckedChanged="RadioButton4_CheckedChanged" Text="Todos" />
&nbsp;<asp:RadioButton ID="RadioButton1" runat="server" Font-Bold="True" Font-Size="Large" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Estado" AutoPostBack="True" ViewStateMode="Enabled" />
<asp:RadioButton ID="RadioButton2" runat="server" Font-Bold="True" Font-Size="Large" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Categoria" AutoPostBack="True" ViewStateMode="Enabled" />
<asp:RadioButton ID="RadioButton3" runat="server" Font-Bold="True" Font-Size="Large" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Situacion" AutoPostBack="True" ViewStateMode="Enabled" />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" >
</asp:DropDownList>
&nbsp;&nbsp;
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CodigoProyecto" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT * FROM [PROYECTO] WHERE ([Projectid] = @Projectid)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList2" Name="Projectid" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
<br />
<br />
<asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="SqlCasos" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="CodigoCaso">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="CodigoCaso" HeaderText="CodigoCaso" ReadOnly="True" SortExpression="CodigoCaso" />
        <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
        <asp:BoundField DataField="Situacion" HeaderText="Situacion" SortExpression="Situacion" />
        <asp:BoundField DataField="FechaEntrega" HeaderText="FechaEntrega" SortExpression="FechaEntrega" />
        <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" SortExpression="Prioridad" />
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
&nbsp;<asp:SqlDataSource ID="SqlCasos" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT CASO.CodigoCaso, CASO.Estado, CASO.Situacion, CASO.FechaEntrega, CASO.Prioridad, CASO.Categoria, CASO.Descripcion FROM CASO INNER JOIN PROYECTO ON CASO.CodigoProyecto = PROYECTO.CodigoProyecto WHERE (PROYECTO.Projectid = @cc) AND (CASO.Estado = @d ) OR (PROYECTO.Projectid = @cc) AND (CASO.Situacion = @d ) OR (PROYECTO.Projectid = @cc) AND (CASO.Categoria = @d ) OR (PROYECTO.Projectid = @cc) AND ( @d = 'Todos')">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList2" Name="cc" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DropDownList1" Name="d" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
<br />
<br />
&nbsp;<br />
</asp:Content>
