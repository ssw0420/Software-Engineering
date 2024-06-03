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
        public DateTime OrderTime { get; set; }
        public string OrderPay { get; set; }
        public int OrderQuan { get; set; }
        public string OrderPayment { get; set; }
        public int TableNum { get; set; }
        public int ProductId { get; set; }
    }
}
