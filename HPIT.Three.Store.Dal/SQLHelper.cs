using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace HPIT.Three.Store.Dal
{
    public class SQLHelper
    {
        private static string sql = ConfigurationManager.ConnectionStrings["BookStoreConnectionString"].ConnectionString;

        public static DataTable Sel(string proc, SqlParameter[] par = null)
        {
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection(sql);
            SqlCommand comm = new SqlCommand(proc, conn);
            comm.CommandType = CommandType.StoredProcedure;
            if (par != null)
                comm.Parameters.AddRange(par);

            SqlDataAdapter sda = new SqlDataAdapter(comm);
            sda.Fill(table);
            return table;
        }

        public static bool NanQuery(string proc, SqlParameter[] par = null)
        {
            int num = 0;
            SqlConnection conn = new SqlConnection(sql);
            SqlCommand comm = new SqlCommand(proc, conn);
            comm.CommandType = CommandType.StoredProcedure;
            if (par != null)
                comm.Parameters.AddRange(par);
            try
            {
                conn.Open();
                num = comm.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
            return num > 0 ? true : false;
        }
    }
}
