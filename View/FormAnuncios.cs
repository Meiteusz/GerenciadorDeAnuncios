using Controller;
using System;
using System.Windows.Forms;

namespace GerenciadorDeAnuncios
{
    public partial class FormAnuncios : Form
    {
        public FormAnuncios()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            btnMostrarRelatorio.Enabled = false;
            dgvRelatorios.DataSource = anuncioBLL.MostrarAnuncios();
        }

        AnuncioBLL anuncioBLL = new AnuncioBLL();

        private void FormRelatorios_Load(object sender, System.EventArgs e)
        {
            txtNomeCliente.AutoCompleteCustomSource = anuncioBLL.ListarNomesCliente();
            txtNomeCliente.AutoCompleteMode = AutoCompleteMode.Append;
            txtNomeCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dgvRelatorios.DataSource = anuncioBLL.MostrarAnuncios();
            dgvRelatorios.Columns["Cliente"].Width = 200;
            dgvRelatorios.Columns["Id"].Width = 50;
            dgvRelatorios.Columns["Investimento_Total"].Width = 130;
            dgvRelatorios.Columns["Qtd_Max_Visualizacoes"].Width = 151;
            dgvRelatorios.Columns["Qtd_Max_Cliques"].Width = 115;
            dgvRelatorios.Columns["Qtd_Max_Compartilhamentos"].Width = 195;
        }

        private void dgvRelatorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDica.Visible = false;
            btnMostrarRelatorio.Enabled = true;
            int idAnuncio = (int)dgvRelatorios.CurrentRow.Cells[0].Value;
            SetHelper.SetAnuncio(idAnuncio);
            SetHelper.SetRelatorio(SetHelper.AnuncioSelecionado.Id);
        }

        private void btnMostrarRelatorio_Click(object sender, System.EventArgs e)
        {
            FormRelatorio formRelatorio = new FormRelatorio();
            Hide();
            formRelatorio.ShowDialog();
            Close();
        }

        private void txtNomeCliente_TextChanged(object sender, System.EventArgs e)
        {
            if (txtNomeCliente.Text.Equals(string.Empty))
            {
                dgvRelatorios.DataSource = anuncioBLL.MostrarAnuncios();
            }
            else
            {
                dgvRelatorios.DataSource = anuncioBLL.FiltrarAnuncios(txtNomeCliente.Text, DateTime.Today, DateTime.Today);
            }
        }

        private void dtpDataInicio_ValueChanged(object sender, System.EventArgs e)
        {
            dgvRelatorios.DataSource = anuncioBLL.FiltrarAnuncios(string.Empty, dtpDataInicio.Value, dtpDataTermino.Value);
        }

        private void dtpDataTermino_ValueChanged(object sender, System.EventArgs e)
        {
            dgvRelatorios.DataSource = anuncioBLL.FiltrarAnuncios(string.Empty, dtpDataInicio.Value, dtpDataTermino.Value);
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = string.Empty;
            dtpDataInicio.Value = DateTime.Today;
            dtpDataTermino.Value = DateTime.Today;
            dgvRelatorios.DataSource = anuncioBLL.MostrarAnuncios();
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            Hide();
            formInicio.ShowDialog();
            Close();
        }
    }
}
