﻿namespace kibelezaTI16Fernanda
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLogin.SuspendLayout();
            this.pnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.pnlSenha);
            this.pnlLogin.Controls.Add(this.pnlEmail);
            this.pnlLogin.Controls.Add(this.pctLogo);
            this.pnlLogin.Location = new System.Drawing.Point(276, 101);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(400, 400);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(71, 329);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(258, 36);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pnlSenha
            // 
            this.pnlSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Controls.Add(this.pictureBox1);
            this.pnlSenha.Controls.Add(this.lblSenha);
            this.pnlSenha.Location = new System.Drawing.Point(25, 242);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(350, 60);
            this.pnlSenha.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(54, 22);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(291, 18);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.iconeSenha;
            this.pictureBox1.Image = global::kibelezaTI16Fernanda.Properties.Resources.iconeSenha;
            this.pictureBox1.Location = new System.Drawing.Point(8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblSenha
            // 
            this.lblSenha.BackColor = System.Drawing.Color.White;
            this.lblSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSenha.Location = new System.Drawing.Point(5, 5);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(340, 50);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.pctEmail);
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Location = new System.Drawing.Point(25, 154);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(350, 60);
            this.pnlEmail.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(54, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 18);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // pctEmail
            // 
            this.pctEmail.BackColor = System.Drawing.Color.White;
            this.pctEmail.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.iconeEmail;
            this.pctEmail.Image = global::kibelezaTI16Fernanda.Properties.Resources.iconeEmail;
            this.pctEmail.Location = new System.Drawing.Point(8, 10);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(40, 40);
            this.pctEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEmail.TabIndex = 1;
            this.pctEmail.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEmail.Location = new System.Drawing.Point(5, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(340, 50);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::kibelezaTI16Fernanda.Properties.Resources.logo1;
            this.pctLogo.Location = new System.Drawing.Point(25, 14);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(350, 100);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // pctSair
            // 
            this.pctSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSair.BackColor = System.Drawing.Color.Transparent;
            this.pctSair.Image = global::kibelezaTI16Fernanda.Properties.Resources.sair;
            this.pctSair.Location = new System.Drawing.Point(1116, 469);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(100, 100);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 1;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 578);
            this.Controls.Add(this.pctSair);
            this.Controls.Add(this.pnlLogin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pctEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

