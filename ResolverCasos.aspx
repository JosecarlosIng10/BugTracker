<%@ Page Title="" Language="C#" MasterPageFile="~/Casos.master" AutoEventWireup="true" CodeBehind="ResolverCasos.aspx.cs" Inherits="BugTracker.ResolverCasos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2>Resolver Caso</h2>
    <p style="margin-left: 40px">Codigo del Caso&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CodigoCaso" DataValueField="CodigoCaso" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT [CodigoCaso] FROM [CASO]"></asp:SqlDataSource>
    &nbsp;&nbsp;&nbsp;
        </p>
    <p style="margin-left: 40px">Estado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p style="margin-left: 40px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Asignar" />
    </p>
    <p>&nbsp;</p>
</asp:Content>
