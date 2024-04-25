using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Project_DBMS.DAO
{
    public class DataBase
    {
        private static DataBase instance;

        public static DataBase Instance
        {
            get { if (instance == null) instance = new DataBase(); return DataBase.instance; }
            private set => instance = value;
        }

        private DataBase() { }
        public string ConnectionSTR { get => connectionSTR; set => connectionSTR = value; }


        //Chuỗi xác định kết nối
        static string connectionSTR = @"Data Source=DuyHao\DUYHAO;Initial Catalog=QuanLyKTX;Integrated Security=True;Encrypt=False";
        public void DangNhap (string UserName, string Password)
        {
            ConnectionSTR = @"Data Source=DuyHao\DUYHAO;Initial Catalog=QuanLyKTX;Integrated Security=True;User ID=" + UserName+", Password ="+ Password+ ";Encrypt=False";
        }

        public DataTable Execute (string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR)) //kết nối từ client tới sever
            {
                // mở connection
                connection.Open();

                // Thực thi câu truy vấn tới sever kết nối
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (string s in list)
                    {
                        if (s.Contains('@'))
                        {
                            //Tham số đầu tiên trong mảng sẽ được ánh xạ đến
                            //tham số đầu tiên được tìm thấy trong truy vấn
                            command.Parameters.AddWithValue(s, parameter[i]);
                            i++;
                        }
                    }
                }

                // Trung gian để thực hiện câu truy vấn lấy dữ liệu ra
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Đổ dữ liệu đã lấy ra được vào data
                adapter.Fill(data);

                // Đóng connection
                connection.Close();

                return data;
            }
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                //Thực thi trên csdl
                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
    }
}
