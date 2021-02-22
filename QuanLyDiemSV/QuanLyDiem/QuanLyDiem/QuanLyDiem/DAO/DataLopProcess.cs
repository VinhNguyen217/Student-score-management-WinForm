using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAO
{
    class DataLopProcess
    {
        private static DataLopProcess instance;
        public static DataLopProcess Instance
        {
            get
            {
                if (instance == null) instance = new DataLopProcess();
                return DataLopProcess.instance;
            }
            private set { DataLopProcess.instance = value; }
        }
        public DataTable DataLop()
        {
            return DataProcess.Instance.dataTable("Select * from View_Lop");
        }
        public void InsertDataLop(String MaLop, String TenLop, String MaKhoa)
        {
            DataProcess.Instance.CapNhatDuLieu("Insert into Lop(MaLop,TenLop,MaKhoa) Values('" + MaLop + "',N'" + TenLop + "','" + MaKhoa + "')");
        }
        public void UpdateDataLop(String MaLop, string TenLop, String MaKhoa)
        {
            DataProcess.Instance.CapNhatDuLieu("update Lop set TenLop = N'" + TenLop + "',MaKhoa='" + MaKhoa + "' where MaLop = '" + MaLop + "'");
        }
        public DataTable DataLopByMaLop(String MaLop)
        {
            return DataProcess.Instance.dataTable("exec dataLopByMaLop '" + MaLop + "'");
        }
        public SqlDataReader DataMaLop()
        {
            return DataProcess.Instance.DataReader("select MaLop from Lop");
        }
        public SqlDataReader MaLopByMaKhoa(String MaKhoa)
        {
            return DataProcess.Instance.DataReader("exec MaLopByMaKhoa '" + MaKhoa + "'");
        }
        public Boolean CheckMaLop(String MaLop)
        {
            Boolean check;
            DataTable data = new DataTable();
            data = DataProcess.Instance.dataTable("select * from Lop " +
                "where MaLop = '" + MaLop + "'");
            if (data.Rows.Count > 0) check = true;
            else check = false;
            return check;
        }
        public Boolean CheckTenLop(String TenLop)
        {
            Boolean check;
            DataTable data = new DataTable();
            data = DataProcess.Instance.dataTable("select * from Lop where TenLop = N'" + TenLop + "'");
            if (data.Rows.Count > 0) check = true;
            else check = false;
            return check;
        }

    }
}
