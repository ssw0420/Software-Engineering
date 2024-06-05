using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; } // 외래 키
    }

    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Map(m => m.OrderId).Name("orderId");
            Map(m => m.OrderDate).Name("orderDate");
            Map(m => m.UserId).Name("userId");
        }
    }
}
