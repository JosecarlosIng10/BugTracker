<%@ Page Title="" Language="C#" MasterPageFile="~/Casos.master" AutoEventWireup="true" CodeBehind="AsignarCasos.aspx.cs" Inherits="BugTracker.AsignarCasos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2>Asignar Caso a Usuario</h2>
    <p style="margin-left: 40px">Codigo Caso:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="CodigoCaso" DataValueField="CodigoCaso">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT [CodigoCaso] FROM [CASO]"></asp:SqlDataSource>
&nbsp;</p>
    <p style="margin-left: 40px">
        &nbsp;</p>
    <p style="margin-left: 40px">
        WorkerID del Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Workerid" DataValueField="Workerid" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT USUARIO.Workerid FROM CASO INNER JOIN USUARIO_PROYECTO ON CASO.CodigoProyecto = USUARIO_PROYECTO.CodigoProyecto INNER JOIN PROYECTO ON CASO.CodigoProyecto = PROYECTO.CodigoProyecto AND USUARIO_PROYECTO.CodigoProyecto = PROYECTO.CodigoProyecto INNER JOIN USUARIO ON USUARIO_PROYECTO.CodigoUsuario = USUARIO.CodigoUsuario WHERE (CASO.CodigoCaso = @cc)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList2" Name="cc" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <p style="margin-left: 40px">
        <asp:Button ID="Button1" runat="server" Text="Asignar" OnClick="Button1_Click" />
    </p>
    <p>&nbsp;</p>
</asp:Content>
