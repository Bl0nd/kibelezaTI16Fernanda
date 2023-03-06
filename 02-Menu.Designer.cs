namespace kibelezaTI16Fernanda
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAguardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.pctReserva = new System.Windows.Forms.PictureBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.pctRelatorio = new System.Windows.Forms.PictureBox();
            this.pctServico = new System.Windows.Forms.PictureBox();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.pctEmpresa = new System.Windows.Forms.PictureBox();
            this.pctCliente = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.pnlMenu.Controls.Add(this.pnlReserva);
            this.pnlMenu.Controls.Add(this.lblAjuda);
            this.pnlMenu.Controls.Add(this.lblSobre);
            this.pnlMenu.Controls.Add(this.pctRelatorio);
            this.pnlMenu.Controls.Add(this.pctServico);
            this.pnlMenu.Controls.Add(this.pctFuncionario);
            this.pnlMenu.Controls.Add(this.pctEmpresa);
            this.pnlMenu.Controls.Add(this.pctCliente);
            this.pnlMenu.Controls.Add(this.lblMensagem);
            this.pnlMenu.Controls.Add(this.lblHora);
            this.pnlMenu.Controls.Add(this.lblData);
            this.pnlMenu.Controls.Add(this.pctLogo);
            this.pnlMenu.Location = new System.Drawing.Point(54, 80);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1200, 600);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlReserva
            // 
            this.pnlReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlReserva.Controls.Add(this.dgvReserva);
            this.pnlReserva.Controls.Add(this.btnAgendar);
            this.pnlReserva.Controls.Add(this.btnFinalizar);
            this.pnlReserva.Controls.Add(this.btnEditar);
            this.pnlReserva.Controls.Add(this.btnAguardar);
            this.pnlReserva.Controls.Add(this.btnCancelar);
            this.pnlReserva.Controls.Add(this.btnAprovar);
            this.pnlReserva.Controls.Add(this.pctReserva);
            this.pnlReserva.Controls.Add(this.cmbStatus);
            this.pnlReserva.Controls.Add(this.lblStatus);
            this.pnlReserva.Controls.Add(this.txtCliente);
            this.pnlReserva.Controls.Add(this.lblCliente);
            this.pnlReserva.Location = new System.Drawing.Point(405, 5);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(790, 405);
            this.pnlReserva.TabIndex = 11;
            // 
            // dgvReserva
            // 
            this.dgvReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(8, 103);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(779, 299);
            this.dgvReserva.TabIndex = 23;
            this.dgvReserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserva_CellClick);
            this.dgvReserva.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReserva_ColumnHeaderMouseClick);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnAgendar.FlatAppearance.BorderSize = 0;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(646, 43);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(127, 50);
            this.btnAgendar.TabIndex = 22;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(409, 53);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(115, 40);
            this.btnFinalizar.TabIndex = 21;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(525, 53);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 40);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAguardar
            // 
            this.btnAguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnAguardar.FlatAppearance.BorderSize = 0;
            this.btnAguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAguardar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAguardar.ForeColor = System.Drawing.Color.White;
            this.btnAguardar.Location = new System.Drawing.Point(288, 53);
            this.btnAguardar.Name = "btnAguardar";
            this.btnAguardar.Size = new System.Drawing.Size(120, 40);
            this.btnAguardar.TabIndex = 19;
            this.btnAguardar.Text = "AGUARDAR";
            this.btnAguardar.UseVisualStyleBackColor = false;
            this.btnAguardar.Click += new System.EventHandler(this.btnAguardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(172, 53);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 40);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnAprovar.FlatAppearance.BorderSize = 0;
            this.btnAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.ForeColor = System.Drawing.Color.White;
            this.btnAprovar.Location = new System.Drawing.Point(56, 53);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(115, 40);
            this.btnAprovar.TabIndex = 17;
            this.btnAprovar.Text = "APROVAR";
            this.btnAprovar.UseVisualStyleBackColor = false;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // pctReserva
            // 
            this.pctReserva.Image = global::kibelezaTI16Fernanda.Properties.Resources.data;
            this.pctReserva.Location = new System.Drawing.Point(3, 47);
            this.pctReserva.Name = "pctReserva";
            this.pctReserva.Size = new System.Drawing.Size(50, 50);
            this.pctReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctReserva.TabIndex = 16;
            this.pctReserva.TabStop = false;
            this.pctReserva.Click += new System.EventHandler(this.pctReserva_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "TODAS",
            "APROVADA",
            "CANCELADA",
            "AGUARDANDO",
            "FINALIZADA"});
            this.cmbStatus.Location = new System.Drawing.Point(607, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(162, 31);
            this.cmbStatus.TabIndex = 15;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(511, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 27);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "STATUS";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(106, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(387, 31);
            this.txtCliente.TabIndex = 13;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(3, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(97, 27);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "CLIENTE";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAjuda
            // 
            this.lblAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblAjuda.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.ForeColor = System.Drawing.Color.White;
            this.lblAjuda.Location = new System.Drawing.Point(1005, 515);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(190, 80);
            this.lblAjuda.TabIndex = 10;
            this.lblAjuda.Text = "AJUDA";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSobre
            // 
            this.lblSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblSobre.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.ForeColor = System.Drawing.Color.White;
            this.lblSobre.Location = new System.Drawing.Point(1005, 415);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(190, 80);
            this.lblSobre.TabIndex = 9;
            this.lblSobre.Text = "SOBRE";
            this.lblSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSobre.Click += new System.EventHandler(this.lblSobre_Click);
            // 
            // pctRelatorio
            // 
            this.pctRelatorio.Image = global::kibelezaTI16Fernanda.Properties.Resources.btnRelatorio;
            this.pctRelatorio.Location = new System.Drawing.Point(805, 415);
            this.pctRelatorio.Name = "pctRelatorio";
            this.pctRelatorio.Size = new System.Drawing.Size(180, 180);
            this.pctRelatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRelatorio.TabIndex = 8;
            this.pctRelatorio.TabStop = false;
            this.pctRelatorio.Click += new System.EventHandler(this.pctRelatorio_Click);
            // 
            // pctServico
            // 
            this.pctServico.Image = global::kibelezaTI16Fernanda.Properties.Resources.btnServico;
            this.pctServico.Location = new System.Drawing.Point(605, 415);
            this.pctServico.Name = "pctServico";
            this.pctServico.Size = new System.Drawing.Size(180, 180);
            this.pctServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctServico.TabIndex = 7;
            this.pctServico.TabStop = false;
            this.pctServico.Click += new System.EventHandler(this.pctServico_Click);
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.Image = global::kibelezaTI16Fernanda.Properties.Resources.btnFuncionario;
            this.pctFuncionario.Location = new System.Drawing.Point(205, 415);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(180, 180);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFuncionario.TabIndex = 6;
            this.pctFuncionario.TabStop = false;
            this.pctFuncionario.Click += new System.EventHandler(this.pctFuncionario_Click);
            // 
            // pctEmpresa
            // 
            this.pctEmpresa.Image = global::kibelezaTI16Fernanda.Properties.Resources.btnEmpresa;
            this.pctEmpresa.Location = new System.Drawing.Point(405, 415);
            this.pctEmpresa.Name = "pctEmpresa";
            this.pctEmpresa.Size = new System.Drawing.Size(180, 180);
            this.pctEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEmpresa.TabIndex = 5;
            this.pctEmpresa.TabStop = false;
            this.pctEmpresa.Click += new System.EventHandler(this.pctEmpresa_Click);
            // 
            // pctCliente
            // 
            this.pctCliente.Image = global::kibelezaTI16Fernanda.Properties.Resources.btnCliente;
            this.pctCliente.Location = new System.Drawing.Point(5, 415);
            this.pctCliente.Name = "pctCliente";
            this.pctCliente.Size = new System.Drawing.Size(180, 180);
            this.pctCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCliente.TabIndex = 4;
            this.pctCliente.TabStop = false;
            this.pctCliente.Click += new System.EventHandler(this.pctCliente_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblMensagem.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(5, 330);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(380, 80);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "Boa Tarde Gateway !";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblHora.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(5, 245);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(380, 80);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblData.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(5, 160);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(380, 80);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "00/00/0000";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctLogo
            // 
            this.pctLogo.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.logoKiBeleza;
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogo.Location = new System.Drawing.Point(5, 5);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(380, 160);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // pctSair
            // 
            this.pctSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSair.BackColor = System.Drawing.Color.Transparent;
            this.pctSair.Image = global::kibelezaTI16Fernanda.Properties.Resources.sair;
            this.pctSair.Location = new System.Drawing.Point(1375, 697);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(100, 100);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 2;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 809);
            this.Controls.Add(this.pctSair);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlReserva.ResumeLayout(false);
            this.pnlReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pctCliente;
        private System.Windows.Forms.PictureBox pctRelatorio;
        private System.Windows.Forms.PictureBox pctServico;
        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.PictureBox pctEmpresa;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.PictureBox pctReserva;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAguardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}