using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloControleEstoque.Controle;

namespace ModuloControleEstoque.Modelo
{
    public class Mdl_Fornecedor
    {
        ChaveConexaoBd _Chave = new ChaveConexaoBd();
        public bool CadastrarFornecedor(Ctl_Fornecedor _Fornecedor)
        {
            try
            {
                string conexaoBd = _Chave.ConexaoBd;
                SqlConnection connection = new SqlConnection(conexaoBd);

                connection.Open();
                string query = "INSERT INTO Fornecedores (Razao_Sc, Cnpj, Email, Telefone, Cidade, Regiao, Bairro) " +
                               "VALUES (@razaoSocial, @cnpj, @email, @telefone, @cidade, @regiao, @bairro)";
                SqlCommand command = new SqlCommand(query, connection);

                var pmtRazaoSocial =  command.CreateParameter();
                pmtRazaoSocial.ParameterName = "@razaoSocial";
                pmtRazaoSocial.DbType = DbType.String;
                pmtRazaoSocial.Value = _Fornecedor.NomeFornecedor;
                command.Parameters.Add(pmtRazaoSocial);

                var pmtCnpj = command.CreateParameter();
                pmtCnpj.ParameterName = "@cnpj";
                pmtCnpj.DbType = DbType.String;
                pmtCnpj.Value = _Fornecedor.Cnpj;
                command.Parameters.Add(pmtCnpj);

                var pmtEmail = command.CreateParameter();
                pmtEmail.ParameterName = "@email";
                pmtEmail.DbType = DbType.String;
                pmtEmail.Value = _Fornecedor.Email;
                command.Parameters.Add(pmtEmail);

                var pmtTelefone = command.CreateParameter();
                pmtTelefone.ParameterName = "@telefone";
                pmtTelefone.DbType = DbType.String;
                pmtTelefone.Value = _Fornecedor.Telefone;
                command.Parameters.Add(pmtTelefone);

                var pmtCidade = command.CreateParameter();
                pmtCidade.ParameterName = "@cidade";
                pmtCidade.DbType = DbType.String;
                pmtCidade.Value = _Fornecedor.Cidade;
                command.Parameters.Add(pmtCidade);

                var pmtRegiao = command.CreateParameter();
                pmtRegiao.ParameterName = "@regiao";
                pmtRegiao.DbType = DbType.String;
                pmtRegiao.Value = _Fornecedor.Regiao;
                command.Parameters.Add(pmtRegiao);

                var pmtBairro = command.CreateParameter();
                pmtBairro.ParameterName = "@bairro";
                pmtBairro.DbType = DbType.String;
                pmtBairro.Value = _Fornecedor.Bairro;
                command.Parameters.Add(pmtBairro);

                if (command.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    return true;
                }
                else 
                {
                    connection.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
