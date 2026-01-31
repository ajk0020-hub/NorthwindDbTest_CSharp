using NorthwindDbTest_CSharp.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindDbTest_CSharp.DataAccess
{
    internal class CategoryRepository : BaseRepository<Category>
    {
        public override string Endpoint { get => NorthwindApiEndpoints.Categories; }

    }
}