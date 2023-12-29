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
        public Fm_AreaRestrita()
        {
            InitializeComponent();
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
    }
}
