namespace kibelezaTI16Fernanda
{
    partial class frmSobre
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
            this.lblSobre = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.sobre;
            this.pnlRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRelatorio.Controls.Add(this.lblSobre);
            this.pnlRelatorio.Controls.Add(this.btnFechar);
            this.pnlRelatorio.Location = new System.Drawing.Point(57, 89);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(1200, 600);
            this.pnlRelatorio.TabIndex = 2;
            // 
            // lblSobre
            // 
            this.lblSobre.BackColor = System.Drawing.Color.Transparent;
            this.lblSobre.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.ForeColor = System.Drawing.Color.Black;
            this.lblSobre.Location = new System.Drawing.Point(472, 238);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(395, 161);
            this.lblSobre.TabIndex = 2;
            this.lblSobre.Text = "SISTEMA DESENVOLVIMENTO PELA TURMA\r\n\r\nTÉCNICO EM INFORMATICA - TI16 - 2023\r\n\r\nSEN" +
    "AC SÃO MIGUEL PAULISTA\r\n\r\nDESENVOLVERDOR: GATEWAY";
            this.lblSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTI16Fernanda.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1315, 779);
            this.Controls.Add(this.pnlRelatorio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSobre";
            this.Text = "12-Sobre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorio;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblSobre;
    }
}