namespace MedicalManagement.Modulos.Graficos
{
    partial class Graficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grfPacientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // picMainLogo
            // 
            this.picMainLogo.Location = new System.Drawing.Point(638, 10);
            this.picMainLogo.Size = new System.Drawing.Size(60, 30);
            // 
            // PicBack
            // 
            this.PicBack.Location = new System.Drawing.Point(12, 10);
            // 
            // grfPacientes
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "GfArea";
            this.grfPacientes.ChartAreas.Add(chartArea1);
            legend1.Name = "GfLegend";
            this.grfPacientes.Legends.Add(legend1);
            this.grfPacientes.Location = new System.Drawing.Point(94, 73);
            this.grfPacientes.Name = "grfPacientes";
            this.grfPacientes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "GfArea";
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.Legend = "GfLegend";
            series1.Name = "Pacientes";
            this.grfPacientes.Series.Add(series1);
            this.grfPacientes.Size = new System.Drawing.Size(515, 304);
            this.grfPacientes.TabIndex = 3;
            this.grfPacientes.Text = "chart1";
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.grfPacientes);
            this.Name = "Graficos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.picMainLogo, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.PicBack, 0);
            this.Controls.SetChildIndex(this.grfPacientes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grfPacientes;
    }
}
