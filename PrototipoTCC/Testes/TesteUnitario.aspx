﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteUnitario.aspx.cs" Inherits="PrototipoTCC.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Button ID="Button2" runat="server" Text="Lista de Testes" OnClick="Button2_Click" Font-Bold="true" BorderColor="Black" />
    <br /><br />
    <div style="text-align:center"><asp:Label ID="LabelTitulo" runat="server" Text="Teste Unitário" Font-Bold="true" Font-Size="29" ></asp:Label>
    </div>       
    <br />
    <br />
    <div>
        <div style="width: 100%; display: table;">
        <div style="display: table-row">            
            <div style="width: 600px; display: table-cell;">               
                
                <br />
                <br />
                <br />
                &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                <asp:Label ID="labelValid" runat="server" Font-Bold="true" Text="Validação:"></asp:Label>
                <br />
                &nbsp<asp:TextBox ID="TextBoxNome" runat="server" placeholder="Digite seu nome" BorderColor="Black"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="Label1" runat="server" Text="Não pode conter números" Font-Italic="true"></asp:Label><br />
                <asp:Label ID="LabelNome" runat="server" ForeColor="Red" ></asp:Label>
                <br />
                &nbsp<asp:TextBox ID="TextBoxEmail" runat="server" placeholder="Digite seu email" BorderColor="Black"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="Label6" runat="server" Text="Precisa ter @" Font-Italic="true"></asp:Label>
                <br />
                <asp:Label ID="LabelEmail" runat="server" Text="" ForeColor="Red"></asp:Label>
                <br />
                &nbsp<asp:TextBox ID="TextBoxCPF" runat="server" placeholder="Digite seu CPF" BorderColor="Black"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="Label2" runat="server" Text="Não pode conter letras" Font-Italic="true"></asp:Label>
    


                <br />
                <asp:Label ID="LabelCPF" runat="server" ForeColor="Red" ></asp:Label><br />
                &nbsp<asp:TextBox ID="TextBoxSenha" runat="server"  placeholder="Digite sua senha" BorderColor="Black"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="Label3" runat="server" Text="Precisa ter letras e números" Font-Italic="true"></asp:Label>
                <br />
                <asp:Label ID="LabelSenha" runat="server" ForeColor="Red"></asp:Label><br />
                &nbsp<asp:TextBox ID="TextBoxSenhaConfirma" runat="server" placeholder="Confirme a senha" BorderColor="Black"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="Label4" runat="server" Text="Precisa ser igual a senha" Font-Italic="true"></asp:Label>
                <br />
                <asp:Label ID="LabelSenhaConfirma" runat="server" ForeColor="Red"></asp:Label><br />
                &nbsp<asp:TextBox ID="TextBoxIdade" runat="server" placeholder="Digite sua idade" BorderColor="Black"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="Label5" runat="server" Text="Não pode conter letras" Font-Italic="true"></asp:Label>
                <br />
                <asp:Label ID="LabelIdade" runat="server" ForeColor="Red"></asp:Label><br />
                &nbsp<asp:Button ID="ButtonConfirma" runat="server" Text="Enviar" OnClick="ButtonConfirma_Click" BorderColor="Black" />
                <br /><br />
                <br />
                <asp:Label ID="LabelResultadoFinal" runat="server" Text="" ForeColor="Blue" Font-Bold="true" ></asp:Label><br /><br /><br />
            </div>
            <div style="display: table-cell;"> 
                <br /><br />
                <asp:Button ID="Button1" runat="server" Text="Iniciar Teste" OnClick="Button1_Click" Font-Bold="true" BorderColor="Black" /><br /><br />
                <asp:TextBox ID="TextBoxEscrever" runat="server" Rows="20" Columns="35" TextMode="MultiLine" ></asp:TextBox>
                &nbsp;

            </div>
            <div style="display: table-cell;"> 
                <br /><br />
                

            </div>
        </div>
    </div>
    </div>
    
    


</asp:Content>
