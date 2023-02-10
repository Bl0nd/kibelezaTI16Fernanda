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

        //Telefone
        private void InserirFoneEmpresa()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `foneempresa`(`idFoneEmpresa`,`numeroEmpresa`,`operFoneEmpresa`,`descFoneEmpresa`,`idEmpresa`) VALUES (DEFAULT,@numeroFone,@operFone,@descFone,@codEmpresa);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneEmpresa);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraEmpresa);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoEmpresa);
                cmd.Parameters.AddWithValue("@codEmpresa", variaveis.codEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DA EMPRESA CADASTRADO COM SUCESSO !", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Telefone \n\n" + ex);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Close();
        }

        private void CarregarUltimaEmpresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT MAX(idEmpresa) FROM ´empresa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codEmpresa = dr.GetInt32(0);
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar última Empresa \n\n" + ex);
            }
        }
        private void AlterarFoneEmpresa()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `foneempresa` SET `numeroEmpresa`=@numeroFone,`operFoneEmpresa`=@operFone,`descFoneEmpresa`=@descFone WHERE `idFoneEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneEmpresa);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraEmpresa);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoEmpresa);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFoneEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DA EMPRESA ALTERADO COM SUCESSO !", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Telefone \n\n" + ex);
            }
        }

        private void CarregarTelefones()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM foneempresa WHERE `idEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEmpresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneEmpresa.DataSource = dt;
                dgvFoneEmpresa.Columns[0].Visible = false;
                dgvFoneEmpresa.Columns[1].HeaderText = "NÚMERO";
                dgvFoneEmpresa.Columns[2].HeaderText = "OPERADORA";
                dgvFoneEmpresa.Columns[3].HeaderText = "DESCRIÇÃO";
                dgvFoneEmpresa.Columns[4].Visible = false;

                dgvFoneEmpresa.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar telefones \n\n" + ex);
            }
        }

        private void CarregarFoneEmpresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `foneempre` WHERE `idFoneEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFoneEmpresa);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codFoneEmpresa = dr.GetInt32(0);
                    variaveis.numeroFoneEmpresa = dr.GetString(1);
                    variaveis.operadoraEmpresa = dr.GetString(2);
                    variaveis.descricaoEmpresa = dr.GetString(3);
                    variaveis.codEmpresa = dr.GetInt32(4);
                    txtCodigo.Text = variaveis.codFoneEmpresa.ToString();
                    mkdFone.Text = variaveis.numeroFoneEmpresa;
                    cmbOperadora.Text = variaveis.operadoraEmpresa;
                    txtDescricao.Text = variaveis.descricaoEmpresa;
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Telefone \n\n" + ex);
            }
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
                    CarregarUltimaEmpresa();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR FONE";
            pnlFone.Visible = true;
            pnlFone.Location = new Point(this.Width / 2 - pnlFone.Width / 2, this.Height / 2 - pnlFone.Height / 2);
            pnlEmpresa.Enabled = false;
            mkdFone.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR FONE";
            pnlFone.Visible = true;

            CarregarFoneEmpresa();

            pnlFone.Visible = true;
            pnlFone.Location = new Point(this.Width / 2 - pnlFone.Width / 2, this.Height / 2 - pnlFone.Height / 2);
            pnlEmpresa.Enabled = false;
            mkdFone.Focus();
        }

        private void mkdFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbOperadora.Enabled = true;
                cmbOperadora.Focus();
            }
        }

        private void cmbOperadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvarFone.Enabled = true;
                btnSalvarFone.Focus();
            }
        }

        private void btnSalvarFone_Click(object sender, EventArgs e)
        {
            if (mkdFone.MaskCompleted == false)
            {
                MessageBox.Show("Preenche o telefone");
                mkdFone.Focus();
            }
            else if (cmbOperadora.Text == "")
            {
                MessageBox.Show("Preencher a operadora");
                cmbOperadora.Focus();
            }
            else if (txtDescricao.Text == "")
            {
                MessageBox.Show("Preencher a descrição");
                txtDescricao.Focus();
            }
            else
            {
                variaveis.numeroFoneEmpresa = mkdFone.Text;
                variaveis.operadoraEmpresa = cmbOperadora.Text;
                variaveis.descricaoEmpresa = txtDescricao.Text;
                 if (variaveis.funcao == "CADASTRAR FONE")
                { 
                InserirFoneEmpresa();
                }
                 else if (variaveis.funcao == "ALTERAR FONE")
                {
                    AlterarFoneEmpresa();
                }
            }
            btnLimparFone.PerformClick();
        }

        private void btnLimparFone_Click(object sender, EventArgs e)
        {
            mkdFone.Text = String.Empty;
            cmbOperadora.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            cmbOperadora.Enabled = false;
            txtDescricao.Enabled = false;
            btnSalvarFone.Enabled = false;
            mkdFone.Focus();
        }

        private void btnFecharFone_Click_1(object sender, EventArgs e)
        {
            pnlEmpresa.Enabled = true;
            CarregarTelefones();
            pnlFone.Visible = false;
            pnlFone.Location = new Point(this.Width / 2 - pnlFone.Width / 2, this.Height / 2 - pnlFone.Height / 2);
        }

        private void cmbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocumento.Text == "CNPJ")
            {
                mkdCnpjCpf.Mask = "00,000,000/0000-00";
            }
            else if (cmbDocumento.Text == "CPF")
            {
                mkdCnpjCpf.Mask = "000,000,000-00";
            }
        }

        private void dgvFoneEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = -1;
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codFoneEmpresa = Convert.ToInt32(dgvFoneEmpresa[0, variaveis.linhaSelecionada].Value);
            }
        }
    }
}
