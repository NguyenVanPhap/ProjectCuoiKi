namespace Nhom11_DoAnQuanLySinhVien
{
    partial class ReportDanhSachLop
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDanhSachLop));
            this.LopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyDiemSinhVien = new Nhom11_DoAnQuanLySinhVien.QuanLyDiemSinhVien();
            this.rpvDSL = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlTittlebar = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.LopTableAdapter = new Nhom11_DoAnQuanLySinhVien.QuanLyDiemSinhVienTableAdapters.LopTableAdapter();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyDiemSinhVien)).BeginInit();
            this.pnlTittlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LopBindingSource
            // 
            this.LopBindingSource.DataMember = "Lop";
            this.LopBindingSource.DataSource = this.QuanLyDiemSinhVien;
            // 
            // QuanLyDiemSinhVien
            // 
            this.QuanLyDiemSinhVien.DataSetName = "QuanLyDiemSinhVien";
            this.QuanLyDiemSinhVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvDSL
            // 
            reportDataSource1.Name = "DataSetLopHoc";
            reportDataSource1.Value = this.LopBindingSource;
            this.rpvDSL.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDSL.LocalReport.ReportEmbeddedResource = "Nhom11_DoAnQuanLySinhVien.ReportDanhSachLop.rdlc";
            this.rpvDSL.Location = new System.Drawing.Point(0, 50);
            this.rpvDSL.Margin = new System.Windows.Forms.Padding(4);
            this.rpvDSL.Name = "rpvDSL";
            this.rpvDSL.ServerReport.BearerToken = null;
            this.rpvDSL.Size = new System.Drawing.Size(1115, 691);
            this.rpvDSL.TabIndex = 0;
            this.rpvDSL.Load += new System.EventHandler(this.rpvDSL_Load);
            // 
            // pnlTittlebar
            // 
            this.pnlTittlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlTittlebar.Controls.Add(this.btnexit);
            this.pnlTittlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTittlebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTittlebar.Name = "pnlTittlebar";
            this.pnlTittlebar.Size = new System.Drawing.Size(1120, 53);
            this.pnlTittlebar.TabIndex = 4;
            this.pnlTittlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTittlebar_MouseDown);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnexit.Location = new System.Drawing.Point(1071, 7);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(40, 39);
            this.btnexit.TabIndex = 1;
            this.btnexit.TabStop = false;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(956, 268);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(67, 64);
            this.btnTimKiem.TabIndex = 57;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.BackColor = System.Drawing.Color.White;
            this.lblMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(845, 221);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(79, 22);
            this.lblMaLop.TabIndex = 55;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Items.AddRange(new object[] {
            "ALL"});
            this.cbbMaLop.Location = new System.Drawing.Point(932, 218);
            this.cbbMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(140, 30);
            this.cbbMaLop.TabIndex = 59;
            this.cbbMaLop.Text = "ALL";
            // 
            // LopTableAdapter
            // 
            this.LopTableAdapter.ClearBeforeFill = true;
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Items.AddRange(new object[] {
            "ALL"});
            this.cbbMaKhoa.Location = new System.Drawing.Point(932, 181);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(140, 30);
            this.cbbMaKhoa.TabIndex = 60;
            this.cbbMaKhoa.Text = "ALL";
            this.cbbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(845, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mã Khoa:";
            // 
            // ReportDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 745);
            this.Controls.Add(this.cbbMaKhoa);
            this.Controls.Add(this.cbbMaLop);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.pnlTittlebar);
            this.Controls.Add(this.rpvDSL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportDanhSachLop";
            this.Text = "ReportDanhSachLop";
            this.Load += new System.EventHandler(this.ReportDanhSachLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyDiemSinhVien)).EndInit();
            this.pnlTittlebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDSL;
        private System.Windows.Forms.Panel pnlTittlebar;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.BindingSource LopBindingSource;
        private QuanLyDiemSinhVien QuanLyDiemSinhVien;
        private QuanLyDiemSinhVienTableAdapters.LopTableAdapter LopTableAdapter;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.Label label1;
    }
}