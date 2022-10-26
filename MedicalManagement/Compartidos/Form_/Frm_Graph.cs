using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedicalManagement.Compartidos
{
    public partial class Frm_Graph : Frm_Root
    {
        public Frm_Graph()
        {
            InitializeComponent();
            this.GoToFrmClosing = true;
        }

        private void Frm_Graph_Load(object sender, EventArgs e)
        {
        }

        private void ExportToPdf_Click(object sender, EventArgs e)
        {
            SavePdf.InitialDirectory = "%userprofile%\\documents";
            SavePdf.Title = "Exportar a Pdf";
            SavePdf.FileName = "";
            SavePdf.Filter = "|*.pdf";

            if (SavePdf.ShowDialog() != DialogResult.Cancel)
            {
                PdfDocument Doc = new PdfDocument();
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    Graph_.SaveImage(memoryStream, ChartImageFormat.Png);
                    XImage xImg = XImage.FromStream(memoryStream);
                    PdfPage page = Doc.AddPage();
                    XGraphics xGraphics = XGraphics.FromPdfPage(page);
                    xGraphics.DrawImage(xImg, 30, 100);
                    string fileName = SavePdf.FileName.ToString();
                    Doc.Save(fileName);
                    Doc.Close();
                }
            }
        }
    }
}
