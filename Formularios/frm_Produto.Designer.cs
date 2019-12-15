namespace Formularios
{
    partial class frm_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Produto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label15 = new System.Windows.Forms.Label();
            this.pnlCompleto = new System.Windows.Forms.Panel();
            this.btnPesquisaAluno = new System.Windows.Forms.Button();
            this.txtAlunoPesquisar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnInicial = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnAjudadois = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnCancela = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.vCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCompleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(6, 16);
            this.Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(114, 16);
            this.Label15.TabIndex = 47;
            this.Label15.Text = "Código/Nome:";
            // 
            // pnlCompleto
            // 
            this.pnlCompleto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCompleto.Controls.Add(this.Label15);
            this.pnlCompleto.Controls.Add(this.btnPesquisaAluno);
            this.pnlCompleto.Controls.Add(this.txtAlunoPesquisar);
            this.pnlCompleto.Controls.Add(this.btnEditar);
            this.pnlCompleto.Controls.Add(this.btnExcluir);
            this.pnlCompleto.Controls.Add(this.dgvAlunos);
            this.pnlCompleto.Controls.Add(this.btnInicial);
            this.pnlCompleto.Controls.Add(this.btnAjuda);
            this.pnlCompleto.Controls.Add(this.btnNovo);
            this.pnlCompleto.Location = new System.Drawing.Point(12, 12);
            this.pnlCompleto.Name = "pnlCompleto";
            this.pnlCompleto.Size = new System.Drawing.Size(388, 265);
            this.pnlCompleto.TabIndex = 50;
            // 
            // btnPesquisaAluno
            // 
            this.btnPesquisaAluno.AutoSize = true;
            this.btnPesquisaAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaAluno.Image")));
            this.btnPesquisaAluno.Location = new System.Drawing.Point(353, 6);
            this.btnPesquisaAluno.Name = "btnPesquisaAluno";
            this.btnPesquisaAluno.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisaAluno.TabIndex = 32;
            this.btnPesquisaAluno.UseVisualStyleBackColor = true;
            // 
            // txtAlunoPesquisar
            // 
            this.txtAlunoPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlunoPesquisar.Location = new System.Drawing.Point(124, 8);
            this.txtAlunoPesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAlunoPesquisar.MaxLength = 40;
            this.txtAlunoPesquisar.Name = "txtAlunoPesquisar";
            this.txtAlunoPesquisar.Size = new System.Drawing.Size(224, 24);
            this.txtAlunoPesquisar.TabIndex = 47;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(204, 210);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 47);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(257, 210);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(47, 47);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToResizeColumns = false;
            this.dgvAlunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vCodigo,
            this.vNome});
            this.dgvAlunos.Location = new System.Drawing.Point(9, 41);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvAlunos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(360, 162);
            this.dgvAlunos.TabIndex = 0;
            // 
            // btnInicial
            // 
            this.btnInicial.FlatAppearance.BorderSize = 0;
            this.btnInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicial.Image = ((System.Drawing.Image)(resources.GetObject("btnInicial.Image")));
            this.btnInicial.Location = new System.Drawing.Point(45, 210);
            this.btnInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInicial.Name = "btnInicial";
            this.btnInicial.Size = new System.Drawing.Size(47, 47);
            this.btnInicial.TabIndex = 40;
            this.btnInicial.UseVisualStyleBackColor = true;
            // 
            // btnAjuda
            // 
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuda.Image")));
            this.btnAjuda.Location = new System.Drawing.Point(98, 210);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(47, 47);
            this.btnAjuda.TabIndex = 39;
            this.btnAjuda.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(151, 210);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(47, 47);
            this.btnNovo.TabIndex = 43;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(9, 9);
            this.Label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(58, 16);
            this.Label19.TabIndex = 49;
            this.Label19.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(12, 28);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCod.MaxLength = 40;
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(71, 20);
            this.txtCod.TabIndex = 50;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAjudadois
            // 
            this.btnAjudadois.FlatAppearance.BorderSize = 0;
            this.btnAjudadois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjudadois.Image = ((System.Drawing.Image)(resources.GetObject("btnAjudadois.Image")));
            this.btnAjudadois.Location = new System.Drawing.Point(39, 210);
            this.btnAjudadois.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjudadois.Name = "btnAjudadois";
            this.btnAjudadois.Size = new System.Drawing.Size(47, 47);
            this.btnAjudadois.TabIndex = 48;
            this.btnAjudadois.UseVisualStyleBackColor = true;
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel4.Controls.Add(this.Label19);
            this.Panel4.Controls.Add(this.txtCod);
            this.Panel4.Controls.Add(this.btnAjudadois);
            this.Panel4.Controls.Add(this.Label1);
            this.Panel4.Controls.Add(this.btnCancela);
            this.Panel4.Controls.Add(this.txtNome);
            this.Panel4.Controls.Add(this.Panel2);
            this.Panel4.Controls.Add(this.btnLimpa);
            this.Panel4.Controls.Add(this.btnConfirma);
            this.Panel4.Location = new System.Drawing.Point(406, 12);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(385, 265);
            this.Panel4.TabIndex = 49;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(86, 9);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 16);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "Nome";
            // 
            // btnCancela
            // 
            this.btnCancela.Enabled = false;
            this.btnCancela.FlatAppearance.BorderSize = 0;
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Image = ((System.Drawing.Image)(resources.GetObject("btnCancela.Image")));
            this.btnCancela.Location = new System.Drawing.Point(303, 210);
            this.btnCancela.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(47, 47);
            this.btnCancela.TabIndex = 46;
            this.btnCancela.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(282, 20);
            this.txtNome.TabIndex = 33;
            this.txtNome.Text = "Roberta Almeida";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.txtNumero);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.txtEndereco);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Location = new System.Drawing.Point(2, 54);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(376, 149);
            this.Panel2.TabIndex = 36;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(107, 39);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumero.MaxLength = 20;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(89, 20);
            this.txtNumero.TabIndex = 8;
            this.txtNumero.Text = "1234B";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(16, 43);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(54, 16);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Preço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(107, 13);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEndereco.MaxLength = 40;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(258, 20);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.Text = "Rua das Ruas";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(16, 16);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(84, 16);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Descrição:";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Enabled = false;
            this.btnLimpa.FlatAppearance.BorderSize = 0;
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpa.Image")));
            this.btnLimpa.Location = new System.Drawing.Point(92, 210);
            this.btnLimpa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(47, 47);
            this.btnLimpa.TabIndex = 41;
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Enabled = false;
            this.btnConfirma.FlatAppearance.BorderSize = 0;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirma.Image")));
            this.btnConfirma.Location = new System.Drawing.Point(250, 210);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(47, 47);
            this.btnConfirma.TabIndex = 38;
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "FotoAluno";
            this.OpenFileDialog1.Filter = "Png (*.png)|*.png|Jpeg(*.jpg)|*.jpg";
            this.OpenFileDialog1.InitialDirectory = "Documents";
            // 
            // vCodigo
            // 
            this.vCodigo.DataPropertyName = "vCodigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.vCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.vCodigo.HeaderText = "Codigo";
            this.vCodigo.Name = "vCodigo";
            this.vCodigo.ReadOnly = true;
            this.vCodigo.Width = 70;
            // 
            // vNome
            // 
            this.vNome.DataPropertyName = "vNome";
            this.vNome.HeaderText = "Nome";
            this.vNome.Name = "vNome";
            this.vNome.ReadOnly = true;
            this.vNome.Width = 268;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 286);
            this.Controls.Add(this.pnlCompleto);
            this.Controls.Add(this.Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.pnlCompleto.ResumeLayout(false);
            this.pnlCompleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Panel pnlCompleto;
        internal System.Windows.Forms.Button btnPesquisaAluno;
        internal System.Windows.Forms.TextBox txtAlunoPesquisar;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.DataGridView dgvAlunos;
        internal System.Windows.Forms.Button btnInicial;
        internal System.Windows.Forms.Button btnAjuda;
        internal System.Windows.Forms.Button btnNovo;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtCod;
        internal System.Windows.Forms.Button btnAjudadois;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnCancela;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox txtNumero;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtEndereco;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnLimpa;
        internal System.Windows.Forms.Button btnConfirma;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNome;
    }
}