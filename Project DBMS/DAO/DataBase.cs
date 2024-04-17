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

        string connectionSTR = @"Data Source=LAPTOP-4TT7LL7D\NGUYENHIEPKA;Initial Catalog=QuanLyKTX;Integrated Security=True;Encrypt=False";
        public DataTable Execute (string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

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

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

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
