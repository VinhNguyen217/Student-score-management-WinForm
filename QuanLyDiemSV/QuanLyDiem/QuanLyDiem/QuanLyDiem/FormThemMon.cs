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
    public partial class FormThemMon : Form
    {
        public FormThemMon()
        {
            InitializeComponent();
            LoadDataCbbDSMaBoMon();
        }
        public void LoadDataCbbDSMaBoMon()
        {
            SqlDataReader dataReader = DataMonProcess.Instance.DataMaBoMon();
            while (dataReader.Read())
            {
                String MaBoMon = dataReader["MaBoMon"].ToString();
                cbbDSMaBoMon.Items.Add(MaBoMon);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMon.TextLength == 0 || txtTenMon.TextLength == 0 || txtSoTC.TextLength == 0 || cbbDSMaBoMon.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải nhập thông tin đầy đủ");
            }
            else
            {
                if (DataMonProcess.Instance.CheckMaMon(txtMaMon.Text) == true)
                {
                    MessageBox.Show("Mã môn học này đã tồn tại");
                    txtMaMon.Clear();
                    txtMaMon.Focus();
                }
                else
                {
                    if (DataMonProcess.Instance.CheckTenMon(txtTenMon.Text) == true)
                    {
                        MessageBox.Show("Tên môn học này đã tồn tại");
                        txtTenMon.Clear();
                        txtTenMon.Focus();
                    }
                    else
                    {
                        DataMonProcess.Instance.InsertDataMon(txtMaMon.Text, txtTenMon.Text, int.Parse(txtSoTC.Text), cbbDSMaBoMon.SelectedItem.ToString());
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtSoTC.Clear();
            cbbDSMaBoMon.SelectedIndex = -1;
            cbbDSMaBoMon.Text = "Chọn mã bộ môn...";
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoTC_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.InitialDelay = 0;
            t.IsBalloon = true;
            t.SetToolTip(this.txtSoTC, "Giá trị nhập là số nguyên");
        }
    }
}
