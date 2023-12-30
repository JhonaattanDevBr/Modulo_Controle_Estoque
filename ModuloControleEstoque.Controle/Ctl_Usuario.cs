using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloControleEstoque.Modelo;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ModuloControleEstoque.Controle
{
    public class Ctl_Usuario
    {
        ChaveConexaoBd _chaveConexao = new ChaveConexaoBd();

        public bool ConsultarUsuario(Mdl_Usuario _mdlUsuario)
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
                    if (_leitor.GetString(2) == _mdlUsuario.Usuario && _leitor.GetString(3) == _mdlUsuario.Senha)
                    {
                        usuario = _leitor.GetString(2);
                        senha = _leitor.GetString(3);
                        break;
                    }
                    
                }
                if(!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha)) 
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

        public string NomeUsuario(Mdl_Usuario _mdlUsuario)
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
                    if (_leitor.GetString(2) == _mdlUsuario.Usuario && _leitor.GetString(3) == _mdlUsuario.Senha)
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
