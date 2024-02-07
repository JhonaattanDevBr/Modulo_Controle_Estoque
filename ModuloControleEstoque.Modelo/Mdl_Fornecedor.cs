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
                string query = "INSERT INTO Fornecedores (Nome_Forne, Cnpj, Email, Telefone, Cidade, Bairro, Rua, Numero) " +
                               "VALUES (@nomeForne, @cnpj, @email, @telefone, @cidade, @bairro, @rua, @numero)";
                SqlCommand command = new SqlCommand(query, connection);

                var pmtNomeForne =  command.CreateParameter();
                pmtNomeForne.ParameterName = "@nomeForne";
                pmtNomeForne.DbType = DbType.String;
                pmtNomeForne.Value = _Fornecedor.NomeFornecedor;
                command.Parameters.Add(pmtNomeForne);

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

                var pmtBairro = command.CreateParameter();
                pmtBairro.ParameterName = "@bairro";
                pmtBairro.DbType = DbType.String;
                pmtBairro.Value = _Fornecedor.Bairro;
                command.Parameters.Add(pmtBairro);

                var pmtRua = command.CreateParameter();
                pmtRua.ParameterName = "@rua";
                pmtRua.DbType = DbType.String;
                pmtRua.Value = _Fornecedor.Rua;
                command.Parameters.Add(pmtRua);

                var pmtNumero = command.CreateParameter();
                pmtNumero.ParameterName = "@numero";
                pmtNumero.DbType = DbType.Int16;
                pmtNumero.Value = _Fornecedor.Numero;
                command.Parameters.Add(pmtNumero);

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
