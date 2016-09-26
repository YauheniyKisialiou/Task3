using Restaurant.interfaces;
using Restaurant.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.human
{
    public class Employee:Human, IEmployee
    {
        public List<Order> ListOfOrder { get; set; }

        public string Profession { get; set; }

        public Employee(string name, string profession):base(name)
        {
            Profession = profession;
        }

        public virtual void GetOrder(Order order)
        {
            ListOfOrder = new List<Order>();
            order.Status = Order.OrderStatus.TAKEN;
            ListOfOrder.Add(order);
            
        }

        public Order GiveOrder()
        {
            Order tempOrder = ListOfOrder[0];
            ListOfOrder.RemoveAt(0);
            tempOrder.Status = Order.OrderStatus.TAKEN;
            return tempOrder;
        }

    }
}
