using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.objects
{
    public class Bill
    {
        public decimal CostOfBill { get; set; }

        public Bill(decimal costOfOrder)
        {
            CostOfBill = costOfOrder;
        }
    }
}
