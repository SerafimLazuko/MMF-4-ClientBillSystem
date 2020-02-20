using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBillWebApp.Models
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }
        public double OrderCost { get; set; }
    }
}
