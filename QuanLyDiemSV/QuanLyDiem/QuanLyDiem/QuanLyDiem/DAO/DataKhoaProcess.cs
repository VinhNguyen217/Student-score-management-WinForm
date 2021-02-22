using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAO
{
    class DataKhoaProcess
    {
        private static DataKhoaProcess instance;
        public static DataKhoaProcess Instance
        {
            get
            {
                if (instance == null) instance = new DataKhoaProcess();
                return DataKhoaProcess.instance;
            }
            private set { DataKhoaProcess.instance = value; }
        }
        public DataTable DataKhoa()
        {
            return DataProcess.Instance.dataTable("select * from View_Khoa");
        }
        public DataTable DataKhoaByMaKhoa(String MaKhoa)
        {
            return DataProcess.Instance.dataTable("exec dataKhoaByMaKhoa '"+MaKhoa+"'");
        }
        public void InsertDataKhoa(String MaKhoa,String TenKhoa)
        {
            DataProcess.Instance.CapNhatDuLieu("Insert into Khoa(MaKhoa,TenKhoa) Values('"+MaKhoa+"',N'"+TenKhoa+"')");
        }
        public void UpdateDataKhoa(String MaKhoa,string TenKhoa)
        {
            DataProcess.Instance.CapNhatDuLieu("update Khoa set TenKhoa = N'"+TenKhoa+"' where MaKhoa = '"+MaKhoa+"'");
        }    
        public Boolean CheckMaKhoa(String MaKhoa)
        {
            Boolean check;
            DataTable data = new DataTable();
            data = DataProcess.Instance.dataTable("select * from Khoa where MaKhoa = '"+MaKhoa+"'");
            if (data.Rows.Count > 0) check = true;
            else check = false;
            return check;
        }
        public Boolean CheckTenKhoa(String TenKhoa)
        {
            Boolean check;
            DataTable data = new DataTable();
            data = DataProcess.Instance.dataTable("select * from Khoa where TenKhoa = N'"+TenKhoa+"'");
            if (data.Rows.Count > 0) check = true;
            else check = false;
            return check;
        }
        public SqlDataReader DataMaKhoa()
        {
            return DataProcess.Instance.DataReader("select MaKhoa from Khoa");
        }


    }
}
