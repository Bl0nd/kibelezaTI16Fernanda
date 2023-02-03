﻿using MySql.Data.MySqlClient;
using System;
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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void CarregarEmpresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM empresacompleta;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar todas as listas de Empresa. \n \n" + ex);
            }
        }

        private void CarregarEmpresaAtiva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM empresaativa;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Empresa. \n \n" + ex);
            }
        }

        private void CarregarEmpresaInativa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM empresainativa;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Empresa Inativa. \n \n" + ex);
            }
        }

        private void CarregarEmpresaNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM empresacompleta WHERE 'NOME FANTASIA' LIKE '%" + variaveis.nomeEmpresa + "%';";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpresa.DataSource = dt;

                dgvEmpresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de Empresa Inativa. \n \n" + ex);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            pnlEmpresa.Location = new Point(this.Width / 2 - pnlEmpresa.Width / 2, this.Height / 2 - pnlEmpresa.Height / 2);
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVA")
            {
                CarregarEmpresaAtiva();
            }
            else if (cmbStatus.Text == "INATIVA")
            {
                CarregarEmpresaInativa();
            }
            else
            {
                CarregarEmpresa();
            }
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeEmpresa = txtEmpresa.Text;

            if(variaveis.nomeEmpresa == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "TODOS";
                CarregarEmpresa();
            }
            else
            {
                cmbStatus.Enabled = false;
                cmbStatus.Text = "TODOS";
                CarregarEmpresaNome();
            }
        }
    }
}
