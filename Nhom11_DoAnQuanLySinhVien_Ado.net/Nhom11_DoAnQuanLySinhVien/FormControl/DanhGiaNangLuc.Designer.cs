namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    partial class DanhGiaNangLuc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhGiaNangLuc));
            this.chartTHHT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTimer = new System.Windows.Forms.Timer(this.components);
            this.dgvTHHT = new System.Windows.Forms.DataGridView();
            this.cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblDGNL = new System.Windows.Forms.Label();
            this.lblBieuDo = new System.Windows.Forms.Label();
            this.grbDiemTB = new System.Windows.Forms.GroupBox();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinhTichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartTHHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHHT)).BeginInit();
            this.grbDiemTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTHHT
            // 
            this.chartTHHT.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chartTHHT.BackSecondaryColor = System.Drawing.Color.White;
            this.chartTHHT.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chartTHHT.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartTHHT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTHHT.Legends.Add(legend1);
            this.chartTHHT.Location = new System.Drawing.Point(536, 158);
            this.chartTHHT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartTHHT.Name = "chartTHHT";
            this.chartTHHT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.SystemColors.ActiveCaption;
            series1.Legend = "Legend1";
            series1.Name = "Grade";
            this.chartTHHT.Series.Add(series1);
            this.chartTHHT.Size = new System.Drawing.Size(436, 352);
            this.chartTHHT.TabIndex = 0;
            this.chartTHHT.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // ChartTimer
            // 
            this.ChartTimer.Interval = 20;
            // 
            // dgvTHHT
            // 
            this.dgvTHHT.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTHHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTHHT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTHHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHHT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.TrungBinhTichLuy});
            this.dgvTHHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTHHT.EnableHeadersVisualStyles = false;
            this.dgvTHHT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTHHT.Location = new System.Drawing.Point(3, 25);
            this.dgvTHHT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTHHT.Name = "dgvTHHT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTHHT.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTHHT.RowHeadersWidth = 51;
            this.dgvTHHT.RowTemplate.Height = 24;
            this.dgvTHHT.Size = new System.Drawing.Size(482, 348);
            this.dgvTHHT.TabIndex = 2;
            // 
            // cbbNamHoc
            // 
            this.cbbNamHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNamHoc.FormattingEnabled = true;
            this.cbbNamHoc.Items.AddRange(new object[] {
            "ALL",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cbbNamHoc.Location = new System.Drawing.Point(145, 91);
            this.cbbNamHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Size = new System.Drawing.Size(92, 29);
            this.cbbNamHoc.TabIndex = 3;
            this.cbbNamHoc.Text = "ALL";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(34, 93);
            this.lblNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(88, 22);
            this.lblNam.TabIndex = 4;
            this.lblNam.Text = "Năm học:";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(271, 93);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(59, 22);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa:";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(355, 91);
            this.cbbKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(92, 29);
            this.cbbKhoa.TabIndex = 5;
            this.cbbKhoa.Text = "ALL";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(484, 79);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 52);
            this.btnTimKiem.TabIndex = 47;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblDGNL
            // 
            this.lblDGNL.AutoSize = true;
            this.lblDGNL.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGNL.ForeColor = System.Drawing.Color.Red;
            this.lblDGNL.Location = new System.Drawing.Point(336, 12);
            this.lblDGNL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDGNL.Name = "lblDGNL";
            this.lblDGNL.Size = new System.Drawing.Size(320, 32);
            this.lblDGNL.TabIndex = 48;
            this.lblDGNL.Text = "ĐÁNH GIÁ NĂNG LỰC";
            // 
            // lblBieuDo
            // 
            this.lblBieuDo.AutoSize = true;
            this.lblBieuDo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBieuDo.Location = new System.Drawing.Point(574, 517);
            this.lblBieuDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBieuDo.Name = "lblBieuDo";
            this.lblBieuDo.Size = new System.Drawing.Size(301, 21);
            this.lblBieuDo.TabIndex = 50;
            this.lblBieuDo.Text = "Biểu đồ Tình Hình Học Tập theo năm ";
            // 
            // grbDiemTB
            // 
            this.grbDiemTB.Controls.Add(this.dgvTHHT);
            this.grbDiemTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDiemTB.Location = new System.Drawing.Point(33, 147);
            this.grbDiemTB.Name = "grbDiemTB";
            this.grbDiemTB.Size = new System.Drawing.Size(488, 376);
            this.grbDiemTB.TabIndex = 51;
            this.grbDiemTB.TabStop = false;
            this.grbDiemTB.Text = "Điểm trung bình";
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MASV";
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // TrungBinhTichLuy
            // 
            this.TrungBinhTichLuy.DataPropertyName = "TrungBinhTichLuy";
            this.TrungBinhTichLuy.HeaderText = "Trung Bình Tích Lũy";
            this.TrungBinhTichLuy.MinimumWidth = 6;
            this.TrungBinhTichLuy.Name = "TrungBinhTichLuy";
            this.TrungBinhTichLuy.Width = 200;
            // 
            // DanhGiaNangLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grbDiemTB);
            this.Controls.Add(this.lblBieuDo);
            this.Controls.Add(this.lblDGNL);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.cbbNamHoc);
            this.Controls.Add(this.chartTHHT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DanhGiaNangLuc";
            this.Size = new System.Drawing.Size(974, 610);
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTHHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHHT)).EndInit();
            this.grbDiemTB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTHHT;
        private System.Windows.Forms.Timer ChartTimer;
        private System.Windows.Forms.DataGridView dgvTHHT;
        private System.Windows.Forms.ComboBox cbbNamHoc;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblDGNL;
        private System.Windows.Forms.Label lblBieuDo;
        private System.Windows.Forms.GroupBox grbDiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinhTichLuy;
    }
}
