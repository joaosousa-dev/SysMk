using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeAluguelDeCarro.Model;
using GerenciamentoDeAluguelDeCarro.Repositorio;

namespace GerenciamentoDeAluguelDeCarro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            controle controle = new controle();
            controle.acessar(txtUsuario.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
                if (controle.T)
                {
                    MessageBox.Show("Acesso Permitido", "Entrando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenu frm = new frmMenu(txtUsuario.Text);
                    frm.Show();
                    txtUsuario.Clear();
                    txtSenha.Clear(); 
                }
                else
                {
                    MessageBox.Show("usúario ou senha invalídos,Tente novamente!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show(controle.mensagem);
            }


        }

        private void cbxMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMostraSenha.Checked)
                txtSenha.UseSystemPasswordChar = false;
            else
                txtSenha.UseSystemPasswordChar = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
