using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloControleEstoque.Controle;
using ModuloControleEstoque.Modelo;

namespace ModuloControleEstoque.View.UserC_Cadastros
{
    public partial class Cad_Fornecedores : UserControl
    {
        public Cad_Fornecedores()
        {
            InitializeComponent();
            MostrarToolTip();
        }

        Ctl_Fornecedor _ControleFornecedor = new Ctl_Fornecedor();
        Mdl_Fornecedor _ModeloFornecedor = new Mdl_Fornecedor();

        // ---------------------------------------Lógica do cadastro: Começo ↓.-----------------------------------

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            bool caminho = PassarValores();
            if (!caminho)
            {
                bool retornoCadastro = _ModeloFornecedor.CadastrarFornecedor(_ControleFornecedor);
                if (retornoCadastro)
                {
                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Operação concluida com sucesso.");
                    LimparCaixas();
                }
                else
                {
                    MessageBox.Show("Fornecedor não cadastrado!", "Falha na operação.");
                }
            }
            else
            {
                PegarErros();
            }
        }

        private bool PassarValores()
        {
            _ControleFornecedor.NomeFornecedor = TxtNomeFornecedor.Text;
            _ControleFornecedor.Cnpj = TxtCnpj.Text;
            _ControleFornecedor.Email = TxtEmail.Text;
            _ControleFornecedor.Telefone = TxtTelefone.Text;
            _ControleFornecedor.Cidade = TxtCidade.Text;
            _ControleFornecedor.Bairro = TxtBairro.Text;
            _ControleFornecedor.Rua = TxtRua.Text;
            _ControleFornecedor.Numero = TxtNumero.Text;

            bool camposVazios = _ControleFornecedor.CamposPrenchidos();
            if (camposVazios)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PegarErros()
        {
            List<bool> retornoValido = new List<bool>();
            string[] mensagemErro = new string[4];
            mensagemErro[0] = "O formato do CPNJ não é válido.";
            mensagemErro[1] = "Ensira todos os dígitos do CNPJ.";
            mensagemErro[2] = "O formato do e-mail não é válido.";
            mensagemErro[3] = "O formato do telefone não é válido.";

            retornoValido = _ControleFornecedor.AutenticarDadosParaCadastro();
            for (int i = 0; i < retornoValido.Count; i++)
            {
                if (!retornoValido[i])
                {
                    MessageBox.Show($"Prencha todos os campos! {mensagemErro[i]}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void LimparCaixas()
        {
            TxtNomeFornecedor.Clear();
            TxtCnpj.Clear();
            TxtEmail.Clear();
            TxtTelefone.Clear();
            TxtCidade.Clear();
            TxtBairro.Clear();
            TxtRua.Clear();
            TxtNumero.Clear();
        }

        private void MostrarToolTip()
        {
            TtpDica.ToolTipTitle = "DICA";
            TtpDica.IsBalloon = true;

            TtpDica.SetToolTip(TxtCnpj, "XX.XXX.XXX/XXXX-X");
            TtpDica.SetToolTip(TxtTelefone, "(XX)-XXXX-XXXX");
        }

        //------------------------------------Lógica do cadastro: Fim ↑.----------------------------------------- 

        //------------------------------------Lógica de valores aceitos nos campos: Inicio ↓.----------------------------------------- 

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TxtNomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TxtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TxtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TxtRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        //------------------------------------Lógica de valores aceitos nos campos: Fim ↑.----------------------------------------- 

        //------------------------------------Lógica para alterar as cores dos botões: Começo ↓.----------------------------------------- 

        private void TxtNomeFornecedor_Enter(object sender, EventArgs e)
        {
            TxtNomeFornecedor.BackColor = SystemColors.GradientActiveCaption;
            TxtNomeFornecedor.SelectionStart = 0;
        }

        private void TxtNomeFornecedor_Leave(object sender, EventArgs e)
        {
            TxtNomeFornecedor.BackColor = SystemColors.Window;
        }

        private void TxtCnpj_Enter(object sender, EventArgs e)
        {
            TxtCnpj.BackColor = SystemColors.GradientActiveCaption;
            TxtCnpj.SelectionStart = 0;
        }

        private void TxtCnpj_Leave(object sender, EventArgs e)
        {
            TxtCnpj.BackColor = SystemColors.Window;
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            TxtEmail.BackColor = SystemColors.GradientActiveCaption;
            TxtEmail.SelectionStart = 0;
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            TxtEmail.BackColor = SystemColors.Window;
        }

        private void TxtTelefone_Enter(object sender, EventArgs e)
        {
            TxtTelefone.BackColor = SystemColors.GradientActiveCaption;
            TxtTelefone.SelectionStart = 0;
        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            TxtTelefone.BackColor = SystemColors.Window;
        }

        private void TxtCidade_Enter(object sender, EventArgs e)
        {
            TxtCidade.BackColor = SystemColors.GradientActiveCaption;
            TxtCidade.SelectionStart = 0;
        }

        private void TxtCidade_Leave(object sender, EventArgs e)
        {
            TxtCidade.BackColor = SystemColors.Window;
        }

        private void TxtBairro_Enter(object sender, EventArgs e)
        {
            TxtBairro.BackColor = SystemColors.GradientActiveCaption;
            TxtBairro.SelectionStart = 0;
        }

        private void TxtBairro_Leave(object sender, EventArgs e)
        {
            TxtBairro.BackColor = SystemColors.Window;
        }

        private void TxtRua_Enter(object sender, EventArgs e)
        {
            TxtRua.BackColor = SystemColors.GradientActiveCaption;
            TxtRua.SelectionStart = 0;
        }

        private void TxtRua_Leave(object sender, EventArgs e)
        {
            TxtRua.BackColor = SystemColors.Window;
        }

        private void TxtNumero_Enter(object sender, EventArgs e)
        {
            TxtNumero.BackColor = SystemColors.GradientActiveCaption;
            TxtNumero.SelectionStart = 0;
        }

        private void TxtNumero_Leave(object sender, EventArgs e)
        {
            TxtNumero.BackColor = SystemColors.Window;
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrarFornecedor.BackColor = SystemColors.GradientActiveCaption;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrarFornecedor.BackColor = SystemColors.Window;
        }

        //------------------------------------Lógica para alterar as cores dos botões: Fim ↑.----------------------------------------- 
    }
}
