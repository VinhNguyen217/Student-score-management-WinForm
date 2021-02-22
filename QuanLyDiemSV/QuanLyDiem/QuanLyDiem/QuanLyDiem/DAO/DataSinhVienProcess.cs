using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAO
{
    class DataSinhVienProcess
    {
        private static DataSinhVienProcess instance;
        public static DataSinhVienProcess Instance
        {
            get
            {
                if (instance == null) instance = new DataSinhVienProcess();
                return DataSinhVienProcess.instance;
            }
            private set { DataSinhVienProcess.instance = value; }
        }
        public DataTable DataSinhVien()
        {
            return DataProcess.Instance.dataTable("select * from View_SinhVien");
        }
        public void InsertDataSV(String MaSinhVien, String HoTen, String GioiTinh, String NgaySinh, String QueQuan, String Khoas, String MaLop)
        {

            DataProcess.Instance.CapNhatDuLieu("Insert into SinhVien Values('" + MaSinhVien + "',N'" + HoTen + "',N'" + GioiTinh + "','" + NgaySinh + "',N'" + QueQuan + "','" + Khoas + "','" + MaLop + "')");
        }
        public void UpdateDataSV(String MaSinhVien, string HoTen, String Khoas, String MaLop, String NgaySinh, String QueQuan, string GioiTinh)
        {
            DataProcess.Instance.CapNhatDuLieu("update SinhVien set HoTen=N'" + HoTen + "',Khoas ='" + Khoas + "',MaLop='" + MaLop + "',NgaySinh='" + NgaySinh + "',QueQuan=N'" + QueQuan + "',GioiTinh=N'" + GioiTinh + "' where MaSinhVien = '" + MaSinhVien + "'");
        }
        public void DeleteDataSV(String MaSinhVien)
        {
            DataProcess.Instance.CapNhatDuLieu("Delete from SinhVien where MaSinhVien = '" + MaSinhVien + "'");
        }
        public DataTable DataSVByMaSV(String MaSV)
        {
            return DataProcess.Instance.dataTable("exec dataSinhVienByMaSV '" + MaSV + "'");
        }
        public DataTable DataSVByMaLop(String MaLop)
        {
            return DataProcess.Instance.dataTable("exec dataSinhVienByMaLop '" + MaLop + "'");
        }
        public SqlDataReader DataMaSV()
        {
            return DataProcess.Instance.DataReader("select MaSinhVien from SinhVien");
        }
        public SqlDataReader MaSinhVienByMaLop(String MaLop)
        {
            return DataProcess.Instance.DataReader("exec MaSinhVienByMaLop '" + MaLop + "'");
        }
        public Boolean CheckMaSinhVien(String MaSinhVien)
        {
            Boolean check;
            DataTable data = new DataTable();
            data = DataProcess.Instance.dataTable("select * from SinhVien where MaSinhVien = '" + MaSinhVien + "'");
            if (data.Rows.Count > 0) check = true;
            else check = false;
            return check;
        }
    }
}
