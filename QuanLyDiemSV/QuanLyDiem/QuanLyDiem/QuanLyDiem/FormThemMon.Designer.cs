namespace QuanLyDiem
{
    partial class FormThemMon
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
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.lbSoTC = new System.Windows.Forms.Label();
            this.cbbDSMaBoMon = new System.Windows.Forms.ComboBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.lbTenMonHoc = new System.Windows.Forms.Label();
            this.lbMaMonHoc = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(198, 120);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(250, 27);
            this.txtSoTC.TabIndex = 43;
            this.txtSoTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            this.txtSoTC.MouseHover += new System.EventHandler(this.txtSoTC_MouseHover);
            // 
            // lbSoTC
            // 
            this.lbSoTC.AutoSize = true;
            this.lbSoTC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTC.Location = new System.Drawing.Point(84, 123);
            this.lbSoTC.Name = "lbSoTC";
            this.lbSoTC.Size = new System.Drawing.Size(94, 19);
            this.lbSoTC.TabIndex = 42;
            this.lbSoTC.Text = "Số tín chỉ :";
            // 
            // cbbDSMaBoMon
            // 
            this.cbbDSMaBoMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDSMaBoMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDSMaBoMon.DropDownHeight = 100;
            this.cbbDSMaBoMon.FormattingEnabled = true;
            this.cbbDSMaBoMon.IntegralHeight = false;
            this.cbbDSMaBoMon.Location = new System.Drawing.Point(198, 164);
            this.cbbDSMaBoMon.Name = "cbbDSMaBoMon";
            this.cbbDSMaBoMon.Size = new System.Drawing.Size(250, 27);
            this.cbbDSMaBoMon.TabIndex = 41;
            this.cbbDSMaBoMon.Text = "Chọn mã bộ môn...";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(198, 72);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(250, 27);
            this.txtTenMon.TabIndex = 40;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(198, 25);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(250, 27);
            this.txtMaMon.TabIndex = 39;
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhoa.Location = new System.Drawing.Point(77, 167);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(101, 19);
            this.lbMaKhoa.TabIndex = 38;
            this.lbMaKhoa.Text = "Mã bộ môn:";
            // 
            // lbTenMonHoc
            // 
            this.lbTenMonHoc.AutoSize = true;
            this.lbTenMonHoc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMonHoc.Location = new System.Drawing.Point(56, 75);
            this.lbTenMonHoc.Name = "lbTenMonHoc";
            this.lbTenMonHoc.Size = new System.Drawing.Size(122, 19);
            this.lbTenMonHoc.TabIndex = 37;
            this.lbTenMonHoc.Text = "Tên môn học :";
            // 
            // lbMaMonHoc
            // 
            this.lbMaMonHoc.AutoSize = true;
            this.lbMaMonHoc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMonHoc.Location = new System.Drawing.Point(63, 28);
            this.lbMaMonHoc.Name = "lbMaMonHoc";
            this.lbMaMonHoc.Size = new System.Drawing.Size(115, 19);
            this.lbMaMonHoc.TabIndex = 36;
            this.lbMaMonHoc.Text = "Mã môn học :";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Location = new System.Drawing.Point(348, 218);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 45;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(242, 218);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormThemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 285);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoTC);
            this.Controls.Add(this.lbSoTC);
            this.Controls.Add(this.cbbDSMaBoMon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.lbMaKhoa);
            this.Controls.Add(this.lbTenMonHoc);
            this.Controls.Add(this.lbMaMonHoc);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThemMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin môn học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.Label lbSoTC;
        private System.Windows.Forms.ComboBox cbbDSMaBoMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.Label lbTenMonHoc;
        private System.Windows.Forms.Label lbMaMonHoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
    }
}