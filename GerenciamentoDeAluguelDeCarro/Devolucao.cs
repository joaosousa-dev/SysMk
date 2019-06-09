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
    public partial class frmDevolucao : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SOUSA-PC;Initial Catalog=LocacaoDeCarro;User ID=sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        int dias;
        float valor;
        float preco;
        public frmDevolucao()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if (txtCodLocacao.Text != string.Empty)
                {
                    if (txtSituacaoLocacao.Text != "Devolvido")
                    {
                        if (txtCodCliente.Text == string.Empty && txtCodVeiculo.Text == string.Empty && txtCodFun.Text == string.Empty)
                        {
                            MessageBox.Show("Esta locação não existe!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            comando.CommandText = "UPDATE locacao SET situacao='Devolvido' WHERE cod_locacao='" + txtCodLocacao.Text + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE veiculo SET odometro='" + txtOdometroVeiculo.Text + "',tanque='" + cbTanqueVeiculo.Text + "',estado='" + cbEstadoVeiculo.Text + "',situacao='Disponivel' WHERE cod_veiculo='"+txtCodVeiculo.Text+"'";
                            comando.ExecuteNonQuery();
                            txtNomeCliente.Clear();
                            txtCnhCliente.Clear();
                            txtEnderecoCliente.Clear();
                            txtComplementoCliente.Clear();
                            txtCepCliente.Clear();
                            txtCidadeCliente.Clear();
                            txtCodCliente.Clear();
                            cbEstadoCliente.Text = "";
                            cbTipoCnh.Text = "";
                            txtCodVeiculo.Clear();
                            txtMarcaVeiculo.Clear();
                            txtModeloVeiculo.Clear();
                            txtCodCategoria.Clear();
                            cbCategoriaVeiculo.Text = "";
                            txtAnoVeiculo.Clear();
                            txtOdometroVeiculo.Clear();
                            txtNomeFun.Clear();
                            txtCodFun.Clear();
                            txtCodLocacao.Clear();
                            txtSituacaoLocacao.Clear();
                            MessageBox.Show("Veiculo Devolvido!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }else
                    {
                        MessageBox.Show("Este Veiculo Ja foi devolvido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o código da locação!", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            try
            {
               if (ckbDiasAMais.Checked)
                 {
                        SqlDataAdapter da;
                        da = new SqlDataAdapter("SELECT * FROM categoria WHERE cod_categoria=" + txtCodCategoria.Text, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        txtTaxaVeiculo.Text = dt.Rows[0]["preco"].ToString();
                        dias = int.Parse(txtDiasAMais.Text);
                        preco = float.Parse(txtTaxaVeiculo.Text);
                        valor = (dias * preco);
                        txtValoresAdicionais.Text = valor.ToString()+"R$";
                  }
                  else
                    {
                        MessageBox.Show("Não tem valores adicionais", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        
       }

        private void frmDevolucao_Load(object sender, EventArgs e)
        {

        }

        private void txtCodLocacao_TextChanged(object sender, EventArgs e)
        {
            if (txtCodLocacao.Text != string.Empty)
            {
                carregartxtLocacao();
                carregartxtFun();
                carregartxtCliente();
                carregartxtLVeiculo();
                txtSituacaoLocacao.Enabled = false;
                txtNomeCliente.Enabled = false;
                txtCnhCliente.Enabled = false;
                txtEnderecoCliente.Enabled = false;
                txtComplementoCliente.Enabled = false;
                txtCepCliente.Enabled = false;
                txtCidadeCliente.Enabled = false;
                cbEstadoCliente.Enabled = false;
                cbTipoCnh.Enabled = false;
                txtMarcaVeiculo.Enabled = false;
                txtModeloVeiculo.Enabled = false;
                txtAnoVeiculo.Enabled = false;
                cbCategoriaVeiculo.Enabled = false;
                txtCodCategoria.Enabled = false;
                txtCodVeiculo.Enabled = false;
                dtpLocacao.Enabled = false;
                dtpDevolucao.Enabled = false;
                txtCodCliente.Enabled = false;
                txtCodFun.Enabled=false;
                txtNomeFun.Enabled = false;
            }else
            {
                
                txtNomeCliente.Enabled = true;
                txtCnhCliente.Enabled = true;
                txtEnderecoCliente.Enabled = true;
                txtComplementoCliente.Enabled = true;
                txtCepCliente.Enabled = true;
                txtCidadeCliente.Enabled = true;
                cbEstadoCliente.Enabled = true;
                cbTipoCnh.Enabled = true;
                txtMarcaVeiculo.Enabled = true;
                txtModeloVeiculo.Enabled = true;
                txtAnoVeiculo.Enabled = true;
                cbCategoriaVeiculo.Enabled = true;
                txtCodCategoria.Enabled = true;
                txtCodVeiculo.Enabled = true;
                txtCodCliente.Enabled = true;
                txtNomeFun.Enabled = true;
                txtCodFun.Enabled = true;
                txtSituacaoLocacao.Enabled = true;
                txtNomeCliente.Clear();
                txtCnhCliente.Clear();
                txtEnderecoCliente.Clear();
                txtComplementoCliente.Clear();
                txtCepCliente.Clear();
                txtCidadeCliente.Clear();
                txtCodCliente.Clear();
                cbEstadoCliente.Text = "";
                cbTipoCnh.Text = "";
                txtCodVeiculo.Clear();
                txtMarcaVeiculo.Clear();
                txtModeloVeiculo.Clear();
                txtCodCategoria.Clear();
                cbCategoriaVeiculo.Text = "";
                txtAnoVeiculo.Clear();
                txtOdometroVeiculo.Clear();
                txtNomeFun.Clear();
                txtCodFun.Clear();
                txtSituacaoLocacao.Clear();
               
            }
        }
        public void carregartxtLocacao()
        {
            con.Open();
            try
            {
                if (txtCodLocacao.Text != string.Empty)
                {
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                    SqlDataReader dr;
                    da = new SqlDataAdapter("SELECT * FROM locacao WHERE cod_locacao=" + txtCodLocacao.Text, con);
                    da.Fill(dt);
                    txtCodCliente.Text = dt.Rows[0]["cod_cliente"].ToString();
                    txtCodVeiculo.Text = dt.Rows[0]["cod_veiculo"].ToString();
                    txtCodFun.Text = dt.Rows[0]["cod_fun"].ToString();
                    dtpDevolucao.Text = dt.Rows[0]["data_devolucao"].ToString();
                    dtpLocacao.Text= dt.Rows[0]["data_aluguel"].ToString();
                    txtSituacaoLocacao.Text = dt.Rows[0]["situacao"].ToString();

                }
                else
                {
                    txtCodFun.Clear();
                    txtCodCliente.Clear();
                    txtCodVeiculo.Clear();
                    txtSituacaoLocacao.Clear();
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

    
        }
        public void carregartxtCliente()
        {
            con.Open();
            try
            {
                if (txtCodLocacao.Text != string.Empty)
                {
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                    SqlDataReader dr;
                    da = new SqlDataAdapter("SELECT * FROM cliente WHERE cod_cliente=" + txtCodCliente.Text, con);
                    da.Fill(dt);
                    txtNomeCliente.Text = dt.Rows[0]["nome"].ToString();
                    txtCnhCliente.Text = dt.Rows[0]["cnh"].ToString();
                    cbTipoCnh.Text = dt.Rows[0]["tipo_cnh"].ToString();
                    txtEnderecoCliente.Text = dt.Rows[0]["endereço"].ToString();
                    txtCidadeCliente.Text = dt.Rows[0]["cidade"].ToString();
                    cbEstadoCliente.Text = dt.Rows[0]["estado"].ToString();
                    txtComplementoCliente.Text = dt.Rows[0]["complemento"].ToString();
                    txtCepCliente.Text = dt.Rows[0]["cep"].ToString();
                }
                else
                {
                    txtNomeCliente.Clear();
                    txtCnhCliente.Clear();
                    txtEnderecoCliente.Clear();
                    txtComplementoCliente.Clear();
                    cbEstadoCliente.Text = "";
                    cbTipoCnh.Text = "";
                    txtCidadeCliente.Clear();
                    txtCepCliente.Clear();
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }


        }
        public void carregartxtLVeiculo()
        {
            con.Open();
            try
            {
                if (txtCodLocacao.Text != string.Empty)
                {
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                    SqlDataReader dr;
                    da = new SqlDataAdapter("SELECT * FROM veiculo WHERE cod_veiculo=" + txtCodVeiculo.Text, con);
                    da.Fill(dt);
                    txtMarcaVeiculo.Text = dt.Rows[0]["marca"].ToString();
                    txtModeloVeiculo.Text = dt.Rows[0]["modelo"].ToString();
                    txtAnoVeiculo.Text = dt.Rows[0]["ano"].ToString();
                    txtCodCategoria.Text = dt.Rows[0]["cod_categoria"].ToString();
                    cbCategoriaVeiculo.Text = dt.Rows[0]["categoria"].ToString();
                    txtOdometroVeiculo.Text = dt.Rows[0]["odometro"].ToString();
                    cbTanqueVeiculo.Text = dt.Rows[0]["tanque"].ToString();
                    cbEstadoVeiculo.Text = dt.Rows[0]["estado"].ToString();
                }
                else
                {
                    txtCodFun.Clear();
                    txtCodCliente.Clear();
                    txtCodVeiculo.Clear();
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }


        }

        private void ckbDiasAMais_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDiasAMais.Checked)
            {
                txtDiasAMais.Enabled = true;
            }
            else
            {
                txtDiasAMais.Enabled = false;
                txtDiasAMais.Clear();
                txtValoresAdicionais.Text = "";
            }
        }

        private void ckbFaltandoPeca_CheckedChanged(object sender, EventArgs e)
        {
        }
        public void carregartxtFun()
        {
            con.Open();
            try
            {
                if (txtCodLocacao.Text != string.Empty)
                {
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                    SqlDataReader dr;
                    da = new SqlDataAdapter("SELECT * FROM funcionario WHERE cod_fun=" + txtCodFun.Text, con);
                    da.Fill(dt);
                    txtNomeFun.Text = dt.Rows[0]["nome"].ToString();
                }
                else
                {
                    txtNomeFun.Clear();
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }


        }
    }
}
