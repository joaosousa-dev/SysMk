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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbcarrega.Value < 100)
            {
                pbcarrega.Value = pbcarrega.Value + 2;

            }else
            {
                timer1.Enabled = false;
                this.Visible = false;
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }
    }
}
