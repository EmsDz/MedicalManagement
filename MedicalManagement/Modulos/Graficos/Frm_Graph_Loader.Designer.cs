namespace MedicalManagement.Modulos.Graficos
{
    partial class Frm_Graph_Loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbxGraficos = new System.Windows.Forms.ComboBox();
            this.gbxPacxdoc = new System.Windows.Forms.GroupBox();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lbxDoctores = new System.Windows.Forms.ListBox();
            this.BtnGenerarGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).BeginInit();
            this.gbxPacxdoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMainLogo
            // 
            this.picMainLogo.Location = new System.Drawing.Point(463, 11);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(0, 643);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Location = new System.Drawing.Point(472, 47);
            // 
            // LbxGraficos
            // 
            this.LbxGraficos.FormattingEnabled = true;
            this.LbxGraficos.Items.AddRange(new object[] {
            "Cantidad de pacientes por doctor",
            "graf 2",
            "graf 3",
            "graf 4",
            "graf 5",
            "graf 6"});
            this.LbxGraficos.Location = new System.Drawing.Point(21, 76);
            this.LbxGraficos.Name = "LbxGraficos";
            this.LbxGraficos.Size = new System.Drawing.Size(292, 21);
            this.LbxGraficos.TabIndex = 5;
            this.LbxGraficos.Text = "Seleccionar gráfico";
            this.LbxGraficos.SelectedIndexChanged += new System.EventHandler(this.LbxGraficos_SelectedIndexChanged);
            // 
            // gbxPacxdoc
            // 
            this.gbxPacxdoc.Controls.Add(this.lblMedicos);
            this.gbxPacxdoc.Controls.Add(this.lbxDoctores);
            this.gbxPacxdoc.Location = new System.Drawing.Point(10, 100);
            this.gbxPacxdoc.Name = "gbxPacxdoc";
            this.gbxPacxdoc.Size = new System.Drawing.Size(450, 200);
            this.gbxPacxdoc.TabIndex = 7;
            this.gbxPacxdoc.TabStop = false;
            this.gbxPacxdoc.Visible = false;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(15, 22);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(119, 13);
            this.lblMedicos.TabIndex = 8;
            this.lblMedicos.Text = "Selecciona los Medicos";
            // 
            // lbxDoctores
            // 
            this.lbxDoctores.DisplayMember = "Text";
            this.lbxDoctores.FormattingEnabled = true;
            this.lbxDoctores.Location = new System.Drawing.Point(11, 47);
            this.lbxDoctores.Name = "lbxDoctores";
            this.lbxDoctores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxDoctores.Size = new System.Drawing.Size(291, 147);
            this.lbxDoctores.TabIndex = 7;
            this.lbxDoctores.ValueMember = "Value";
            // 
            // BtnGenerarGraph
            // 
            this.BtnGenerarGraph.Location = new System.Drawing.Point(352, 76);
            this.BtnGenerarGraph.Name = "BtnGenerarGraph";
            this.BtnGenerarGraph.Size = new System.Drawing.Size(75, 21);
            this.BtnGenerarGraph.TabIndex = 8;
            this.BtnGenerarGraph.Text = "Generar";
            this.BtnGenerarGraph.UseVisualStyleBackColor = true;
            this.BtnGenerarGraph.Click += new System.EventHandler(this.BtnGenerarGraph_Click);
            // 
            // Frm_Graph_Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(534, 656);
            this.Controls.Add(this.BtnGenerarGraph);
            this.Controls.Add(this.gbxPacxdoc);
            this.Controls.Add(this.LbxGraficos);
            this.MinimumSize = new System.Drawing.Size(550, 410);
            this.Name = "Frm_Graph_Loader";
            this.Load += new System.EventHandler(this.Frm_Graph_Loader_Load);
            this.Controls.SetChildIndex(this.picMainLogo, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.PicBack, 0);
            this.Controls.SetChildIndex(this.ExportToExcel, 0);
            this.Controls.SetChildIndex(this.LbxGraficos, 0);
            this.Controls.SetChildIndex(this.gbxPacxdoc, 0);
            this.Controls.SetChildIndex(this.BtnGenerarGraph, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).EndInit();
            this.gbxPacxdoc.ResumeLayout(false);
            this.gbxPacxdoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LbxGraficos;
        private System.Windows.Forms.GroupBox gbxPacxdoc;
        private System.Windows.Forms.ListBox lbxDoctores;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Button BtnGenerarGraph;
    }
}
