using System;
using System.Collections.Generic;

namespace NorthwindDbTest_CSharp.Models
{
    public class Order
    {
        public int id { get; set; }
        public String customerId { get; set; }
        public int employeeId { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime requiredDate { get; set; }
        public string shipDate { get; set; }
        public int shipVia { get; set; }
        public decimal freight { get; set; }
        public String shipName { get; set; }
        public Address shipAddress { get; set; }
        public List<Detail> details { get; set; }
    }
}