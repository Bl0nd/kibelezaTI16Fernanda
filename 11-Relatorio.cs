using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTI16Fernanda
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarClienteTelefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clientetelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente \n\n" + erro.Message);
            }
        }
        private void CarregarClienteAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clienteativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente \n\n" + erro.Message);
            }
        }

        private void CarregarClienteInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clienteinativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Cliente \n\n" + erro.Message);
            }
        }

        private void CarregarEmpresaTelefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresatelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Empresa \n\n" + erro.Message);
            }
        }

        private void CarregarEmpresaAtiva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresaativa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Empresa \n\n" + erro.Message);
            }
        }
        private void CarregarEmpresaInativa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresainativa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Empresa \n\n" + erro.Message);
            }
        }
        private void CarregarFuncionarioTelefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionariotelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
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
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
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
                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o Funcionario \n\n" + erro.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(radCliente.Checked == true && radAtivo.Checked ==true)
            {
                CarregarClienteAtivo();
                variaveis.relatorio = "Cliente Ativo";
            }
            else if (radCliente.Checked == true && radInativo.Checked ==true)
            {
                CarregarClienteInativo();
                variaveis.relatorio = "Cliente Inativo";
            }
            else if (radCliente.Checked == true && radTelefone.Checked ==true)
            {
                CarregarClienteTelefone();
                variaveis.relatorio = "Cliente Telefone";
            }
            else if (radEmpresa.Checked == true && radAtivo.Checked == true)
            {
                CarregarEmpresaAtiva();
                variaveis.relatorio = "Empresa Ativa";
            }
            else if (radEmpresa.Checked == true && radInativo.Checked == true)
            {
                CarregarEmpresaInativa();
                variaveis.relatorio = "Empresa Inativa";
            }
            else if (radEmpresa.Checked == true && radTelefone.Checked == true)
            {
                CarregarEmpresaTelefone();
                variaveis.relatorio = "Empresa Telefone";
            }
            else if (radFuncionario.Checked == true && radAtivo.Checked == true)
            {
                CarregarFuncionarioAtivo();
                variaveis.relatorio = "Funcionario Ativo";
            }
            else if (radFuncionario.Checked == true && radInativo.Checked == true)
            {
                CarregarFuncionarioInativo();
                variaveis.relatorio = "Funcionario Inativo";
            }
            else if (radFuncionario.Checked == true && radTelefone.Checked == true)
            {
                CarregarFuncionarioTelefone();
                variaveis.relatorio = "Funcionario Telefone";
            }
            else
            {
                MessageBox.Show("Selecione uma tabela e um filtro antes de atualizar");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvRelatorio.Rows.Count > 0)
            {
                SaveFileDialog salvar = new SaveFileDialog(); //caixa de salvamento
                salvar.Filter = "PDF (*.pedf)|*.pdf"; //filtro em pdf
                salvar.InitialDirectory = @"C:/xampp/htdocs/kibelezati16/admin";
                salvar.FileName = variaveis.relatorio + ".pdf"; //nome arquivo
                bool fileError = false; //erro de arquivo inicia em falso
                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(salvar.FileName))
                    {
                        try
                        {
                            File.Delete(salvar.FileName); //deleta o arquivo existente
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Não foi possivel gravar os dados no disco" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfPTable = new PdfPTable(dgvRelatorio.ColumnCount); //gerar tabela em pdf
                            pdfPTable.DefaultCell.Padding = 3; //margin interna na célula de 3px
                            pdfPTable.WidthPercentage = 100; //largura de 100%
                            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT; //alinhamento a esquerda

                            foreach (DataGridViewColumn column in dgvRelatorio.Columns) //gerar titulos
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfPTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in dgvRelatorio.Rows) //inserir valores
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfPTable.AddCell(cell.Value.ToString());
                                }
                            }
                            using (FileStream stream = new FileStream(salvar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);//estrutura
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                Paragraph titulo = new Paragraph();
                                titulo.Add("RELATÓRIO" + variaveis.relatorio + "\n\n");
                                pdfDoc.Add(titulo);
                                pdfDoc.Add(pdfPTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Dados exportados com Sucesso !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Exportação não salva !!!", "Info");
            }
        }
    }
}
