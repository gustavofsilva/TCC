﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace PrototipoTCC
{
    public class WebDriver
    {
        internal IWebDriver startTesteRegistro()
        {
            IWebDriver driver = startBrowser();
            driver.Url = HttpContext.Current.Request.Url.Authority + "/Testes/TesteUnitario";
            return driver;
        }

        public void AtualizaPagina(IWebDriver driver, string url)
        {
            waitMiliSegundos(1000);
            driver.Url = HttpContext.Current.Request.Url.Authority + url;
        }
        public void testeRegistroOk(IWebDriver driver)
        {
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenhaConfirma")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxIdade")).SendKeys("25");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        internal void FinzalizaDriver(IWebDriver driver)
        {
            waitMiliSegundos(1000);
            driver.Close();
        }

        internal void AtualizaPagina2(IWebDriver driver2, string v, string url)
        {
            driver2.Url = url + v;
        }

        internal void TesteStress(int qtdRepeticoes, IWebDriver driver)
        {
            
            for (int aux = 0; aux < qtdRepeticoes; aux++)
            {
                
                    waitMiliSegundos(100);
                    driver.FindElement(By.Name("ctl00$MainContent$TextBoxGenerico1")).SendKeys("Entrada Generica!");
                    waitMiliSegundos(100);
                    driver.FindElement(By.Name("ctl00$MainContent$TextBoxGenerico2")).SendKeys("Entrada Generica!");
                    waitMiliSegundos(100);
                    driver.FindElement(By.Name("ctl00$MainContent$TextBoxGenerico3")).SendKeys("Entrada Generica!");
                    waitMiliSegundos(100);
                    
                    driver.FindElement(By.Name("ctl00$MainContent$ButtonGenerico")).Click();        
            }
            driver.Close();
        }

        public IWebDriver StartDriver(string linkBase, string linkPagina)
        {
            IWebDriver driver = startBrowser();
            driver.Url = linkBase + linkPagina; //HttpContext.Current.Request.Url.Authority + linkPagina;// + "/Testes/TesteStress";
            return driver;
        }

        public void testeCampoIdade(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenhaConfirma")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxIdade")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }
        public void testeCampoIdadeUnitPerf(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenhaConfirma")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxIdade")).SendKeys("teste");
            waitMiliSegundos(1000);
        }

        internal void EscreveErroIdadeAmostragem(string v, IWebDriver driver)
        {
            driver.FindElement(By.Name("ctl00$MainContent$TextArea1")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextArea1")).SendKeys(v);
        }

        internal void FazTesteAmostragemCampoIdade(IWebDriver driver, int idade)
        {
            waitMiliSegundos(500);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(500);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxIdade")).SendKeys(idade.ToString());
            waitMiliSegundos(500);
            driver.FindElement(By.Name("ctl00$MainContent$ctl00")).Click();
        }

        internal void FazTesteAmostragemCampoAltura(IWebDriver driver, int altura)
        {
            waitMiliSegundos(500);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(500);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxAltura")).SendKeys(altura.ToString());
            waitMiliSegundos(500);
            driver.FindElement(By.Name("ctl00$MainContent$ctl00")).Click();
        }

        internal void LimpaCamposAmostragem(IWebDriver driver)
        {
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxIdade")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxAltura")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxPartidas")).Clear();
        }

        internal void FazTesteAmostragemCampoPartidas(IWebDriver driver, int partidas)
        {
            waitMiliSegundos(500);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(500);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxPartidas")).SendKeys(partidas.ToString());
            waitMiliSegundos(500);
            driver.FindElement(By.Name("ctl00$MainContent$ctl00")).Click();
        }

        public void testeCampoSenhaConfirma(IWebDriver driver)
        {
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste123");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenhaConfirma")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }
        public void testeCampoSenha(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("1234567890");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        internal void escreveTesteCampoEmail(IWebDriver driver)
        {
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).SendKeys("if (pessoa.email == '')\n" +
                "{\n" +
                "   Email vazio!;\n" +
                "   return;\n" +
                "} else\n" +
                "{\n" +
                "   if (!pessoa.email.Contains('@'))\n" +
                "   {\n" +
                "       Email precisa ter um @;\n" +
                "       return;\n" +
                "   }\n" +
                "}");
        }

        internal void escreveTesteCampoIdade(IWebDriver driver)
        {
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).SendKeys("try\n" +
            "{\n" +
            "    Convert.ToInt32(TextBoxIdade.Text);\n" +
            "}\n" +
            "catch\n" +
            "{\n" +
            "   'Idade inválida!';\n" +
            "    return;\n" +
            "}");
            
        }

        internal void escreveTesteCampoSenha(IWebDriver driver)
        {
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).SendKeys("if (pessoa.senha == '')\n" +
                "{\n" +
                "   'Senha vazia!';\n" +
                "   return;\n" +
                "}\n" +
                "else\n" +
                "{\n" +
                "   if (pessoa.senha.All(char.IsLetter))\n" +
                "   {\n" +
                "       'Senha precisa conter números!';\n" +
                "       return;\n" +
                "   }\n" +
                "   else\n" +
                "   {\n" +
                "       if (pessoa.senha.All(char.IsNumber))\n" +
                "       {\n" +
                "           'Senha precisa conter letras!';\n" +
                "           return;\n" +
                "       }\n" +
                "   }\n" +
                "}");

        }

        internal void escreveTesteCampoSenhaConfirma(IWebDriver driver)
        {
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).SendKeys("if (!(senhaConfirma == senha))\n" +
            "{\n"+
            "   'Senhas diferentes!';\n" +
            "}\n" +
            "else\n" +
            "{\n" +
            "    if (senhaConfirma == '')\n" +
            "    {\n" +
            "        'Senha vazia!';\n" +
            "    }\n" +
            "}\n");
            
        }

        internal void escreveTesteCampoCPF(IWebDriver driver)
        {
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).Clear();
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).SendKeys("if (pessoa.cpf.Any(char.IsLetter))\n" +
                "{\n" +
                "   'CPF inválido!';\n" +
                "   return;\n" +
                "}\n");
        }

        internal void escreveTesteCampoNome(IWebDriver driver)
        {
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEscrever")).SendKeys(
             "if (pessoa.nome.Any(char.IsNumber)) \n" +
             "{\n" +
             "    Nome com números!\n" +
             "    return;\n" +
             "} else\n" +
             "{\n" +
             "    if (pessoa.nome == '')\n" +
             "    {\n" +
             "        Nome Vazio!\n" +
             "        return;\n" +
             "    }\n" +
             "}\n");

        }

        public void testeCampoEmailRegistro(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }
        public void testeCampoCpfRegistro(IWebDriver driver)
        {
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("luiz gustavo");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).SendKeys("teste@gmail.com");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).SendKeys("teste");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
            
            
        }
        public ChromeDriver startBrowser()
        {
            if (Environment.OSVersion.ToString().Contains("Mac") || Environment.OSVersion.ToString().Contains("MacOS") || Environment.OSVersion.ToString().Contains("mac")
                || Environment.OSVersion.ToString().Contains("macos"))
            {
                return new ChromeDriver(HttpRuntime.AppDomainAppPath + "\\drivermac");
            }
            return new ChromeDriver(HttpRuntime.AppDomainAppPath);


        }

        public void testeCampoNomeRegistro(IWebDriver driver)
        {
            
            waitMiliSegundos(2000);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).SendKeys("teste1");
            waitMiliSegundos(1000);
            driver.FindElement(By.Name("ctl00$MainContent$ButtonConfirma")).Click();
            waitMiliSegundos(1000);
        }

        public void cleanRegistro(IWebDriver driver)
        {
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxNome")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxEmail")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxCPF")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenha")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxSenhaConfirma")).Clear();
            waitMiliSegundos(300);
            driver.FindElement(By.Name("ctl00$MainContent$TextBoxIdade")).Clear();
            waitMiliSegundos(1000);
        }
        public void waitMiliSegundos(int v)
        {
            System.Threading.Thread.Sleep(v/2);
        }
    }
}