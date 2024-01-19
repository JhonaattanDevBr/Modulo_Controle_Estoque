using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModuloControleEstoque.Controle
{
    public class Ctl_Fornecedor
    {
        public int CodFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Regiao { get; set; }
        public string Bairro { get; set; }


        public List<bool> AutenticarDadosParaCadastro()
        {
            List<bool> isValid = new List<bool>();
            isValid.Add(AutenticarFormatoCnpj());
            isValid.Add(AutenticarTodosDigitosCnpj());
            isValid.Add(AutenticarFormatoEmail());
            isValid.Add(AutenticarTelefone());
            
            return isValid;
           
        }

        private bool AutenticarFormatoCnpj()
        {
            string cnpj = Cnpj;
            Regex _Expression = new Regex(@"^([0-9]{2}\.[0-9]{3}\.[0-9]{3}/[0-9]{4}-[0-9]{2})$");
            bool isValid = _Expression.IsMatch(cnpj);
            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AutenticarTodosDigitosCnpj()
        {
            string cnpj = Cnpj;
            Regex _Expression = new Regex(@"^([0-9]{2}\.[0-9]{3}\.[0-9]{3}/[0-9]{4}-[0-9]{2})$");
            bool isValid =  _Expression.IsMatch(cnpj);
            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AutenticarFormatoEmail()
        {
            string email = Email;
            Regex _Expression = new Regex(@"^([a-zA-Z0-9_.%$])+@[a-zA-Z]+\.[a-zA-Z]{2,}$");
            bool isValid = _Expression.IsMatch(email);
            if (isValid)
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
            /*string numTelefone = Telefone;
            numTelefone = numTelefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (numTelefone.Length == 10)
            {
                return true;
            }
            else
            {
                //MENSAGEM: Ensira todos os dígitos do telefone.
                return false;
            }*/
            string telefone = Telefone;
            Regex _Expression = new Regex(@"^(\([0-9]{2}\)-[0-9]{4}-[0-9]{4})$");
            bool isValid = _Expression.IsMatch(telefone); // O metodo IsMatch da classe Regex serve para comparar uma string
                                                           // com uma expressão regular e dizer se ela é valida ou não. Ela retorna um bool.
            if (isValid)
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
