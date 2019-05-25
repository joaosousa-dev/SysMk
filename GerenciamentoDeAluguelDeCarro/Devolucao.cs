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
    public partial class frmDevolucao : Form
    {
        public frmDevolucao()
        {
            InitializeComponent();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento frm = new frmPagamento();
            frm.Show();
        }
    }
}
