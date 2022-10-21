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
        public DataGridView dtGridView;
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
            this.GoToFrmClosing = false;
            C_Utility.Fun_ShowFrmMain(this);
        }

        private void Frm_Root_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GoToFrmClosing == true)
                Compartidos.C_Utility.Fun_ExitApp();
        }

        /// <summary>
        /// Exporta una tabla a excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            SaveExcel.InitialDirectory = "%userprofile%\\documents";
            SaveExcel.Title = "Exportar a Excel";
            SaveExcel.FileName = "";
            SaveExcel.Filter = "|*.xlsx|Excel 2003|*.xls";

            if (SaveExcel.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                /// store header
                /// Coloca los encabezados
                for (int i = 1; i < dtGridView.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dtGridView.Columns[i - 1].HeaderText;
                }
                /// Rellena la tabla
                for (int i = 0; i < dtGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dtGridView.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dtGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(SaveExcel.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }
    }
}
