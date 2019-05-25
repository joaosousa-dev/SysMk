using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeAluguelDeCarro
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            frmCarros frm = new frmCarros();
            frm.Show();
        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            frmLocacao frm = new frmLocacao();
            frm.Show();
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            frmDevolucao frm = new frmDevolucao();
            frm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void btnCategoriasDeVeiculos_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionarios frm = new frmCadastrarFuncionarios();
            frm.Show();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento frm = new frmPagamento();
            frm.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" SysMk ltda \n Version - 1.0 alpha \n ® all rights reserved","About" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraVeiculo frm = new frmCadastraVeiculo();
            frm.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente frm = new frmCadastrarCliente();
            frm.Show();
        }

        private void carrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionarios frm = new frmCadastrarFuncionarios();
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCategoria frm = new frmCadastrarCategoria();
            frm.Show();
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarros frm = new frmCarros();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionarios frm = new frmCadastrarFuncionarios();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.Show();
        }
    }
}
