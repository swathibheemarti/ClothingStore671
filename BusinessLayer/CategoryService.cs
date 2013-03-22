using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Clothes671.DAL;


namespace Clothes671.BL
{
    public static class CategoryService
    {
        public static DataSet GetCategories()
        {
            return CategoryRepository.GetCategories();
        }
    }
}