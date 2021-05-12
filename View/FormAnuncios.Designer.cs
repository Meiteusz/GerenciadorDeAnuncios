
namespace GerenciadorDeAnuncios
{
    partial class FormAnuncios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvRelatorios = new System.Windows.Forms.DataGridView();
            this.btnMostrarRelatorio = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataTermino = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(36, 559);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(143, 65);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvRelatorios
            // 
            this.dgvRelatorios.AllowUserToAddRows = false;
            this.dgvRelatorios.AllowUserToResizeColumns = false;
            this.dgvRelatorios.AllowUserToResizeRows = false;
            this.dgvRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelatorios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRelatorios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRelatorios.EnableHeadersVisualStyles = false;
            this.dgvRelatorios.GridColor = System.Drawing.Color.Black;
            this.dgvRelatorios.Location = new System.Drawing.Point(36, 109);
            this.dgvRelatorios.MultiSelect = false;
            this.dgvRelatorios.Name = "dgvRelatorios";
            this.dgvRelatorios.ReadOnly = true;
            this.dgvRelatorios.Size = new System.Drawing.Size(1082, 379);
            this.dgvRelatorios.TabIndex = 18;
            this.dgvRelatorios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelatorios_CellClick);
            // 
            // btnMostrarRelatorio
            // 
            this.btnMostrarRelatorio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarRelatorio.Location = new System.Drawing.Point(975, 559);
            this.btnMostrarRelatorio.Name = "btnMostrarRelatorio";
            this.btnMostrarRelatorio.Size = new System.Drawing.Size(143, 65);
            this.btnMostrarRelatorio.TabIndex = 19;
            this.btnMostrarRelatorio.Text = "Mostrar relatório";
            this.btnMostrarRelatorio.UseVisualStyleBackColor = true;
            this.btnMostrarRelatorio.Click += new System.EventHandler(this.btnMostrarRelatorio_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(8, 57);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(409, 29);
            this.txtNomeCliente.TabIndex = 20;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicio.Location = new System.Drawing.Point(500, 60);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(139, 26);
            this.dtpDataInicio.TabIndex = 21;
            this.dtpDataInicio.ValueChanged += new System.EventHandler(this.dtpDataInicio_ValueChanged);
            // 
            // dtpDataTermino
            // 
            this.dtpDataTermino.CustomFormat = "dd/MM/yyyy";
            this.dtpDataTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataTermino.Location = new System.Drawing.Point(740, 60);
            this.dtpDataTermino.Name = "dtpDataTermino";
            this.dtpDataTermino.Size = new System.Drawing.Size(139, 26);
            this.dtpDataTermino.TabIndex = 22;
            this.dtpDataTermino.ValueChanged += new System.EventHandler(this.dtpDataTermino_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimparFiltros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDataTermino);
            this.groupBox1.Controls.Add(this.dtpDataInicio);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(36, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 89);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFiltros.ForeColor = System.Drawing.Color.Black;
            this.btnLimparFiltros.Location = new System.Drawing.Point(936, 47);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(143, 38);
            this.btnLimparFiltros.TabIndex = 24;
            this.btnLimparFiltros.Text = "Limpar filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data de início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(736, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Data de término";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome do cliente";
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.Color.White;
            this.lblDica.Location = new System.Drawing.Point(33, 491);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(538, 16);
            this.lblDica.TabIndex = 24;
            this.lblDica.Text = "Clique na célula do anúncio que deseja para visualizar o relatório do mesmo";
            // 
            // FormAnuncios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1154, 642);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMostrarRelatorio);
            this.Controls.Add(this.dgvRelatorios);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnuncios";
            this.Text = "Relatórios dos Anúncios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvRelatorios;
        private System.Windows.Forms.Button btnMostrarRelatorio;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataTermino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.Label lblDica;
    }
}