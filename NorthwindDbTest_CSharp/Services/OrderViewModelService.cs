using NorthwindDbTest_CSharp.Models;
using NorthwindDbTest_CSharp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace NorthwindDbTest_CSharp.Services
{
    public class OrderViewModelService : IViewModelService<OrderViewModel, Order>
    {
        public OrderViewModelService()
        {

        }

        /// <summary>
        /// Creates a <see cref="ProductViewModel"/> from a provided <see cref="Product"/> model.
        /// </summary>
        /// <param name="source">The <see cref="Product"/> model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public OrderViewModel CreateViewModel(Order source)
        {
            if (source == null) { throw new ArgumentNullException(nameof(source)); }

            string sd;
            if(source.shippedDate != "NULL")
            {
                sd = source.shippedDate.Substring(0, 10);
            }
            else
            {
                sd = "Not Shipped";
            }

            string sa;
            if (source.shipAddress.Region != "NULL")
            {
                sa = source.shipAddress.Street + ", " + source.shipAddress.City + ", " + source.shipAddress.Region + ", " + source.shipAddress.PostalCode + ", " + source.shipAddress.Country;
            }
            else
            {
                sa = source.shipAddress.Street + ", " + source.shipAddress.City + ", " + source.shipAddress.PostalCode + ", " + source.shipAddress.Country;
            }

            return new OrderViewModel()
            {
                id = source.id,
                shipName = source.shipName,
                orderDate = source.orderDate.ToString("yyyy-MM-dd"),
                shippedDate = sd,
                shipAddress = sa,
                quantity = source.details.First().quantity
            };
        }

        public IEnumerable<OrderViewModel> CreateViewModel(IEnumerable<Order> source)
        {
            if (source == null) { throw new ArgumentNullException(nameof(source)); }

            return source.Select(order => CreateViewModel(order));
        }
    }
}