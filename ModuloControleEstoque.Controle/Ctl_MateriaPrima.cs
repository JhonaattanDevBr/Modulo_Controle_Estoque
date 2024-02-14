using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModuloControleEstoque.Controle
{
    public class Ctl_MateriaPrima
    {
        private string _idMatP;
        private string _nomeMatP;
        private string _materialMatP;
        private string _peso;
        private string _valorUnitMatP;
        private string _idFornecedor;
       
        
        public string NomeMP
        {
            get { return _nomeMatP; }
            set
            {
                _nomeMatP = null;
                value = value.Trim();
                if (value != null && value.Length > 4)
                {
                    _nomeMatP = value;
                }
            }
        }

        public string MaterialMP
        {
            get { return _materialMatP; }
            set
            {
                _materialMatP = null; // basta tornar o atributo vazio antes de testar no if para resolver o problema.
                value = value.Trim();
                if (value != null && value.Length > 4)
                {
                    _materialMatP = value;
                }

            }
        }

        public string PesoMP
        {
            get { return _peso; }
            set
            {
                _peso = null;
                value = value.Trim();
                if (value != null && value.Length > 0)
                {
                    _peso = value;
                }
            }
        }

        public string ValorUnitarioMp
        {
            get { return _valorUnitMatP; }
            set
            {
                _valorUnitMatP = null;
                value = value.Trim();
                if (value != null && value.Length >= 4)
                {
                    _valorUnitMatP = value;
                }
            }
        }


        public List<bool> AutenticarDadosParaCadastro()
        {
            List<bool> autenticado = new List<bool>();
            //autenticado.Add(AutenticarFormatoPeso());
            //autenticado.Add(AutenticarFormatovalor());

            return autenticado;
        }

        public bool CamposPrenchidos()
        {
            bool vazio = false;
            if(string.IsNullOrEmpty(_nomeMatP) && string.IsNullOrEmpty(_materialMatP) && string.IsNullOrEmpty(_peso) && string.IsNullOrEmpty(_valorUnitMatP))
            {
                vazio = true;
                return vazio;
            }
            else { return vazio; }
        }

        private bool AutenticarFormatoPeso()
        {
            if (PesoMP != null)
            {
                string peso = PesoMP;
                Regex _Expression = new Regex(@"^([0-9]{2}\.[0-9]{3}\.[0-9]{3}/[0-9]{4}-[0-9]{2})$");
                bool valido = _Expression.IsMatch(peso);
                if (valido)
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

        private bool AutenticarFormatovalor()
        {

        }
    }
}
