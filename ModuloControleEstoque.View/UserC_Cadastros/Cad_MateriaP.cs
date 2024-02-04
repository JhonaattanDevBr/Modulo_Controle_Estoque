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
        }

        Ctl_MateriaPrima _ctlMatPrima = new Ctl_MateriaPrima();

        // Código para alterar as cores dos botões: Começo ↓.

        private void TxtNomeMP_Enter(object sender, EventArgs e)
        {
            TxtNomeMP.BackColor = SystemColors.GradientActiveCaption;
            TxtNomeMP.SelectionStart = 0;
        }

        private void TxtNomeMP_Leave(object sender, EventArgs e)
        {
            TxtNomeMP.BackColor = SystemColors.Window;
        }

        private void CmbCategoriaMP_Enter(object sender, EventArgs e)
        {
            CmbCategoriaMP.BackColor = SystemColors.GradientActiveCaption;
            CmbCategoriaMP.SelectionStart = 0;
        }

        private void CmbCategoriaMP_Leave(object sender, EventArgs e)
        {
            CmbCategoriaMP.BackColor = SystemColors.Window;
        }

        private void TxtNovaCategoriaMP_Enter(object sender, EventArgs e)
        {
            TxtNovaCategoriaMP.BackColor = SystemColors.GradientActiveCaption;
            TxtNovaCategoriaMP.SelectionStart = 0;
        }

        private void TxtNovaCategoriaMP_Leave(object sender, EventArgs e)
        {
            TxtNovaCategoriaMP.BackColor = SystemColors.Window;
        }

        private void TxtPrecoUnitarioMP_Enter(object sender, EventArgs e)
        {
            TxtPrecoUnitarioMP.BackColor = SystemColors.GradientActiveCaption;
            TxtPrecoUnitarioMP.SelectionStart = 0;
        }

        private void TxtPrecoUnitarioMP_Leave(object sender, EventArgs e)
        {
            TxtPrecoUnitarioMP.BackColor = SystemColors.Window;
        }

        private void TxtQuantidadeMP_Enter(object sender, EventArgs e)
        {
            TxtQuantidadeMP.BackColor = SystemColors.GradientActiveCaption;
            TxtQuantidadeMP.SelectionStart = 0;
        }

        private void TxtQuantidadeMP_Leave(object sender, EventArgs e)
        {
            TxtQuantidadeMP.BackColor = SystemColors.Window;
        }

        private void CmbFornecedorMP_Enter(object sender, EventArgs e)
        {
            CmbFornecedorMP.BackColor = SystemColors.GradientActiveCaption;
            CmbFornecedorMP.SelectionStart = 0;
        }

        private void CmbFornecedorMP_Leave(object sender, EventArgs e)
        {
            CmbFornecedorMP.BackColor = SystemColors.Window;
        }

        private void CkbCadastrarMP_CheckedChanged(object sender, EventArgs e)
        {
            
            if(CkbCadastrarMP.Checked)
            {
                CmbCategoriaMP.SelectionStart = 0;
                CmbCategoriaMP.Enabled = false;
                TxtNovaCategoriaMP.Enabled = true;
            }
            else
            {
                TxtNovaCategoriaMP.Clear();
                TxtNovaCategoriaMP.Enabled = false;
                CmbCategoriaMP.Enabled = true;
            }
        }

        private void BtnCadastrarFornecedor_MouseEnter(object sender, EventArgs e)
        {
            BtnCadastrarFornecedor.BackColor = SystemColors.GradientActiveCaption;
        }

        private void BtnCadastrarFornecedor_MouseLeave(object sender, EventArgs e)
        {
            BtnCadastrarFornecedor.BackColor = SystemColors.Window;
        }

        // Código para alterar as cores dos botões: Fim ↑.

        private void BtnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            bool vlCampos = _ctlMatPrima.CamposPrenchidos();
            if (vlCampos)
            {
                MessageBox.Show("Todos os campos estão corretos.");
            }
            else
            {
                string msgErro = _ctlMatPrima.DscobrirErro();
                if (msgErro != "O ERRO NÃO ESTA AQUI")
                {
                    MessageBox.Show(msgErro, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Código de passagem de valores as properties: Início ↓

        private void TxtNomeMP_TextChanged(object sender, EventArgs e)
        {
            _ctlMatPrima.Nome = TxtNomeMP.Text;
        }

        private void TxtNovaCategoriaMP_TextChanged(object sender, EventArgs e)
        {
            _ctlMatPrima.NovaCategoria = TxtNovaCategoriaMP.Text;
        }

        private void TxtPrecoUnitarioMP_TextChanged(object sender, EventArgs e)
        {
            _ctlMatPrima.ValorUnitarioMp = TxtPrecoUnitarioMP.Text;
        }

        private void TxtQuantidadeMP_TextChanged(object sender, EventArgs e)
        {
            _ctlMatPrima.QuantidadeMp = TxtQuantidadeMP.Text;
        }
    }
}
