namespace Formularios
{
    partial class frm_PesqCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PesqCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCompleto = new System.Windows.Forms.Panel();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtClientePesquisar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.vCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInicial = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlCompleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCompleto
            // 
            this.pnlCompleto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCompleto.Controls.Add(this.Label15);
            this.pnlCompleto.Controls.Add(this.txtClientePesquisar);
            this.pnlCompleto.Controls.Add(this.btnEditar);
            this.pnlCompleto.Controls.Add(this.btnExcluir);
            this.pnlCompleto.Controls.Add(this.dgvClientes);
            this.pnlCompleto.Controls.Add(this.btnInicial);
            this.pnlCompleto.Controls.Add(this.btnAjuda);
            this.pnlCompleto.Controls.Add(this.btnNovo);
            this.pnlCompleto.Location = new System.Drawing.Point(12, 12);
            this.pnlCompleto.Name = "pnlCompleto";
            this.pnlCompleto.Size = new System.Drawing.Size(473, 436);
            this.pnlCompleto.TabIndex = 51;
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
            // txtClientePesquisar
            // 
            this.txtClientePesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClientePesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientePesquisar.Location = new System.Drawing.Point(124, 8);
            this.txtClientePesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtClientePesquisar.MaxLength = 40;
            this.txtClientePesquisar.Name = "txtClientePesquisar";
            this.txtClientePesquisar.Size = new System.Drawing.Size(338, 24);
            this.txtClientePesquisar.TabIndex = 47;
            this.txtClientePesquisar.TextChanged += new System.EventHandler(this.txtClientePesquisar_TextChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(254, 381);
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
            this.btnExcluir.Location = new System.Drawing.Point(307, 381);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(47, 47);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vCodigo,
            this.vNome,
            this.vEmail});
            this.dgvClientes.Location = new System.Drawing.Point(9, 41);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(453, 333);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
            // 
            // vCodigo
            // 
            this.vCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.vCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.vCodigo.HeaderText = "Codigo";
            this.vCodigo.Name = "vCodigo";
            this.vCodigo.ReadOnly = true;
            this.vCodigo.Width = 65;
            // 
            // vNome
            // 
            this.vNome.DataPropertyName = "Nome";
            this.vNome.HeaderText = "Nome";
            this.vNome.Name = "vNome";
            this.vNome.ReadOnly = true;
            this.vNome.Width = 268;
            // 
            // vEmail
            // 
            this.vEmail.DataPropertyName = "Email";
            this.vEmail.HeaderText = "Email";
            this.vEmail.Name = "vEmail";
            this.vEmail.ReadOnly = true;
            // 
            // btnInicial
            // 
            this.btnInicial.FlatAppearance.BorderSize = 0;
            this.btnInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicial.Image = ((System.Drawing.Image)(resources.GetObject("btnInicial.Image")));
            this.btnInicial.Location = new System.Drawing.Point(95, 381);
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
            this.btnAjuda.Location = new System.Drawing.Point(148, 381);
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
            this.btnNovo.Location = new System.Drawing.Point(201, 381);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(47, 47);
            this.btnNovo.TabIndex = 43;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frm_PesqCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 460);
            this.Controls.Add(this.pnlCompleto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PesqCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Clientes";
            this.Load += new System.EventHandler(this.frm_PesqCliente_Load);
            this.pnlCompleto.ResumeLayout(false);
            this.pnlCompleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlCompleto;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.DataGridView dgvClientes;
        internal System.Windows.Forms.Button btnInicial;
        internal System.Windows.Forms.Button btnAjuda;
        internal System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn vEmail;
        public System.Windows.Forms.TextBox txtClientePesquisar;
    }
}