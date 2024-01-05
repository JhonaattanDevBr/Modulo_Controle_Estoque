using ModuloControleEstoque.View.UserC_Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloControleEstoque.View.Int_Principal
{
    public partial class Fm_AreaRestrita : Form
    {
        public Fm_AreaRestrita(string nomeUsuario)
        {
            InitializeComponent();
            lblNomeUsuario.Text = nomeUsuario;
        }

        private void btnCadastro_MouseEnter(object sender, EventArgs e)
        {
            btnCadastro.BackColor = Color.BurlyWood;
        }

        private void btnCadastro_MouseLeave(object sender, EventArgs e)
        {
            btnCadastro.BackColor = SystemColors.Window;
        }

        private void btnConsultas_MouseEnter(object sender, EventArgs e)
        {
            btnConsultas.BackColor = Color.BurlyWood;
        }

        private void btnConsultas_MouseLeave(object sender, EventArgs e)
        {
            btnConsultas.BackColor = SystemColors.Window;
        }

        private void btnAjuda_MouseEnter(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.BurlyWood;
        }

        private void btnAjuda_MouseLeave(object sender, EventArgs e)
        {
            btnAjuda.BackColor = SystemColors.Window;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.BurlyWood;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = SystemColors.Window;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseseja encerrar o programa?", "ATENÇÃO", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseseja encerrar o programa?", "ATENÇÃO", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            gpbGrupoBotoes.Visible = true; gpbGrupoBotoes.Text = "Novo Cadastro";
            btnBotaoUm.Visible = true; btnBotaoUm.Text = "Fornecedor";
            btnBotaoDois.Visible = true; btnBotaoDois.Text = "Matéria Prima";
            btnBotaoTres.Visible = true; btnBotaoTres.Text = "Produto";
            btnBotaoQuatro.Visible = false; btnBotaoQuatro.Text = "Botão 4";
            btnBotaoCinco.Visible = false; btnBotaoCinco.Text = "Botão 5";
            btnBotaoSeis.Visible = false; btnBotaoSeis.Text = "Botão 6";
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            gpbGrupoBotoes.Visible = true; gpbGrupoBotoes.Text = "Realizar Consulta";
            btnBotaoUm.Visible = true; btnBotaoUm.Text = "Forncedores";
            btnBotaoDois.Visible = true; btnBotaoDois.Text = "Matérias Primas";
            btnBotaoTres.Visible = true; btnBotaoTres.Text = "Produtos";
            btnBotaoQuatro.Visible = true; btnBotaoQuatro.Text = "Entrada MP";
            btnBotaoCinco.Visible = true; btnBotaoCinco.Text = "Entrada Produtos";
            btnBotaoSeis.Visible = true; btnBotaoSeis.Text = "Saída Produtos";
        }

        // Cores dos botões superiores otário
        private void btnBotaoUm_MouseEnter(object sender, EventArgs e)
        {
            btnBotaoUm.BackColor = Color.BurlyWood;

        }

        private void btnBotaoUm_MouseLeave(object sender, EventArgs e)
        {
            btnBotaoUm.BackColor = SystemColors.Window;

        }

        private void btnBotaoDois_MouseEnter(object sender, EventArgs e)
        {
            btnBotaoDois.BackColor = Color.BurlyWood;
        }

        private void btnBotaoDois_MouseLeave(object sender, EventArgs e)
        {
            btnBotaoDois.BackColor = SystemColors.Window;
        }

        private void btnBotaoTres_MouseEnter(object sender, EventArgs e)
        {
            btnBotaoTres.BackColor = Color.BurlyWood;
        }

        private void btnBotaoTres_MouseLeave(object sender, EventArgs e)
        {
            btnBotaoTres.BackColor = SystemColors.Window;
        }

        private void btnBotaoQuatro_MouseEnter(object sender, EventArgs e)
        {
            btnBotaoQuatro.BackColor = Color.BurlyWood;
        }

        private void btnBotaoQuatro_MouseLeave(object sender, EventArgs e)
        {
            btnBotaoQuatro.BackColor = SystemColors.Window;
        }

        private void btnBotaoCinco_MouseEnter(object sender, EventArgs e)
        {
            btnBotaoCinco.BackColor = Color.BurlyWood;
        }

        private void btnBotaoCinco_MouseLeave(object sender, EventArgs e)
        {
            btnBotaoCinco.BackColor = SystemColors.Window;
        }

        private void btnBotaoSeis_MouseEnter(object sender, EventArgs e)
        {
            btnBotaoSeis.BackColor = Color.BurlyWood;
        }

        private void btnBotaoSeis_MouseLeave(object sender, EventArgs e)
        {
            btnBotaoSeis.BackColor = SystemColors.Window;
        }


        // Preciso rever todo esse código ↓↓↓
        private void MostrarFormulario(string formulario)
        {
            switch (formulario)
            {
                case "Fornecedor":
                    Cad_Fornecedores _Fornecedor = new Cad_Fornecedores();
                    pnlExibir.Controls.Clear();
                    _Fornecedor.Dock = DockStyle.Fill;
                    pnlExibir.Controls.Add(_Fornecedor);
                    break;

                case "Matéria Prima":
                    Cad_MateriaP _MateriaP = new Cad_MateriaP();
                    pnlExibir.Controls.Clear();
                    _MateriaP.Dock = DockStyle.Fill;
                    pnlExibir.Controls.Add(_MateriaP);
                    break;

                case "Produto":
                    Cad_Produtos _Produto = new Cad_Produtos();
                    pnlExibir.Controls.Clear();
                    _Produto.Dock = DockStyle.Fill;
                    pnlExibir.Controls.Add(_Produto);
                    break;

                case "Forncedores":
                    Con_Fornecedores _Fornecedores = new Con_Fornecedores();
                    pnlExibir.Controls.Clear();
                    _Fornecedores.Dock = DockStyle.Fill;
                    pnlExibir.Controls.Add(_Fornecedores);
                    break;

                case "Matérias Primas":
                    Con_MateriasPrimas _MateriasPrimas = new Con_MateriasPrimas();
                    pnlExibir.Controls.Clear();
                    _MateriasPrimas.Dock = DockStyle.Fill;
                    pnlExibir.Controls.Add(_MateriasPrimas);
                    break;

                case "Produtos":
                    Con_Produtos _Produtos = new Con_Produtos();
                    pnlExibir.Controls.Clear();
                    _Produtos.Dock = DockStyle.Fill;
                    pnlExibir.Controls.Add(_Produtos);
                    break;

                case "Entrada MP":
                    Con_EntradaMP _EntradaMP = new Con_EntradaMP();
                    pnlExibir.Controls.Clear();
                    _EntradaMP.Dock = DockStyle.Fill;
                    pnlExibir.Controls.Add(_EntradaMP);
                    break;

                case "Entrada Produtos":
                    Con_EntradaProdutos _EntradaProdutos = new Con_EntradaProdutos();
                    pnlExibir.Controls.Clear();
                    _EntradaProdutos.Dock = DockStyle.Fill;
                    pnlExibir.Controls.Add(_EntradaProdutos);
                    break;

                default:
                    break;
            }
        }

        private void btnBotaoUm_Click(object sender, EventArgs e)
        {
            string formularioParaExibir = btnBotaoUm.Text;
            if (pnlExibir.Visible && pnlExibir.Controls.Count > 0)
            {
                DialogResult alterarFuncao =  MessageBox.Show("Sair agora irá encerrar qualquer processo que não tenha sido concluído.\nDeseja Continuar?", "ATENÇÃO",
                                                               MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Question);
                if(alterarFuncao == DialogResult.Yes)
                {
                    pnlExibir.Visible = true;
                    pnlExibir.Dock = DockStyle.Fill;
                    MostrarFormulario(formularioParaExibir);
                    //btnBotaoUm.Enabled = false; btnBotaoDois.Enabled = true; btnBotaoTres.Enabled = true; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

                }
            }
            else
            {
                pnlExibir.Visible = true;
                pnlExibir.Dock = DockStyle.Fill;
                MostrarFormulario(formularioParaExibir);
                //btnBotaoUm.Enabled = false; btnBotaoDois.Enabled = true; btnBotaoTres.Enabled = true; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

            }
        }

        private void btnBotaoDois_Click(object sender, EventArgs e)
        {
            string formularioParaExibir = btnBotaoDois.Text;
            if (pnlExibir.Visible && pnlExibir.Controls.Count > 0)
            {
                DialogResult alterarFuncao = MessageBox.Show("Sair agora irá encerrar qualquer processo que não tenha sido concluído.\nDeseja Continuar?", "ATENÇÃO",
                                                               MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Question);
                if(alterarFuncao == DialogResult.Yes)
                {
                    pnlExibir.Visible = true;
                    pnlExibir.Dock = DockStyle.Fill;
                    MostrarFormulario(formularioParaExibir);
                    //btnBotaoUm.Enabled = true; btnBotaoDois.Enabled = false; btnBotaoTres.Enabled = true; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

                }
            }
            else
            {
                pnlExibir.Visible = true;
                pnlExibir.Dock = DockStyle.Fill;
                MostrarFormulario(formularioParaExibir);
                //btnBotaoUm.Enabled = true; btnBotaoDois.Enabled = false; btnBotaoTres.Enabled = true; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

            }
        }

        private void btnBotaoTres_Click(object sender, EventArgs e)
        {
            string formularioParaExibir = btnBotaoTres.Text;
            if (pnlExibir.Visible && pnlExibir.Controls.Count > 0)
            {
                DialogResult alterarFuncao = MessageBox.Show("Sair agora irá encerrar qualquer processo que não tenha sido concluído.\nDeseja Continuar?", "ATENÇÃO",
                                                               MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Question);
                if(alterarFuncao == DialogResult.Yes)
                {
                    pnlExibir.Visible = true;
                    pnlExibir.Dock = DockStyle.Fill;
                    MostrarFormulario(formularioParaExibir);
                    //btnBotaoUm.Enabled = true; btnBotaoDois.Enabled = true; btnBotaoTres.Enabled = false; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

                }
            }
            else
            {
                pnlExibir.Visible = true;
                pnlExibir.Dock = DockStyle.Fill;
                MostrarFormulario(formularioParaExibir);
                //btnBotaoUm.Enabled = true; btnBotaoDois.Enabled = true; btnBotaoTres.Enabled = false; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

            }
        }

        private void btnBotaoQuatro_Click(object sender, EventArgs e)
        {
            string formularioParaExibir = btnBotaoQuatro.Text;
            if (pnlExibir.Visible && pnlExibir.Controls.Count > 0)
            {
                DialogResult alterarFuncao = MessageBox.Show("Sair agora irá encerrar qualquer processo que não tenha sido concluído.\nDeseja Continuar?", "ATENÇÃO",
                                                               MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Question);
                if (alterarFuncao == DialogResult.Yes)
                {
                    pnlExibir.Visible = true;
                    pnlExibir.Dock = DockStyle.Fill;
                    MostrarFormulario(formularioParaExibir);
                    //btnBotaoUm.Enabled = true; btnBotaoDois.Enabled = true; btnBotaoTres.Enabled = false; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

                }
            }
            else
            {
                pnlExibir.Visible = true;
                pnlExibir.Dock = DockStyle.Fill;
                MostrarFormulario(formularioParaExibir);
                //btnBotaoUm.Enabled = true; btnBotaoDois.Enabled = true; btnBotaoTres.Enabled = false; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

            }
        }

        private void btnBotaoCinco_Click(object sender, EventArgs e)
        {
            string formularioParaExibir = btnBotaoCinco.Text;
            if (pnlExibir.Visible && pnlExibir.Controls.Count > 0)
            {
                DialogResult alterarFuncao = MessageBox.Show("Sair agora irá encerrar qualquer processo que não tenha sido concluído.\nDeseja Continuar?", "ATENÇÃO",
                                                               MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Question);
                if (alterarFuncao == DialogResult.Yes)
                {
                    pnlExibir.Visible = true;
                    pnlExibir.Dock = DockStyle.Fill;
                    MostrarFormulario(formularioParaExibir);
                    //btnBotaoUm.Enabled = true; btnBotaoDois.Enabled = true; btnBotaoTres.Enabled = false; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

                }
            }
            else
            {
                pnlExibir.Visible = true;
                pnlExibir.Dock = DockStyle.Fill;
                MostrarFormulario(formularioParaExibir);
                //btnBotaoUm.Enabled = true; btnBotaoDois.Enabled = true; btnBotaoTres.Enabled = false; btnBotaoQuatro.Enabled = true; btnBotaoCinco.Enabled = true; btnSair.Enabled = true;

            }
        }
    }
}
