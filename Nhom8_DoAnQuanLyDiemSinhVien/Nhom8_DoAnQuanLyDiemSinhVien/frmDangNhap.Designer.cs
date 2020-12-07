namespace Nhom11_DoAnQuanLySinhVien
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.cbbServer = new System.Windows.Forms.ComboBox();
            this.lblserver = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.pnlTittle = new System.Windows.Forms.Panel();
            this.lblInfor2 = new System.Windows.Forms.Label();
            this.lblInfor1 = new System.Windows.Forms.Label();
            this.lblInfor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoNhanVien = new System.Windows.Forms.RadioButton();
            this.rdoGiangVien = new System.Windows.Forms.RadioButton();
            this.rdoSV = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pnlTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbServer
            // 
            this.cbbServer.BackColor = System.Drawing.Color.White;
            this.cbbServer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbServer.FormattingEnabled = true;
            this.cbbServer.Location = new System.Drawing.Point(68, 131);
            this.cbbServer.Margin = new System.Windows.Forms.Padding(2);
            this.cbbServer.Name = "cbbServer";
            this.cbbServer.Size = new System.Drawing.Size(231, 29);
            this.cbbServer.TabIndex = 13;
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblserver.Location = new System.Drawing.Point(66, 91);
            this.lblserver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(117, 23);
            this.lblserver.TabIndex = 14;
            this.lblserver.Text = "Server Name";
            // 
            // txtTenDN
            // 
            this.txtTenDN.BackColor = System.Drawing.Color.White;
            this.txtTenDN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(71, 214);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(315, 22);
            this.txtTenDN.TabIndex = 0;
            // 
            // pnlTittle
            // 
            this.pnlTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlTittle.Controls.Add(this.lblInfor2);
            this.pnlTittle.Controls.Add(this.lblInfor1);
            this.pnlTittle.Controls.Add(this.lblInfor);
            this.pnlTittle.Controls.Add(this.pictureBox1);
            this.pnlTittle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTittle.Location = new System.Drawing.Point(0, 0);
            this.pnlTittle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.Size = new System.Drawing.Size(241, 478);
            this.pnlTittle.TabIndex = 15;
            this.pnlTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseDown);
            // 
            // lblInfor2
            // 
            this.lblInfor2.AutoSize = true;
            this.lblInfor2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor2.ForeColor = System.Drawing.Color.White;
            this.lblInfor2.Location = new System.Drawing.Point(138, 223);
            this.lblInfor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfor2.Name = "lblInfor2";
            this.lblInfor2.Size = new System.Drawing.Size(84, 26);
            this.lblInfor2.TabIndex = 17;
            this.lblInfor2.Text = "System";
            // 
            // lblInfor1
            // 
            this.lblInfor1.AutoSize = true;
            this.lblInfor1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor1.ForeColor = System.Drawing.Color.White;
            this.lblInfor1.Location = new System.Drawing.Point(10, 195);
            this.lblInfor1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfor1.Name = "lblInfor1";
            this.lblInfor1.Size = new System.Drawing.Size(216, 26);
            this.lblInfor1.TabIndex = 16;
            this.lblInfor1.Text = "School management";
            // 
            // lblInfor
            // 
            this.lblInfor.AutoSize = true;
            this.lblInfor.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor.ForeColor = System.Drawing.Color.White;
            this.lblInfor.Location = new System.Drawing.Point(55, 171);
            this.lblInfor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(169, 26);
            this.lblInfor.TabIndex = 15;
            this.lblInfor.Text = "Welcome to the";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.hiclipart_com;
            this.pictureBox1.Location = new System.Drawing.Point(45, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.rdoNhanVien);
            this.panel3.Controls.Add(this.rdoGiangVien);
            this.panel3.Controls.Add(this.rdoSV);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnexit);
            this.panel3.Controls.Add(this.lblusername);
            this.panel3.Controls.Add(this.lblserver);
            this.panel3.Controls.Add(this.lblpass);
            this.panel3.Controls.Add(this.cbbServer);
            this.panel3.Controls.Add(this.lblTittle);
            this.panel3.Controls.Add(this.btnDangNhap);
            this.panel3.Controls.Add(this.txtTenDN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(241, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 478);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // rdoNhanVien
            // 
            this.rdoNhanVien.AutoSize = true;
            this.rdoNhanVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.rdoNhanVien.Location = new System.Drawing.Point(325, 340);
            this.rdoNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNhanVien.Name = "rdoNhanVien";
            this.rdoNhanVien.Size = new System.Drawing.Size(105, 25);
            this.rdoNhanVien.TabIndex = 20;
            this.rdoNhanVien.TabStop = true;
            this.rdoNhanVien.Text = "Nhân Viên";
            this.rdoNhanVien.UseVisualStyleBackColor = true;
            this.rdoNhanVien.CheckedChanged += new System.EventHandler(this.rdoNhanVien_CheckedChanged);
            // 
            // rdoGiangVien
            // 
            this.rdoGiangVien.AutoSize = true;
            this.rdoGiangVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGiangVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.rdoGiangVien.Location = new System.Drawing.Point(189, 340);
            this.rdoGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.rdoGiangVien.Name = "rdoGiangVien";
            this.rdoGiangVien.Size = new System.Drawing.Size(110, 25);
            this.rdoGiangVien.TabIndex = 19;
            this.rdoGiangVien.TabStop = true;
            this.rdoGiangVien.Text = "Giảng Viên";
            this.rdoGiangVien.UseVisualStyleBackColor = true;
            this.rdoGiangVien.CheckedChanged += new System.EventHandler(this.rdoGiangVien_CheckedChanged);
            // 
            // rdoSV
            // 
            this.rdoSV.AutoSize = true;
            this.rdoSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.rdoSV.Location = new System.Drawing.Point(71, 340);
            this.rdoSV.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSV.Name = "rdoSV";
            this.rdoSV.Size = new System.Drawing.Size(99, 25);
            this.rdoSV.TabIndex = 18;
            this.rdoSV.TabStop = true;
            this.rdoSV.Text = "Sinh Viên";
            this.rdoSV.UseVisualStyleBackColor = true;
            this.rdoSV.CheckedChanged += new System.EventHandler(this.rdoSV_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(68, 315);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 1);
            this.panel4.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(71, 290);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(68, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 1);
            this.panel2.TabIndex = 15;
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
            this.btnexit.Location = new System.Drawing.Point(455, 3);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(34, 37);
            this.btnexit.TabIndex = 0;
            this.btnexit.TabStop = false;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblusername.Location = new System.Drawing.Point(64, 186);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(98, 23);
            this.lblusername.TabIndex = 7;
            this.lblusername.Text = "User name";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblpass.Location = new System.Drawing.Point(66, 260);
            this.lblpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(90, 23);
            this.lblpass.TabIndex = 11;
            this.lblpass.Text = "Password";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTittle.Location = new System.Drawing.Point(62, 29);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(285, 31);
            this.lblTittle.TabIndex = 6;
            this.lblTittle.Text = "Login To Your Account";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(68, 392);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(107, 42);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "LOGIN";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(733, 478);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.pnlTittle.ResumeLayout(false);
            this.pnlTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.ComboBox cbbServer;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblserver;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Panel pnlTittle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfor2;
        private System.Windows.Forms.Label lblInfor1;
        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rdoGiangVien;
        private System.Windows.Forms.RadioButton rdoSV;
        private System.Windows.Forms.RadioButton rdoNhanVien;
    }
}