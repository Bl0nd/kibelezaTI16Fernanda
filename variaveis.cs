﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kibelezaTI16Fernanda
{
    public static class variaveis
    {
        //Geral
        public static string funcao;
        public static int linhaSelecionada;

        //Login
        public static string usuario, senha, nivel;

        //Cliente
        public static int codCliente;
        public static string nomeCliente, emailCliente, senhaCliente, statusCliente, fotoCliente, atFotoCliente, caminhoFotoCliente;
        public static DateTime dataCadastroCliente;

        //Funcionario
        public static int codFuncionario;
        public static string nomeFuncionario;

        //Servico
        public static int codServico;
        public static string nomeServico;

        //Empresa
        public static int codEmpresa;
        public static string nomeEmpresa, cnpjCpfEmpresa, razaoSocialEmpresa, emailEmpresa, statusEmpresa;
        public static DateTime dataCadastroEmpresa, horarioAtendEmpresa;

        //Fone Empresa
        public static int codFoneEmpresa;
        public static string numeroFoneEmpresa, operadoraEmpresa, descricaoEmpresa;

        //Cliente
        public static int codFoneCliente;
        public static string numeroFoneCliente, operadoraCliente, operFoneCliente, descricaoCliente;

        //FOTOS FTP
        public static string enderecoServidorFtp = "ftp://127.0.0.1/admin/";
        public static string usuarioFtp ="ti16";
        public static string senhaFtp = "1234";

        //Reserva
        public static int codReserva;
        public static string obsReserva, statusReserva;
        public static DateTime dataReserva, horarioReserva;
    }
}
