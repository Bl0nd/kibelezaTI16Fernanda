using MySql.Data.MySqlClient;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeFuncionario.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome do funcionario");
                txtNomeFuncionario.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email");
                txtEmail.Focus();
            }
            else if (txtSenha.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a senha");
                txtSenha.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status");
                cmbStatus.Focus();
            }
            else
            {
                variaveis.nomeFuncionario = txtNomeFuncionario.Text;
                variaveis.emailFuncionario = txtEmail.Text;
                variaveis.senhaFuncionario = txtSenha.Text;
                variaveis.statusFuncionario = cmbStatus.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    mkdDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    variaveis.dataCadastroCliente = DateTime.Parse(mkdDataCad.Text);
                    InserirFuncionario();
                    CarregarUltimoFuncionario();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    AlterarFuncionario();

                }
                pnlFoneFuncionario.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void txtNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Enabled = true;
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Enabled = true;
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbNivel.Enabled = true;
                cmbNivel.Focus();
            }
        }

        private void cmbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFuncionario.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbStatus.SelectedIndex = -1;
            mkdDataCad.Clear();
            cmbNivel.SelectedIndex = -1;

            txtNomeFuncionario.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    CarregarTelefones();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha");
            }
        }

        private void CarregarDadosFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionario` WHERE `idFuncionario`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeFuncionario = dr.GetString(1);
                    variaveis.emailFuncionario = dr.GetString(2);
                    variaveis.senhaFuncionario = dr.GetString(3);
                    variaveis.statusFuncionario = dr.GetString(4);
                    variaveis.nivelFuncionario = dr.GetString(5);
                    variaveis.dataCadFuncionario = dr.GetDateTime(6);

                    txtCodigo.Text = variaveis.codCliente.ToString();
                    txtNomeFuncionario.Text = variaveis.nomeCliente;
                    txtEmail.Text = variaveis.emailCliente;
                    txtSenha.Text = variaveis.senhaCliente;
                    cmbStatus.Text = variaveis.statusCliente;
                    mkdDataCad.Text = variaveis.dataCadFuncionario.ToString("dd/MM/yyyy");
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Funcionario \n\n" + ex);
            }
        }

        private void InserirFuncionario()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `funcionario`(`idFuncionario`, `nomeFuncionario`, `emailFuncionario`, `senhaFuncionario`, `nivelFuncionario`, `statusFuncionario`, `dataCadFuncionario`) VALUES (DEFAULT,@nomeFuncionario,@emailFuncionario,@senhaFuncionario,@nivelFuncionario,@statusFuncionario,@dataCadFuncionario);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeFuncionario", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@emailFuncionario", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senhaFuncionario", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@statusFuncionario", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@nivelFuncionario", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@dataCadFuncionario", variaveis.dataCadFuncionario.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@fotoCliente", variaveis.fotoCliente);
                cmd.ExecuteNonQuery();

                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO !", "CADASTRO");
                banco.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Cliente \n\n" + ex);
            }
        }

        private void AlterarFuncionario()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `funcionario` SET `nomeFuncionario`=@nomeFuncionario,`emailFuncionario`=@emailFuncionario,`senhaFuncionario`=@senhaFuncionario,`nivelFuncionario`=@nivelFuncionario,`statusFuncionario`=@statusFuncionario,`dataCadFuncionario`=@dataCadFuncionario WHERE `idFuncionario`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeFuncionario", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@emailFuncionario", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senhaFuncionario", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@statusFuncionario", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@nivelFuncionario", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO REALIZADO COM SUCESSO !", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Funcionario \n\n" + ex);
            }
        }

        private void CarregarUltimoFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT MAX (idFuncionario) FROM `funcionario`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codFuncionario = dr.GetInt32(0);
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar ultimo Funcionario \n\n" + ex);
            }
        }

        private void CarregarTelefones()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM fonefuncionario WHERE `idFuncionario`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEmpresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneFuncionario.DataSource = dt;
                dgvFoneFuncionario.Columns[0].Visible = false;
                dgvFoneFuncionario.Columns[1].HeaderText = "NÚMERO";
                dgvFoneFuncionario.Columns[2].HeaderText = "OPERADORA";
                dgvFoneFuncionario.Columns[3].HeaderText = "DESCRIÇÃO";
                dgvFoneFuncionario.Columns[4].Visible = false;

                dgvFoneFuncionario.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar telefones \n\n" + ex);
            }
        }

    }
}
