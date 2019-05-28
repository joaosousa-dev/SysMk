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
    public partial class frmCadastraVeiculo : Form
    {
        SqlConnection con = new SqlConnection("Data Source = SOUSA-PC; Initial Catalog = LocacaoDeCarro; User ID = sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        public frmCadastraVeiculo()
        {
            InitializeComponent();
            comando.Connection = con;
        }



        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            if (txtAnoCarro.Text == String.Empty || txtMarcaCarro.Text == String.Empty || txtModeloCarro.Text == String.Empty || txtPlacaCarro.Text == String.Empty || cbCategoriaCarro.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os campos vazios", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else

            {
                con.Open();
                comando.CommandText = "INSERT INTO veiculo (marca,modelo,ano,categoria,odometro,estado,placa) VALUES ('"+txtMarcaCarro.Text+"','"+txtModeloCarro.Text+"','"+int.Parse(txtAnoCarro.Text)+"','"+cbCategoriaCarro.Text+"','"+int.Parse(txtOdometroCarro.Text)+"','"+cbEstadoCarro.Text+"','"+txtPlacaCarro.Text+"')";
                comando.ExecuteNonQuery();
                txtAnoCarro.Clear();
                txtMarcaCarro.Clear();
                txtModeloCarro.Clear();
                txtOdometroCarro.Clear();
                txtPlacaCarro.Clear();
                cbCategoriaCarro.Text = "";
                cbEstadoCarro.Text = "";
                MessageBox.Show("Carro Cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                con.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
