using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages
{
    static class SQLCon
    {
        public static DataSet dataSet = new DataSet();
        public static SqlCommand sqlCommand;
        //public static SqlDataReader sqlDataReader;
        public static SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public static SqlConnection sqlConnection = new SqlConnection();
        public static DataTable dataTable = new DataTable();
        //public static string sql;

        static string dataSource = "PpYCha";
        static string databaseName = "AxaD";

        public static void dbCon()
        {
            try
            {
                sqlConnection.Close();
                sqlConnection = new SqlConnection("Data Source='" + dataSource + "'; Initial Catalog='" + databaseName + "'; Integrated Security=true");
                sqlConnection.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("System can not stablish a connection to database!");

            }
        }
    }
}
