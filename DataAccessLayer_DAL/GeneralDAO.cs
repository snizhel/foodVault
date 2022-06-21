using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class GeneralDAO
    {
        //public string connectionString = "Data source=.; user id =sa; " +
        //        "password=1; initial catalog =ProjectQLKTP12";
        public string connectionString = "Data source=DESKTOP-8ID1E1D\\DUYJOHANNES; user id =sa; " +
                "password=1; initial catalog =ProjectQLKTPDB";
        SqlConnection con = null;

        public DataSet getAll(string tblName)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + tblName, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet search(string tblName, string whereSql)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + tblName + " where " + whereSql, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public SqlConnection getConnection()
        {
            if (con == null)
                con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        public void closeConnection()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con = null;
            }
        }
        public void closeConnerction(SqlConnection con)
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con = null;
            }
        }
        public SqlDataReader findById(string tblName, string where_primarykey_id)
        {
            string sql = "select * from " + tblName + " where " + where_primarykey_id;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public int insert_update_delete(string sql)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            int result = cmd.ExecuteNonQuery();
            closeConnerction(con);
            return result;
        }
    }
}
