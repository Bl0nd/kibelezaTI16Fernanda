namespace kibelezaTI16Fernanda
{
    partial class frmCadCliente
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
            this.pnlCadCliente = new System.Windows.Forms.Panel();
            this.mkdDataCad = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnlFoneCliente = new System.Windows.Forms.Panel();
            this.dgvFoneCliente = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pnlCadCliente.SuspendLayout();
            this.pnlFoneCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneCliente)).BeginInit();
            this.pnlCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadCliente
            // 
            this.pnlCadCliente.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.cliente;
            this.pnlCadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCadCliente.Controls.Add(this.btnFoto);
            this.pnlCadCliente.Controls.Add(this.pctFoto);
            this.pnlCadCliente.Controls.Add(this.lblFoto);
            this.pnlCadCliente.Controls.Add(this.mkdDataCad);
            this.pnlCadCliente.Controls.Add(this.lblDataCad);
            this.pnlCadCliente.Controls.Add(this.lblStatus);
            this.pnlCadCliente.Controls.Add(this.btnSalvar);
            this.pnlCadCliente.Controls.Add(this.btnLimpar);
            this.pnlCadCliente.Controls.Add(this.cmbStatus);
            this.pnlCadCliente.Controls.Add(this.pnlFoneCliente);
            this.pnlCadCliente.Controls.Add(this.txtEmail);
            this.pnlCadCliente.Controls.Add(this.txtSenha);
            this.pnlCadCliente.Controls.Add(this.txtNomeCliente);
            this.pnlCadCliente.Controls.Add(this.lblSenha);
            this.pnlCadCliente.Controls.Add(this.lblEmail);
            this.pnlCadCliente.Controls.Add(this.txtCodigo);
            this.pnlCadCliente.Controls.Add(this.lblCodigo);
            this.pnlCadCliente.Controls.Add(this.lblNomeCliente);
            this.pnlCadCliente.Controls.Add(this.pnlCliente);
            this.pnlCadCliente.Location = new System.Drawing.Point(102, 96);
            this.pnlCadCliente.Name = "pnlCadCliente";
            this.pnlCadCliente.Size = new System.Drawing.Size(1200, 600);
            this.pnlCadCliente.TabIndex = 6;
            // 
            // mkdDataCad
            // 
            this.mkdDataCad.Enabled = false;
            this.mkdDataCad.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdDataCad.Location = new System.Drawing.Point(445, 214);
            this.mkdDataCad.Mask = "         00/00/0000";
            this.mkdDataCad.Name = "mkdDataCad";
            this.mkdDataCad.Size = new System.Drawing.Size(211, 29);
            this.mkdDataCad.TabIndex = 20;
            this.mkdDataCad.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCad.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataCad.Location = new System.Drawing.Point(440, 184);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(221, 27);
            this.lblDataCad.TabIndex = 18;
            this.lblDataCad.Text = "DATA DE CADASTRO";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(197, 184);
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
            this.btnSalvar.Location = new System.Drawing.Point(982, 487);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(203, 50);
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
            this.btnLimpar.Location = new System.Drawing.Point(982, 420);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(203, 50);
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
            this.cmbStatus.Location = new System.Drawing.Point(192, 214);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 31);
            this.cmbStatus.TabIndex = 13;
            // 
            // pnlFoneCliente
            // 
            this.pnlFoneCliente.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.telefone;
            this.pnlFoneCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFoneCliente.Controls.Add(this.dgvFoneCliente);
            this.pnlFoneCliente.Controls.Add(this.btnCadastrar);
            this.pnlFoneCliente.Controls.Add(this.btnAlterar);
            this.pnlFoneCliente.Controls.Add(this.btnExcluir);
            this.pnlFoneCliente.Location = new System.Drawing.Point(192, 249);
            this.pnlFoneCliente.Name = "pnlFoneCliente";
            this.pnlFoneCliente.Size = new System.Drawing.Size(678, 348);
            this.pnlFoneCliente.TabIndex = 12;
            // 
            // dgvFoneCliente
            // 
            this.dgvFoneCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvFoneCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoneCliente.Enabled = false;
            this.dgvFoneCliente.Location = new System.Drawing.Point(108, 0);
            this.dgvFoneCliente.Name = "dgvFoneCliente";
            this.dgvFoneCliente.Size = new System.Drawing.Size(570, 288);
            this.dgvFoneCliente.TabIndex = 5;
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
            this.txtEmail.Location = new System.Drawing.Point(192, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(747, 31);
            this.txtEmail.TabIndex = 11;
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtSenha.Location = new System.Drawing.Point(945, 150);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(240, 31);
            this.txtSenha.TabIndex = 10;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtNomeCliente.Location = new System.Drawing.Point(324, 87);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(867, 31);
            this.txtNomeCliente.TabIndex = 8;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblSenha.Location = new System.Drawing.Point(945, 121);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(81, 27);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "SENHA";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmail.Location = new System.Drawing.Point(197, 120);
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
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(337, 57);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(165, 27);
            this.lblNomeCliente.TabIndex = 5;
            this.lblNomeCliente.Text = "NOME CLIENTE";
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlCliente.Controls.Add(this.lblCliente);
            this.pnlCliente.Controls.Add(this.btnFechar);
            this.pnlCliente.Location = new System.Drawing.Point(186, 0);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(1014, 54);
            this.pnlCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(328, 3);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(336, 38);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CADASTRAR CLIENTE";
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
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblFoto.Location = new System.Drawing.Point(917, 187);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(68, 27);
            this.lblFoto.TabIndex = 21;
            this.lblFoto.Text = "FOTO";
            // 
            // pctFoto
            // 
            this.pctFoto.Image = global::kibelezaTI16Fernanda.Properties.Resources.semimagem;
            this.pctFoto.Location = new System.Drawing.Point(982, 187);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(209, 206);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFoto.TabIndex = 22;
            this.pctFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFoto.Location = new System.Drawing.Point(1157, 361);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(34, 32);
            this.btnFoto.TabIndex = 23;
            this.btnFoto.Text = "+";
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 792);
            this.Controls.Add(this.pnlCadCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadCliente";
            this.Text = "09-CadCliente";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.pnlCadCliente.ResumeLayout(false);
            this.pnlCadCliente.PerformLayout();
            this.pnlFoneCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneCliente)).EndInit();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadCliente;
        private System.Windows.Forms.MaskedTextBox mkdDataCad;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel pnlFoneCliente;
        private System.Windows.Forms.DataGridView dgvFoneCliente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Button btnFoto;
    }
}