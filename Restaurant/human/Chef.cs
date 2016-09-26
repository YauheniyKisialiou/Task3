using Restaurant.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.human
{
    public class Chef:Employee
    {
        public Chef(string name, string profession) : base(name, profession)
        {
           
        }

        public void Cook()
        {
            ListOfOrder[0].OrderStatus = true;

        }

    }
}
