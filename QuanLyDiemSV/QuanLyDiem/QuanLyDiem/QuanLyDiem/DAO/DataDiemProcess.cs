using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAO
{
    class DataDiemProcess
    {
        private static DataDiemProcess instance;
        public static DataDiemProcess Instance
        {
            get
            {
                if (instance == null) instance = new DataDiemProcess();
                return DataDiemProcess.instance;
            }
            private set { DataDiemProcess.instance = value; }
        }
        public DataTable DataDiem()
        {
            return DataProcess.Instance.dataTable("Select * from View_Diem");
        }
        public DataTable DataDiemByMaHocKy(String mahocky)
        {
            return DataProcess.Instance.dataTable("exec dataDiemByMaHocKy '" + mahocky + "'");
        }
        public DataTable DataDiemByMaSinhVien(String maSV)
        {
            return DataProcess.Instance.dataTable("exec dataDiemByMaSinhVien '" + maSV + "'");
        }
        public DataTable DataDiemBy_SV_HK(String mahocky, String maSV)
        {
            return DataProcess.Instance.dataTable("exec dataDiemBy_SV_HK '" + mahocky + "','" + maSV + "'");
        }
        public void InsertDataDiem(String MaSV, String MaHP, float diemthi, float diemQT)
        {
            DataProcess.Instance.CapNhatDuLieu("Insert into Diem(MaSinhVien,MaHocPhan,DiemThi,DiemQuaTrinh)" +
                "Values('" + MaSV + "','" + MaHP + "'," + diemthi + "," + diemQT + ")");
        }
        public void UpdateDataDiem(String MaSV, String MaHP, float diemthi, float diemQT)
        {
            DataProcess.Instance.CapNhatDuLieu("Update Diem " +
                "set DiemThi=" + diemthi + ",DiemQuaTrinh =" + diemQT + "" +
                "where MaSinhVien = '" + MaSV + "' and MaHocPhan='" + MaHP + "'");
        }
        public void DeleteDataDiem(String MaSV, String MaHP)
        {
            DataProcess.Instance.CapNhatDuLieu("Delete from Diem where MaSinhVien ='" + MaSV + "' and MaHocPhan = '" + MaHP + "'");
        }
        public Boolean CheckdataDiem(String MaSV, String MaHP)
        {
            Boolean check;
            DataTable data = DataProcess.Instance.dataTable("Select * from Diem where MaSinhVien ='" + MaSV + "' and MaHocPhan ='" + MaHP + "'");
            if (data.Rows.Count > 0) check = true;
            else check = false;
            return check;
        }
        public SqlDataReader DataMaHocKy()
        {
            return DataProcess.Instance.DataReader("select MaHocKy from HocKy");
        }
        public SqlDataReader MaHocPhanByMaSV(String MaSinhVien)
        {
            return DataProcess.Instance.DataReader("exec MaHocPhanByMaSV '" + MaSinhVien + "'");
        }
    }
}
