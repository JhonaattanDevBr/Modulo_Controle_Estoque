using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloControleEstoque.Controle;
using ModuloControleEstoque.Modelo;

namespace ModuloControleEstoque.View
{
    public partial class Fm_Login : Form
    {
        Mdl_Usuario _mdlUsuario = new Mdl_Usuario();
        Ctl_Usuario _ctlUsuario = new Ctl_Usuario();

        public Fm_Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.BurlyWood;
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {

            txtSenha.BackColor = Color.BurlyWood;
            txtSenha.ForeColor = Color.Black;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = SystemColors.Window;
            txtSenha.ForeColor = Color.Black;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.BurlyWood;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.Window;
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
            if(sair == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _mdlUsuario.Usuario = txtUsuario.Text;
            _mdlUsuario.Senha = txtSenha.Text;
            bool retornoAutLogin = _mdlUsuario.RealizarLogin();
            if (retornoAutLogin)
            {
                bool retornoLogin = _ctlUsuario.ConsultarUsuario(_mdlUsuario);
                if (retornoLogin)
                {
                    MessageBox.Show("Login realizado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Login não realizado os dados estão incorretos.", "Falha ao acessar o sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos.", "Falha ao acessar o sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                txtUsuario.SelectAll();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnLogin_Click(sender, e);
            }
        }
    }
}
