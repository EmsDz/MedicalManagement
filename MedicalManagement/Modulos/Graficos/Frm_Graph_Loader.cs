using MedicalManagement.Compartidos;
using MedicalManagement.Compartidos.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedicalManagement.Modulos.Graficos
{
    public partial class Frm_Graph_Loader : Compartidos.Frm_Root
    {
        public Frm_Graph_Loader()
        {
            InitializeComponent();
        }

        private GroupBox GBoxInputs = new GroupBox();
        private string SelectedGraphName;

        private void Frm_Graph_Loader_Load(object sender, EventArgs e)
        {
            // Ajusta el size de la ventana
            this.Size = new Size(550, 410);

            // position 20 , 120
            // or 10 , 100 for the grbox

            // Llenar el select de medicos
            DataTable dt = Bd_Context.Fun_ejecutarScript("EXEC [Pr_MedicalNameGetAll]");
            List<object> items = new List<object>();

            foreach (DataRow row in dt.Rows)
            {
                items.Add(new ListBoxItem
                {
                    Text = row["nameComplete"].ToString(),
                    Value = row["Id"].ToIntObj()
                });
            }
            lbxDoctores.DataSource = items;
        }

        private void LbxGraficos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedGraphName = LbxGraficos.SelectedItem?.ToString() ?? "";

            GBoxInputs.Hide();

            switch (SelectedGraphName)
            {
                case "Cantidad de pacientes por doctor":
                    GBoxInputs = gbxPacxdoc;
                    break;
                default:
                    GBoxInputs = new GroupBox
                    {
                        Text = ""
                    };
                    break;
            }

            GBoxInputs.Location = new Point(10, 100);
            GBoxInputs.Show();
        }

        private void BtnGenerarGraph_Click(object sender, EventArgs e)
        {
            switch (SelectedGraphName)
            {
                case "Cantidad de pacientes por doctor":
                    ShowGraph("pac_x_doc");
                    break;
                default:
                    break;
            }
        }

        private void ShowGraph(string selected)
        {
            Form graph_ = selected switch
            {
                "pac_x_doc" => Pac_X_Doc(),
                _ => new Graph_Templ(),
            };

            graph_.Show();
        }

        private Form Pac_X_Doc()
        {
            // Utiliza el grafico como plantilla
            Graph_Templ templ_ = new Graph_Templ();
            List<int> medc_ids = new List<int>();
            string[] medc = Array.Empty<string>();
            List<string> cant_pac = new List<string>();

            // Obtiene el id de cada medico
            foreach (ListBoxItem id in lbxDoctores.SelectedItems) medc_ids.Add(id.Value);

            foreach (var m in medc_ids)
            {
                DataTable dt = Bd_Context.Fun_ejecutarScript($"EXEC [Pr_MedicalGetAllPatientsById] @Id_Medico ='{m}' ");
                medc = medc.Append(dt.Rows[0]["nameComplete"].ToString()).ToArray();
                cant_pac.Add(dt.Rows[0]["patients"].ToString());
            }

            templ_.vectorx = medc;
            templ_.vectory = cant_pac.ToArray();

            // cambiar la config de colores
            templ_.Graph_.Palette = ChartColorPalette.Pastel;
            templ_.Graph_.Titles["GfTitle"].Text = "Grafico de pasientes atendidos por cada doctor";

            Series serie = templ_.Graph_.Series["Serie"];
            serie.LegendText = "Cant. de Pacientes";

            for (int i = 0; i < templ_.vectorx.Length; i++)
            {
                serie.Points.AddXY(templ_.vectorx[i], templ_.vectory[i]);
                serie.Points[i].Label = templ_.vectory[i].ToString();
            }

            return templ_;
        }
    }
}
