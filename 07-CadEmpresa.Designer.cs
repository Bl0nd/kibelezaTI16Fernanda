namespace kibelezaTI16Fernanda
{
    partial class frmCadEmpresa
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
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.mkdDataCad = new System.Windows.Forms.MaskedTextBox();
            this.mkdCnpjCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.cmbCargaHoraria = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnlTelefone = new System.Windows.Forms.Panel();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtEmpresaFant = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblEmpresaFant = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.lblCadEmpresa = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlEmpresa.SuspendLayout();
            this.pnlTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.pnlBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEmpresa.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.empresa;
            this.pnlEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmpresa.Controls.Add(this.mkdDataCad);
            this.pnlEmpresa.Controls.Add(this.mkdCnpjCpf);
            this.pnlEmpresa.Controls.Add(this.lblDataCad);
            this.pnlEmpresa.Controls.Add(this.lblCargaHoraria);
            this.pnlEmpresa.Controls.Add(this.cmbCargaHoraria);
            this.pnlEmpresa.Controls.Add(this.lblStatus);
            this.pnlEmpresa.Controls.Add(this.btnSalvar);
            this.pnlEmpresa.Controls.Add(this.btnLimpar);
            this.pnlEmpresa.Controls.Add(this.cmbStatus);
            this.pnlEmpresa.Controls.Add(this.pnlTelefone);
            this.pnlEmpresa.Controls.Add(this.txtEmail);
            this.pnlEmpresa.Controls.Add(this.txtRazaoSocial);
            this.pnlEmpresa.Controls.Add(this.txtEmpresaFant);
            this.pnlEmpresa.Controls.Add(this.lblRazaoSocial);
            this.pnlEmpresa.Controls.Add(this.cmbDocumento);
            this.pnlEmpresa.Controls.Add(this.lblEmail);
            this.pnlEmpresa.Controls.Add(this.txtCodigo);
            this.pnlEmpresa.Controls.Add(this.lblCodigo);
            this.pnlEmpresa.Controls.Add(this.lblCnpj);
            this.pnlEmpresa.Controls.Add(this.lblEmpresaFant);
            this.pnlEmpresa.Controls.Add(this.lblDocumento);
            this.pnlEmpresa.Controls.Add(this.pnlBusca);
            this.pnlEmpresa.Location = new System.Drawing.Point(30, 71);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(1200, 600);
            this.pnlEmpresa.TabIndex = 4;
            // 
            // mkdDataCad
            // 
            this.mkdDataCad.Enabled = false;
            this.mkdDataCad.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdDataCad.Location = new System.Drawing.Point(957, 296);
            this.mkdDataCad.Mask = "         00/00/0000";
            this.mkdDataCad.Name = "mkdDataCad";
            this.mkdDataCad.Size = new System.Drawing.Size(211, 29);
            this.mkdDataCad.TabIndex = 20;
            this.mkdDataCad.ValidatingType = typeof(System.DateTime);
            // 
            // mkdCnpjCpf
            // 
            this.mkdCnpjCpf.Enabled = false;
            this.mkdCnpjCpf.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCnpjCpf.Location = new System.Drawing.Point(358, 152);
            this.mkdCnpjCpf.Mask = "00,000,000/0000-00";
            this.mkdCnpjCpf.Name = "mkdCnpjCpf";
            this.mkdCnpjCpf.Size = new System.Drawing.Size(263, 31);
            this.mkdCnpjCpf.TabIndex = 19;
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCad.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataCad.Location = new System.Drawing.Point(952, 266);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(221, 27);
            this.lblDataCad.TabIndex = 18;
            this.lblDataCad.Text = "DATA DE CADASTRO";
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.BackColor = System.Drawing.Color.Transparent;
            this.lblCargaHoraria.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaHoraria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCargaHoraria.Location = new System.Drawing.Point(953, 354);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(184, 27);
            this.lblCargaHoraria.TabIndex = 17;
            this.lblCargaHoraria.Text = "CARGA HORÁRIA";
            // 
            // cmbCargaHoraria
            // 
            this.cmbCargaHoraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargaHoraria.Enabled = false;
            this.cmbCargaHoraria.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargaHoraria.FormattingEnabled = true;
            this.cmbCargaHoraria.Items.AddRange(new object[] {
            "04:00",
            "06:00",
            "08:00",
            "10:00",
            "12:00"});
            this.cmbCargaHoraria.Location = new System.Drawing.Point(957, 384);
            this.cmbCargaHoraria.Name = "cmbCargaHoraria";
            this.cmbCargaHoraria.Size = new System.Drawing.Size(160, 31);
            this.cmbCargaHoraria.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(1029, 188);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 27);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "STATUS";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(957, 526);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 50);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(958, 448);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cmbStatus.Location = new System.Drawing.Point(1025, 214);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 31);
            this.cmbStatus.TabIndex = 13;
            // 
            // pnlTelefone
            // 
            this.pnlTelefone.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.telefone;
            this.pnlTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelefone.Controls.Add(this.dgvServico);
            this.pnlTelefone.Controls.Add(this.btnCadastrar);
            this.pnlTelefone.Controls.Add(this.btnAlterar);
            this.pnlTelefone.Controls.Add(this.btnExcluir);
            this.pnlTelefone.Location = new System.Drawing.Point(192, 249);
            this.pnlTelefone.Name = "pnlTelefone";
            this.pnlTelefone.Size = new System.Drawing.Size(678, 348);
            this.pnlTelefone.TabIndex = 12;
            // 
            // dgvServico
            // 
            this.dgvServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Enabled = false;
            this.dgvServico.Location = new System.Drawing.Point(108, 0);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(570, 288);
            this.dgvServico.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(108, 294);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 50);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Location = new System.Drawing.Point(304, 294);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(160, 50);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(503, 294);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 50);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtEmail.Location = new System.Drawing.Point(192, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(827, 31);
            this.txtEmail.TabIndex = 11;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtRazaoSocial.Location = new System.Drawing.Point(640, 150);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(545, 31);
            this.txtRazaoSocial.TabIndex = 10;
            // 
            // txtEmpresaFant
            // 
            this.txtEmpresaFant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresaFant.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresaFant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtEmpresaFant.Location = new System.Drawing.Point(324, 87);
            this.txtEmpresaFant.Name = "txtEmpresaFant";
            this.txtEmpresaFant.Size = new System.Drawing.Size(867, 31);
            this.txtEmpresaFant.TabIndex = 8;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblRazaoSocial.Location = new System.Drawing.Point(641, 122);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(164, 27);
            this.lblRazaoSocial.TabIndex = 1;
            this.lblRazaoSocial.Text = "RAZÃO SOCIAL";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Items.AddRange(new object[] {
            "CNPJ",
            "CPF"});
            this.cmbDocumento.Location = new System.Drawing.Point(192, 154);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(160, 31);
            this.cmbDocumento.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmail.Location = new System.Drawing.Point(197, 188);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 27);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCodigo.Location = new System.Drawing.Point(192, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 31);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodigo.Location = new System.Drawing.Point(197, 57);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(96, 27);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblCnpj.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCnpj.Location = new System.Drawing.Point(367, 118);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(128, 27);
            this.lblCnpj.TabIndex = 4;
            this.lblCnpj.Text = "CNPJ / CPF";
            // 
            // lblEmpresaFant
            // 
            this.lblEmpresaFant.AutoSize = true;
            this.lblEmpresaFant.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresaFant.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaFant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmpresaFant.Location = new System.Drawing.Point(337, 57);
            this.lblEmpresaFant.Name = "lblEmpresaFant";
            this.lblEmpresaFant.Size = new System.Drawing.Size(319, 27);
            this.lblEmpresaFant.TabIndex = 5;
            this.lblEmpresaFant.Text = "NOME FANTASIA DA EMPRESA";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumento.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDocumento.Location = new System.Drawing.Point(197, 122);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(146, 27);
            this.lblDocumento.TabIndex = 6;
            this.lblDocumento.Text = "DOCUMENTO";
            // 
            // pnlBusca
            // 
            this.pnlBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlBusca.Controls.Add(this.lblCadEmpresa);
            this.pnlBusca.Controls.Add(this.btnFechar);
            this.pnlBusca.Location = new System.Drawing.Point(186, 0);
            this.pnlBusca.Name = "pnlBusca";
            this.pnlBusca.Size = new System.Drawing.Size(1014, 54);
            this.pnlBusca.TabIndex = 0;
            // 
            // lblCadEmpresa
            // 
            this.lblCadEmpresa.AutoSize = true;
            this.lblCadEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblCadEmpresa.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblCadEmpresa.Location = new System.Drawing.Point(328, 3);
            this.lblCadEmpresa.Name = "lblCadEmpresa";
            this.lblCadEmpresa.Size = new System.Drawing.Size(354, 38);
            this.lblCadEmpresa.TabIndex = 0;
            this.lblCadEmpresa.Text = "CADASTRAR EMPRESA";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(955, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1487, 740);
            this.Controls.Add(this.pnlEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "07-CadEmpresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadEmpresa_Load);
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            this.pnlTelefone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblEmpresaFant;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlBusca;
        private System.Windows.Forms.Label lblCadEmpresa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtEmpresaFant;
        private System.Windows.Forms.Panel pnlTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.ComboBox cmbCargaHoraria;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.MaskedTextBox mkdDataCad;
        private System.Windows.Forms.MaskedTextBox mkdCnpjCpf;
    }
}