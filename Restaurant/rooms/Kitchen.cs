using Restaurant.human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.rooms
{
    public class Kitchen:Room
    {
        public Kitchen()
        {
            ListOfEmployees = new List<Employee>();
            ListOfEmployees.Add(new Chef("WonderWoman", "chef"));
        }

        public void GoToHall(Employee employee, List<Employee> listOfEmploees)
        {
            listOfEmploees.Add(employee);
            ListOfEmployees.Remove(employee);
        }
    }
}
