﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTI16Fernanda
{
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            pnlFuncionario.Location = new Point(this.Width / 2 - pnlFuncionario.Width / 2, this.Height / 2 - pnlFuncionario.Height / 2);
            if (txtCodigo.Text != "")
            {
                pnlFoneFuncionario.Enabled = true;
                btnSalvar.Enabled = true;
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbNivel.Enabled = true;
                cmbStatus.Enabled = true;
                cmbCargaHoraria.Enabled = true;
                cmbEmpresa.Enabled = true;
            }
        }
    }
}
