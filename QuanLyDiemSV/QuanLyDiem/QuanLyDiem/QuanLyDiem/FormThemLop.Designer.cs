namespace QuanLyDiem
{
    partial class FormThemLop
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
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.cbbDSMaKhoa = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(85, 27);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(73, 19);
            this.lbMaLop.TabIndex = 0;
            this.lbMaLop.Text = "Mã lớp :";
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.Location = new System.Drawing.Point(80, 82);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(80, 19);
            this.lbTenLop.TabIndex = 1;
            this.lbTenLop.Text = "Tên lớp :";
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhoa.Location = new System.Drawing.Point(73, 140);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(85, 19);
            this.lbMaKhoa.TabIndex = 2;
            this.lbMaKhoa.Text = "Mã khoa :";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(194, 24);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(250, 27);
            this.txtMaLop.TabIndex = 3;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(194, 79);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(250, 27);
            this.txtTenLop.TabIndex = 4;
            // 
            // cbbDSMaKhoa
            // 
            this.cbbDSMaKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDSMaKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDSMaKhoa.FormattingEnabled = true;
            this.cbbDSMaKhoa.Location = new System.Drawing.Point(194, 137);
            this.cbbDSMaKhoa.Name = "cbbDSMaKhoa";
            this.cbbDSMaKhoa.Size = new System.Drawing.Size(250, 27);
            this.cbbDSMaKhoa.TabIndex = 5;
            this.cbbDSMaKhoa.Text = "Chọn mã khoa...";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Location = new System.Drawing.Point(344, 194);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(237, 194);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 257);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbDSMaKhoa);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lbMaKhoa);
            this.Controls.Add(this.lbTenLop);
            this.Controls.Add(this.lbMaLop);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThemLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ComboBox cbbDSMaKhoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
    }
}