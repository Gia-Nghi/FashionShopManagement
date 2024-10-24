using System;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        private string connectionString = "Data Source=ASUS-TUFGAMING;Initial Catalog=KVShop;Integrated Security=True;Encrypt=False";

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    var parameterNames = command.Parameters;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        command.Parameters.AddWithValue(parameterNames[i].ParameterName, parameters[i]);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }
    }
}
