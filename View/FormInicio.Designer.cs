
namespace GerenciadorDeAnuncios
{
    partial class FormInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastroAnuncio = new System.Windows.Forms.Button();
            this.btnRelatoriosAnuncios = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Divulga Tudo";
            // 
            // btnCadastroAnuncio
            // 
            this.btnCadastroAnuncio.BackColor = System.Drawing.Color.White;
            this.btnCadastroAnuncio.FlatAppearance.BorderSize = 0;
            this.btnCadastroAnuncio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroAnuncio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAnuncio.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastroAnuncio.Location = new System.Drawing.Point(168, 280);
            this.btnCadastroAnuncio.Name = "btnCadastroAnuncio";
            this.btnCadastroAnuncio.Size = new System.Drawing.Size(182, 82);
            this.btnCadastroAnuncio.TabIndex = 1;
            this.btnCadastroAnuncio.Text = "Cadastro de Anúncio";
            this.btnCadastroAnuncio.UseVisualStyleBackColor = false;
            this.btnCadastroAnuncio.Click += new System.EventHandler(this.btnCadastroAnuncio_Click);
            // 
            // btnRelatoriosAnuncios
            // 
            this.btnRelatoriosAnuncios.BackColor = System.Drawing.Color.White;
            this.btnRelatoriosAnuncios.FlatAppearance.BorderSize = 0;
            this.btnRelatoriosAnuncios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatoriosAnuncios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatoriosAnuncios.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnRelatoriosAnuncios.Location = new System.Drawing.Point(452, 280);
            this.btnRelatoriosAnuncios.Name = "btnRelatoriosAnuncios";
            this.btnRelatoriosAnuncios.Size = new System.Drawing.Size(182, 82);
            this.btnRelatoriosAnuncios.TabIndex = 2;
            this.btnRelatoriosAnuncios.Text = "Relatórios dos Anúncios";
            this.btnRelatoriosAnuncios.UseVisualStyleBackColor = false;
            this.btnRelatoriosAnuncios.Click += new System.EventHandler(this.btnRelatoriosAnuncios_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(686, 404);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 41);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelatoriosAnuncios);
            this.Controls.Add(this.btnCadastroAnuncio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastroAnuncio;
        private System.Windows.Forms.Button btnRelatoriosAnuncios;
        private System.Windows.Forms.Button btnSair;
    }
}