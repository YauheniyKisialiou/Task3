using Restaurant.human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.rooms
{
    public class Hall:Room
    {

        public Hall()
        {
            ListOfClients = new List<Client>();
            ListOfClients.Add(new Client("Flash", 100m, 0.5, false));
            ListOfEmployees = new List<Employee>();
            ListOfEmployees.Add(new Waiter("BatMan", "waiter", 2));
        }

        public void GoToKitchen(Employee employee, List<Employee> listOfEmploees)
        {

            listOfEmploees.Add(employee);
            ListOfEmployees.Remove(employee);
        }
    }
}
