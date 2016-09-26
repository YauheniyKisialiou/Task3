using Restaurant.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.interfaces
{
    public interface IEmployee
    {
        Order GiveOrder();
        void GetOrder(Order order);
    }
}
