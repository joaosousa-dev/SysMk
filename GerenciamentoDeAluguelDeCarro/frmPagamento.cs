using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GerenciamentoDeAluguelDeCarro
{
    public partial class frmPagamento : Form
    {
        SqlConnection con = new SqlConnection("Data Source = SOUSA-PC; Initial Catalog = LocacaoDeCarro; User ID = sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        
        public frmPagamento()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao frm = new frmLocacao();
            frm.Show();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if ((rbAvista.Checked == false && rbCredito.Checked == false && rbDebito.Checked == false ) || txtCodLocacao.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o método de pagamento e o código da locação", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (rbAvista.Checked)
                    {
                        comando.CommandText = "UPDATE locacao SET situacao_pagamento='Pago a Vista' WHERE cod_locacao='" + txtCodLocacao.Text + "'";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Locação Paga!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbAvista.Checked = false;
                        rbCredito.Checked = false;
                        rbDebito.Checked = false;
                    }
                    else if (rbCredito.Checked)
                    {
                        comando.CommandText = "UPDATE locacao SET situacao_pagamento='Pago Com cartão de crédito' WHERE cod_locacao='" + txtCodLocacao.Text + "'";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Locação Paga!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbAvista.Checked = false;
                        rbCredito.Checked = false;
                        rbDebito.Checked = false;
                    }
                    else
                    {
                        comando.CommandText = "UPDATE locacao SET situacao_pagamento='Pago Com cartão de crédito' WHERE cod_locacao='" + txtCodLocacao.Text + "'";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Locação Paga!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbAvista.Checked = false;
                        rbCredito.Checked = false;
                        rbDebito.Checked = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            }
    }
}
