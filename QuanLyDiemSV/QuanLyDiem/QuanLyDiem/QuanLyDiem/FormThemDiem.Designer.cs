namespace QuanLyDiem
{
    partial class FormThemDiem
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
            this.lbDiemQT = new System.Windows.Forms.Label();
            this.lbMaSinhVien = new System.Windows.Forms.Label();
            this.cbbDSMaSV = new System.Windows.Forms.ComboBox();
            this.lbMaLopHP = new System.Windows.Forms.Label();
            this.cbbDSMaHocPhan = new System.Windows.Forms.ComboBox();
            this.lbDiemThi = new System.Windows.Forms.Label();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtDiemQT = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.cbbDSMaKhoa = new System.Windows.Forms.ComboBox();
            this.cbbDSMaLop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbDiemQT
            // 
            this.lbDiemQT.AutoSize = true;
            this.lbDiemQT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemQT.Location = new System.Drawing.Point(475, 334);
            this.lbDiemQT.Name = "lbDiemQT";
            this.lbDiemQT.Size = new System.Drawing.Size(135, 19);
            this.lbDiemQT.TabIndex = 16;
            this.lbDiemQT.Text = "Điểm quá trình :";
            // 
            // lbMaSinhVien
            // 
            this.lbMaSinhVien.AutoSize = true;
            this.lbMaSinhVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSinhVien.Location = new System.Drawing.Point(12, 334);
            this.lbMaSinhVien.Name = "lbMaSinhVien";
            this.lbMaSinhVien.Size = new System.Drawing.Size(117, 19);
            this.lbMaSinhVien.TabIndex = 13;
            this.lbMaSinhVien.Text = "Mã sinh viên :";
            // 
            // cbbDSMaSV
            // 
            this.cbbDSMaSV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDSMaSV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDSMaSV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDSMaSV.FormattingEnabled = true;
            this.cbbDSMaSV.Location = new System.Drawing.Point(161, 331);
            this.cbbDSMaSV.Name = "cbbDSMaSV";
            this.cbbDSMaSV.Size = new System.Drawing.Size(250, 27);
            this.cbbDSMaSV.TabIndex = 23;
            this.cbbDSMaSV.Text = "Chọn mã sinh viên...";
            this.cbbDSMaSV.SelectedIndexChanged += new System.EventHandler(this.cbbDSMaSV_SelectedIndexChanged);
            // 
            // lbMaLopHP
            // 
            this.lbMaLopHP.AutoSize = true;
            this.lbMaLopHP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLopHP.Location = new System.Drawing.Point(459, 30);
            this.lbMaLopHP.Name = "lbMaLopHP";
            this.lbMaLopHP.Size = new System.Drawing.Size(151, 19);
            this.lbMaLopHP.TabIndex = 24;
            this.lbMaLopHP.Text = "Mã lớp học phần :";
            // 
            // cbbDSMaHocPhan
            // 
            this.cbbDSMaHocPhan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDSMaHocPhan.FormattingEnabled = true;
            this.cbbDSMaHocPhan.Location = new System.Drawing.Point(636, 27);
            this.cbbDSMaHocPhan.Name = "cbbDSMaHocPhan";
            this.cbbDSMaHocPhan.Size = new System.Drawing.Size(249, 27);
            this.cbbDSMaHocPhan.TabIndex = 25;
            this.cbbDSMaHocPhan.Text = "Chọn mã lớp học phần...";
            // 
            // lbDiemThi
            // 
            this.lbDiemThi.AutoSize = true;
            this.lbDiemThi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemThi.Location = new System.Drawing.Point(526, 178);
            this.lbDiemThi.Name = "lbDiemThi";
            this.lbDiemThi.Size = new System.Drawing.Size(84, 19);
            this.lbDiemThi.TabIndex = 26;
            this.lbDiemThi.Text = "Điểm thi :";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThi.Location = new System.Drawing.Point(636, 175);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(249, 27);
            this.txtDiemThi.TabIndex = 27;
            // 
            // txtDiemQT
            // 
            this.txtDiemQT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemQT.Location = new System.Drawing.Point(636, 331);
            this.txtDiemQT.Name = "txtDiemQT";
            this.txtDiemQT.Size = new System.Drawing.Size(249, 27);
            this.txtDiemQT.TabIndex = 28;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(785, 388);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 30;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(679, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhoa.Location = new System.Drawing.Point(49, 30);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(90, 19);
            this.lbMaKhoa.TabIndex = 31;
            this.lbMaKhoa.Text = "Mã khoa : ";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(49, 178);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(73, 19);
            this.lbMaLop.TabIndex = 32;
            this.lbMaLop.Text = "Mã lớp :";
            // 
            // cbbDSMaKhoa
            // 
            this.cbbDSMaKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDSMaKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDSMaKhoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDSMaKhoa.FormattingEnabled = true;
            this.cbbDSMaKhoa.Location = new System.Drawing.Point(161, 27);
            this.cbbDSMaKhoa.Name = "cbbDSMaKhoa";
            this.cbbDSMaKhoa.Size = new System.Drawing.Size(250, 27);
            this.cbbDSMaKhoa.TabIndex = 33;
            this.cbbDSMaKhoa.Text = "Chọn mã khoa...";
            this.cbbDSMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbDSMaKhoa_SelectedIndexChanged);
            // 
            // cbbDSMaLop
            // 
            this.cbbDSMaLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDSMaLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDSMaLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDSMaLop.FormattingEnabled = true;
            this.cbbDSMaLop.Location = new System.Drawing.Point(161, 175);
            this.cbbDSMaLop.Name = "cbbDSMaLop";
            this.cbbDSMaLop.Size = new System.Drawing.Size(250, 27);
            this.cbbDSMaLop.TabIndex = 34;
            this.cbbDSMaLop.Text = "Chọn mã lớp...";
            this.cbbDSMaLop.SelectedIndexChanged += new System.EventHandler(this.cbbDSMaLop_SelectedIndexChanged);
            // 
            // FormThemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.cbbDSMaLop);
            this.Controls.Add(this.cbbDSMaKhoa);
            this.Controls.Add(this.lbMaLop);
            this.Controls.Add(this.lbMaKhoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiemQT);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.lbDiemThi);
            this.Controls.Add(this.cbbDSMaHocPhan);
            this.Controls.Add(this.lbMaLopHP);
            this.Controls.Add(this.cbbDSMaSV);
            this.Controls.Add(this.lbDiemQT);
            this.Controls.Add(this.lbMaSinhVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormThemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDiemQT;
        private System.Windows.Forms.Label lbMaSinhVien;
        private System.Windows.Forms.ComboBox cbbDSMaSV;
        private System.Windows.Forms.Label lbMaLopHP;
        private System.Windows.Forms.ComboBox cbbDSMaHocPhan;
        private System.Windows.Forms.Label lbDiemThi;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtDiemQT;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.ComboBox cbbDSMaKhoa;
        private System.Windows.Forms.ComboBox cbbDSMaLop;
    }
}