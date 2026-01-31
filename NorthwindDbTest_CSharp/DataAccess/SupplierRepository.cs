using NorthwindDbTest_CSharp.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindDbTest_CSharp.DataAccess
{
    internal class SupplierRepository : BaseRepository<Supplier>
    {
        public override string Endpoint { get => NorthwindApiEndpoints.Suppliers; }
        
    }
}