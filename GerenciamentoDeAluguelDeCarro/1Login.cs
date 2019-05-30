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
                    MessageBox.Show("Logado com sucesso", "entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMenu frm = new frmMenu();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("usúario/senha invalídos", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show(controle.mensagem);
            }


        }
    }
}
