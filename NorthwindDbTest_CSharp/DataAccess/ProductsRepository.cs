using NorthwindDbTest_CSharp.Models;
using System.Collections.Generic;

namespace NorthwindDbTest_CSharp.DataAccess
{
    internal class ProductsRepository : BaseRepository<Product>
    {
        /// <summary>
        /// Gets or sets the Northwind API endpoint used by this repository.
        /// </summary>
        public override string Endpoint { get => NorthwindApiEndpoints.Products; }

        public IEnumerable<Product> GetAvailable()
        {
            return GetDataFromEndpoint<IEnumerable<Product>>($"{Endpoint}?discontinued=false");
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return GetDataFromEndpoint<IEnumerable<Product>>($"{Endpoint}?name={name}");
        }
    }
}