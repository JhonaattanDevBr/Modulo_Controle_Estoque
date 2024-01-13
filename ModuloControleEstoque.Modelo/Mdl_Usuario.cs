
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ModuloControleEstoque.Controle;

namespace ModuloControleEstoque.Modelo
{
    public class Mdl_Usuario
    {
        ChaveConexaoBd _chaveConexao = new ChaveConexaoBd();

        public bool ConsultarUsuario(Ctl_Usuario _Usuario)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(_chaveConexao.ConexaoBd);
                conexao.Open();
                string q = "SELECT * FROM Usuarios";
                SqlCommand cmd = new SqlCommand(q, conexao);
                SqlDataReader _leitor = cmd.ExecuteReader();

                string usuario = null, senha = null;
                while (_leitor.Read())
                {
                    if (_leitor.GetString(2) == _Usuario.Usuario && _leitor.GetString(3) == _Usuario.Senha)
                    {
                        usuario = _leitor.GetString(2);
                        senha = _leitor.GetString(3);
                        break;
                    }

                }
                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string NomeUsuario(Ctl_Usuario _Usuario)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(_chaveConexao.ConexaoBd);
                conexao.Open();
                string q = "SELECT * FROM Usuarios";
                SqlCommand cmd = new SqlCommand(q, conexao);
                SqlDataReader _leitor = cmd.ExecuteReader();

                string nome = null;
                while (_leitor.Read())
                {
                    if (_leitor.GetString(2) == _Usuario.Usuario && _leitor.GetString(3) == _Usuario.Senha)
                    {
                        nome = _leitor.GetString(1);
                        break;
                    }
                }
                return nome;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
