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
    public partial class Graph_Templ : Frm_Graph
    {
        public Graph_Templ()
        {
            InitializeComponent();
            this.GoToFrmClosing = false;
        }

        public string[] vectorx;
        public string[] vectory;

        private void Graph_Load(object sender, EventArgs e) { }
    }
}
