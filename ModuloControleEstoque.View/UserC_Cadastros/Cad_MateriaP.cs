using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloControleEstoque.Controle;

namespace ModuloControleEstoque.View.UserC_Cadastros
{
    public partial class Cad_MateriaP : UserControl
    {
        public Cad_MateriaP()
        {
            InitializeComponent();
            MostrarDica();
        }

        Ctl_MateriaPrima _ctlMatPrima = new Ctl_MateriaPrima();

        // ---------------------------------------Lógica do cadastro: Começo ↓.-----------------------------------

        private void BtnCadastrarMP_Click(object sender, EventArgs e)
        {
            
        }

        private bool PegarPassarValores()
        {
            _ctlMatPrima.NomeMP = TxtNomeMP.Text;
            _ctlMatPrima.MaterialMP = TxtMaterialMP.Text;
            _ctlMatPrima.PesoMP = TxtPesoMP.Text;
            _ctlMatPrima.ValorUnitarioMp = TxtValorUnitarioMP.Text;

            bool camposvazio = _ctlMatPrima.CamposPrenchidos();
            if (camposvazio)
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
            string[] mensagemErro = new string[3];
            //mensagemErro[0] = "Informe o nome da matéria prima.";
            //mensagemErro[1] = "Informe o nome do material da matéria prima.";
            mensagemErro[0] = "O formato do peso não é válido.";
            mensagemErro[1] = "O formato do valor não é válido.";
            mensagemErro[2] = "Informe o fornecedor da matéria prima.";

            retornoValido = _ctlMatPrima.AutenticarDadosParaCadastro();
            for (int i = 0; i < retornoValido.Count; i++)
            {
                if (!retornoValido[i])
                {
                    MessageBox.Show($"Prencha todos os campos! {mensagemErro[i]}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void MostrarDica()
        {
            TtpDica.ToolTipTitle = "DICA";
            TtpDica.IsBalloon = true;

            TtpDica.SetToolTip(TxtPesoMP, "Utilize a vírgula.\nExemplo: XX,X");
            TtpDica.SetToolTip(TxtValorUnitarioMP, "Utilize a vírgula e o ponto.\nExemplo: X.XXX,XX");
        }

        //------------------------------------Lógica do cadastro: Fim ↑.----------------------------------------- 

        //------------------------------------Lógica para alterar as cores dos botões: Começo ↓.----------------------------------------- 
        private void TxtNomeMP_Enter(object sender, EventArgs e)
        {
            TxtNomeMP.BackColor = SystemColors.GradientActiveCaption;
            TxtNomeMP.SelectionStart = 0;
        }

        private void TxtNomeMP_Leave(object sender, EventArgs e)
        {
            TxtNomeMP.BackColor = SystemColors.Window;
        }

        private void TxtMaterialMP_Enter(object sender, EventArgs e)
        {
            TxtMaterialMP.BackColor = SystemColors.GradientActiveCaption;
            TxtMaterialMP.SelectionStart = 0;
        }

        private void TxtMaterialMP_Leave(object sender, EventArgs e)
        {
            TxtMaterialMP.BackColor = SystemColors.Window;
        }

        private void TxtPesoMP_Enter(object sender, EventArgs e)
        {
            TxtPesoMP.BackColor = SystemColors.GradientActiveCaption;
            TxtPesoMP.SelectionStart = 0;
        }

        private void TxtPesoMP_Leave(object sender, EventArgs e)
        {
            TxtPesoMP.BackColor = SystemColors.Window;
        }

        private void TxtValorUnitarioMP_Enter(object sender, EventArgs e)
        {
            TxtValorUnitarioMP.BackColor = SystemColors.GradientActiveCaption;
            TxtValorUnitarioMP.SelectionStart = 0;
        }

        private void TxtValorUnitarioMP_Leave(object sender, EventArgs e)
        {
            TxtValorUnitarioMP.BackColor = SystemColors.Window;
        }

        private void CmbFornecedorMP_Enter(object sender, EventArgs e)
        {
            CmbFornecedorMP.BackColor = SystemColors.GradientActiveCaption;
            CmbFornecedorMP.SelectionStart = 0; // Essa parte vai dar erro pq eu não coloquei pra ele pegar o primeiro indice da lista.
        }

        private void CmbFornecedorMP_Leave(object sender, EventArgs e)
        {
            CmbFornecedorMP.BackColor = SystemColors.Window;
        }

        private void BtnCadastrarMP_MouseEnter(object sender, EventArgs e)
        {
            BtnCadastrarMP.BackColor = SystemColors.GradientActiveCaption;
        }

        private void BtnCadastrarMP_MouseLeave(object sender, EventArgs e)
        {
            BtnCadastrarMP.BackColor = SystemColors.Window;
        }

        private void TxtNomeMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TxtMaterialMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TxtPesoMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }

        private void TxtValorUnitarioMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != 44) && (e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        //------------------------------------Lógica para alterar as cores dos botões: Fim ↑.----------------------------------------- 


    }
}
