namespace QuanLyDiem
{
    partial class FormThemKhoa
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
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.lbTenKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhoa.Location = new System.Drawing.Point(55, 34);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(85, 19);
            this.lbMaKhoa.TabIndex = 0;
            this.lbMaKhoa.Text = "Mã khoa :";
            // 
            // lbTenKhoa
            // 
            this.lbTenKhoa.AutoSize = true;
            this.lbTenKhoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhoa.Location = new System.Drawing.Point(50, 93);
            this.lbTenKhoa.Name = "lbTenKhoa";
            this.lbTenKhoa.Size = new System.Drawing.Size(92, 19);
            this.lbTenKhoa.TabIndex = 1;
            this.lbTenKhoa.Text = "Tên khoa :";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(175, 31);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(250, 27);
            this.txtMaKhoa.TabIndex = 2;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(175, 90);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(250, 27);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(218, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Location = new System.Drawing.Point(325, 142);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormThemKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 215);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.lbTenKhoa);
            this.Controls.Add(this.lbMaKhoa);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThemKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin khoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.Label lbTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
    }
}