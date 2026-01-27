using System;

namespace NorthwindDbTest_CSharp.ViewModels
{
    public class OrderViewModel
    {
        public int id { get; set; }
        public string shipName { get; set; }
        public string orderDate { get; set; }
        public string shipDate { get; set; }
        public string shipAddress { get; set; }
        public int quantity { get; set; }
    }
}