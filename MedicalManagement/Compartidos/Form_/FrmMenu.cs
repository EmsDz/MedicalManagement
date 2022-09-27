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
            this.GoToFrmClosing=true;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Program.FrmMain = this;
        }

        private void picPatient_Click(object sender, EventArgs e)
        {
            MedicalManagement.Modulos.Patient.Frm_Patient frm_Patient = new Modulos.Patient.Frm_Patient();
            frm_Patient.Show();
            this.Hide();
        }

        private void PIcMedicos_Click(object sender, EventArgs e)
        {
            var medicos = new Modulos.Medicos.FrmMedicos();
            medicos.Show();
            this.Hide();
        }

        private void picFacturas_Click(object sender, EventArgs e)
        {
            var medicos = new Modulos.Facturas.FrmFact();
            medicos.Show();
            this.Hide();
        }
    }
}
