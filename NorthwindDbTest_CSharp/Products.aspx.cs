using NorthwindDbTest_CSharp.DataAccess;
using NorthwindDbTest_CSharp.Models;
using NorthwindDbTest_CSharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindDbTest_CSharp
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadProducts();
            }
        }

        /// <summary>
        /// Load all Products into the grid.
        /// </summary>
        private void LoadProducts()
        {
            using (ProductsRepository productRepo = new ProductsRepository())
            {
                ProductViewModelService productViewModelService = new ProductViewModelService();
                IEnumerable<Product> products = productRepo.GetAll();

                if (products != null)
                {
                    gvProducts.DataSource = productViewModelService.CreateViewModel(products).OrderBy(x => x.Name);
                    gvProducts.DataBind();
                }
            }
        }

        protected void gvProducts_PreRender(object sender, EventArgs e)
        {
            GridView gv = (GridView)sender;

            if ((gv.ShowHeader == true && gv.Rows.Count > 0) || (gv.ShowHeaderWhenEmpty == true))
            {
                // Force GridView to use <thead> instead of <tbody>
                // This allows the Bootstrap styles to be applied appropriately
                gv.HeaderRow.TableSection = TableRowSection.TableHeader;
            }

            if (gv.ShowFooter == true && gv.Rows.Count > 0)
            {
                // Force GridView to use <tfoot> instead of <tbody>
                // This allows the Bootstrap styles to be applied appropriately
                gv.FooterRow.TableSection = TableRowSection.TableFooter;
            }
        }

        protected void gvProducts_DataBound(object sender, EventArgs e)
        {
            GridView gv = (GridView)sender;

            lblRecordCount.Text = $"Showing 1 to {gv.Rows.Count} of {gv.Rows.Count} entries";
        }

        protected void showAvailableOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAvailableOnly.Checked)
            {
                System.Diagnostics.Debug.WriteLine("Checkbox checked!");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Checkbox unchecked!");
            }
        }
    }
}