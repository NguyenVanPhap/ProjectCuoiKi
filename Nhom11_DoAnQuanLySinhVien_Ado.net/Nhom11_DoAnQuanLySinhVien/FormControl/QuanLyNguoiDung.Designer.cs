namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    partial class QuanLyNguoiDung
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
            this.epvTaiKhoan = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUsers = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            this.TenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.grbTTCT = new System.Windows.Forms.GroupBox();
            this.lblpassword = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.epvTaiKhoan)).BeginInit();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            this.grbTTCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // epvTaiKhoan
            // 
            this.epvTaiKhoan.ContainerControl = this;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsers.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.Red;
            this.lblUsers.Location = new System.Drawing.Point(327, 22);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(351, 32);
            this.lblUsers.TabIndex = 54;
            this.lblUsers.Text = "QUẢN LÝ NGƯỜI DÙNG ";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(106, 61);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(58, 29);
            this.cboGioiTinh.TabIndex = 55;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(12, 66);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(80, 21);
            this.lblGioiTinh.TabIndex = 54;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // mskPhone
            // 
            this.mskPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhone.ForeColor = System.Drawing.Color.Black;
            this.mskPhone.Location = new System.Drawing.Point(107, 95);
            this.mskPhone.Margin = new System.Windows.Forms.Padding(2);
            this.mskPhone.Mask = "9999 000 000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(136, 29);
            this.mskPhone.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(107, 130);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 29);
            this.txtEmail.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Email:";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgvLogin);
            this.grbDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbDanhSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSach.Location = new System.Drawing.Point(96, 269);
            this.grbDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Padding = new System.Windows.Forms.Padding(2);
            this.grbDanhSach.Size = new System.Drawing.Size(582, 261);
            this.grbDanhSach.TabIndex = 56;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách";
            // 
            // dgvLogin
            // 
            this.dgvLogin.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDN,
            this.MatKhau,
            this.HoTen,
            this.GioiTinh,
            this.Phone,
            this.Email,
            this.Quyen});
            this.dgvLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogin.EnableHeadersVisualStyles = false;
            this.dgvLogin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLogin.Location = new System.Drawing.Point(2, 24);
            this.dgvLogin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLogin.Name = "dgvLogin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLogin.RowHeadersWidth = 51;
            this.dgvLogin.Size = new System.Drawing.Size(578, 235);
            this.dgvLogin.TabIndex = 0;
            this.dgvLogin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogin_CellClick);
            // 
            // TenDN
            // 
            this.TenDN.DataPropertyName = "TenDN";
            this.TenDN.HeaderText = "Tài Khoản";
            this.TenDN.MinimumWidth = 6;
            this.TenDN.Name = "TenDN";
            this.TenDN.Width = 150;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 150;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.Width = 125;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(13, 99);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 21);
            this.lblPhone.TabIndex = 50;
            this.lblPhone.Text = "Phone:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(106, 27);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(136, 29);
            this.txtHoTen.TabIndex = 49;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblHoTen.Location = new System.Drawing.Point(13, 32);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(86, 21);
            this.lblHoTen.TabIndex = 48;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // cboQuyen
            // 
            this.cboQuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuyen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Sinh Viên",
            "Giảng Viên",
            "Admin"});
            this.cboQuyen.Location = new System.Drawing.Point(428, 119);
            this.cboQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(137, 29);
            this.cboQuyen.TabIndex = 18;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuyen.Location = new System.Drawing.Point(327, 122);
            this.lblQuyen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(63, 21);
            this.lblQuyen.TabIndex = 17;
            this.lblQuyen.Text = "Quyền:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhau.Location = new System.Drawing.Point(428, 76);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(136, 29);
            this.txtMatKhau.TabIndex = 14;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTaiKhoan.Location = new System.Drawing.Point(428, 31);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(136, 29);
            this.txtTaiKhoan.TabIndex = 13;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaiKhoan.Location = new System.Drawing.Point(327, 36);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(93, 21);
            this.lblTaiKhoan.TabIndex = 9;
            this.lblTaiKhoan.Text = "Tài khoản: ";
            // 
            // grbTTCT
            // 
            this.grbTTCT.Controls.Add(this.cboGioiTinh);
            this.grbTTCT.Controls.Add(this.lblGioiTinh);
            this.grbTTCT.Controls.Add(this.mskPhone);
            this.grbTTCT.Controls.Add(this.txtEmail);
            this.grbTTCT.Controls.Add(this.label3);
            this.grbTTCT.Controls.Add(this.lblPhone);
            this.grbTTCT.Controls.Add(this.txtHoTen);
            this.grbTTCT.Controls.Add(this.lblHoTen);
            this.grbTTCT.Controls.Add(this.cboQuyen);
            this.grbTTCT.Controls.Add(this.lblQuyen);
            this.grbTTCT.Controls.Add(this.txtMatKhau);
            this.grbTTCT.Controls.Add(this.txtTaiKhoan);
            this.grbTTCT.Controls.Add(this.lblpassword);
            this.grbTTCT.Controls.Add(this.lblTaiKhoan);
            this.grbTTCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbTTCT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTCT.ForeColor = System.Drawing.Color.Black;
            this.grbTTCT.Location = new System.Drawing.Point(96, 89);
            this.grbTTCT.Margin = new System.Windows.Forms.Padding(2);
            this.grbTTCT.Name = "grbTTCT";
            this.grbTTCT.Padding = new System.Windows.Forms.Padding(2);
            this.grbTTCT.Size = new System.Drawing.Size(582, 170);
            this.grbTTCT.TabIndex = 55;
            this.grbTTCT.TabStop = false;
            this.grbTTCT.Text = "Thông tin chi tiết";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblpassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpassword.Location = new System.Drawing.Point(327, 80);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(83, 21);
            this.lblpassword.TabIndex = 11;
            this.lblpassword.Text = "Mật khẩu:";
            // 
            // lblXoa
            // 
            this.lblXoa.AutoSize = true;
            this.lblXoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXoa.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXoa.Location = new System.Drawing.Point(844, 443);
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
            this.lblLuu.Location = new System.Drawing.Point(846, 368);
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
            this.lblHuyBo.Location = new System.Drawing.Point(831, 289);
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
            this.lblSua.Location = new System.Drawing.Point(848, 212);
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
            this.lblThem.Location = new System.Drawing.Point(835, 135);
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
            this.btnHuyBo.Location = new System.Drawing.Point(748, 268);
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
            this.btnXoa.Location = new System.Drawing.Point(748, 422);
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
            this.btnLuu.Location = new System.Drawing.Point(748, 347);
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
            this.btnSua.Location = new System.Drawing.Point(748, 191);
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
            this.btnThem.Location = new System.Drawing.Point(748, 114);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 73);
            this.btnThem.TabIndex = 56;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblXoa);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblLuu);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.lblHuyBo);
            this.Controls.Add(this.grbTTCT);
            this.Controls.Add(this.lblSua);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.lblThem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyNguoiDung";
            this.Size = new System.Drawing.Size(932, 600);
            this.Load += new System.EventHandler(this.QuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epvTaiKhoan)).EndInit();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            this.grbTTCT.ResumeLayout(false);
            this.grbTTCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epvTaiKhoan;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgvLogin;
        private System.Windows.Forms.GroupBox grbTTCT;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblXoa;
        private System.Windows.Forms.Label lblLuu;
        private System.Windows.Forms.Label lblHuyBo;
        private System.Windows.Forms.Label lblSua;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Label lblThem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
    }
}
