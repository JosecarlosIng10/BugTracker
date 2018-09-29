<%@ Page Title="" Language="C#" MasterPageFile="~/Casos.master" AutoEventWireup="true" CodeBehind="CrearCasos.aspx.cs" Inherits="BugTracker.CrearCasos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h2>Crear Caso</h2>
    <div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; Nombre del Proyecto:&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList8" runat="server" DataSourceID="SqlDataSource1" DataTextField="Projectid" DataValueField="Projectid" OnTextChanged="DropDownList8_TextChanged" OnDataBound="DropDownList8_DataBound" OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDbugtrackerConnectionString %>" SelectCommand="SELECT [Projectid] FROM [PROYECTO]"></asp:SqlDataSource>
        &nbsp;<br />
&nbsp;&nbsp;&nbsp; Codigo del Caso&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp; Estado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList6" runat="server" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Activo</asp:ListItem>
            <asp:ListItem>Resuelto</asp:ListItem>
            <asp:ListItem>Cerrado</asp:ListItem>
            <asp:ListItem>Re activado</asp:ListItem>
        </asp:DropDownList>
        <br />
&nbsp;&nbsp;&nbsp; Situacion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList7" runat="server" OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="Button3" runat="server" Height="23px" OnClick="Button3_Click" Width="23px" />
        <br />
&nbsp;&nbsp;&nbsp; Prioridad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Critica</asp:ListItem>
            <asp:ListItem>Debe Arreglarse</asp:ListItem>
            <asp:ListItem>Arreglar si hay tiempo</asp:ListItem>
            <asp:ListItem>No arreglar</asp:ListItem>
        </asp:DropDownList>
        <br />
&nbsp;&nbsp;&nbsp; 
        <br />
        &nbsp;&nbsp;&nbsp; Fecha de Entrega <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>21</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
            <asp:ListItem>23</asp:ListItem>
            <asp:ListItem>24</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>26</asp:ListItem>
            <asp:ListItem>27</asp:ListItem>
            <asp:ListItem>28</asp:ListItem>
            <asp:ListItem>29</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>31</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>01</asp:ListItem>
            <asp:ListItem>02</asp:ListItem>
            <asp:ListItem>03</asp:ListItem>
            <asp:ListItem>04</asp:ListItem>
            <asp:ListItem>05</asp:ListItem>
            <asp:ListItem>06</asp:ListItem>
            <asp:ListItem>07</asp:ListItem>
            <asp:ListItem>08</asp:ListItem>
            <asp:ListItem>09</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownList4" runat="server" >
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
       
        
        <br />
&nbsp;&nbsp;&nbsp; Categoria``<asp:DropDownList ID="DropDownList5" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Bug</asp:ListItem>
            <asp:ListItem>Mejora</asp:ListItem>
            <asp:ListItem>Investigacion</asp:ListItem>
            <asp:ListItem>Actividad</asp:ListItem>
        </asp:DropDownList>
       
        
        <br />
&nbsp;&nbsp;&nbsp; Descripcion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox>
        <br />
&nbsp;<asp:TextBox ID="TextBox5"  TextMode="MultiLine" runat="server" Height="109px" Width="302px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agragar Caso" />
       
        
        <br />
        <br />
        <br />
        <br />
    </div>
    <p>&nbsp;</p>
</asp:Content>
