using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;

namespace GerenciamentoDeAluguelDeCarro
{
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void _4Locacao_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCarros frm = new frmCarros();
            frm.Show();
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
             
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();//adicionando as configuracoes
            string caminho = @"D:\Users\Celso\Desktop\joao\###Prototipo Sistema GLV\SysMk\Contratos\" + "CONTRATO"+txtCodCliente.Text+".pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
         try
            {
                doc.Open();
                Paragraph paragrafo = new Paragraph("    Eu, "+txtNomeCliente.Text+", Cnh: "+txtCnhCliente.Text+ ",Inscrito no CPF: ___.___.___-__ E RG______________ residente e domiciliado(a) à "+txtEnderecoCliente.Text+", na cidade de "+txtCidadeCliente.Text+" - "+cbEstadoCliente.Text+ ",por meio deste instrumento declaro me responsabilizar pela conservação de um Veiculo "+txtModeloVeiculo.Text+ ".\n    Me comprometo a devolver o mencionado bem em perfeito estado de conservação, como atualmente se encontra, ao fim do prazo estabelecido.\n    Em caso de extravio ou danos que provoquem a perda total ou parcial do bem, fico obrigado a ressarcir o proprietário dos prejuízos ocasionados.\n\n\n"+dtpLocacao.Text+"\n\nAssinatura:\n_____________________________________\n\n\n\nAtesto que o bem foi devolvido em "+dtpDevolucao.Text+", Nas seguintes condições: \n\n(_)Perfeito Estado\n(_)Com Defeitos\n(_)Faltando peças /acessórios\n");
                doc.Add(paragrafo);
                MessageBox.Show("Contrato Gerado Com sucesso!","Contrato",MessageBoxButtons.OK,MessageBoxIcon.Information);
                doc.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }
    }
}
