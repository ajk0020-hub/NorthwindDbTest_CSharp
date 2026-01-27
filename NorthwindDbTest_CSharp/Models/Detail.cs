using System;

namespace NorthwindDbTest_CSharp.Models
{
    public class Detail
    {
        public int productId { get; set; }
        public float unitPrice { get; set; }
        public int quantity { get; set; }
        public float discount { get; set; }
    }
}