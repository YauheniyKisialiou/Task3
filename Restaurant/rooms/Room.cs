using Restaurant.human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.rooms
{
    public class Room
    {
        public List<Client> ListOfClients { get; set; }
        public List<Employee> ListOfEmployees { get; set; }
    }
}
