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

        Ctl_Fornecedor _ControleFornecedor = new Ctl_Fornecedor();
        Mdl_Fornecedor _ModeloFornecedor = new Mdl_Fornecedor();

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
            _ControleFornecedor.NomeFornecedor = txtRazaoSocial.Text;
            _ControleFornecedor.Cnpj = mskCnpj.Text;
            _ControleFornecedor.Email = txtEmail.Text;
            _ControleFornecedor.Telefone = mskTelefone.Text;
            _ControleFornecedor.Cidade = txtCidade.Text;
            _ControleFornecedor.Regiao = cmbRegiao.Text;
            _ControleFornecedor.Bairro = txtBairro.Text;

            if(!string.IsNullOrEmpty(txtRazaoSocial.Text) &&
               !string.IsNullOrEmpty(mskCnpj.Text) &&
               !string.IsNullOrEmpty(mskTelefone.Text) &&
               !string.IsNullOrEmpty(txtCidade.Text) &&
               !string.IsNullOrEmpty(cmbRegiao.Text) &&
               !string.IsNullOrEmpty(txtBairro.Text))
            {
                List<bool> retornoIsValid = new List<bool>();// VOu precisar rever esse código. Esta com Erro nesta parte
                retornoIsValid = _ControleFornecedor.AutenticarDadosParaCadastro();

                if (retornoIsValid[0] &&
                    retornoIsValid[1] &&
                    retornoIsValid[2] &&
                    retornoIsValid[3])
                {
                    bool retornoCadastro = _ModeloFornecedor.CadastrarFornecedor(_ControleFornecedor);
                    if (retornoCadastro)
                    {
                        MessageBox.Show("Fornecedor cadastrado com sucesso.", "!Operação concluida com sucesso.");
                        LimparCaixas();
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não cadastrado.", "!Falha na operação.");
                    }
                }
                else
                {
                    string[] mensagemErro = new string[4];
                    mensagemErro[0] = "O formato do CPNJ não é válido.";
                    mensagemErro[1] = "Ensira todos os dígitos do CNPJ.";
                    mensagemErro[2] = "O formato do e-mail não é válido.";
                    mensagemErro[3] = "Ensira todos os dígitos do telefone.";
                    for (int i = 0; i < retornoIsValid.Count; i++)
                    {
                        if (!retornoIsValid[i])
                        {
                            MessageBox.Show(mensagemErro[i], "Atenção!");
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimparCaixas()
        {
            txtRazaoSocial.Clear();
            mskCnpj.Clear();
            txtEmail.Clear();
            mskTelefone.Clear();
            txtCidade.Clear();
            cmbRegiao.SelectedIndex = 0;
            txtBairro.Clear();
        }
    }
}
