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
    public partial class FormThemLop : Form
    {
        public FormThemLop()
        {
            InitializeComponent();
            LoadDataCbbMaKhoa();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0 || txtTenLop.TextLength == 0 || cbbDSMaKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }
            else
            {
                if (DataLopProcess.Instance.CheckMaLop(txtMaLop.Text) == true)
                {
                    MessageBox.Show("Mã lớp đã tồn tại");
                    txtMaLop.Clear();
                    txtMaLop.Focus();
                }
                else
                {
                    if (DataLopProcess.Instance.CheckTenLop(txtTenLop.Text) == true)
                    {
                        MessageBox.Show("Tên lớp đã tồn tại");
                        txtTenLop.Focus();
                        txtTenLop.Clear();
                    }
                    else
                    {
                        DataLopProcess.Instance.InsertDataLop(txtMaLop.Text, txtTenLop.Text, cbbDSMaKhoa.SelectedItem.ToString());
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            cbbDSMaKhoa.SelectedIndex = -1;
            cbbDSMaKhoa.Text = "Chọn mã khoa...";
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
    }
}
