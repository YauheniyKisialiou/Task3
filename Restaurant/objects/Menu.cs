using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.objects
{
    public class Menu
    {
        public string MenuNumber { get; set; }

        public Menu(string menuNumber)
        {
            MenuNumber = menuNumber;
        }

    }
}
