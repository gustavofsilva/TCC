using OpenQA.Selenium;
using PerformanceView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrototipoTCC.Testes
{
    public partial class TestePerformance : System.Web.UI.Page
    {
        string url;

        protected void Page_Load(object sender, EventArgs e)
        {
            url = HttpContext.Current.Request.Url.Authority;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/TestList.aspx");
        }

        protected void buttonIniciar_Click(object sender, EventArgs e)
        {
            WebDriver webDriver = new WebDriver();
            FormPerformanceView perf = new FormPerformanceView();
            perf.startForm();

            for (int aux =0; aux < 2; aux++)
            {
                Task task = Task.Factory.StartNew(() =>
                {
                    IWebDriver driver;
                    driver = webDriver.StartDriver(url, "/Testes/TesteStress");
                    webDriver.TesteStress(5, driver);
                    
                });

                Task task2 = Task.Factory.StartNew(() =>
                {
                    IWebDriver driver2;
                    driver2 = webDriver.StartDriver(url, "/Testes/TesteUnitario");
                    webDriver.testeCampoIdadeUnitPerf(driver2);
                    webDriver.AtualizaPagina2(driver2, "/Testes/TesteUnitario", url);
                    webDriver.FinzalizaDriver(driver2);

                });
                Task task3 = Task.Factory.StartNew(() =>
                {
                    IWebDriver driver3;
                    driver3 = webDriver.StartDriver(url, "/Testes/TesteAmostragem");
                    webDriver.FazTesteAmostragemCampoIdade(driver3, 18);
                    webDriver.FazTesteAmostragemCampoAltura(driver3, 190);
                    webDriver.FazTesteAmostragemCampoPartidas(driver3, 35);
                    webDriver.FinzalizaDriver(driver3);

                });
            }
            
        }
    }
}