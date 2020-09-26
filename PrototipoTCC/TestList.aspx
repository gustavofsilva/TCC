<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestList.aspx.cs" Inherits="PrototipoTCC.TestList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <br /><br /><br /> 
    <div style="width: 800px; display: table; text-align:center">
        <!-- ROW -->
        <div style="height:200px; display: table-row">
            <!-- cell -->
            <div style="width: 1000px; display: table-cell;" > 
                <a href="/TesteUnitario.aspx">
                    <div><b>Teste Unitário</b></div>
                    <img src="https://media.discordapp.net/attachments/728046982400180248/757481106848088064/B9kDoj0MMtp9QAAAABJRU5ErkJggg.png?width=200&height=100"/>
                </a>            
            </div>
            <!-- cell -->
            <div style="width: 1000px; display: table-cell;" > 
                <a href="/TesteStress.aspx">
                    <div><b>Teste de Estresse</b></div>
                    <img src="https://media.discordapp.net/attachments/728046982400180248/758871486495850506/graph-line-up-and-down-1-1237014.png?width=200&height=100"/>
                </a>
            </div>
            <!-- cell -->
            <div style="width: 1000px; display: table-cell;" > 
                <a href="/Registro.aspx">
                    <div><b>Teste de Aceitação</b></div>
                    <img src="https://media.discordapp.net/attachments/728046982400180248/758874077737123870/unknown.png?width=200&height=100"/>
                </a>
            </div>
        </div> 
        <!-- ROW -->
        <div style="display: table-row">
            <!-- cell -->
            <div style="width: 1000px; display: table-cell;"> 
                <a href="/Registro.aspx">
                    <div><b>Teste de Integração</b></div>
                    <img src="https://media.discordapp.net/attachments/728046982400180248/758872009001664522/unknown.png?width=200&height=100"/> 
                </a>
            </div>
            <!-- cell -->
            <div style="width: 1000px; display: table-cell;"> 
                <a href="/Registro.aspx">
                    <div><b>Teste 5</b></div>
                    <img src="https://media.discordapp.net/attachments/728046982400180248/757481106848088064/B9kDoj0MMtp9QAAAABJRU5ErkJggg.png?width=200&height=100"/>  
                </a>
            </div>
            <!-- cell -->
            <div style="width: 1000px; display: table-cell;" > 
                <a href="/Registro.aspx">
                    <div><b>Teste 6</b></div>
                    <img src="https://media.discordapp.net/attachments/728046982400180248/757481106848088064/B9kDoj0MMtp9QAAAABJRU5ErkJggg.png?width=200&height=100"/>
                </a>
            </div>
        </div>
    </div>
                

</asp:Content>
