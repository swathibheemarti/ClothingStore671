using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Clothes671.Managers
{
    public static class ProductManager
    {
        public static DataSet GetProducts(decimal categoryID)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlConnection = new SqlConnection("Data Source=KiranMSI\\SQLExpress;Initial Catalog=Clothes671;Integrated Security=SSPI");
            sqlConnection.Open();

            String sqlString = "select * from Product where CategoryID = " + categoryID.ToString();

            SqlCommand cmd = new SqlCommand(sqlString, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            dataAdapter.Fill(ds);

            cmd.Dispose();
            sqlConnection.Close();
            sqlConnection.Dispose();

            return ds;
        }
    }
}