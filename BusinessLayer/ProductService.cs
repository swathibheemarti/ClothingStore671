using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Clothes671.DAL;

namespace Clothes671.BL
{
    public static class ProductService
    {
        public static DataSet GetProducts(decimal categoryID)
        {
            return ProductRepository.GetProducts(categoryID);
        }
    }
}