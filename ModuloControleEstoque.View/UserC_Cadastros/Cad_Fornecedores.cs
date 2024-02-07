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

        // Lógica do botão cadastrar: Começo ↓.
        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            _ControleFornecedor.NomeFornecedor = TxtNomeFornecedor.Text;
            _ControleFornecedor.Cnpj = TxtCnpj.Text;
            _ControleFornecedor.Email = TxtEmail.Text; // <- Ele não esta recebendo o vali
            _ControleFornecedor.Telefone = TxtTelefone.Text;
            _ControleFornecedor.Cidade = TxtCidade.Text;
            _ControleFornecedor.Bairro = TxtBairro.Text;
            _ControleFornecedor.Rua = TxtRua.Text;
            _ControleFornecedor.Numero = TxtNumero.Text;

            if(!string.IsNullOrEmpty(TxtNomeFornecedor.Text) &&
               !string.IsNullOrEmpty(TxtCnpj.Text) &&
               !string.IsNullOrEmpty(TxtTelefone.Text) &&
               !string.IsNullOrEmpty(TxtCidade.Text) &&
               !string.IsNullOrEmpty(TxtBairro.Text))
            {
                List<bool> retornoValido = new List<bool>();
                string[] mensagemErro = new string[4];
                mensagemErro[0] = "O formato do CPNJ não é válido.";
                mensagemErro[1] = "Ensira todos os dígitos do CNPJ.";
                mensagemErro[2] = "O formato do e-mail não é válido.";
                mensagemErro[3] = "Ensira todos os dígitos do telefone.";

                retornoValido = _ControleFornecedor.AutenticarDadosParaCadastro();

                for (int i = 0; i < retornoValido.Count; i++)
                {
                    if (!retornoValido[i])
                    {
                        MessageBox.Show(mensagemErro[i], "Atenção!");
                        break;
                    }
                    else
                    {
                        if (retornoValido[3])
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
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Lógica do botão cadastrar: Fim ↑.

        private void LimparCaixas()
        {
            TxtNomeFornecedor.Clear();
            TxtCnpj.Clear();
            TxtEmail.Clear();
            TxtTelefone.Clear();
            TxtCidade.Clear();
            TxtBairro.Clear();
        }

        // Código para alterar as cores dos botões: Começo ↓.

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

        // Código para alterar as cores dos botões: Fim ↑.
    }
}
