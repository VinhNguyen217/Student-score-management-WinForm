using QuanLyDiem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormThemSV : Form
    {
        public FormThemSV()
        {
            InitializeComponent();
            LoadDataCbbMaKhoa();
        }

        public void LoadDataCbbMaKhoa()
        {
            SqlDataReader dataReader = DataKhoaProcess.Instance.DataMaKhoa();
            while (dataReader.Read())
            {
                String MaKhoa = dataReader["MaKhoa"].ToString();
                cbbDSMaKhoa.Items.Add(MaKhoa);
            }
        }
        private void cbbDSMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDSMaKhoa.SelectedIndex != -1)
            {
                cbbDSMaLop.Items.Clear();
                SqlDataReader dataReader = DataLopProcess.Instance.MaLopByMaKhoa(cbbDSMaKhoa.SelectedItem.ToString());
                while (dataReader.Read())
                {
                    String MaLop = dataReader["MaLop"].ToString();
                    cbbDSMaLop.Items.Add(MaLop);
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.TextLength == 0 || txtHoTen.TextLength == 0 || txtKhoas.TextLength == 0 || cbbGioiTinh.SelectedIndex == -1 || txtQueQuan.TextLength == 0 || cbbDSMaKhoa.SelectedIndex == -1 || cbbDSMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }
            else
            {
                if (DataSinhVienProcess.Instance.CheckMaSinhVien(txtMaSinhVien.Text) == true)
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại");
                    txtMaSinhVien.Clear();
                    txtMaSinhVien.Focus();
                }
                else
                {
                    DataSinhVienProcess.Instance.InsertDataSV(txtMaSinhVien.Text, txtHoTen.Text, cbbGioiTinh.Text, dtpNgaySinh.Value.ToString(), txtQueQuan.Text, txtKhoas.Text, cbbDSMaLop.SelectedItem.ToString());
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            txtKhoas.Clear();
            cbbGioiTinh.SelectedIndex = -1;
            cbbGioiTinh.Text = "Chọn giới tính...";
            dtpNgaySinh.Value = DateTime.Now;
            txtQueQuan.Clear();
            cbbDSMaKhoa.SelectedIndex = -1;
            cbbDSMaKhoa.Text = "Chọn mã khoa...";
            cbbDSMaLop.SelectedIndex = -1;
            cbbDSMaLop.Text = "Chọn mã lớp...";
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;       
        }
        private void txtKhoas_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.InitialDelay = 0;
            t.IsBalloon = true;
            t.SetToolTip(this.txtKhoas, "Giá trị nhập là số nguyên");
        }
    }
}
