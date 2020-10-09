<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestList.aspx.cs" Inherits="PrototipoTCC.TestList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <br /><br /><br /> 
    <div style="width: 1000px; display: table; text-align:left">
        <!-- ROW -->
        <div style="height:00px; display: table-row">
            <!-- cell -->
            <div style="width: 1500px; display: table-cell; border-style:double"> 

                <div style="width: 100%; display: table;">
                    <div style="display: table-row">            
                        <div style="width: 300px; display: table-cell;">
                            <asp:Label runat="server" ID="labelTesteUnitario" Text="&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbspTeste Unitário" Font-Size="Large" Font-Bold="true"></asp:Label><br />
                            <a href="Testes/TesteUnitario.aspx"> 
                                &nbsp&nbsp<img src="https://media.discordapp.net/attachments/728046982400180248/757481106848088064/B9kDoj0MMtp9QAAAABJRU5ErkJggg.png?width=300&height=200"/>
                            </a>    
                         </div>
                        <div style="width: 600px; display: table-cell;">
                            <br /><br />
                            <asp:Label Font-Bold="true" Font-Size="Large" runat="server" ID="labelExplica" Text="O que é o Teste Unitário? É a forma de se testar unidades individuais do código fonte, cada pequena parte do código será testada."></asp:Label>
                            <br />
                            <asp:Label Font-Bold="true" Font-Size="Large" runat="server" ID="labelExplica2" Text="No nosso caso, cada campo do formulário será testado até que se complete o formulário."></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <!-- ROW -->
        <div style="height:200px; display: table-row">
            <!-- cell -->
            <div style="width: 1000px; display: table-cell; border-style:double" > 
                <div style="width: 100%; display: table;">
                    <div style="display: table-row">            
                        <div style="width: 300px; display: table-cell;">
                            <asp:Label runat="server" ID="labelTesteEstresse" Text="&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbspTeste de Estresse" Font-Size="Large" Font-Bold="true"></asp:Label><br />
                            <a href="Testes/TesteStress.aspx">
                                &nbsp&nbsp<img src="https://media.discordapp.net/attachments/728046982400180248/758871486495850506/graph-line-up-and-down-1-1237014.png?width=300&height=200"/>
                            </a>
                        </div>
                        <div style="width: 600px; display: table-cell;">
                            <br /><br />
                            <asp:Label Font-Bold="true" Font-Size="Large" runat="server" ID="label2" Text="O que é o Teste de Estresse? É a forma de se testar o quanto o computador vai aguentar e como vai reagir a isso."></asp:Label>
                            <br />
                            <asp:Label Font-Bold="true" Font-Size="Large" runat="server" ID="label4" Text="No nosso caso, ele abrirá várias instancias do site e testará todas ao mesmo tempo."></asp:Label>
                        
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <!-- ROW -->
        <div style="height:200px; display: table-row">
            <!-- cell -->
            <div style="width: 1000px; display: table-cell; border-style:double" > 
                <asp:Label runat="server" ID="label1" Text="&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbspTeste de Aceitação" Font-Size="Large" Font-Bold="true"></asp:Label><br />
                <a href="Testes/Registro.aspx">
                    &nbsp&nbsp<img src="https://media.discordapp.net/attachments/728046982400180248/758874077737123870/unknown.png?width=300&height=200"/>
                </a>
            </div>
        </div> 
        <br />
        <!-- ROW -->
        <div style="height:200px; display: table-row">
            <!-- cell -->
            <div style="width: 1000px; display: table-cell; border-style:double" > 
                <asp:Label runat="server" ID="label3" Text="&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbspTeste de Integração" Font-Size="Large" Font-Bold="true"></asp:Label><br />
                <a href="Testes/Registro.aspx">
                    &nbsp&nbsp<img src="https://cdn.discordapp.com/attachments/728046982400180248/763255656680783882/unknown.png?width=300&height=200"/>
                </a>
            </div>
        </div> 

        
        
    </div>
</asp:Content>
