using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; } // 외래 키
        public int ProductId { get; set; } // 외래 키
    }

    public class OrderItemMap : ClassMap<OrderItem>
    {
        public OrderItemMap()
        {
            Map(m => m.OrderItemId).Name("orderItemId");
            Map(m => m.Quantity).Name("quantity");
            Map(m => m.Price).Name("price");
            Map(m => m.OrderId).Name("orderId");
            Map(m => m.ProductId).Name("productId");
        }
    }
}
