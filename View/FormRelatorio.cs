using Controller;
using System.Windows.Forms;

namespace GerenciadorDeAnuncios
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormRelatorio_Load(object sender, System.EventArgs e)
        {
            lblNomeCliente.Text = SetHelper.AnuncioSelecionado.Cliente;
            txtNomeAnuncio.Text = SetHelper.AnuncioSelecionado.Nome;
            lblDataInicio.Text = SetHelper.AnuncioSelecionado.DataInicio.ToString("dd/MM/yyyy");
            lblDataTermino.Text = SetHelper.AnuncioSelecionado.DataTermino.ToString("dd/MM/yyyy");
            lblInvestimentoDia.Text = SetHelper.AnuncioSelecionado.InvestimentoDia.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
            lblInvestimentoTotal.Text = SetHelper.RelatorioSelecionado.ValorTotalInvestido.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
            lblVisualizacoes.Text = SetHelper.RelatorioSelecionado.QtdMaximaVisualizacoes.ToString();
            lblCliques.Text = SetHelper.RelatorioSelecionado.QtdMaximaCliques.ToString();
            lblCompartilhamentos.Text = SetHelper.RelatorioSelecionado.QtdMaximaCompartilhamentos.ToString();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            FormAnuncios formAnuncios = new FormAnuncios();
            Hide();
            formAnuncios.ShowDialog();
            Close();
        }
    }
}
