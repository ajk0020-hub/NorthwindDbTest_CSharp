using NorthwindDbTest_CSharp.DataAccess;
using NorthwindDbTest_CSharp.Models;
using NorthwindDbTest_CSharp.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindDbTest_CSharp
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                using (ProductsRepository productRepo = new ProductsRepository())
                {
                    IEnumerable<Product> products = productRepo.GetByName(Request.QueryString["name"]);

                    if (products != null)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.AddRange(new DataColumn[10] {
                            new DataColumn("name"),
                            new DataColumn("id"),
                            new DataColumn("supplier"),
                            new DataColumn("catagory"),
                            new DataColumn("quantityPerUnit"),
                            new DataColumn("unitPrice"),
                            new DataColumn("unitsInStock"),
                            new DataColumn("unitsOnOrder"),
                            new DataColumn("reorderLevel"),
                            new DataColumn("discontinued"),
                        });
                        Product product = products.First();//Only 1 product expected
                        String supplierName;
                        if (product.Supplier == null)
                        {
                            supplierName = "N/A";
                        }
                        else
                        {
                            supplierName = product.Supplier.CompanyName;
                        }

                        String catagoryName;
                        if (product.Category == null)
                        {
                            catagoryName = "N/A";
                        }
                        else
                        {
                            catagoryName = product.Category.Name;
                        }
                        dt.Rows.Add(product.Name, product.Id, supplierName, catagoryName, product.QuantityPerUnit, product.UnitPrice, product.UnitsInStock, product.UnitsOnOrder, product.ReorderLevel, product.Discontinued);
                        gvProduct.DataSource = dt;
                        gvProduct.DataBind();

                        using (OrdersRepository orderRepo = new OrdersRepository())
                        {
                            OrderViewModelService orderViewModelService = new OrderViewModelService();
                            IEnumerable<Order> orders = orderRepo.GetByProductID(product.Id);

                            if (orders != null)
                            {
                                gvOrders.DataSource = orderViewModelService.CreateViewModel(orders).OrderBy(o => o.orderDate);
                                gvOrders.DataBind();
                            }
                        }
                    }
                }
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }
    }
}