using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Clothes671.DAL
{
    public static class ProductRepository
    {
        public static DataSet GetProducts(decimal categoryID)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingConnectionString"].ConnectionString);
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