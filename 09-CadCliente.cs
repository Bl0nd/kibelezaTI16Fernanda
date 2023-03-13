using crypto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
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
            new frmCliente().Show();
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
                string inserir = "INSERT INTO `cliente`(`idCliente`, `nomeCliente`, `emailCliente`, `senhaCliente`, `statusCliente`, `dataCadCliente`, `fotoCliente`) VALUES (DEFAULT,@nomeCliente,@emailCliente,@senhaCliente,@statusCliente,@dataCadCliente,@fotoCliente);";
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
                string alterar = "UPDATE `cliente` SET `nomeCliente`=@nomeCliente,`emailCliente`=@emailCliente,`senhaCliente`=@senhaCliente,`statusCliente`=@statusCliente  WHERE `idCliente`= @codigo;";
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
            string alterar = "UPDATE `cliente` SET `fotoCliente`=@fotoCliente WHERE `idCliente`= @codigo;";
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
                string inserir = "INSERT INTO `fonecliente` (`idFoneCliente`,`numeroCliente`,`operFoneCliente`,`descFoneCliente`,`idCliente`) VALUES (DEFAULT,@numeroFone,@operFone,@descFone,@codCliente);";
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
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR FONE";
            pnlFone.Visible = true;
            pnlFone.Location = new Point(this.Width / 2 - pnlFone.Width / 2, this.Height / 2 - pnlFone.Height / 2);
            pnlCliente.Enabled = false;
            mkdFone.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR FONE";
            pnlFone.Visible = true;

            CarregarFoneCliente();

            pnlFone.Location = new Point(this.Width / 2 - pnlFone.Width / 2, this.Height / 2 - pnlFone.Height / 2);
            pnlCliente.Enabled = false;
            mkdFone.Focus();
        }

        private void btnFecharFone_Click(object sender, EventArgs e)
        {
            pnlCliente.Enabled = true;
            CarregarTelefones();
            pnlFone.Visible = false;
            pnlFone.Location = new Point(this.Width / 2 - pnlFone.Width / 2, this.Height / 2 - pnlFone.Height / 2);
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
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
                btnFoto.Enabled = true;
                btnFoto.Focus();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdFoto = new OpenFileDialog();
                ofdFoto.Multiselect = false;
                ofdFoto.FileName = "";
                ofdFoto.InitialDirectory = @"C:";
                ofdFoto.Title = "SELECIONE UMA FOTO";
                ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg;*.png";
                ofdFoto.CheckFileExists = true; //verificar se o caminho existe
                ofdFoto.CheckPathExists = true; // verificar se o arquivo existe
                ofdFoto.RestoreDirectory = true; //verificar ao diretório inicial

                DialogResult dr = ofdFoto.ShowDialog();
                pctFoto.Image = Image.FromFile(ofdFoto.FileName);

                if (ofdFoto.FileName.Substring(ofdFoto.FileName.Length - 8) == "user.png")
                {
                    variaveis.fotoCliente = "cliente/user.png";
                }
                else
                {
                    variaveis.fotoCliente = "cliente/" + Regex.Replace(txtNomeCliente.Text, @"\s", "").ToLower() + ".png"; //a variavel recebe o nome da foto com o nome da pasta "cliente/nome_foto.png
                }
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        variaveis.atFotoCliente = "S";
                        variaveis.caminhoFotoCliente = ofdFoto.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de segurança - Fale com o Admin \n Mensagem: " + ex + " \n Detalhe: \n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Você não tem permissão \n Detalhe: " + ex);
                    }
                }
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
            catch
            {
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
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
                MessageBox.Show("Preencher o telefone");
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
                variaveis.numeroFoneCliente = mkdFone.Text;
                variaveis.operadoraCliente = cmbOperadora.Text;
                variaveis.descricaoCliente = txtDescricao.Text;

                if (variaveis.funcao == "CADASTRAR FONE")
                {
                    InserirFoneCliente();
                }
                else if (variaveis.funcao == "ALTERAR FONE")
                {
                    AlterarFoneCliente();
                }
            }
            btnLimparFone.PerformClick();
        }

        private void dgvFoneCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = -1;
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codFoneCliente = Convert.ToInt32(dgvFoneCliente[0, variaveis.linhaSelecionada].Value);
                txtCodigo.Text = variaveis.codFoneCliente.ToString();
            }
        }

        private void dgvFoneCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFoneCliente.Sort(dgvFoneCliente.Columns[1], ListSortDirection.Ascending);
            dgvFoneCliente.ClearSelection();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbStatus.SelectedIndex = -1;
            mkdDataCad.Clear();
            pctFoto.Image = Properties.Resources.semimagem;

            txtNomeCliente.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirFoneCliente();
                    CarregarTelefones();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha");
            }
        }
    }
}
