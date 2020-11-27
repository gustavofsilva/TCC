using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrototipoTCC.Testes
{
    public partial class TesteAceitacao : System.Web.UI.Page
    {
        string url;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            url = HttpContext.Current.Request.Url.Authority;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Atleta atleta = new Atleta();
            if (!ValidaEntrada())
            {
                //System.Windows.Forms.MessageBox.Show("Erro !");
                return;
            } 

            atleta.Altura = Convert.ToInt32(RemovePontoVirgula(TextBoxAltura.Text));
            atleta.Idade = Convert.ToInt32(TextBoxIdade.Text);
            atleta.Nome = TextBoxNome.Text;
            atleta.QtdPartidas = Convert.ToInt32(TextBoxPartidas.Text);

            
            if (atleta.Altura < 180)
            {
                labelAltura.Text = "Sem altura mínima!";
            }
            if (atleta.Idade < 18)
            {
                labelIdade.Text = "Sem idade mínima!";
            }
            if (atleta.QtdPartidas < 10)
            {
                labelPartidas.Text = "Sem partidas mínimas!";
            }
        }

        private string RemovePontoVirgula(string texto)
        {
            if (texto.Contains(","))
            {
                return texto.Replace(",", "");
            } else
            {
                return texto.Replace(".", "");
            }
        }

        private bool ValidaEntrada()
        {
            if (TextBoxNome.Text == "")
            {
                labelNome.Text = "Nome Vazio!";
            }
            try
            {
                if (TextBoxAltura.Text.Contains("."))
                {
                    int altura = Convert.ToInt32(RemovePontoVirgula(TextBoxAltura.Text));
                }
                if (TextBoxAltura.Text.Contains(","))
                {
                    int altura = Convert.ToInt32(RemovePontoVirgula(TextBoxAltura.Text));
                }     
                
            } catch
            {
                labelAltura.Text = "Altura digitada incorretamente!";
                return false;
            }

            try
            {
                int idade = Convert.ToInt32(TextBoxIdade.Text);
            }
            catch
            {
                labelIdade.Text = "Idade digitada incorretamente!";
                return false;
            }

            try
            {
                int partidas = Convert.ToInt32(TextBoxPartidas.Text);
            } catch
            {
                labelPartidas.Text = "Quantidade de partidas digitada incorretamente!";
                return false;
            }
            return true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/TestList.aspx");
        }

        protected void ButtonTest_Click(object sender, EventArgs e)
        {
            string textArea = "";

            WebDriver web = new WebDriver();
            IWebDriver driver = web.StartDriver(url, "/Testes/TesteAmostragem");
            web.FazTesteAmostragemCampoIdade(driver, 17);
            if (!(labelIdade.Text == "Sem idade mínima!"))
            {
                textArea += "Erro! Não deveria aceitar a idade 17!\n";
                web.EscreveErroIdadeAmostragem(textArea, driver);
            }
            web.LimpaCamposAmostragem(driver);

            web.FazTesteAmostragemCampoIdade(driver, 18);
            if (labelIdade.Text == "Sem altura mínima!")
            {
                textArea += "Erro! Deveria aceitar a idade 18!\n";
                web.EscreveErroIdadeAmostragem(textArea, driver);
            }
            web.LimpaCamposAmostragem(driver);

            web.FazTesteAmostragemCampoIdade(driver, 19);
            if (labelIdade.Text == "Sem altura mínima!")
            {
                textArea += "Erro! Deveria aceitar a idade 19!\n";
                web.EscreveErroIdadeAmostragem(textArea, driver);
            }
            web.LimpaCamposAmostragem(driver);

            web.FazTesteAmostragemCampoAltura(driver, 179);
            if (!(labelIdade.Text == "Sem altura mínima!"))
            {
                textArea += "Erro! Não deveria aceitar altura 1.79!\n";
                web.EscreveErroIdadeAmostragem(textArea, driver);
            }
            web.LimpaCamposAmostragem(driver);

            web.FazTesteAmostragemCampoAltura(driver, 180);
            if (labelIdade.Text == "Sem altura mínima!")
            {
                textArea += "Erro! Deveria aceitar altura 1.80!\n";
                web.EscreveErroIdadeAmostragem(textArea, driver);
            }
            web.LimpaCamposAmostragem(driver);

            web.FazTesteAmostragemCampoAltura(driver, 181);
            if (labelIdade.Text == "Sem altura mínima!")
            {
                textArea += "Erro! Deveria aceitar altura 1.181!\n";
                web.EscreveErroIdadeAmostragem(textArea, driver);
            }

            web.LimpaCamposAmostragem(driver);
            web.FazTesteAmostragemCampoPartidas(driver, 9);
            if (!(labelPartidas.Text == "Sem partidas mínimas!"))
            {
                textArea += "Erro! Não deveria aceitar 9 partidas!\n";
                web.EscreveErroIdadeAmostragem(textArea, driver);
            }

            web.LimpaCamposAmostragem(driver);
            web.FazTesteAmostragemCampoPartidas(driver, 10);
            if (labelPartidas.Text == "Sem partidas mínimas!")
            {
                textArea += "Erro! Deveria aceitar 10 partidas!\n";
                web.EscreveErroIdadeAmostragem(textArea, driver);
            }

            web.LimpaCamposAmostragem(driver);
            web.FazTesteAmostragemCampoPartidas(driver, 11);
            if (labelPartidas.Text == "Sem partidas mínimas!")
            {
                textArea += "Erro! Deveria aceitar 11 partidas!\n";
                web.EscreveErroIdadeAmostragem(textArea, driver);
            }

            web.EscreveErroIdadeAmostragem(textArea, driver);
        }
    }
}