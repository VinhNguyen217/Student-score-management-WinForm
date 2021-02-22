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
    public partial class FormThemDiem : Form
    {
        public FormThemDiem()
        {
            InitializeComponent();
            LoadcbbDSMaKhoa();
        }
        public void LoadcbbDSMaKhoa()
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
                cbbDSMaLop.Text = "Chọn mã lớp...";
                SqlDataReader dataReader = DataLopProcess.Instance.MaLopByMaKhoa(cbbDSMaKhoa.SelectedItem.ToString());
                while (dataReader.Read())
                {
                    String MaLop = dataReader["MaLop"].ToString();
                    cbbDSMaLop.Items.Add(MaLop);
                }
            }
            else
            {
                cbbDSMaLop.SelectedIndex = -1;
                cbbDSMaLop.Text = "Chọn mã lớp...";
                cbbDSMaLop.Items.Clear();
                cbbDSMaSV.SelectedIndex = -1;
                cbbDSMaSV.Text = "Chọn mã sinh viên...";
                cbbDSMaSV.Items.Clear();
                cbbDSMaHocPhan.SelectedIndex = -1;
                cbbDSMaHocPhan.Text = "Chọn mã lớp học phần...";
                cbbDSMaHocPhan.Items.Clear();
            }
        }
        private void cbbDSMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDSMaLop.SelectedIndex != -1)
            {
                cbbDSMaSV.Items.Clear();
                cbbDSMaSV.Text = "Chọn mã sinh viên...";
                SqlDataReader dataReader = DataSinhVienProcess.Instance.MaSinhVienByMaLop(cbbDSMaLop.SelectedItem.ToString());
                while (dataReader.Read())
                {
                    String MaSinhVien = dataReader["MaSinhVien"].ToString();
                    cbbDSMaSV.Items.Add(MaSinhVien);
                }
            }
            else
            {
                cbbDSMaSV.SelectedIndex = -1;
                cbbDSMaSV.Text = "Chọn mã sinh viên...";
                cbbDSMaSV.Items.Clear();
                cbbDSMaHocPhan.SelectedIndex = -1;
                cbbDSMaHocPhan.Text = "Chọn mã lớp học phần...";
                cbbDSMaHocPhan.Items.Clear();
            }
        }
        private void cbbDSMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDSMaSV.SelectedIndex != -1)
            {
                cbbDSMaHocPhan.Items.Clear();
                cbbDSMaHocPhan.Text = "Chọn mã lớp học phần...";
                SqlDataReader dataReader = DataDiemProcess.Instance.MaHocPhanByMaSV(cbbDSMaSV.SelectedItem.ToString());
                while (dataReader.Read())
                {
                    String MaHocPhan = dataReader["MaHocPhan"].ToString();
                    cbbDSMaHocPhan.Items.Add(MaHocPhan);
                }
            }
            else
            {
                cbbDSMaHocPhan.Items.Clear();
                cbbDSMaHocPhan.Text = "Chọn mã lớp học phần...";
                cbbDSMaHocPhan.Items.Clear();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbDSMaSV.SelectedIndex == -1 || cbbDSMaHocPhan.SelectedIndex == -1 || txtDiemThi.TextLength == 0 || txtDiemQT.TextLength == 0)
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                }
                else
                {
                    if (CheckDiem(txtDiemThi.Text) == false || CheckDiem(txtDiemQT.Text) == false)
                    {
                        MessageBox.Show("Điểm thi hoặc điểm quá trình không đúng định dạng");
                        ;
                    }
                    else
                    {
                        if (DataDiemProcess.Instance.CheckdataDiem(cbbDSMaSV.SelectedItem.ToString(), cbbDSMaHocPhan.SelectedItem.ToString()) == true)
                        {
                            MessageBox.Show("Sinh viên đã có điểm học phần môn này");
                        }
                        else
                        {
                            DataDiemProcess.Instance.InsertDataDiem(cbbDSMaSV.SelectedItem.ToString(), cbbDSMaHocPhan.SelectedItem.ToString(), float.Parse(txtDiemThi.Text), float.Parse(txtDiemQT.Text));
                            MessageBox.Show("Thêm thành công");
                            this.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbDSMaKhoa.SelectedIndex = -1;
            cbbDSMaKhoa.Text = "Chọn mã khoa...";

            cbbDSMaLop.SelectedIndex = -1;
            cbbDSMaLop.Text = "Chọn mã lớp...";
            cbbDSMaLop.Items.Clear();

            cbbDSMaSV.SelectedIndex = -1;
            cbbDSMaSV.Text = "Chọn mã sinh viên...";
            cbbDSMaSV.Items.Clear();

            cbbDSMaHocPhan.SelectedIndex = -1;
            cbbDSMaHocPhan.Text = "Chọn mã lớp học phần...";
            cbbDSMaHocPhan.Items.Clear();

            txtDiemThi.Clear();
            txtDiemQT.Clear();
        }
        public Boolean CheckDiem(String diem)
        {
            Boolean check;
            float a;
            if (float.TryParse(diem, out a) == true && float.Parse(diem) >= 0 && float.Parse(diem) <= 10) check = true;
            else check = false;
            return check;
        }
    }
}
