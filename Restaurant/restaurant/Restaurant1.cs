using Restaurant.human;
using Restaurant.rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.restaurant
{
    public class Restaurant1
    {
        public Restaurant1()
        {
            Hall hall = new Hall();
            Kitchen kitchen = new Kitchen();

            Client client = hall.ListOfClients[0];
            Waiter waiter = (Waiter)hall.ListOfEmployees[0];
            Chef chef = (Chef)kitchen.ListOfEmployees[0];

            client.TakeMenu(waiter.GiveMenu(1));
            client.MakeOrder();
            waiter.GetOrder(client.ClientOrder);
            hall.GoToKitchen(waiter, kitchen.ListOfEmployees);
            chef.GetOrder(waiter.GiveOrder());
            chef.Cook();
            waiter.GetOrder(chef.GiveOrder());
            waiter.MakeBill();
            kitchen.GoToHall(waiter, hall.ListOfEmployees);
            client.GetReadyOrder(waiter.GiveOrder());
            client.Eat();
            client.GetBill(waiter.GiveBill());
            client.Pay();
        }
        
    }
}
