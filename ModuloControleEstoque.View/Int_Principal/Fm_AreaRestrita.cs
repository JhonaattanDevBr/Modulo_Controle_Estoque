﻿using System;
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
            pnlMenuDireita.Visible = true;
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
            pnlMenuDireita.Visible = true;
            gpbGrupoBotoes.Visible = true; gpbGrupoBotoes.Text = "Realizar Consulta";
            btnBotaoUm.Visible = true; btnBotaoUm.Text = "Forncedores";
            btnBotaoDois.Visible = true; btnBotaoDois.Text = "Matérias Primas";
            btnBotaoTres.Visible = true; btnBotaoTres.Text = "Produtos";
            btnBotaoQuatro.Visible = true; btnBotaoQuatro.Text = "Entrada MP";
            btnBotaoCinco.Visible = true; btnBotaoCinco.Text = "Entrada Produtos";
            btnBotaoSeis.Visible = true; btnBotaoSeis.Text = "Saída Produtos";
        }

        // Cores dos botões superiores
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
    }
}