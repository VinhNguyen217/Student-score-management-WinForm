using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyDiem.DAO
{
  
    class DataProcess
    {
        private static DataProcess instance;
        private String strConnect = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyDiemSinhVien;Integrated Security=True";
        private SqlConnection connection;

        public static DataProcess Instance
        {
            get
            {
                if (instance == null) instance = new DataProcess();
                return DataProcess.instance;
            }
            private set { DataProcess.instance = value; }
        }
        private DataProcess() { }
        private void OpenDataBase()
        {
            connection = new SqlConnection(strConnect);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        private void CloseDataBase()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public DataTable dataTable(String query)
        {
            DataTable data = new DataTable();
            OpenDataBase();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(data);
            return data;
        }
        public void CapNhatDuLieu(String query)
        {
            OpenDataBase();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            command.ExecuteNonQuery();
            CloseDataBase();
        }
        public SqlDataReader DataReader(String query)
        {
            OpenDataBase();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            SqlDataReader dataReader = command.ExecuteReader();
            return dataReader;      
        }
    }
}
