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
    public partial class FrmAudit : Frm_Root
    {
        public FrmAudit()
        {
            InitializeComponent();
        }

        public string query = "";


        /// <summary>
        /// Muestra un query en  en un dgv
        /// </summary>
        /// <param name="Query"></param>
        public void ShowData()
        {
            try
            {
                dgvAuditoria.DataSource = Bd_Context.Fun_ejecutarScript(query, false);
            }
            catch (Exception ex)
            {
            }
        }

        private void FrmAudit_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
