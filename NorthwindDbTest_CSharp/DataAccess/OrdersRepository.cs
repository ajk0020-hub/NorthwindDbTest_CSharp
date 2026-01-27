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

        public IEnumerable<Order> GetByProductID(int id)
        {
            IEnumerable<Order> orders = GetAll();
            orders = orders.Where(order => order.details.First().productId == id);
            return orders;
        }
    }
}