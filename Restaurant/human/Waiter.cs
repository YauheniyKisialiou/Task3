using Restaurant.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.human
{
    public class Waiter:Employee
    {
        public Bill ClientBill { get; set; }
        public List<Menu> ListOfMenu { get; set; }

        public Waiter(string name, string profession, int numberOfMenu) : base(name, profession)
        {
            ListOfMenu = new List<Menu>();
            for (int i = 0; i < numberOfMenu; i++)
            {

                ListOfMenu.Add(new Menu($"{i}"));
            }
        }

        public Menu GiveMenu(int numberOfMenu)
        {
            Menu tempMenu = ListOfMenu[0];
            ListOfMenu.RemoveAt(0);
            return tempMenu;
        }

        public Bill GiveBill()
        {
            return ClientBill;
        }

        public void MakeBill()
        {
            ClientBill = new Bill(ListOfOrder[0].CostOfOrder);
        }

        


    }
}
