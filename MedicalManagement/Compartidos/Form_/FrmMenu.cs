using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Compartidos.Form_
{
    public partial class FrmMenu : Frm_Root
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.GoToFrmClosing = true;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Program.FrmMain = this;
        }

        private void PicPatient_Click(object sender, EventArgs e)
        {
            Modulos.Patient.Frm_Patient frm_Patient = new Modulos.Patient.Frm_Patient();
            frm_Patient.Show();
            this.Hide();
        }

        private void PicMedicos_Click(object sender, EventArgs e)
        {
            var medicos = new Modulos.Medicos.FrmMedicos();
            medicos.Show();
            this.Hide();
        }

        private void PicFacturas_Click(object sender, EventArgs e)
        {
            var facturas = new Modulos.Facturas.FrmFact();
            facturas.Show();
            this.Hide();
        }

        private void PicGraph_Click(object sender, EventArgs e)
        {
            var graficos = new Modulos.Graficos.Graficos();
            graficos.Show();
            this.Hide();
        }
    }
}
