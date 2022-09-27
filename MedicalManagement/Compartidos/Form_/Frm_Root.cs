using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Compartidos
{
    public partial class Frm_Root : Form
    {
        public Frm_Root()
        {
            InitializeComponent();
        }
        public bool GoToFrmClosing = false;
        /// <summary>
        /// Variables para actiones 
        /// </summary>
        public enum Actions
        {
            Create = 1,
            Update = 2,
            Search = 3,
            Exit = 4,
        }

        public Actions VarAtions = Actions.Create;

        public string Menssage = "";
        public bool ColorError = false;

        private void PicBack_Click(object sender, EventArgs e)
        {
        
            ///Cierra el actual y abre el menu
            Compartidos.C_Utility.Fun_ShowFrmMain(this);
        }

        private void Frm_Root_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GoToFrmClosing == true)
                Compartidos.C_Utility.Fun_ExitApp();
        }
    }
}
