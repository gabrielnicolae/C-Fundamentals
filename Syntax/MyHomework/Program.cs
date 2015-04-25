using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Gabriel", "Nicolae", DateTime.MinValue, DateTime.MinValue, 100.0, 10);
            employee.DisplayInfo();
            Leave leave = new Leave(DateTime.MinValue, 20, "E bolnav");
            employee.AddNewLeave(leave);
            employee.DisplayInfo();
            Console.ReadKey();
        }
    }
}
