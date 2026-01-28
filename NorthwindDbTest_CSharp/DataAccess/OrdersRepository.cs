using NorthwindDbTest_CSharp.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindDbTest_CSharp.DataAccess
{
    internal class OrdersRepository : BaseRepository<Order>
    {
        /// <summary>
        /// Gets or sets the Northwind API endpoint used by this repository.
        /// </summary>
        public override string Endpoint { get => NorthwindApiEndpoints.Orders; }

        public IEnumerable<Order> GetByProductID(int id) //Each order that is returned will contain one entry in the details list which contains the product being searched for
        {
            IEnumerable<Order> orders = GetAll();
            foreach(Order order in orders)
            {
                order.details = order.details.Where(detail => detail.productId == id).ToList();
            }
            orders = orders.Where(order => order.details.Count == 1);
            return orders;
        }
    }
}