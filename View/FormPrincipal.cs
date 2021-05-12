using Controller;
using Entities;
using System;
using System.Windows.Forms;

namespace GerenciadorDeAnuncios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dtpDataInicio.Value = DateTime.Today;
            dtpDataTermino.Value = DateTime.Today;
        }

        AnuncioBLL anuncioBLL = new AnuncioBLL();

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCliente.Text = string.Empty;
            txtNomeAnuncio.Text = string.Empty;
            txtInvestimentoDia.Value = 0;
            dtpDataInicio.Value = DateTime.Today;
            dtpDataTermino.Value = DateTime.Today;
        }


        private void btnCadastrarAnuncio_Click(object sender, EventArgs e)
        {
            Anuncio anuncio = new Anuncio(txtNomeAnuncio.Text, txtCliente.Text, dtpDataInicio.Value, dtpDataTermino.Value, (float)txtInvestimentoDia.Value);

            if (anuncioBLL.CadastrarAnuncio(anuncio))
                MessageBox.Show("Anúncio cadastrado com sucesso!");
            else
                MessageBox.Show(anuncioBLL.Output);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            Hide();
            formInicio.ShowDialog();
            Close();
        }
    }
}
