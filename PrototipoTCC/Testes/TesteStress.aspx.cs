using System;
using System.Threading.Tasks;

namespace PrototipoTCC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonComecaTeste_Click(object sender, EventArgs e)
        {
            string charQtdTeste= TextBoxQtdTeste.Text;
            string charQtdRepeticoes= TextBoxRepeticoes.Text;

            
            if (!ValidaEntrada(charQtdTeste, charQtdRepeticoes))
            {
                return;
            }

            int qtdTeste = Convert.ToInt32(TextBoxQtdTeste.Text);
            int qtdRepeticoes = Convert.ToInt32(TextBoxRepeticoes.Text);

            
            for (int aux = 0; aux < qtdTeste; aux++)
            {
                Task task = Task.Factory.StartNew(() =>
                {
                    WebDriver webDriver = new WebDriver();
                    webDriver.TesteStress(qtdRepeticoes);
                });
            }

        }

        private bool ValidaEntrada(string text1, string text2)
        {
            try
            {
                int qtdTeste = Convert.ToInt32(TextBoxQtdTeste.Text);
                int qtdRepeticoes = Convert.ToInt32(TextBoxRepeticoes.Text);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Numero errado!");
                return false;
            }
            return true;
        }

        protected void ButtonGenerico_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Testes/TesteStress.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/TestList.aspx");
        }
    }
}