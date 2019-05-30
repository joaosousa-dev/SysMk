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
                Paragraph paragrafo = new Paragraph("Código Do cliente :"+txtCodCliente.Text+"\n"+"Nome do cliente: "+txtNomeCliente.Text);
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
