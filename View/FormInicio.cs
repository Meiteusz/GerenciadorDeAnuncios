using System.Windows.Forms;

namespace GerenciadorDeAnuncios
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCadastroAnuncio_Click(object sender, System.EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            Hide();
            formPrincipal.ShowDialog();
            Close();
        }

        private void btnRelatoriosAnuncios_Click(object sender, System.EventArgs e)
        {
            FormAnuncios formRelatorios = new FormAnuncios();
            Hide();
            formRelatorios.ShowDialog();
            Close();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
