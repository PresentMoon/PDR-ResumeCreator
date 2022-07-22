using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Experiment
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"C:/Try/Pdf.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph(TextBox1.Text + "Miks");
            doc.Add(p1);
            doc.Close();
            MessageBox.Show("Done");
        }
    }
}