using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clothes671.Managers;

namespace Clothes671
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindPage();
        }

        private void BindPage()
        {
            BindCategories();
        }

        private void BindCategories()
        {
            lstCategories.DataSource = CategoryManager.GetCategories();
            lstCategories.DataTextField = "Name";
            lstCategories.DataValueField = "CategoryID";
            lstCategories.DataBind();
        }

        protected void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProducts.DataSource = ProductManager.GetProducts(decimal.Parse(lstCategories.SelectedValue));
            lstProducts.DataTextField = "Name";
            lstProducts.DataValueField = "ProductID";
            lstProducts.DataBind();
        }
    }
}