namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    partial class SoLuongSinhVienTheoKhoa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSVTK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbltittle = new System.Windows.Forms.Label();
            this.lblBDSVTK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSVTK)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSVTK
            // 
            chartArea4.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea4.Name = "ChartArea1";
            this.chartSVTK.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSVTK.Legends.Add(legend4);
            this.chartSVTK.Location = new System.Drawing.Point(0, 93);
            this.chartSVTK.Name = "chartSVTK";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Số SV";
            this.chartSVTK.Series.Add(series4);
            this.chartSVTK.Size = new System.Drawing.Size(974, 442);
            this.chartSVTK.TabIndex = 0;
            this.chartSVTK.Text = "Số lượng Sinh Viên theo Khoa";
            this.chartSVTK.Click += new System.EventHandler(this.chartSVTK_Click);
            // 
            // lbltittle
            // 
            this.lbltittle.AutoSize = true;
            this.lbltittle.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltittle.ForeColor = System.Drawing.Color.Red;
            this.lbltittle.Location = new System.Drawing.Point(149, 19);
            this.lbltittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltittle.Name = "lbltittle";
            this.lbltittle.Size = new System.Drawing.Size(664, 32);
            this.lbltittle.TabIndex = 49;
            this.lbltittle.Text = "    BIỂU ĐỒ SỐ LƯỢNG SINH VIÊN THEO KHOA";
            // 
            // lblBDSVTK
            // 
            this.lblBDSVTK.AutoSize = true;
            this.lblBDSVTK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDSVTK.Location = new System.Drawing.Point(347, 538);
            this.lblBDSVTK.Name = "lblBDSVTK";
            this.lblBDSVTK.Size = new System.Drawing.Size(296, 21);
            this.lblBDSVTK.TabIndex = 50;
            this.lblBDSVTK.Text = "Biểu đồ số lượng Sinh Viên theo Khoa";
            // 
            // SoLuongSinhVienTheoKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblBDSVTK);
            this.Controls.Add(this.lbltittle);
            this.Controls.Add(this.chartSVTK);
            this.Name = "SoLuongSinhVienTheoKhoa";
            this.Size = new System.Drawing.Size(974, 610);
            this.Load += new System.EventHandler(this.SoLuongSinhVienTheoKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSVTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSVTK;
        private System.Windows.Forms.Label lbltittle;
        private System.Windows.Forms.Label lblBDSVTK;
    }
}
