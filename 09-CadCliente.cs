using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTI16Fernanda
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmCadCliente().Show();
            Close();
        }

        private void CarregarDadosCiente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `cliente` WHERE `idCliente`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeCliente = dr.GetString(1);
                    variaveis.emailCliente = dr.GetString(2);
                    variaveis.senhaCliente = dr.GetString(3);
                    variaveis.statusCliente = dr.GetString(4);
                    variaveis.dataCadastroCliente = dr.GetDateTime(5);
                    variaveis.fotoCliente = dr.GetString(6);
                    variaveis.fotoCliente = variaveis.fotoCliente.Remove(0, 8);

                    txtCodigo.Text = variaveis.codCliente.ToString();
                    txtNomeCliente.Text = variaveis.nomeCliente;
                    txtEmail.Text = variaveis.emailCliente;
                    txtSenha.Text = variaveis.senhaCliente;
                    cmbStatus.Text = variaveis.statusCliente;
                    mkdDataCad.Text = variaveis.dataCadastroCliente.ToString("dd/MM/yyyy");
                    pctFoto.Image = ByteToImage(GetImgToByte(variaveis.enderecoServidorFtp + "cliente/" + variaveis.fotoCliente));
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Cliente \n\n" + ex);
            }
        }
        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            pnlCadCliente.Location = new Point(this.Width / 2 - pnlCadCliente.Width / 2, this.Height / 2 - pnlCadCliente.Height / 2);
            variaveis.atFotoCliente = "N";

            if (variaveis.funcao == "ALTERAR")
            {
                CarregarDadosCiente();
                CarregarTelefones();
                lblTitulo.Text = "ALTERAR CLIENTE";
            }

            if (txtCodigo.Text != "")
            {
                pnlFoneCliente.Enabled = true;
                btnSalvar.Enabled = true;
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbStatus.Enabled = true;
                btnFoto.Enabled = true;
            }
        }

        //VALIDAÇÃO FTP
        private bool ValidarFTP()
        {
            if (string.IsNullOrEmpty(variaveis.enderecoServidorFtp) || string.IsNullOrEmpty(variaveis.usuarioFtp) || string.IsNullOrEmpty(variaveis.senhaFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //CONVERTER A IMAGEM EM BYTE
        public byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpCliente = new WebClient();
            ftpCliente.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
            byte[] imageToByte = ftpCliente.DownloadData(caminhoArquivoFtp);
            return imageToByte;
        }

        //CONVERTER A IMAGEM DE BYTE PARA IMG
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void InserirCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `cliente`(`idCliente`,`nomeCliente`,`emailCliente`,`senhaCliente`,`statusCliente`,`dataCadCliente`,`fotoCliente`) VALUES (DEFAULT,@nomeCliente,@emailCliente,@senhaCliente,@statusCliente,@dataCadCliente,@fotoCliente);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeCliente", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@dataCadCliente", variaveis.dataCadastroCliente.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@fotoCliente", variaveis.fotoCliente);
                cmd.ExecuteNonQuery();

                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO !", "CADASTRO");
                banco.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoCliente))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "cliente/" + Path.GetFileName(variaveis.fotoCliente);

                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoCliente, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Foto não selecionada ou foto já existente no servidor \n\n" + ex, "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Cliente \n\n" + ex);
            }
        }

        private void AlterarCliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `cliente` SET `nomeCliente`=@nomeCliente,`emailCliente`=@emailCliente,`senhaCliente`=@senhaCliente,´statusCliente`=@statusCliente WHERE `idCliente`= @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeCliente", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO CLIENTE REALIZADO COM SUCESSO !", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Cliente \n\n" + ex);
            }
        }
        private void AlterarFotoCliente()
        {
            banco.Conectar();
            string alterar = "UPDATE `cliente` SET ´fotoCliente`=@fotoCliente WHERE `idCliente`= @codigo;";
            MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
            cmd.Parameters.AddWithValue("@fotoCliente", variaveis.fotoCliente);
            cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
            cmd.ExecuteNonQuery();
            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(variaveis.fotoCliente))
                {
                    string urlEnviarArquivo = variaveis.enderecoServidorFtp + "cliente/" + Path.GetFileName(variaveis.fotoCliente);
                    try
                    {
                        ftp.EnviarArquivoFtp(variaveis.caminhoFotoCliente, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Foto não selecionada ou foto ja existente no servidor \n\n" + ex, "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void InserirFoneCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `fonecliente`(`idFoneCliente`,`numeroCliente`,`operFoneCliente`,`descFoneCliente`,`idCliente`) VALUES (DEFAULT,@numeroFone,@operFone,@descFone,@codCliente);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneCliente);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operFoneCliente);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@codCliente", variaveis.codCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO CLIENTE CADASTRADO COM SUCESSO !", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Telefone \n\n" + ex);
            }
        }

        private void AlterarFoneCliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `fonecliente` SET `numeroCliente`=@numeroFone,`operFoneCliente`=@operFone,`descFoneCliente`=@descFone WHERE `idFoneCliente`= @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneCliente);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraCliente);
                cmd.Parameters.AddWithValue("@descCliente", variaveis.descricaoCliente);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFoneCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO CLIENTE ALTERADO COM SUCESSO !", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Telefone \n\n" + ex);
            }
        }
        private void CarregarUltimoCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT MAX (idCliente) FROM `cliente`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codCliente = dr.GetInt32(0);
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar ultimo cliente \n\n" + ex);
            }
        }

        private void CarregarTelefones()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM fonecliente WHERE `idCliente`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEmpresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneCliente.DataSource = dt;
                dgvFoneCliente.Columns[0].Visible = false;
                dgvFoneCliente.Columns[1].HeaderText = "NÚMERO";
                dgvFoneCliente.Columns[2].HeaderText = "OPERADORA";
                dgvFoneCliente.Columns[3].HeaderText = "DESCRIÇÃO";
                dgvFoneCliente.Columns[4].Visible = false;

                dgvFoneCliente.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar telefones \n\n" + ex);
            }
        }

        private void CarregarFoneCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `fonecliente` WHERE `idFoneCliente`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFoneCliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codFoneCliente = dr.GetInt32(0);
                    variaveis.numeroFoneCliente = dr.GetString(1);
                    variaveis.operadoraCliente = dr.GetString(2);
                    variaveis.descricaoCliente = dr.GetString(3);
                    variaveis.codCliente = dr.GetInt32(4);
                    txtCodigo.Text = variaveis.codFoneCliente.ToString();
                    mkdFone.Text = variaveis.numeroFoneCliente;
                    cmbOperadora.Text = variaveis.operadoraCliente;
                    txtDescricao.Text = variaveis.descricaoCliente;
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Telefone \n\n" + ex);
            }
        }

        private void ExcluirFoneCliente()
        {
            try
            {
                banco.Conectar();
                string excluir = "DELETE FROM `fonecliente` WHERE `idFoneCliente`=@codFone";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codFone", variaveis.codFoneCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFoneCliente.DataSource = dt;
                dgvFoneCliente.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir o Telefone do Cliente \n\n" + erro.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome do cliente");
                txtNomeCliente.Focus();
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
                variaveis.nomeCliente = txtNomeCliente.Text;
                variaveis.emailCliente = txtEmail.Text;
                variaveis.senhaCliente = txtSenha.Text;
                variaveis.statusCliente = cmbStatus.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    mkdDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    variaveis.dataCadastroCliente = DateTime.Parse(mkdDataCad.Text);
                    InserirCliente();
                    CarregarUltimoCliente();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    AlterarCliente();
                    if (variaveis.atFotoCliente == "S")
                    {
                        AlterarFotoCliente();
                    }
                }
                pnlFoneCliente.Enabled = true;
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
            }
        }
    }
}
