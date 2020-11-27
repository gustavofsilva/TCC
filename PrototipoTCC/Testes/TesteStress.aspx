<%@ Page Title="" Language="C#" Async="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteStress.aspx.cs" Inherits="PrototipoTCC.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Button ID="Button2" runat="server" Text="Lista de Testes" Font-Bold="true" BorderColor="Black" OnClick="Button2_Click" />
    <div style="text-align:center" ><asp:Label ID="LabelTitulo" runat="server" Text="Teste Estresse" Font-Bold="true" Font-Size="29"></asp:Label></div> 
    <br /><br /><br />
    
    <b>Quantos Testes Serão:</b>  &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="TextBoxQtdTeste" runat="server" BorderColor="Black" placeholder="Ex 2" Text="2"></asp:TextBox><br />
    <b>Quantas Vezes Será Testado:</b> <asp:TextBox ID="TextBoxRepeticoes" runat="server" BorderColor="Black" placeholder="Ex 3" Text="3"></asp:TextBox>
    <br /><br />
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <asp:Button ID="ButtonComecaTeste" runat="server" Text="Começar Teste!" OnClick="ButtonComecaTeste_Click" BorderColor="Black" />

    
    <br /><br /><br /><br />
    <div style="align-content:center"><b>Exemplo de Formulário</b></div><br />
    <asp:TextBox ID="TextBoxGenerico1" runat="server" placeholder="Entrada Generica!"></asp:TextBox><br />
    <asp:TextBox ID="TextBoxGenerico2" runat="server" placeholder="Entrada Generica!"></asp:TextBox><br />
    <asp:TextBox ID="TextBoxGenerico3" runat="server" placeholder="Entrada Generica!"></asp:TextBox><br />
    <asp:Button ID="ButtonGenerico" runat="server" Text="Enviar Formulário" OnClick="ButtonGenerico_Click" />



</asp:Content>
