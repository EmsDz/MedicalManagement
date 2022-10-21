using MedicalManagement.Compartidos;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedicalManagement.Modulos.Graficos
{
    public partial class Graficos : MedicalManagement.Compartidos.Frm_Root
    {
        public Graficos()
        {
            InitializeComponent();
            this.GoToFrmClosing = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var medc_ids = new List<int> { 33, 34, 1034, 1035 };
            DataTable dt = new DataTable();
            string[] medc = Array.Empty<string>();
            List<string> cant_pac = new List<string>();

            foreach (var m in medc_ids)
            {
                dt = Bd_Context.Fun_ejecutarScript($"EXEC [Pr_MedicalGetAllPatientsById] @Id_Medico ='{m}' ");
                medc = medc.Append(dt.Rows[0]["nameComplete"].ToString()).ToArray();
                cant_pac.Add(dt.Rows[0]["patients"].ToString());
            }

            // los vectores con los datos
            //string[] vectorx = { "trat1", "trat2", "trat3" };
            //int[] vectory = { 4, 5, 10 };
            string[] vectorx = medc;
            string[] vectory = cant_pac.ToArray();

            // cambiar la config de colores
            grfPacientes.Palette = ChartColorPalette.Pastel;
            grfPacientes.Titles.Add("Grafico de pasientes atendidos por  cada doctor");

            //Series serie = grfPacientes.Series.Add("Pacientes");
            Series serie = grfPacientes.Series["Pacientes"];
            for (int i = 0; i < vectorx.Length; i++)
            {
                // titulos
                //Series serie = grfTratamt.Series.Add(vectorx[i]);

                // valores
                //serie.Label = vectory[i].ToString();
                //serie.Points.Add(int.Parse(vectory[i]));
                serie.Points.AddXY(vectorx[i], vectory[i]);
                serie.Points[i].Label = vectory[i].ToString();
            }
        }
    }
}
