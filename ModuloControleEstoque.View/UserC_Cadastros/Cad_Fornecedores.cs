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
using ModuloControleEstoque.Modelo;

namespace ModuloControleEstoque.View.UserC_Cadastros
{
    public partial class Cad_Fornecedores : UserControl
    {
        public Cad_Fornecedores()
        {
            InitializeComponent();
        }

        Ctl_Fornecedor _Fornecedor = new Ctl_Fornecedor();

        private void txtRazaoSocial_Enter(object sender, EventArgs e)
        {
            txtRazaoSocial.BackColor = SystemColors.GradientActiveCaption;
        }

        private void txtRazaoSocial_Leave(object sender, EventArgs e)
        {
            txtRazaoSocial.BackColor = SystemColors.Window;
        }

        private void mskCnpj_Enter(object sender, EventArgs e)
        {
            mskCnpj.BackColor = SystemColors.GradientActiveCaption;
        }

        private void mskCnpj_Leave(object sender, EventArgs e)
        {
            mskCnpj.BackColor = SystemColors.Window;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.BackColor = SystemColors.GradientActiveCaption;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.BackColor = SystemColors.Window;
        }

        private void mskTelefone_Enter(object sender, EventArgs e)
        {
            mskTelefone.BackColor = SystemColors.GradientActiveCaption;
        }

        private void mskTelefone_Leave(object sender, EventArgs e)
        {
            mskTelefone.BackColor = SystemColors.Window;
        }

        private void txtCidade_Enter(object sender, EventArgs e)
        {
            txtCidade.BackColor = SystemColors.GradientActiveCaption;
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            txtCidade.BackColor = SystemColors.Window;
        }

        private void cmbRegiao_Enter(object sender, EventArgs e)
        {
            cmbRegiao.BackColor = SystemColors.GradientActiveCaption;
        }

        private void cmbRegiao_Leave(object sender, EventArgs e)
        {
            cmbRegiao.BackColor = SystemColors.Window;
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            txtBairro.BackColor = SystemColors.GradientActiveCaption;
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            txtBairro.BackColor = SystemColors.Window;
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrarFornecedor.BackColor = SystemColors.GradientActiveCaption;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrarFornecedor.BackColor = SystemColors.Window;
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            _Fornecedor.NomeFornecedor = txtRazaoSocial.Text;
            _Fornecedor.Cnpj = mskCnpj.Text;
            _Fornecedor.Email = txtEmail.Text;
            _Fornecedor.Telefone = mskTelefone.Text;
            _Fornecedor.Cidade = txtCidade.Text;
            _Fornecedor.Regiao = cmbRegiao.SelectedText;
            _Fornecedor.Bairro = txtBairro.Text;

            bool retornoAutenDigitosTelefone = _Fornecedor.AutenticarTelefone();
            if (retornoAutenDigitosTelefone)
            {
                MessageBox.Show("A autenticação funcionou. Foram digitados todos os 10 digitos do telefone.");
            }
            else
            {
                MessageBox.Show("ERRO!! A autenticação não funcionou. Não foram digitados todos os 10 digitos do telefone.");
            }
        }
    }
}
