namespace QuanLyDiem
{
    partial class FormThemSV
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
            this.lbMaSinhVien = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbKhoas = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.cbbDSMaLop = new System.Windows.Forms.ComboBox();
            this.txtKhoas = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbbDSMaKhoa = new System.Windows.Forms.ComboBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbMaSinhVien
            // 
            this.lbMaSinhVien.AutoSize = true;
            this.lbMaSinhVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSinhVien.Location = new System.Drawing.Point(34, 32);
            this.lbMaSinhVien.Name = "lbMaSinhVien";
            this.lbMaSinhVien.Size = new System.Drawing.Size(117, 19);
            this.lbMaSinhVien.TabIndex = 0;
            this.lbMaSinhVien.Text = "Mã sinh viên :";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(78, 85);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(72, 19);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ tên :";
            // 
            // lbKhoas
            // 
            this.lbKhoas.AutoSize = true;
            this.lbKhoas.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoas.Location = new System.Drawing.Point(87, 143);
            this.lbKhoas.Name = "lbKhoas";
            this.lbKhoas.Size = new System.Drawing.Size(61, 19);
            this.lbKhoas.TabIndex = 2;
            this.lbKhoas.Text = "Khóa :";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(444, 197);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(73, 19);
            this.lbMaLop.TabIndex = 3;
            this.lbMaLop.Text = "Mã lớp :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(157, 82);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 27);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(157, 29);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(200, 27);
            this.txtMaSinhVien.TabIndex = 6;
            // 
            // cbbDSMaLop
            // 
            this.cbbDSMaLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDSMaLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDSMaLop.FormattingEnabled = true;
            this.cbbDSMaLop.Location = new System.Drawing.Point(523, 194);
            this.cbbDSMaLop.Name = "cbbDSMaLop";
            this.cbbDSMaLop.Size = new System.Drawing.Size(200, 27);
            this.cbbDSMaLop.TabIndex = 9;
            this.cbbDSMaLop.Text = "Chọn mã lớp...";
            // 
            // txtKhoas
            // 
            this.txtKhoas.Location = new System.Drawing.Point(157, 140);
            this.txtKhoas.Name = "txtKhoas";
            this.txtKhoas.Size = new System.Drawing.Size(200, 27);
            this.txtKhoas.TabIndex = 10;
            this.txtKhoas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            this.txtKhoas.MouseHover += new System.EventHandler(this.txtKhoas_MouseHover);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Location = new System.Drawing.Point(623, 246);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(508, 246);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioitinh.Location = new System.Drawing.Point(60, 197);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(88, 19);
            this.lbGioitinh.TabIndex = 13;
            this.lbGioitinh.Text = "Giới tính :";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(419, 32);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(98, 19);
            this.lbNgaySinh.TabIndex = 14;
            this.lbNgaySinh.Text = "Ngày sinh :";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueQuan.Location = new System.Drawing.Point(421, 85);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(96, 19);
            this.lbQueQuan.TabIndex = 15;
            this.lbQueQuan.Text = "Quê quán :";
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhoa.Location = new System.Drawing.Point(432, 143);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(85, 19);
            this.lbMaKhoa.TabIndex = 16;
            this.lbMaKhoa.Text = "Mã khoa :";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbGioiTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(157, 194);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(198, 27);
            this.cbbGioiTinh.TabIndex = 17;
            this.cbbGioiTinh.Text = "Chọn giới tính...";
            // 
            // cbbDSMaKhoa
            // 
            this.cbbDSMaKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDSMaKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDSMaKhoa.FormattingEnabled = true;
            this.cbbDSMaKhoa.Location = new System.Drawing.Point(523, 140);
            this.cbbDSMaKhoa.Name = "cbbDSMaKhoa";
            this.cbbDSMaKhoa.Size = new System.Drawing.Size(200, 27);
            this.cbbDSMaKhoa.TabIndex = 18;
            this.cbbDSMaKhoa.Text = "Chọn mã khoa...";
            this.cbbDSMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbDSMaKhoa_SelectedIndexChanged);
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(523, 82);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(200, 27);
            this.txtQueQuan.TabIndex = 19;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(523, 29);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 27);
            this.dtpNgaySinh.TabIndex = 20;
            // 
            // FormThemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 307);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.cbbDSMaKhoa);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.lbMaKhoa);
            this.Controls.Add(this.lbQueQuan);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbGioitinh);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtKhoas);
            this.Controls.Add(this.cbbDSMaLop);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.lbMaLop);
            this.Controls.Add(this.lbKhoas);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbMaSinhVien);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThemSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaSinhVien;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbKhoas;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.ComboBox cbbDSMaLop;
        private System.Windows.Forms.TextBox txtKhoas;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.ComboBox cbbDSMaKhoa;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}