namespace Formularios
{
    partial class frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label15 = new System.Windows.Forms.Label();
            this.pnlCompleto = new System.Windows.Forms.Panel();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.txtClientePesquisar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.vCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTelcom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInicial = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnAjudadois = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnCancela = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtObserv = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            this.Label17 = new System.Windows.Forms.Label();
            this.mtbContato = new System.Windows.Forms.MaskedTextBox();
            this.cbxUf = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlCompleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.pnlCompleto.Controls.Add(this.btnPesquisaCliente);
            this.pnlCompleto.Controls.Add(this.txtClientePesquisar);
            this.pnlCompleto.Controls.Add(this.btnEditar);
            this.pnlCompleto.Controls.Add(this.btnExcluir);
            this.pnlCompleto.Controls.Add(this.dgvClientes);
            this.pnlCompleto.Controls.Add(this.btnInicial);
            this.pnlCompleto.Controls.Add(this.btnAjuda);
            this.pnlCompleto.Controls.Add(this.btnNovo);
            this.pnlCompleto.Location = new System.Drawing.Point(12, 12);
            this.pnlCompleto.Name = "pnlCompleto";
            this.pnlCompleto.Size = new System.Drawing.Size(473, 363);
            this.pnlCompleto.TabIndex = 50;
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.AutoSize = true;
            this.btnPesquisaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCliente.Image")));
            this.btnPesquisaCliente.Location = new System.Drawing.Point(437, 6);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisaCliente.TabIndex = 32;
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // txtClientePesquisar
            // 
            this.txtClientePesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientePesquisar.Location = new System.Drawing.Point(124, 8);
            this.txtClientePesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtClientePesquisar.MaxLength = 40;
            this.txtClientePesquisar.Name = "txtClientePesquisar";
            this.txtClientePesquisar.Size = new System.Drawing.Size(308, 24);
            this.txtClientePesquisar.TabIndex = 47;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(257, 305);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 47);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(310, 305);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(47, 47);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vCodigo,
            this.vNome,
            this.vDataCadastro,
            this.vObservacao,
            this.vAtivo,
            this.vTelcom,
            this.vRua,
            this.vNumero,
            this.vBairro,
            this.vCidade,
            this.vUf,
            this.vCep,
            this.vEmail});
            this.dgvClientes.Location = new System.Drawing.Point(9, 41);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(453, 257);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // vCodigo
            // 
            this.vCodigo.DataPropertyName = "vCodigo";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.vCodigo.DefaultCellStyle = dataGridViewCellStyle17;
            this.vCodigo.HeaderText = "Codigo";
            this.vCodigo.Name = "vCodigo";
            this.vCodigo.ReadOnly = true;
            this.vCodigo.Width = 65;
            // 
            // vNome
            // 
            this.vNome.DataPropertyName = "vNome";
            this.vNome.HeaderText = "Nome";
            this.vNome.Name = "vNome";
            this.vNome.ReadOnly = true;
            this.vNome.Width = 268;
            // 
            // vDataCadastro
            // 
            this.vDataCadastro.DataPropertyName = "vDataCadastro";
            this.vDataCadastro.HeaderText = "DataCadastro";
            this.vDataCadastro.Name = "vDataCadastro";
            this.vDataCadastro.ReadOnly = true;
            // 
            // vObservacao
            // 
            this.vObservacao.DataPropertyName = "vObservacao";
            this.vObservacao.HeaderText = "Observacao";
            this.vObservacao.Name = "vObservacao";
            this.vObservacao.ReadOnly = true;
            this.vObservacao.Visible = false;
            // 
            // vAtivo
            // 
            this.vAtivo.DataPropertyName = "vAtivo";
            this.vAtivo.HeaderText = "Ativo";
            this.vAtivo.Name = "vAtivo";
            this.vAtivo.ReadOnly = true;
            this.vAtivo.Visible = false;
            // 
            // vTelcom
            // 
            this.vTelcom.DataPropertyName = "vTelcom";
            this.vTelcom.HeaderText = "Tel. Com.";
            this.vTelcom.Name = "vTelcom";
            this.vTelcom.ReadOnly = true;
            this.vTelcom.Visible = false;
            // 
            // vRua
            // 
            this.vRua.DataPropertyName = "vRua";
            this.vRua.HeaderText = "Rua";
            this.vRua.Name = "vRua";
            this.vRua.ReadOnly = true;
            this.vRua.Visible = false;
            // 
            // vNumero
            // 
            this.vNumero.DataPropertyName = "vNumero";
            this.vNumero.HeaderText = "Numero";
            this.vNumero.Name = "vNumero";
            this.vNumero.ReadOnly = true;
            this.vNumero.Visible = false;
            // 
            // vBairro
            // 
            this.vBairro.DataPropertyName = "vBairro";
            this.vBairro.HeaderText = "Bairro";
            this.vBairro.Name = "vBairro";
            this.vBairro.ReadOnly = true;
            this.vBairro.Visible = false;
            // 
            // vCidade
            // 
            this.vCidade.DataPropertyName = "vCidade";
            this.vCidade.HeaderText = "Cidade";
            this.vCidade.Name = "vCidade";
            this.vCidade.ReadOnly = true;
            this.vCidade.Visible = false;
            // 
            // vUf
            // 
            this.vUf.DataPropertyName = "vUf";
            this.vUf.HeaderText = "Uf";
            this.vUf.Name = "vUf";
            this.vUf.ReadOnly = true;
            this.vUf.Visible = false;
            // 
            // vCep
            // 
            this.vCep.DataPropertyName = "vCep";
            this.vCep.HeaderText = "Cep";
            this.vCep.Name = "vCep";
            this.vCep.ReadOnly = true;
            this.vCep.Visible = false;
            // 
            // vEmail
            // 
            this.vEmail.DataPropertyName = "vEmail";
            this.vEmail.HeaderText = "Email";
            this.vEmail.Name = "vEmail";
            this.vEmail.ReadOnly = true;
            this.vEmail.Visible = false;
            // 
            // btnInicial
            // 
            this.btnInicial.FlatAppearance.BorderSize = 0;
            this.btnInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicial.Image = ((System.Drawing.Image)(resources.GetObject("btnInicial.Image")));
            this.btnInicial.Location = new System.Drawing.Point(98, 305);
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
            this.btnAjuda.Location = new System.Drawing.Point(151, 305);
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
            this.btnNovo.Location = new System.Drawing.Point(204, 305);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(47, 47);
            this.btnNovo.TabIndex = 43;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Checked = false;
            this.dtpCadastro.Enabled = false;
            this.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastro.Location = new System.Drawing.Point(382, 28);
            this.dtpCadastro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(101, 20);
            this.dtpCadastro.TabIndex = 51;
            this.dtpCadastro.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
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
            this.btnAjudadois.Location = new System.Drawing.Point(80, 305);
            this.btnAjudadois.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjudadois.Name = "btnAjudadois";
            this.btnAjudadois.Size = new System.Drawing.Size(47, 47);
            this.btnAjudadois.TabIndex = 48;
            this.btnAjudadois.UseVisualStyleBackColor = true;
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel4.Controls.Add(this.dtpCadastro);
            this.Panel4.Controls.Add(this.Label19);
            this.Panel4.Controls.Add(this.txtCod);
            this.Panel4.Controls.Add(this.btnAjudadois);
            this.Panel4.Controls.Add(this.Label1);
            this.Panel4.Controls.Add(this.btnCancela);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Controls.Add(this.txtNome);
            this.Panel4.Controls.Add(this.Panel2);
            this.Panel4.Controls.Add(this.btnLimpa);
            this.Panel4.Controls.Add(this.btnConfirma);
            this.Panel4.Location = new System.Drawing.Point(491, 12);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(505, 363);
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
            this.btnCancela.Location = new System.Drawing.Point(394, 305);
            this.btnCancela.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(47, 47);
            this.btnCancela.TabIndex = 46;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(379, 9);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 16);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "Cadastro";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(291, 20);
            this.txtNome.TabIndex = 33;
            this.txtNome.Text = "Roberta Almeida";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.txtObserv);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.groupBox1);
            this.Panel2.Controls.Add(this.btnPesquisarCep);
            this.Panel2.Controls.Add(this.Label17);
            this.Panel2.Controls.Add(this.mtbContato);
            this.Panel2.Controls.Add(this.cbxUf);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.mtbCep);
            this.Panel2.Controls.Add(this.txtEmail);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.txtCidade);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.txtBairro);
            this.Panel2.Controls.Add(this.Label12);
            this.Panel2.Controls.Add(this.txtNumero);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.txtEndereco);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Location = new System.Drawing.Point(2, 54);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(496, 244);
            this.Panel2.TabIndex = 36;
            // 
            // txtObserv
            // 
            this.txtObserv.Location = new System.Drawing.Point(218, 152);
            this.txtObserv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtObserv.MaxLength = 500;
            this.txtObserv.Multiline = true;
            this.txtObserv.Name = "txtObserv";
            this.txtObserv.ReadOnly = true;
            this.txtObserv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserv.Size = new System.Drawing.Size(261, 74);
            this.txtObserv.TabIndex = 6;
            this.txtObserv.Text = "Este é um teste para o banco de dados";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(215, 130);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(65, 16);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Observ.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(19, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 42);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ativo:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "não";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(61, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "sim";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.AutoSize = true;
            this.btnPesquisarCep.Enabled = false;
            this.btnPesquisarCep.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCep.Image")));
            this.btnPesquisarCep.Location = new System.Drawing.Point(453, 65);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarCep.TabIndex = 31;
            this.btnPesquisarCep.UseVisualStyleBackColor = true;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(16, 129);
            this.Label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(66, 16);
            this.Label17.TabIndex = 28;
            this.Label17.Text = "Contato";
            // 
            // mtbContato
            // 
            this.mtbContato.Location = new System.Drawing.Point(107, 126);
            this.mtbContato.Mask = "(99) 0000-0000";
            this.mtbContato.Name = "mtbContato";
            this.mtbContato.ReadOnly = true;
            this.mtbContato.Size = new System.Drawing.Size(87, 20);
            this.mtbContato.TabIndex = 27;
            this.mtbContato.Text = "1111111111";
            // 
            // cbxUf
            // 
            this.cbxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUf.Enabled = false;
            this.cbxUf.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUf.FormattingEnabled = true;
            this.cbxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUf.Location = new System.Drawing.Point(266, 68);
            this.cbxUf.MaxLength = 2;
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.Size = new System.Drawing.Size(57, 22);
            this.cbxUf.TabIndex = 26;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(232, 71);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(32, 16);
            this.Label11.TabIndex = 25;
            this.Label11.Text = "UF:";
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(378, 68);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.ReadOnly = true;
            this.mtbCep.Size = new System.Drawing.Size(70, 20);
            this.mtbCep.TabIndex = 13;
            this.mtbCep.Text = "12345789";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 97);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(341, 20);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Text = "algumacoisa@gmail.com";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(16, 100);
            this.Label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(53, 16);
            this.Label16.TabIndex = 21;
            this.Label16.Text = "Email:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(328, 71);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(46, 16);
            this.Label13.TabIndex = 19;
            this.Label13.Text = "CEP.:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(107, 68);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(121, 20);
            this.txtCidade.TabIndex = 18;
            this.txtCidade.Text = "Sorocaba";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(16, 71);
            this.Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(63, 16);
            this.Label14.TabIndex = 17;
            this.Label14.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(107, 39);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(372, 20);
            this.txtBairro.TabIndex = 14;
            this.txtBairro.Text = "Centro";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(16, 42);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(57, 16);
            this.Label12.TabIndex = 13;
            this.Label12.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(390, 13);
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
            this.Label8.Location = new System.Drawing.Point(355, 16);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(31, 16);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Nº:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(107, 13);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEndereco.MaxLength = 40;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(244, 20);
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
            this.Label6.Size = new System.Drawing.Size(40, 16);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Rua:";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Enabled = false;
            this.btnLimpa.FlatAppearance.BorderSize = 0;
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpa.Image")));
            this.btnLimpa.Location = new System.Drawing.Point(133, 305);
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
            this.btnConfirma.Location = new System.Drawing.Point(341, 305);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(47, 47);
            this.btnConfirma.TabIndex = 38;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "FotoAluno";
            this.OpenFileDialog1.Filter = "Png (*.png)|*.png|Jpeg(*.jpg)|*.jpg";
            this.OpenFileDialog1.InitialDirectory = "Documents";
            // 
            // frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 384);
            this.Controls.Add(this.pnlCompleto);
            this.Controls.Add(this.Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Clientes";
            this.Load += new System.EventHandler(this.frm_Cliente_Load);
            this.pnlCompleto.ResumeLayout(false);
            this.pnlCompleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Panel pnlCompleto;
        internal System.Windows.Forms.Button btnPesquisaCliente;
        internal System.Windows.Forms.TextBox txtClientePesquisar;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.DataGridView dgvClientes;
        internal System.Windows.Forms.Button btnInicial;
        internal System.Windows.Forms.Button btnAjuda;
        internal System.Windows.Forms.Button btnNovo;
        internal System.Windows.Forms.DateTimePicker dtpCadastro;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtCod;
        internal System.Windows.Forms.Button btnAjudadois;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnCancela;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnPesquisarCep;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.MaskedTextBox mtbContato;
        internal System.Windows.Forms.ComboBox cbxUf;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.MaskedTextBox mtbCep;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtCidade;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox txtBairro;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtNumero;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtEndereco;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnLimpa;
        internal System.Windows.Forms.TextBox txtObserv;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnConfirma;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn vObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTelcom;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn vBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn vEmail;
    }
}