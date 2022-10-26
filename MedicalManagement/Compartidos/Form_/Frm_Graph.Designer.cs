namespace MedicalManagement.Compartidos
{
    partial class Frm_Graph
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Graph));
            this.Graph_ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExportToPdf = new System.Windows.Forms.PictureBox();
            this.SavePdf = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // picMainLogo
            // 
            this.picMainLogo.Location = new System.Drawing.Point(610, 10);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(0, 448);
            // 
            // PicBack
            // 
            this.PicBack.Location = new System.Drawing.Point(12, 10);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Location = new System.Drawing.Point(597, 323);
            // 
            // Graph_
            // 
            this.Graph_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.Name = "GfArea";
            this.Graph_.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "GfLegend";
            this.Graph_.Legends.Add(legend1);
            this.Graph_.Location = new System.Drawing.Point(32, 45);
            this.Graph_.MinimumSize = new System.Drawing.Size(550, 400);
            this.Graph_.Name = "Graph_";
            this.Graph_.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.Graph_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "GfArea";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.Legend = "GfLegend";
            series1.Name = "Serie";
            this.Graph_.Series.Add(series1);
            this.Graph_.Size = new System.Drawing.Size(550, 400);
            this.Graph_.TabIndex = 3;
            this.Graph_.Text = "Chart_";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "GfTitle";
            this.Graph_.Titles.Add(title1);
            // 
            // ExportToPdf
            // 
            this.ExportToPdf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportToPdf.BackColor = System.Drawing.Color.Aquamarine;
            this.ExportToPdf.Enabled = false;
            this.ExportToPdf.Image = ((System.Drawing.Image)(resources.GetObject("ExportToPdf.Image")));
            this.ExportToPdf.Location = new System.Drawing.Point(597, 388);
            this.ExportToPdf.Name = "ExportToPdf";
            this.ExportToPdf.Size = new System.Drawing.Size(50, 50);
            this.ExportToPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExportToPdf.TabIndex = 5;
            this.ExportToPdf.TabStop = false;
            this.ExportToPdf.Visible = false;
            this.ExportToPdf.Click += new System.EventHandler(this.ExportToPdf_Click);
            // 
            // Frm_Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.ExportToPdf);
            this.Controls.Add(this.Graph_);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Frm_Graph";
            this.Load += new System.EventHandler(this.Frm_Graph_Load);
            this.Controls.SetChildIndex(this.Graph_, 0);
            this.Controls.SetChildIndex(this.ExportToExcel, 0);
            this.Controls.SetChildIndex(this.picMainLogo, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.PicBack, 0);
            this.Controls.SetChildIndex(this.ExportToPdf, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToPdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart Graph_;
        public System.Windows.Forms.PictureBox ExportToPdf;
        private System.Windows.Forms.SaveFileDialog SavePdf;
    }
}
