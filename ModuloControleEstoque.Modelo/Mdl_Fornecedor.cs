﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloControleEstoque.Modelo
{
    public class Mdl_Fornecedor
    {
        public int CodFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Regiao { get; set; }
        public string Bairro { get; set; }


        public void AutenticarDadosParaCadastro() // Vou deixar como void para testar o código.
        {

        }

        public bool AutenticarFormatoCnpj()
        {
            // Formato de CNPJ: 00.000.000/0000-00
            // Dígitos: 14
            // Total de caracteres: 18
            // Preciso verificar se os pontos, barra e traços estão no lugar certo.

            // DESCOBRI QUE NÃO VOU PRECISAR DESSE CÓDIGO PORQUE ESTOU USANDO MSK ENTÃO INDEPENDENTE DO USUÁRIO DIGITAR TODOS OS DIGITOS DO CNPJ
            // O SISTEMA VAI PASSAR PORQUE AS ACENTUAÇÕES JA ESTÃO NO FORMS DEVIDO O USO DO MSK.
            // VOU PRECISAR VERIFICAR SE TODOS OS DIGITOS FORAM INSERIDOS.
            string cnpj = Cnpj;
           
            char[] list = cnpj.ToCharArray();
            if (Convert.ToChar(list[2]) == '.' &&
                Convert.ToChar(list[6]) == '.' &&
                Convert.ToChar(list[10]) == '/' &&
                Convert.ToChar(list[15]) == '-')
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private bool AutenticarTelefone()
        {
            string numTelefone = Telefone;
            numTelefone = numTelefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if(numTelefone.Length == 10)
            {
                return true;
            }
            else
            {
                //MENSAGEM: Ensira todos os dígitos do telefone.
                return false;
            }
            
        }

        private void AutenticarEmail()
        {

        } // Vou deixar como void para testar o código.

        private void ConverterParaUpperCase()
        {

        }
    }
}