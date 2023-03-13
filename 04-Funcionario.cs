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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmCadFuncionario().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frmCadCliente().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir o cliente ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirFuncionario();
                    CarregarFuncionario();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha");
            }
        }

        private void dgvFuncionario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFuncionario.Sort(dgvFuncionario.Columns[1], ListSortDirection.Ascending);
            dgvFuncionario.ClearSelection();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            pnlFuncionario.Location = new Point(this.Width / 2 - pnlFuncionario.Width / 2, this.Height / 2 - pnlFuncionario.Height / 2);
            CarregarFuncionario();
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (txtFuncionario.Text == "")
            {
                cmbStatus.Enabled = true;
                CarregarFuncionario();
            }
            else
            {
                cmbStatus.Text = "TODOS";
                cmbStatus.Enabled = false;
                variaveis.nomeFuncionario = txtFuncionario.Text;
                CarregarFuncionarioNome();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarFuncionarioAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarFuncionarioInativo();
            }
            else
            {
                CarregarFuncionario();
            }
        }

        private void CarregarFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioecompleto`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Funcionario \n\n" + erro.Message);
            }
        }

        private void CarregarFuncionarioAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.ClearSelection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Funcionario \n\n" + erro.Message);
            }
        }

        private void CarregarFuncionarioInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioinativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.ClearSelection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente \n\n" + erro.Message);
            }
        }

        private void CarregarFuncionarioNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionariocompleto` WHERE ´NOME Funcionario` LIKE `%" + variaveis.nomeFuncionario + "%´";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.ClearSelection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Funcionario \n\n" + erro.Message);
            }
        }

        private void ExcluirFuncionario()
        {
            try
            {
                banco.Conectar();
                string excluir = "DELETE FROM `funcionario` WHERE `idFuncionario`=@codigo";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
                dgvFuncionario.ClearSelection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir o Funcionario \n\n" + erro.Message);
            }
        }
    }
}
