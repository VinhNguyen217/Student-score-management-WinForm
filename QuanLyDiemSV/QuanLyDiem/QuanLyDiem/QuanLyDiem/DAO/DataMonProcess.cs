using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAO
{
    class DataMonProcess
    {
        private static DataMonProcess instance;
        public static DataMonProcess Instance
        {
            get
            {
                if (instance == null) instance = new DataMonProcess();
                return DataMonProcess.instance;
            }
            private set { DataMonProcess.instance = value; }
        }
        public DataTable DataMonHoc()
        {
            return DataProcess.Instance.dataTable("Select * from View_Mon");
        }
        public void InsertDataMon(String MaMon, String TenMon, int SoTC,String MaBoMon)
        {
            DataProcess.Instance.CapNhatDuLieu("insert into MonHoc(MaMon,TenMon,SoTC,MaBoMon) Values('"+MaMon+"',N'"+TenMon+"',"+SoTC+",'"+MaBoMon+"')");
        }
        public void UpdateDataMon(String MaMon, string TenMon,int SoTC ,String MaBoMon)
        {
            DataProcess.Instance.CapNhatDuLieu("update MonHoc set TenMon = N'"+TenMon+"',SoTC = "+SoTC+",MaBoMon = '"+MaBoMon+"' where MaMon = '"+MaMon+"'");
        }
        public void DeleteDataMon(String MaMon)
        {
            DataProcess.Instance.CapNhatDuLieu("Delete from MonHoc where MaMon = '" + MaMon + "'");
        }
        public DataTable DataMonHocByMaMon(String MaMon)
        {
            return DataProcess.Instance.dataTable("exec dataMonHocByMaMon '" + MaMon + "'");
        }
        public SqlDataReader DataMaBoMon()
        {
            return DataProcess.Instance.DataReader("select MaBoMon from BoMon");
        }
        public Boolean CheckMaMon(String MaMon)
        {
            Boolean check;
            DataTable data = new DataTable();
            data = DataProcess.Instance.dataTable("select * from MonHoc where MaMon = '" + MaMon + "'");
            if (data.Rows.Count > 0) check = true;
            else check = false;
            return check;
        }
        public Boolean CheckTenMon(String TenMon)
        {
            Boolean check;
            DataTable data = new DataTable();
            data = DataProcess.Instance.dataTable("select * from MonHoc where TenMon = N'" + TenMon + "'");
            if (data.Rows.Count > 0) check = true;
            else check = false;
            return check;
        }
    }
}
