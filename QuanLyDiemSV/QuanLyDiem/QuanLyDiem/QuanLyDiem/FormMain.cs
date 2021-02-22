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
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        public void FormMain_Load(object sender, EventArgs e)
        {
            LoadDataKhoa();
            LoadDataLop();
            LoadDataSinhVien();
            LoadDataMonHoc();
            LoadDataDiem();
        }
        public void tabControl_Click(object sender, EventArgs e)
        {
            cbbDSMaKhoa.Items.Clear();
            LoadDataCbbMaKhoa();

            cbbDSMaLop1.Items.Clear();
            LoadDataCbbMaLop1();

            cbbDSMaKhoa1.Items.Clear();
            LoadDataCbbMaKhoa1();

            cbbDSMaBoMon.Items.Clear();
            LoadDatacbbDSMaBoMon();

            cbbDSHocKy.Items.Clear();
            LoadCbbDSHocKy();

            cbbDSMaSinhVien.Items.Clear();
            LoadCbbDSMaSinhVien();
        }
        //--------------------------------------------------Xử lý dữ liệu TabKhoa--------------------------------------------------
        public void LoadDataKhoa()
        {
            dgvKhoa.DataSource = DataKhoaProcess.Instance.DataKhoa();
            dgvKhoa.Columns[0].HeaderText = "Mã khoa";
            dgvKhoa.Columns[1].HeaderText = "Tên khoa";
        }
        public void ClearTextBoxKhoa()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtTimKiem.Clear();
            btnSua.Enabled = false;
        }
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
            {
                if (dgvKhoa.Rows[i].Cells["MaKhoa"].Value.ToString().Length != 0)
                {
                    dgvKhoa.CurrentRow.Selected = true;
                    txtMaKhoa.Text = dgvKhoa.Rows[i].Cells["MaKhoa"].Value.ToString();
                    txtTenKhoa.Text = dgvKhoa.Rows[i].Cells["TenKhoa"].Value.ToString();
                    btnSua.Enabled = true;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemKhoa f = new FormThemKhoa();
            f.ShowDialog();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn sự thay đổi này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (DataKhoaProcess.Instance.CheckTenKhoa(txtTenKhoa.Text) == true)
                    {
                        MessageBox.Show("Tên khoa đã tồn tại");
                    }
                    else
                    {
                        DataKhoaProcess.Instance.UpdateDataKhoa(txtMaKhoa.Text, txtTenKhoa.Text);
                        LoadDataKhoa();
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void txtTimKiem_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.InitialDelay = 0;
            t.IsBalloon = true;
            t.SetToolTip(this.txtTimKiem, "Nhập mã khoa cần tìm kiếm");
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu");
                txtTimKiem.Focus();
            }
            else
            {
                dgvKhoa.DataSource = DataKhoaProcess.Instance.DataKhoaByMaKhoa(txtTimKiem.Text);
            }
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDataKhoa();
            ClearTextBoxKhoa();
        }
        //-------------------------------------------------------------------------------------------------------------------------



        //--------------------------------------------------Xử lý dữ liệu TabLop--------------------------------------------------
        public void LoadDataLop()
        {
            dgvLop.DataSource = DataLopProcess.Instance.DataLop();
            dgvLop.Columns[0].HeaderText = "Mã lớp";
            dgvLop.Columns[1].HeaderText = "Tên lớp";
            dgvLop.Columns[2].HeaderText = "Mã khoa";
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
        public void ClearTextBoxLop()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            cbbDSMaKhoa.SelectedIndex = -1;
            cbbDSMaKhoa.Text = "Chọn mã khoa...";
            txtTimKiem1.Clear();
            btnSua1.Enabled = false;
        }
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
            {
                if (dgvLop.Rows[i].Cells["MaLop"].Value.ToString().Length != 0)
                {
                    dgvLop.CurrentRow.Selected = true;
                    txtMaLop.Text = dgvLop.Rows[i].Cells["MaLop"].Value.ToString();
                    txtTenLop.Text = dgvLop.Rows[i].Cells["TenLop"].Value.ToString();
                    cbbDSMaKhoa.Text = dgvLop.Rows[i].Cells["MaKhoa"].Value.ToString();
                    btnSua1.Enabled = true;
                }
            }
        }
        private void btnThem1_Click(object sender, EventArgs e)
        {
            FormThemLop f = new FormThemLop();
            f.ShowDialog();
        }
        private void btnSua1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn sự thay đổi này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (DataLopProcess.Instance.CheckTenLop(txtTenLop.Text) == true)
                    {
                        MessageBox.Show("Tên lớp đã tồn tại");
                    }
                    else
                    {
                        DataLopProcess.Instance.UpdateDataLop(txtMaLop.Text, txtTenLop.Text, cbbDSMaKhoa.SelectedItem.ToString());
                        LoadDataLop();
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void btnTimKiem1_Click(object sender, EventArgs e)
        {
            if (txtTimKiem1.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu");
                txtTimKiem1.Focus();
            }
            else
            {
                dgvLop.DataSource = DataLopProcess.Instance.DataLopByMaLop(txtTimKiem1.Text);
            }
        }
        private void txtTimKiem1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.InitialDelay = 0;
            t.IsBalloon = true;
            t.SetToolTip(this.txtTimKiem1, "Nhập mã lớp cần tìm kiếm");
        }
        private void btnHienThi1_Click(object sender, EventArgs e)
        {
            LoadDataLop();
            ClearTextBoxLop();
        }
        //-------------------------------------------------------------------------------------------------------------------------



        //--------------------------------------------------Xử lý dữ liệu TabSinhVien--------------------------------------------------
        public void LoadDataSinhVien()
        {
            dgvDSSinhVien.DataSource = DataSinhVienProcess.Instance.DataSinhVien();
            dgvDSSinhVien.Columns[0].HeaderText = "Mã sinh viên";
            dgvDSSinhVien.Columns[1].HeaderText = "Họ tên";
            dgvDSSinhVien.Columns[2].HeaderText = "Giới tính";
            dgvDSSinhVien.Columns[3].HeaderText = "Ngày sinh";
            dgvDSSinhVien.Columns[4].HeaderText = "Quê quán";
            dgvDSSinhVien.Columns[5].HeaderText = "Khóa";
            dgvDSSinhVien.Columns[6].HeaderText = "Mã lớp";
            dgvDSSinhVien.Columns[7].HeaderText = "Mã khoa";
        }
        public void LoadDataCbbMaLop1()
        {
            SqlDataReader dataReader = DataLopProcess.Instance.DataMaLop();
            while (dataReader.Read())
            {
                String MaLop = dataReader["MaLop"].ToString();
                cbbDSMaLop1.Items.Add(MaLop);
            }
        }
        public void LoadDataCbbMaKhoa1()
        {
            SqlDataReader dataReader = DataKhoaProcess.Instance.DataMaKhoa();
            while (dataReader.Read())
            {
                String MaKhoa = dataReader["MaKhoa"].ToString();
                cbbDSMaKhoa1.Items.Add(MaKhoa);
            }
        }
        public void LoadDataCbbMaLop(String MaKhoa)
        {
            SqlDataReader dataReader = DataLopProcess.Instance.MaLopByMaKhoa(MaKhoa);
            while (dataReader.Read())
            {
                String MaLop = dataReader["MaLop"].ToString();
                cbbDSMalop.Items.Add(MaLop);
            }
        }
        public void ClearTextBoxSV()
        {
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            txtKhoas.Clear();
            cbbGioiTinh.SelectedIndex = -1;
            cbbGioiTinh.Text = "Chọn giới tính...";
            dtpNgaySinh.Value = DateTime.Now;
            txtQueQuan.Clear();
            cbbDSMaKhoa1.SelectedIndex = -1;
            cbbDSMaKhoa1.Text = "Chọn mã khoa...";
            cbbDSMalop.SelectedIndex = -1;
            cbbDSMalop.Text = "Chọn mã lớp...";
            cbbDSMaLop1.SelectedIndex = -1;
            cbbDSMaLop1.Text = "Chọn mã lớp...";
            txtTimKiem2.Clear();
            btnSua2.Enabled = false;
            btnXoa2.Enabled = false;
        }
        private void dgvDSSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
            {
                if (dgvDSSinhVien.Rows[i].Cells["MaSinhVien"].Value.ToString().Length != 0)
                {
                    dgvDSSinhVien.CurrentRow.Selected = true;
                    txtMaSinhVien.Text = dgvDSSinhVien.Rows[i].Cells["MaSinhVien"].Value.ToString();
                    txtHoTen.Text = dgvDSSinhVien.Rows[i].Cells["HoTen"].Value.ToString();
                    txtKhoas.Text = dgvDSSinhVien.Rows[i].Cells["Khoas"].Value.ToString();
                    cbbGioiTinh.Text = dgvDSSinhVien.Rows[i].Cells["GioiTinh"].Value.ToString();
                    dtpNgaySinh.Value = DateTime.Parse(dgvDSSinhVien.Rows[i].Cells["NgaySinh"].Value.ToString());
                    txtQueQuan.Text = dgvDSSinhVien.Rows[i].Cells["QueQuan"].Value.ToString();
                    cbbDSMaKhoa1.Text = dgvDSSinhVien.Rows[i].Cells["MaKhoa"].Value.ToString();
                    cbbDSMalop.Text = dgvDSSinhVien.Rows[i].Cells["MaLop"].Value.ToString();
                    btnSua2.Enabled = true;
                    btnXoa2.Enabled = true;
                }
            }
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            FormThemSV f = new FormThemSV();
            f.ShowDialog();
        }
        private void btnSua2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn sự thay đổi này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (txtHoTen.TextLength == 0 || txtKhoas.TextLength == 0 || cbbDSMalop.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa nhập đủ dữ liệu");
                    }
                    else
                    {
                        DataSinhVienProcess.Instance.UpdateDataSV(txtMaSinhVien.Text, txtHoTen.Text, txtKhoas.Text, cbbDSMalop.SelectedItem.ToString(), dtpNgaySinh.Value.ToString(), txtQueQuan.Text, cbbGioiTinh.Text);
                        LoadDataSinhVien();
                        ClearTextBoxSV();
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void btnXoa2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DataSinhVienProcess.Instance.DeleteDataSV(txtMaSinhVien.Text);
                    LoadDataSinhVien();
                    ClearTextBoxSV();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Không thể xóa do còn nhiều thông tin liên quan");
            }
        }
        private void cbbDSMaKhoa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDSMaKhoa1.SelectedIndex != -1)
            {
                cbbDSMalop.Items.Clear();
                cbbDSMalop.Text = "Chọn mã lớp...";
                LoadDataCbbMaLop(cbbDSMaKhoa1.SelectedItem.ToString());
            }
            else cbbDSMalop.Items.Clear();
        }
        private void cbbDSMaLop1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDSMaLop1.SelectedIndex != -1) dgvDSSinhVien.DataSource = DataSinhVienProcess.Instance.DataSVByMaLop(cbbDSMaLop1.SelectedItem.ToString());
        }
        private void btnTimKiem2_Click(object sender, EventArgs e)
        {
            if (txtTimKiem2.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập giá trị");
                txtTimKiem2.Focus();
            }
            else dgvDSSinhVien.DataSource = DataSinhVienProcess.Instance.DataSVByMaSV(txtTimKiem2.Text);
        }
        private void txtTimKiem2_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.InitialDelay = 0;
            t.IsBalloon = true;
            t.SetToolTip(this.txtTimKiem2, "Nhập mã sinh viên cần tìm kiếm");
        }
        private void btnHienThi2_Click(object sender, EventArgs e)
        {
            LoadDataSinhVien();
            ClearTextBoxSV();
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

        //-------------------------------------------------------------------------------------------------------------------------------



        //--------------------------------------------------Xử lý dữ liệu TabMonHoc--------------------------------------------------
        public void LoadDataMonHoc()
        {
            dgvDSMonHoc.DataSource = DataMonProcess.Instance.DataMonHoc();
            dgvDSMonHoc.Columns[0].HeaderText = "Mã môn học";
            dgvDSMonHoc.Columns[1].HeaderText = "Tên môn học";
            dgvDSMonHoc.Columns[2].HeaderText = "Số tín chỉ";
            dgvDSMonHoc.Columns[3].HeaderText = "Mã bộ môn";
        }
        public void LoadDatacbbDSMaBoMon()
        {
            SqlDataReader dataReader = DataMonProcess.Instance.DataMaBoMon();
            while (dataReader.Read())
            {
                String MaBoMon = dataReader["MaBoMon"].ToString();
                cbbDSMaBoMon.Items.Add(MaBoMon);
            }
        }
        public void ClearTextBoxMonHoc()
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtSoTC.Clear();
            cbbDSMaBoMon.SelectedIndex = -1;
            cbbDSMaBoMon.Text = "Chọn mã bộ môn...";
            txtTimKiem3.Clear();
            btnSua3.Enabled = false;
            btnXoa3.Enabled = false;
        }
        private void dgvDSMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
            {
                if (dgvDSMonHoc.Rows[i].Cells["MaMon"].Value.ToString().Length != 0)
                {
                    dgvDSMonHoc.CurrentRow.Selected = true;
                    txtMaMon.Text = dgvDSMonHoc.Rows[i].Cells["MaMon"].Value.ToString();
                    txtTenMon.Text = dgvDSMonHoc.Rows[i].Cells["TenMon"].Value.ToString();
                    txtSoTC.Text = dgvDSMonHoc.Rows[i].Cells["SoTC"].Value.ToString();
                    cbbDSMaBoMon.Text = dgvDSMonHoc.Rows[i].Cells["MaBoMon"].Value.ToString();
                    btnSua3.Enabled = true;
                    btnXoa3.Enabled = true;
                }
            }
        }
        private void btnThem3_Click(object sender, EventArgs e)
        {
            FormThemMon f = new FormThemMon();
            f.ShowDialog();
        }
        private void btnSua3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn sự thay đổi này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    DataMonProcess.Instance.UpdateDataMon(txtMaMon.Text, txtTenMon.Text, int.Parse(txtSoTC.Text), cbbDSMaBoMon.SelectedItem.ToString());
                    LoadDataMonHoc();
                }
            }
            catch (Exception ex) { }
        }
        private void btnXoa3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DataMonProcess.Instance.DeleteDataMon(txtMaMon.Text);
                    LoadDataMonHoc();
                    ClearTextBoxMonHoc();
                }
            }
            catch (Exception ex) { }
        }
        private void btnTimKiem3_Click(object sender, EventArgs e)
        {
            if (txtTimKiem3.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu");
                txtTimKiem3.Focus();
            }
            else dgvDSMonHoc.DataSource = DataMonProcess.Instance.DataMonHocByMaMon(txtTimKiem3.Text);
        }
        private void txtTimKiem3_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.InitialDelay = 0;
            t.IsBalloon = true;
            t.SetToolTip(this.txtTimKiem3, "Nhập mã môn học cần tìm kiếm");
        }
        private void btnHienThi3_Click(object sender, EventArgs e)
        {
            LoadDataMonHoc();
            ClearTextBoxMonHoc();
        }
        //-------------------------------------------------------------------------------------------------------------------------------



        //--------------------------------------------------Xử lý dữ liệu TabQuanLyDiem--------------------------------------------------
        public void LoadDataDiem()
        {
            dgvDSDiem.DataSource = DataDiemProcess.Instance.DataDiem();
            dgvDSDiem.Columns[0].HeaderText = "Mã sinh viên";
            dgvDSDiem.Columns[1].HeaderText = "Họ tên";
            dgvDSDiem.Columns[2].HeaderText = "Mã lớp học phần";
            dgvDSDiem.Columns[3].HeaderText = "Mã môn học";
            dgvDSDiem.Columns[4].HeaderText = "Tên môn học";
            dgvDSDiem.Columns[5].HeaderText = "Lần thi";
            dgvDSDiem.Columns[6].HeaderText = "THI";
            dgvDSDiem.Columns[7].HeaderText = "ĐQT";
            dgvDSDiem.Columns[8].HeaderText = "ĐTK";
            dgvDSDiem.Columns[9].HeaderText = "Đánh giá";
        }
        public void ClearTextBoxDiem()
        {
            txtMaSinhVien1.Clear();
            txtHoTen1.Clear();
            txtLanThi.Clear();
            txtDiemThi.Clear();
            txtMaLopHocPhan.Clear();
            txtMaMon1.Clear();
            txtTenMon1.Clear();
            txtDiemQT.Clear();
            txtDiemTK.Clear();
            txtDanhGia.Clear();
            btnCapNhat.Enabled = false;
            btnXoa4.Enabled = false;
        }
        public void LoadCbbDSHocKy()
        {
            SqlDataReader dataReader = DataDiemProcess.Instance.DataMaHocKy();
            while (dataReader.Read())
            {
                String MaHocKy = dataReader["MaHocKy"].ToString();
                cbbDSHocKy.Items.Add(MaHocKy);
            }
        }
        public void LoadCbbDSMaSinhVien()
        {
            SqlDataReader dataReader = DataSinhVienProcess.Instance.DataMaSV();
            while (dataReader.Read())
            {
                String MaSV = dataReader["MaSinhVien"].ToString();
                cbbDSMaSinhVien.Items.Add(MaSV);
            }
        }
        private void dgvDSDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
            {
                if (dgvDSDiem.Rows[i].Cells["MaSinhVien"].Value.ToString().Length != 0)
                {
                    dgvDSDiem.CurrentRow.Selected = true;
                    txtMaSinhVien1.Text = dgvDSDiem.Rows[i].Cells["MaSinhVien"].Value.ToString();
                    txtHoTen1.Text = dgvDSDiem.Rows[i].Cells["HoTen"].Value.ToString();
                    txtMaLopHocPhan.Text = dgvDSDiem.Rows[i].Cells["MaHocPhan"].Value.ToString();
                    txtMaMon1.Text = dgvDSDiem.Rows[i].Cells["MaMon"].Value.ToString();
                    txtTenMon1.Text = dgvDSDiem.Rows[i].Cells["TenMon"].Value.ToString();
                    txtLanThi.Text = dgvDSDiem.Rows[i].Cells["LanThi"].Value.ToString();
                    txtDiemThi.Text = dgvDSDiem.Rows[i].Cells["DiemThi"].Value.ToString();
                    txtDiemQT.Text = dgvDSDiem.Rows[i].Cells["DiemQuaTrinh"].Value.ToString();
                    txtDiemTK.Text = dgvDSDiem.Rows[i].Cells["DiemTK"].Value.ToString();
                    txtDanhGia.Text = dgvDSDiem.Rows[i].Cells["DanhGia"].Value.ToString();
                    btnCapNhat.Enabled = true;
                    btnXoa4.Enabled = true;
                }
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormThemDiem f = new FormThemDiem();
            f.ShowDialog();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn sự thay đổi này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (CheckDiem(txtDiemThi.Text) == false)
                    {
                        MessageBox.Show("Điểm thi không đúng định dạng");
                        txtDiemThi.Clear();
                        txtDiemThi.Focus();
                    }
                    else
                    {
                        if (CheckDiem(txtDiemQT.Text) == false)
                        {
                            MessageBox.Show("Điểm quá trình không đúng định dạng");
                            txtDiemQT.Clear();
                            txtDiemQT.Focus();
                        }
                        else
                        {
                            DataDiemProcess.Instance.UpdateDataDiem(txtMaSinhVien1.Text, txtMaLopHocPhan.Text, float.Parse(txtDiemThi.Text), float.Parse(txtDiemQT.Text));
                            LoadDataDiem();
                            MessageBox.Show("Cập nhật thành công");
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void btnXoa4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DataDiemProcess.Instance.DeleteDataDiem(txtMaSinhVien1.Text, txtMaLopHocPhan.Text);
                    dgvDSDiem.DataSource = DataDiemProcess.Instance.DataDiem();
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception ex) { }
        }
        private void btnHienThi4_Click(object sender, EventArgs e)
        {
            LoadDataDiem();
            ClearTextBoxDiem();
            cbbDSHocKy.SelectedIndex = -1;
            cbbDSHocKy.Text = "Chọn học kỳ...";
            cbbDSMaSinhVien.SelectedIndex = -1;
            cbbDSMaSinhVien.Text = "Chọn mã sinh viên";
        }
        private void cbbDSHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDSHocKy.SelectedIndex != -1 && cbbDSMaSinhVien.SelectedIndex == -1)
            {
                dgvDSDiem.DataSource = DataDiemProcess.Instance.DataDiemByMaHocKy(cbbDSHocKy.SelectedItem.ToString());
                ClearTextBoxDiem();
            }
            if (cbbDSHocKy.SelectedIndex != -1 && cbbDSMaSinhVien.SelectedIndex != -1)
            {
                dgvDSDiem.DataSource = DataDiemProcess.Instance.DataDiemBy_SV_HK(cbbDSHocKy.SelectedItem.ToString(), cbbDSMaSinhVien.SelectedItem.ToString());
                ClearTextBoxDiem();
            }
        }
        private void cbbDSMaSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDSMaSinhVien.SelectedIndex != -1 && cbbDSHocKy.SelectedIndex == -1)
            {
                dgvDSDiem.DataSource = DataDiemProcess.Instance.DataDiemByMaSinhVien(cbbDSMaSinhVien.SelectedItem.ToString());
                ClearTextBoxDiem();
            }
            if (cbbDSHocKy.SelectedIndex != -1 && cbbDSMaSinhVien.SelectedIndex != -1)
            {
                dgvDSDiem.DataSource = DataDiemProcess.Instance.DataDiemBy_SV_HK(cbbDSHocKy.SelectedItem.ToString(), cbbDSMaSinhVien.SelectedItem.ToString());
                ClearTextBoxDiem();
            }
        }
        public Boolean CheckDiem(String diem)
        {
            Boolean check;
            float a;
            if (float.TryParse(diem, out a) == true && float.Parse(diem) >= 0 && float.Parse(diem) <= 10) check = true;
            else check = false;
            return check;
        }
        //-------------------------------------------------------------------------------------------------------------------------------
    }
}
