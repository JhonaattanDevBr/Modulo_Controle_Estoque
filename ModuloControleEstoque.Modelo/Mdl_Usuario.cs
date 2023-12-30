
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModuloControleEstoque.Modelo
{
    public class Mdl_Usuario
    {

        public string CodUsuario { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public bool RealizarLogin()
        {
            bool retorno = false, autUsuario, autSenha;

            autUsuario = AutenticarUsuario();
            if (autUsuario)
            {
                autSenha = AutenticarSenha();
                if (autSenha)
                {
                    retorno = true;
                    return retorno;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool AutenticarUsuario()
        {
            string nomeUsuario = Usuario;
            if (nomeUsuario == nomeUsuario.ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool AutenticarSenha()
        {
            string senhaUsuario = Senha;
            if (!(senhaUsuario.Length != 8))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
