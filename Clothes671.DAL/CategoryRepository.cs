using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Clothes671.DAL
{
    public static class CategoryRepository
    {
        public static DataSet GetCategories()
        {
            DataSet ds = new DataSet();

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingConnectionString"].ConnectionString);
            sqlConnection.Open();
            
            String sqlString = "select * from Category";

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