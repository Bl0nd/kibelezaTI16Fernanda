namespace kibelezaTI16Fernanda
{
    partial class frmRelatorio
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
            this.pnlRelatorio = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.radTelefone = new System.Windows.Forms.RadioButton();
            this.radInativo = new System.Windows.Forms.RadioButton();
            this.radAtivo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlTabela = new System.Windows.Forms.Panel();
            this.radEmpresa = new System.Windows.Forms.RadioButton();
            this.radFuncionario = new System.Windows.Forms.RadioButton();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTabela = new System.Windows.Forms.Label();
            this.pnlRelatorio.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.pnlTabela.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.relatorio;
            this.pnlRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRelatorio.Controls.Add(this.btnAtualizar);
            this.pnlRelatorio.Controls.Add(this.pnlFiltro);
            this.pnlRelatorio.Controls.Add(this.dgvRelatorio);
            this.pnlRelatorio.Controls.Add(this.btnSalvar);
            this.pnlRelatorio.Controls.Add(this.btnFechar);
            this.pnlRelatorio.Controls.Add(this.pnlTabela);
            this.pnlRelatorio.Location = new System.Drawing.Point(99, 110);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(1200, 600);
            this.pnlRelatorio.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.atualizar;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(1091, 14);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(45, 49);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlFiltro.Controls.Add(this.radTelefone);
            this.pnlFiltro.Controls.Add(this.radInativo);
            this.pnlFiltro.Controls.Add(this.radAtivo);
            this.pnlFiltro.Controls.Add(this.panel2);
            this.pnlFiltro.Location = new System.Drawing.Point(216, 90);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(869, 70);
            this.pnlFiltro.TabIndex = 1;
            // 
            // radTelefone
            // 
            this.radTelefone.AutoSize = true;
            this.radTelefone.BackColor = System.Drawing.Color.Transparent;
            this.radTelefone.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTelefone.ForeColor = System.Drawing.Color.White;
            this.radTelefone.Location = new System.Drawing.Point(300, 31);
            this.radTelefone.Name = "radTelefone";
            this.radTelefone.Size = new System.Drawing.Size(120, 27);
            this.radTelefone.TabIndex = 5;
            this.radTelefone.TabStop = true;
            this.radTelefone.Text = "TELEFONE";
            this.radTelefone.UseVisualStyleBackColor = false;
            // 
            // radInativo
            // 
            this.radInativo.AutoSize = true;
            this.radInativo.BackColor = System.Drawing.Color.Transparent;
            this.radInativo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInativo.ForeColor = System.Drawing.Color.White;
            this.radInativo.Location = new System.Drawing.Point(151, 34);
            this.radInativo.Name = "radInativo";
            this.radInativo.Size = new System.Drawing.Size(102, 27);
            this.radInativo.TabIndex = 6;
            this.radInativo.TabStop = true;
            this.radInativo.Text = "INATIVO";
            this.radInativo.UseVisualStyleBackColor = false;
            // 
            // radAtivo
            // 
            this.radAtivo.AutoSize = true;
            this.radAtivo.BackColor = System.Drawing.Color.Transparent;
            this.radAtivo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAtivo.ForeColor = System.Drawing.Color.White;
            this.radAtivo.Location = new System.Drawing.Point(3, 34);
            this.radAtivo.Name = "radAtivo";
            this.radAtivo.Size = new System.Drawing.Size(82, 27);
            this.radAtivo.TabIndex = 7;
            this.radAtivo.TabStop = true;
            this.radAtivo.Text = "ATIVO";
            this.radAtivo.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.lblFiltro);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 28);
            this.panel2.TabIndex = 2;
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.White;
            this.lblFiltro.Location = new System.Drawing.Point(408, 1);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(86, 27);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "FILTRO";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(216, 166);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(979, 434);
            this.dgvRelatorio.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(1091, 100);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 40);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1148, 16);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 44);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlTabela
            // 
            this.pnlTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlTabela.Controls.Add(this.radEmpresa);
            this.pnlTabela.Controls.Add(this.radFuncionario);
            this.pnlTabela.Controls.Add(this.radCliente);
            this.pnlTabela.Controls.Add(this.panel1);
            this.pnlTabela.Location = new System.Drawing.Point(216, 10);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(869, 74);
            this.pnlTabela.TabIndex = 0;
            // 
            // radEmpresa
            // 
            this.radEmpresa.AutoSize = true;
            this.radEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.radEmpresa.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEmpresa.ForeColor = System.Drawing.Color.White;
            this.radEmpresa.Location = new System.Drawing.Point(151, 34);
            this.radEmpresa.Name = "radEmpresa";
            this.radEmpresa.Size = new System.Drawing.Size(114, 27);
            this.radEmpresa.TabIndex = 4;
            this.radEmpresa.TabStop = true;
            this.radEmpresa.Text = "EMPRESA";
            this.radEmpresa.UseVisualStyleBackColor = false;
            // 
            // radFuncionario
            // 
            this.radFuncionario.AutoSize = true;
            this.radFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.radFuncionario.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFuncionario.ForeColor = System.Drawing.Color.White;
            this.radFuncionario.Location = new System.Drawing.Point(300, 34);
            this.radFuncionario.Name = "radFuncionario";
            this.radFuncionario.Size = new System.Drawing.Size(156, 27);
            this.radFuncionario.TabIndex = 3;
            this.radFuncionario.TabStop = true;
            this.radFuncionario.Text = "FUNCIONARIO";
            this.radFuncionario.UseVisualStyleBackColor = false;
            // 
            // radCliente
            // 
            this.radCliente.AutoSize = true;
            this.radCliente.BackColor = System.Drawing.Color.Transparent;
            this.radCliente.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCliente.ForeColor = System.Drawing.Color.White;
            this.radCliente.Location = new System.Drawing.Point(3, 34);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(105, 27);
            this.radCliente.TabIndex = 2;
            this.radCliente.TabStop = true;
            this.radCliente.Text = "CLIENTE";
            this.radCliente.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.lblTabela);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 28);
            this.panel1.TabIndex = 1;
            // 
            // lblTabela
            // 
            this.lblTabela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTabela.AutoSize = true;
            this.lblTabela.BackColor = System.Drawing.Color.Transparent;
            this.lblTabela.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.ForeColor = System.Drawing.Color.White;
            this.lblTabela.Location = new System.Drawing.Point(428, 1);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(90, 27);
            this.lblTabela.TabIndex = 0;
            this.lblTabela.Text = "TABELA";
            this.lblTabela.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 821);
            this.Controls.Add(this.pnlRelatorio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "11-Relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlRelatorio.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.pnlTabela.ResumeLayout(false);
            this.pnlTabela.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorio;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlTabela;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.RadioButton radTelefone;
        private System.Windows.Forms.RadioButton radInativo;
        private System.Windows.Forms.RadioButton radAtivo;
        private System.Windows.Forms.RadioButton radEmpresa;
        private System.Windows.Forms.RadioButton radFuncionario;
    }
}