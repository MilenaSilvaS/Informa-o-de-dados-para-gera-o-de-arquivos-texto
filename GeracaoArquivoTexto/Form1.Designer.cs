
namespace GeracaoArquivoTexto
{
    partial class FrmGeracaoDeArquivoTexto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeracaoDeArquivoTexto));
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.lblNFuncionarios = new System.Windows.Forms.Label();
            this.txtNumeroFuncionarios = new System.Windows.Forms.TextBox();
            this.btnCriarLinhasDeRegistro = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdGravar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(19, 51);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(364, 269);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // lblNFuncionarios
            // 
            this.lblNFuncionarios.AutoSize = true;
            this.lblNFuncionarios.Location = new System.Drawing.Point(21, 17);
            this.lblNFuncionarios.Name = "lblNFuncionarios";
            this.lblNFuncionarios.Size = new System.Drawing.Size(102, 13);
            this.lblNFuncionarios.TabIndex = 0;
            this.lblNFuncionarios.Text = "Nr. de Funcionários:";
            // 
            // txtNumeroFuncionarios
            // 
            this.txtNumeroFuncionarios.Location = new System.Drawing.Point(120, 14);
            this.txtNumeroFuncionarios.Name = "txtNumeroFuncionarios";
            this.txtNumeroFuncionarios.Size = new System.Drawing.Size(67, 20);
            this.txtNumeroFuncionarios.TabIndex = 1;
            // 
            // btnCriarLinhasDeRegistro
            // 
            this.btnCriarLinhasDeRegistro.Location = new System.Drawing.Point(216, 14);
            this.btnCriarLinhasDeRegistro.Name = "btnCriarLinhasDeRegistro";
            this.btnCriarLinhasDeRegistro.Size = new System.Drawing.Size(167, 23);
            this.btnCriarLinhasDeRegistro.TabIndex = 2;
            this.btnCriarLinhasDeRegistro.Text = "Criar linhas para registro";
            this.btnCriarLinhasDeRegistro.UseVisualStyleBackColor = true;
            this.btnCriarLinhasDeRegistro.Click += new System.EventHandler(this.btnCriarLinhasDeRegistro_Click);
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Location = new System.Drawing.Point(19, 334);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(201, 23);
            this.btnCriarArquivo.TabIndex = 4;
            this.btnCriarArquivo.Text = "Criar Arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(249, 334);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(134, 23);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdGravar
            // 
            this.sfdGravar.DefaultExt = "*.txt";
            this.sfdGravar.Filter = "Arquivos textos|*.txt";
            this.sfdGravar.Title = "Dados para geração de arquivo";
            // 
            // FrmGeracaoDeArquivoTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 369);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnCriarLinhasDeRegistro);
            this.Controls.Add(this.txtNumeroFuncionarios);
            this.Controls.Add(this.lblNFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGeracaoDeArquivoTexto";
            this.Text = "Dados para geração de arquivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNFuncionarios;
        private System.Windows.Forms.TextBox txtNumeroFuncionarios;
        private System.Windows.Forms.Button btnCriarLinhasDeRegistro;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdGravar;
    }
}

