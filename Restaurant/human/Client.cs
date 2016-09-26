
using Restaurant.interfaces;
using Restaurant.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.human
{
     public class Client:Human, IClient
    {
        public Bill ClientBill { get; set; }
        public bool Menu { get; set; }
        public double Hunger { get; set; }
        public decimal Money { get; set; }
        public Order ClientOrder { get; set; }
        public bool Order { get; set; }
        public Menu ClientMenu { get; set; }

        public Client(string name, decimal money, double hunger, bool order):base(name)
        {
            Money = money;
            Hunger = hunger;
            Order = order;
        }

        public void Eat()
        {
            Hunger = 1;
        }

        public void MakeOrder()
        {
            Order = true;
            ClientOrder = new Order();
            
        }

        public void TakeMenu(Menu menu)
        {
            ClientMenu = menu;
            Menu = true;
        }

        public void GetReadyOrder(Order readyOrder)
        {
            ClientOrder = readyOrder;
        }

        public void GetBill(Bill bill)
        {
            ClientBill = bill;
        }

        public void Pay()
        {
            Money -= ClientBill.CostOfBill;
        }

    }
}
