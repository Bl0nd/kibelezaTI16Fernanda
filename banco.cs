using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTI16Fernanda
{
    public static class banco
    {
        //string de conexão com banco de dados
        public static string db = "SERVER=localhost;USER=root;DATABASE=kibelezati16"; //local

        //public static string db = "SERVER=ipServidor;USER=nome_usuario;PASSWORD=senha;DATABASE=nome_banco;SSL MODE=None"; //Banco de dados remoto

        //reconhecer a biblioteca Mysql
        public static MySqlConnection conexao;

        //metodo para abrir conexão
        public static void Conectar()
        {
            try
            {
            conexao = new MySqlConnection(db);
            conexao.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao iniciar conexão com o banco de dados...", "ERRO AO CONECTAR");
            }
        }

        //metodo para fechar conexão
        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao fechar conexão com o banco de dados...", "ERRO AO DESCONECTAR");
            }
        }
    }
}
