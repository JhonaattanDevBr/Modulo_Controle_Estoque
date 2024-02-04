using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModuloControleEstoque.Controle
{
    public class Ctl_MateriaPrima
    {
        private string _nomeMP;
        private string _categoriaMp;
        private string _novaCategoriaMp;
        private string _valorUnitarioMp;
        private string _quantiadadeMp;
        private string _fornecedor;
        private string _comprimento;
        private string _largura;
        private string _altura;
        private string _peso;
        private string _saldoMP;
        
        public string Nome
        {
            get { return _nomeMP; }
            set
            {
                _nomeMP = null;
                value = value.Trim();
                if (value != null && value.Length > 4)
                {
                    _nomeMP = value;
                }
            }
        }

        public string NovaCategoria
        {
            get { return _novaCategoriaMp; }
            set
            {
                _novaCategoriaMp = null; // basta tornar o atributo vazio antes de testar no if para resolver o problema.
                value = value.Trim();
                if (value != null && value.Length > 4)
                {
                    _novaCategoriaMp = value;
                }

            }
        }

        public string ValorUnitarioMp
        {
            get { return _valorUnitarioMp; }
            set
            {
                _valorUnitarioMp = null;
                value = value.Trim();
                if (value != null && value.Length >= 4)
                {
                    _valorUnitarioMp = value;
                }
            }
        }

        public string QuantidadeMp
        {
            get { return _quantiadadeMp; }
            set
            {
                _quantiadadeMp = null;
                value = value.Trim();
                if (value != null && value.Length > 0)
                {
                    _quantiadadeMp = value;
                }
            }
        }

        public bool CamposPrenchidos()
        {
            if(!string.IsNullOrEmpty(_nomeMP) &&
               !string.IsNullOrEmpty(_novaCategoriaMp) &&
               !string.IsNullOrEmpty(_valorUnitarioMp) &&
               !string.IsNullOrEmpty(_quantiadadeMp))
            {
                return true;
            }
            else { return false; }
        }

        public string DscobrirErro()
        {
            string[] valores = new string[4];
            valores[0] = _nomeMP;
            valores[1] = _novaCategoriaMp;
            valores[2] = _valorUnitarioMp;
            valores[3] = _quantiadadeMp;

            string[] msgErro = new string[4];
            msgErro[0] = "O campo nome não pode estar vazio. Mínimo de 4 letras.";
            msgErro[1] = "O campo nova categoria não pode estar vazio. Mínimo de 4 letras.";
            msgErro[2] = "O campo valor unitário não pode estar vazio. Informe o valor de acordo com a dica.";
            msgErro[3] = "O campo quantidade não pode estar vazio.";

            string erro = "O ERRO NÃO ESTA AQUI";
            for(int i = 0; i < valores.Length; i++)
            {
                if (string.IsNullOrEmpty(valores[i]))
                {
                    return msgErro[i];
                }
            }
            return erro;
        }
    }
}
