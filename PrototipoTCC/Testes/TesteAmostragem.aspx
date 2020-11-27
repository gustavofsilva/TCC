<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteAmostragem.aspx.cs" Inherits="PrototipoTCC.Testes.TesteAceitacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Button ID="Button1" runat="server" Text="Lista de Testes" Font-Bold="true" BorderColor="Black" OnClick="Button1_Click" />
    <br /><br />
    <div style="text-align:center"><asp:Label ID="LabelTitulo" runat="server" Text="Teste por Amostragem" Font-Bold="true" Font-Size="29" ></asp:Label>
    </div> 
    <div>
        <br />
        <asp:Label Font-Size="Large" ID="labelAnuncio" Text="Estamos à procura de atletas com 1,80 de altura ou maior, que seja maior de idade e que tenha pelo menos 10 partidas oficiais disputadas." runat="server" />
    </div>
    <br /><br /><br />
    <div style="width: 1000px; display: table; text-align:left">
        <!-- ROW -->
        <div style="height:00px; display: table-row">
            <!-- cell -->
            <div style="width: 1500px; display: table-cell;"> 
                <asp:TextBox ID="TextBoxNome" runat="server" placeholder="Digite seu nome" BorderColor="Black"></asp:TextBox><br />
                <asp:Label ID="labelNome" Text="" runat="server" /><br />
                <asp:TextBox ID="TextBoxIdade" runat="server" placeholder="Digite sua idade" BorderColor="Black"></asp:TextBox><br />
                <asp:Label ID="labelIdade" Text="" runat="server" /><br />
                <asp:TextBox ID="TextBoxAltura" runat="server" placeholder="Digite sua altura" BorderColor="Black"></asp:TextBox><br />
                <asp:Label ID="labelAltura" Text="" runat="server" /><br />
                <asp:TextBox ID="TextBoxPartidas" runat="server" placeholder="Quantidade de partidas" BorderColor="Black"></asp:TextBox><br />
                <asp:Label ID="labelPartidas" Text="" runat="server" /><br />
                <asp:Button Text="Enviar" runat="server" BorderColor="Black" OnClick="Unnamed1_Click"/>
                <br /><br />
                
            </div>
            <div style= "display: table-cell;"> 
                <br />
                <textarea runat="server" id="TextArea1" cols="50" rows="13"></textarea>
            </div>
        </div>
    </div>
    <asp:Button ID="ButtonTest" Text="Iniciar Teste" BorderColor="Black" runat="server" OnClick="ButtonTest_Click" />
    <br />
    <asp:Label ID="labelResult" Text="" runat="server" />
    <br />
    
    
</asp:Content>
