namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    partial class DiemSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemSinhVien));
            this.grbDSV = new System.Windows.Forms.GroupBox();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThiLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThiLan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbGhiChu = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.grbTTChiTiet = new System.Windows.Forms.GroupBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.lblDiemLan1 = new System.Windows.Forms.Label();
            this.txtDiemThi1 = new System.Windows.Forms.TextBox();
            this.txtDiemThi2 = new System.Windows.Forms.TextBox();
            this.lblDiemLan2 = new System.Windows.Forms.Label();
            this.txtDiemTK = new System.Windows.Forms.TextBox();
            this.lblDiemTK = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.grpLuaChon = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblNam = new System.Windows.Forms.Label();
            this.cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.cbbHocKi = new System.Windows.Forms.ComboBox();
            this.lblHK = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.lblDiemSV = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblXoa = new System.Windows.Forms.Label();
            this.lblLuu = new System.Windows.Forms.Label();
            this.lblHuyBo = new System.Windows.Forms.Label();
            this.lblSua = new System.Windows.Forms.Label();
            this.lblThem = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbDSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.grbGhiChu.SuspendLayout();
            this.grbTTChiTiet.SuspendLayout();
            this.grpLuaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDSV
            // 
            this.grbDSV.Controls.Add(this.dgvDiem);
            this.grbDSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDSV.Location = new System.Drawing.Point(39, 303);
            this.grbDSV.Margin = new System.Windows.Forms.Padding(2);
            this.grbDSV.Name = "grbDSV";
            this.grbDSV.Padding = new System.Windows.Forms.Padding(2);
            this.grbDSV.Size = new System.Drawing.Size(701, 256);
            this.grbDSV.TabIndex = 37;
            this.grbDSV.TabStop = false;
            this.grbDSV.Text = "Danh sách";
            // 
            // dgvDiem
            // 
            this.dgvDiem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.HoTen,
            this.MaLop,
            this.MaMon,
            this.TenMon,
            this.HocKi,
            this.NamHoc,
            this.DiemThiLan1,
            this.DiemThiLan2,
            this.DiemTongKet});
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.EnableHeadersVisualStyles = false;
            this.dgvDiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiem.Location = new System.Drawing.Point(2, 24);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDiem.Name = "dgvDiem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.Size = new System.Drawing.Size(697, 230);
            this.dgvDiem.TabIndex = 0;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã SV";
            this.MASV.MinimumWidth = 6;
            this.MASV.Name = "MASV";
            this.MASV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 150;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 200;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Môn";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 120;
            // 
            // HocKi
            // 
            this.HocKi.DataPropertyName = "HocKi";
            this.HocKi.HeaderText = "Học Kì";
            this.HocKi.MinimumWidth = 6;
            this.HocKi.Name = "HocKi";
            this.HocKi.Width = 150;
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm Học";
            this.NamHoc.MinimumWidth = 6;
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.Width = 150;
            // 
            // DiemThiLan1
            // 
            this.DiemThiLan1.DataPropertyName = "DiemThiLan1";
            this.DiemThiLan1.HeaderText = "Điểm Thi Lần 1";
            this.DiemThiLan1.MinimumWidth = 6;
            this.DiemThiLan1.Name = "DiemThiLan1";
            this.DiemThiLan1.Width = 200;
            // 
            // DiemThiLan2
            // 
            this.DiemThiLan2.DataPropertyName = "DiemThiLan2";
            this.DiemThiLan2.HeaderText = "Điểm Thi Lần 2";
            this.DiemThiLan2.MinimumWidth = 6;
            this.DiemThiLan2.Name = "DiemThiLan2";
            this.DiemThiLan2.Width = 200;
            // 
            // DiemTongKet
            // 
            this.DiemTongKet.DataPropertyName = "DiemTongKet";
            this.DiemTongKet.HeaderText = "Điểm Tổng Kết";
            this.DiemTongKet.MinimumWidth = 6;
            this.DiemTongKet.Name = "DiemTongKet";
            this.DiemTongKet.Width = 200;
            // 
            // grbGhiChu
            // 
            this.grbGhiChu.Controls.Add(this.txtGhiChu);
            this.grbGhiChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGhiChu.Location = new System.Drawing.Point(532, 19);
            this.grbGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.grbGhiChu.Name = "grbGhiChu";
            this.grbGhiChu.Padding = new System.Windows.Forms.Padding(2);
            this.grbGhiChu.Size = new System.Drawing.Size(148, 101);
            this.grbGhiChu.TabIndex = 36;
            this.grbGhiChu.TabStop = false;
            this.grbGhiChu.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGhiChu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(2, 15);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(144, 84);
            this.txtGhiChu.TabIndex = 12;
            // 
            // grbTTChiTiet
            // 
            this.grbTTChiTiet.Controls.Add(this.btnKiemTra);
            this.grbTTChiTiet.Controls.Add(this.lblDiemLan1);
            this.grbTTChiTiet.Controls.Add(this.txtDiemThi1);
            this.grbTTChiTiet.Controls.Add(this.txtDiemThi2);
            this.grbTTChiTiet.Controls.Add(this.lblDiemLan2);
            this.grbTTChiTiet.Controls.Add(this.txtDiemTK);
            this.grbTTChiTiet.Controls.Add(this.lblDiemTK);
            this.grbTTChiTiet.Controls.Add(this.txtHoTen);
            this.grbTTChiTiet.Controls.Add(this.lblHoTen);
            this.grbTTChiTiet.Controls.Add(this.txtMaSV);
            this.grbTTChiTiet.Controls.Add(this.lblMaSV);
            this.grbTTChiTiet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTChiTiet.Location = new System.Drawing.Point(39, 190);
            this.grbTTChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.grbTTChiTiet.Name = "grbTTChiTiet";
            this.grbTTChiTiet.Padding = new System.Windows.Forms.Padding(2);
            this.grbTTChiTiet.Size = new System.Drawing.Size(701, 98);
            this.grbTTChiTiet.TabIndex = 35;
            this.grbTTChiTiet.TabStop = false;
            this.grbTTChiTiet.Text = "Thông tin chi tiết";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.Transparent;
            this.btnKiemTra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKiemTra.BackgroundImage")));
            this.btnKiemTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKiemTra.FlatAppearance.BorderSize = 0;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKiemTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiemTra.Location = new System.Drawing.Point(202, 35);
            this.btnKiemTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(50, 50);
            this.btnKiemTra.TabIndex = 47;
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // lblDiemLan1
            // 
            this.lblDiemLan1.AutoSize = true;
            this.lblDiemLan1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemLan1.Location = new System.Drawing.Point(267, 62);
            this.lblDiemLan1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemLan1.Name = "lblDiemLan1";
            this.lblDiemLan1.Size = new System.Drawing.Size(95, 19);
            this.lblDiemLan1.TabIndex = 25;
            this.lblDiemLan1.Text = "Điểm thi lần 1:";
            // 
            // txtDiemThi1
            // 
            this.txtDiemThi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiemThi1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThi1.Location = new System.Drawing.Point(364, 58);
            this.txtDiemThi1.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiemThi1.Name = "txtDiemThi1";
            this.txtDiemThi1.Size = new System.Drawing.Size(67, 26);
            this.txtDiemThi1.TabIndex = 8;
            // 
            // txtDiemThi2
            // 
            this.txtDiemThi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiemThi2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThi2.Location = new System.Drawing.Point(613, 26);
            this.txtDiemThi2.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiemThi2.Name = "txtDiemThi2";
            this.txtDiemThi2.Size = new System.Drawing.Size(66, 26);
            this.txtDiemThi2.TabIndex = 9;
            // 
            // lblDiemLan2
            // 
            this.lblDiemLan2.AutoSize = true;
            this.lblDiemLan2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemLan2.Location = new System.Drawing.Point(513, 30);
            this.lblDiemLan2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemLan2.Name = "lblDiemLan2";
            this.lblDiemLan2.Size = new System.Drawing.Size(95, 19);
            this.lblDiemLan2.TabIndex = 20;
            this.lblDiemLan2.Text = "Điểm thi lần 2:";
            // 
            // txtDiemTK
            // 
            this.txtDiemTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiemTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTK.Location = new System.Drawing.Point(613, 61);
            this.txtDiemTK.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiemTK.Name = "txtDiemTK";
            this.txtDiemTK.Size = new System.Drawing.Size(66, 26);
            this.txtDiemTK.TabIndex = 11;
            // 
            // lblDiemTK
            // 
            this.lblDiemTK.AutoSize = true;
            this.lblDiemTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTK.Location = new System.Drawing.Point(513, 66);
            this.lblDiemTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemTK.Name = "lblDiemTK";
            this.lblDiemTK.Size = new System.Drawing.Size(97, 19);
            this.lblDiemTK.TabIndex = 14;
            this.lblDiemTK.Text = "Điểm tổng kết:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(364, 25);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(114, 26);
            this.txtHoTen.TabIndex = 6;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(267, 29);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(71, 19);
            this.lblHoTen.TabIndex = 12;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(113, 46);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(84, 26);
            this.txtMaSV.TabIndex = 5;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(15, 47);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(56, 19);
            this.lblMaSV.TabIndex = 10;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // grpLuaChon
            // 
            this.grpLuaChon.Controls.Add(this.lblTimKiem);
            this.grpLuaChon.Controls.Add(this.btnTimKiem);
            this.grpLuaChon.Controls.Add(this.lblNam);
            this.grpLuaChon.Controls.Add(this.cbbNamHoc);
            this.grpLuaChon.Controls.Add(this.cbbMonHoc);
            this.grpLuaChon.Controls.Add(this.lblMaMon);
            this.grpLuaChon.Controls.Add(this.cbbHocKi);
            this.grpLuaChon.Controls.Add(this.lblHK);
            this.grpLuaChon.Controls.Add(this.cbbLop);
            this.grpLuaChon.Controls.Add(this.lblLop);
            this.grpLuaChon.Controls.Add(this.cbbKhoa);
            this.grpLuaChon.Controls.Add(this.lblkhoa);
            this.grpLuaChon.Controls.Add(this.grbGhiChu);
            this.grpLuaChon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLuaChon.Location = new System.Drawing.Point(39, 55);
            this.grpLuaChon.Margin = new System.Windows.Forms.Padding(2);
            this.grpLuaChon.Name = "grpLuaChon";
            this.grpLuaChon.Padding = new System.Windows.Forms.Padding(2);
            this.grpLuaChon.Size = new System.Drawing.Size(701, 133);
            this.grpLuaChon.TabIndex = 34;
            this.grpLuaChon.TabStop = false;
            this.grpLuaChon.Text = "Lựa chọn";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(361, 79);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(68, 19);
            this.lblTimKiem.TabIndex = 47;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(449, 64);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(69, 48);
            this.btnTimKiem.TabIndex = 46;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(14, 60);
            this.lblNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(68, 19);
            this.lblNam.TabIndex = 38;
            this.lblNam.Text = "Năm học:";
            // 
            // cbbNamHoc
            // 
            this.cbbNamHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNamHoc.FormattingEnabled = true;
            this.cbbNamHoc.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cbbNamHoc.Location = new System.Drawing.Point(113, 59);
            this.cbbNamHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Size = new System.Drawing.Size(80, 27);
            this.cbbNamHoc.TabIndex = 37;
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(113, 93);
            this.cbbMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(224, 27);
            this.cbbMonHoc.TabIndex = 4;
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMon.Location = new System.Drawing.Point(16, 95);
            this.lblMaMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(67, 19);
            this.lblMaMon.TabIndex = 8;
            this.lblMaMon.Text = "Môn học:";
            // 
            // cbbHocKi
            // 
            this.cbbHocKi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbHocKi.Location = new System.Drawing.Point(292, 58);
            this.cbbHocKi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(47, 27);
            this.cbbHocKi.TabIndex = 3;
            // 
            // lblHK
            // 
            this.lblHK.AutoSize = true;
            this.lblHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHK.Location = new System.Drawing.Point(222, 62);
            this.lblHK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHK.Name = "lblHK";
            this.lblHK.Size = new System.Drawing.Size(53, 19);
            this.lblHK.TabIndex = 6;
            this.lblHK.Text = "Học kì:";
            // 
            // cbbLop
            // 
            this.cbbLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(419, 28);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(99, 27);
            this.cbbLop.TabIndex = 2;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(361, 32);
            this.lblLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(37, 19);
            this.lblLop.TabIndex = 4;
            this.lblLop.Text = "Lớp:";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(113, 25);
            this.cbbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(224, 27);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.Text = "ALL";
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkhoa.Location = new System.Drawing.Point(14, 30);
            this.lblkhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(46, 19);
            this.lblkhoa.TabIndex = 0;
            this.lblkhoa.Text = "Khoa:";
            // 
            // lblDiemSV
            // 
            this.lblDiemSV.AutoSize = true;
            this.lblDiemSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiemSV.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemSV.ForeColor = System.Drawing.Color.Red;
            this.lblDiemSV.Location = new System.Drawing.Point(291, 3);
            this.lblDiemSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemSV.Name = "lblDiemSV";
            this.lblDiemSV.Size = new System.Drawing.Size(391, 32);
            this.lblDiemSV.TabIndex = 33;
            this.lblDiemSV.Text = "QUẢN LÝ ĐIỂM SINH VIÊN ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblXoa
            // 
            this.lblXoa.AutoSize = true;
            this.lblXoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXoa.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXoa.Location = new System.Drawing.Point(882, 422);
            this.lblXoa.Name = "lblXoa";
            this.lblXoa.Size = new System.Drawing.Size(58, 26);
            this.lblXoa.TabIndex = 60;
            this.lblXoa.Text = " Xóa";
            // 
            // lblLuu
            // 
            this.lblLuu.AutoSize = true;
            this.lblLuu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuu.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLuu.Location = new System.Drawing.Point(884, 346);
            this.lblLuu.Name = "lblLuu";
            this.lblLuu.Size = new System.Drawing.Size(55, 26);
            this.lblLuu.TabIndex = 61;
            this.lblLuu.Text = "Lưu";
            // 
            // lblHuyBo
            // 
            this.lblHuyBo.AutoSize = true;
            this.lblHuyBo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuyBo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHuyBo.Location = new System.Drawing.Point(870, 267);
            this.lblHuyBo.Name = "lblHuyBo";
            this.lblHuyBo.Size = new System.Drawing.Size(87, 26);
            this.lblHuyBo.TabIndex = 62;
            this.lblHuyBo.Text = "Hủy bỏ";
            // 
            // lblSua
            // 
            this.lblSua.AutoSize = true;
            this.lblSua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSua.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSua.Location = new System.Drawing.Point(887, 190);
            this.lblSua.Name = "lblSua";
            this.lblSua.Size = new System.Drawing.Size(51, 26);
            this.lblSua.TabIndex = 63;
            this.lblSua.Text = "Sửa";
            // 
            // lblThem
            // 
            this.lblThem.AutoSize = true;
            this.lblThem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThem.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblThem.Location = new System.Drawing.Point(879, 113);
            this.lblThem.Name = "lblThem";
            this.lblThem.Size = new System.Drawing.Size(70, 26);
            this.lblThem.TabIndex = 64;
            this.lblThem.Text = "Thêm";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyBo.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_cancel;
            this.btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHuyBo.FlatAppearance.BorderSize = 0;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(787, 246);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(72, 73);
            this.btnHuyBo.TabIndex = 58;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_delete;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(787, 400);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 73);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_save;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(787, 325);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 73);
            this.btnLuu.TabIndex = 57;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_update;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(787, 169);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 73);
            this.btnSua.TabIndex = 55;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_add;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(787, 92);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 73);
            this.btnThem.TabIndex = 56;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblXoa);
            this.Controls.Add(this.lblLuu);
            this.Controls.Add(this.lblHuyBo);
            this.Controls.Add(this.lblSua);
            this.Controls.Add(this.lblThem);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbDSV);
            this.Controls.Add(this.grbTTChiTiet);
            this.Controls.Add(this.grpLuaChon);
            this.Controls.Add(this.lblDiemSV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DiemSinhVien";
            this.Size = new System.Drawing.Size(974, 610);
            this.Load += new System.EventHandler(this.DiemSinhVien_Load);
            this.grbDSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.grbGhiChu.ResumeLayout(false);
            this.grbGhiChu.PerformLayout();
            this.grbTTChiTiet.ResumeLayout(false);
            this.grbTTChiTiet.PerformLayout();
            this.grpLuaChon.ResumeLayout(false);
            this.grpLuaChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbDSV;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.GroupBox grbGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.GroupBox grbTTChiTiet;
        private System.Windows.Forms.Label lblDiemLan1;
        private System.Windows.Forms.TextBox txtDiemThi1;
        private System.Windows.Forms.TextBox txtDiemThi2;
        private System.Windows.Forms.Label lblDiemLan2;
        private System.Windows.Forms.TextBox txtDiemTK;
        private System.Windows.Forms.Label lblDiemTK;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.GroupBox grpLuaChon;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.Label lblHK;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Label lblDiemSV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cbbNamHoc;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblXoa;
        private System.Windows.Forms.Label lblLuu;
        private System.Windows.Forms.Label lblHuyBo;
        private System.Windows.Forms.Label lblSua;
        private System.Windows.Forms.Label lblThem;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThiLan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThiLan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongKet;
    }
}
