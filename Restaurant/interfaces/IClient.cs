using Restaurant.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.interfaces
{
    public interface IClient
    {
        void Eat();
        void TakeMenu(Menu menu);
        void MakeOrder();
        void GetReadyOrder(Order readyOrder);
        void GetBill(Bill bill);
        void Pay();
    }
}
