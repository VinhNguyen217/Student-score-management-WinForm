using QuanLyDiem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormThemKhoa : Form
    {
        public FormThemKhoa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0 || txtTenKhoa.TextLength == 0) MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            else
            {
                if (DataKhoaProcess.Instance.CheckMaKhoa(txtMaKhoa.Text) == true)
                {
                    MessageBox.Show("Mã khoa này đã tồn tại");
                    txtMaKhoa.Clear();
                }
                else
                {
                    if (DataKhoaProcess.Instance.CheckTenKhoa(txtTenKhoa.Text) == true)
                    {
                        MessageBox.Show("Tên khoa đã tồn tại");
                        txtTenKhoa.Clear();
                    }
                    else
                    {
                        DataKhoaProcess.Instance.InsertDataKhoa(txtMaKhoa.Text, txtTenKhoa.Text);
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
        }
    }
}
