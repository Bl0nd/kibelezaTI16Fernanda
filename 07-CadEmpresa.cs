using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTI16Fernanda
{
    public partial class frmCadEmpresa : Form
    {
        public frmCadEmpresa()
        {
            InitializeComponent();
        }
        private void CarregarDadosEmpresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresa` WHERE `idEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEmpresa);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeEmpresa = dr.GetString(1);
                    variaveis.cnpjCpfEmpresa = dr.GetString(2);
                    variaveis.razaoSocialEmpresa = dr.GetString(3);
                    variaveis.emailEmpresa = dr.GetString(4);
                    variaveis.statusEmpresa = dr.GetString(5);
                    variaveis.dataCadastroEmpresa = dr.GetDateTime(6);
                    variaveis.horarioAtendEmpresa = DateTime.Parse(dr.GetString(7));

                    txtCodigo.Text = variaveis.codEmpresa.ToString();
                    txtNomeFantasia.Text = variaveis.nomeEmpresa;
                    mkdCnpjCpf.Text = variaveis.cnpjCpfEmpresa;
                    if (mkdCnpjCpf.Text.Length > 15)
                    {
                        cmbDocumento.Text = "CNPJ";
                    }
                    else
                    {
                        cmbDocumento.Text = "CPF";
                    }
                    txtRazaoSocial.Text = variaveis.razaoSocialEmpresa;
                    txtEmail.Text = variaveis.emailEmpresa;
                    cmbStatus.Text = variaveis.statusEmpresa;
                    mkdDataCad.Text = variaveis.dataCadastroEmpresa.ToString("dd/MM/yyyy");
                    cmbCargaHoraria.Text = variaveis.horarioAtendEmpresa.ToString("HH:mm");
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da Empresa. \n\n" + ex);
            }
        }

        private void InserirEmpresa()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `empresa`(`idEmpresa`, `nomeFantasiaEmpresa`, `cnpjCpfEmpresa`, `razaoSocialEmpresa`, `emailEmpresa`, `statusEmpresa`, `dataCadEmpresa`, `horarioAtendEmpresa`) VALUES (DEFAULT,@nomeEmpresa,@cnpjCpf,@razaoSocial,@emailEmpresa,@statusEmpresa,@dataCadEmpresa,@horarioEmpresa);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeEmpresa", variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpf", variaveis.cnpjCpfEmpresa);
                cmd.Parameters.AddWithValue("@razaoSocial", variaveis.razaoSocialEmpresa);
                cmd.Parameters.AddWithValue("@emailEmpresa", variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@statusEmpresa", variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@dataCadEmpresa", variaveis.dataCadastroEmpresa.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horarioEmpresa", variaveis.horarioAtendEmpresa.ToString("HH:mm"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DA EMPRESA REALIZADO COM SUCESSO !", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a Empresa \n\n" + ex);
            }
        }

        private void AlterarEmpresa()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `empresa` SET `nomeFantasiaEmpresa`=@nomeEmpresa, `cnpjCpfEmpresa`=cnpjCpf, `razaoSocialEmpresa`=razaoSocial, `emailEmpresa`=@emailEmpresa, `statusEmpresa`=@statusEmpresa,`horarioAtendEmpresa`=@horarioEmpresa WHERE `idEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeEmpresa", variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpf", variaveis.cnpjCpfEmpresa);
                cmd.Parameters.AddWithValue("@razaoSocial", variaveis.razaoSocialEmpresa);
                cmd.Parameters.AddWithValue("@emailEmpresa", variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@statusEmpresa", variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@horarioEmpresa", variaveis.horarioAtendEmpresa.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DA EMPRESA REALIZADO COM SUCESSO !", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a Empresa \n\n" + ex);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Close();
        }

        private void frmCadEmpresa_Load(object sender, EventArgs e)
        {
            pnlEmpresa.Location = new Point(this.Width / 2 - pnlEmpresa.Width / 2, this.Height / 2 - pnlEmpresa.Height / 2);
            cmbDocumento.Text = "CNPJ";

            if (variaveis.funcao == "ALTERAR")
            {
                CarregarDadosEmpresa();
                lblTitulo.Text = "ALTERAR EMPRESA";
            }

            if (txtCodigo.Text != "")
            {
                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = true;
                cmbDocumento.Enabled = true;
                mkdCnpjCpf.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtEmail.Enabled = true;
                cmbStatus.Enabled = true;
                cmbCargaHoraria.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeFantasia.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome da empresa");
                txtNomeFantasia.Focus();
            }
            else if (mkdCnpjCpf.MaskCompleted == false)
            {
                MessageBox.Show("Preencher completamente o número do documento");
                mkdCnpjCpf.Focus();
            }
            else if (txtRazaoSocial.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher razão social");
                txtRazaoSocial.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email");
                txtEmail.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status");
                cmbStatus.Focus();
            }
            else if (cmbCargaHoraria.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o horário");
                cmbCargaHoraria.Focus();
            }
            else 
            {
                variaveis.nomeEmpresa = txtNomeFantasia.Text;
                variaveis.cnpjCpfEmpresa = mkdCnpjCpf.Text;
                variaveis.razaoSocialEmpresa = txtRazaoSocial.Text;
                variaveis.emailEmpresa = txtEmail.Text;
                variaveis.statusEmpresa = cmbStatus.Text;
                if (variaveis.funcao == "CADASTRAR")
                {
                    InserirEmpresa();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    AlterarEmpresa();
                }
                pnlEmpresa.Enabled = true;
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
            }
        }
    }
}
