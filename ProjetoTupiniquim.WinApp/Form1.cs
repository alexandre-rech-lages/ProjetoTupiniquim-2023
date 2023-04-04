using ProjetoTupiniquim.ConsoleApp;

namespace ProjetoTupiniquim.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            Robo robo = new Robo();

            robo.Localizacao = txtLocalizacao.Text;

            robo.ExplorarArea(txtComando.Text);

            labelLocalizacaoFinal.Text = robo.Localizacao;
        }
    }
}