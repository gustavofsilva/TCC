<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestePerformance.aspx.cs" Inherits="PrototipoTCC.Testes.TestePerformance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Button ID="Button1" runat="server" Text="Lista de Testes" Font-Bold="true" BorderColor="Black" OnClick="Button1_Click" />
    <br /><br />
    <div style="text-align:center"><asp:Label ID="LabelTitulo" runat="server" Text="Teste de Performance" Font-Bold="true" Font-Size="29" ></asp:Label>
    </div> <br /><br />
    <div style="text-align:center">
        <asp:Label ID="label2" Text="Ao iniciar o teste ele executará várias instâncias do website, simulando o uso das instâncias ao mesmo tempo." Font-Size="Large" runat="server" />
        <br /><br />
        <asp:Button ID="buttonIniciar" Text="Iniciar Teste" runat="server" OnClick="buttonIniciar_Click" />
    </div>
    
</asp:Content>
