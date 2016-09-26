using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.objects
{
    public class Order
    {
        public decimal CostOfOrder { get; set; }

        public enum OrderStatus
        {
            NOTREADY,
            TAKEN,
            COOKING,
            READY
        }

        public OrderStatus Status { get; set; }

        //public bool OrderStatus { get; set; }

        public Order()
        {
            CostOfOrder = 70m;
            Status = OrderStatus.NOTREADY;
        }
    }
}
