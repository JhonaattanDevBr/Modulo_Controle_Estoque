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
        private string _codFornecedor;
        private string _nomeFornecedor;
        private string _cnpj;
        private string _email;
        private string _telefone;
        private string _cidade;
        private string _bairro;
        private string _rua;
        private string _numero;

        public string NomeFornecedor
        {
            get { return _nomeFornecedor; }
            set
            {
                _nomeFornecedor = null;
                if (value != null && value.Length > 4)
                {
                    _nomeFornecedor = value;
                }
            }
        }

        public string Cnpj
        {
            get { return _cnpj; }
            set
            {
                _cnpj = null;
                if (value != null && value.Length == 18)
                {
                    _cnpj = value;
                }
            }
        }
        
        public string Email
        {
            get { return _email; }
            set
            {
                _email = null;
                if (value != null && value.Length > 5)
                {
                    _email = value;
                }
            }
        }

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                _telefone = null;
                if (value != null && value.Length == 14)
                {
                    _telefone = value;
                }
            }
        }

        public string Cidade
        {
            get { return _cidade; }
            set 
            {
                _cidade = null;
                if (value != null && value.Length > 5)
                {
                    _cidade = value;
                }
            }
        }

        public string Bairro
        {
            get { return _bairro; }
            set
            {
                _bairro = null;
                if (value != null && value.Length > 4)
                {
                    _bairro = value;
                }
            }
        }

        public string Rua
        {
            get { return _rua; }
            set
            {
                _rua = null;
                if (value != null && value.Length > 4)
                {
                    _rua = value;
                }
            }
        }

        public string Numero
        {
            get { return _numero; }
            set
            {
                _numero = null;
                if (value != null && value.Length > 1)
                {
                    _numero = value;
                }
            }
        }

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
            if (Cnpj != null)
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
            else { return false; }
            
        }

        private bool AutenticarTodosDigitosCnpj()
        {
            if (Cnpj != null)
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
            else { return false; }
            
        }

        private bool AutenticarFormatoEmail()
        {
            if (Email != null) // <- Apontou erro nessa parte pois ele tentou validar uma string vazia, se pular pra outro metodo esse funcionou.
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
            else { return false; }
           
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
            if (Telefone != null)
            {
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
            else { return false; }
        }
    }
}
