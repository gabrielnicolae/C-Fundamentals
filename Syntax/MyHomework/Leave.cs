using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {
        public DateTime startingDate;
        public int duration;
        public string leaveType;
        public Employee employee;

        public Leave(DateTime startingdate, int duration, string leavetype)
        {
            this.startingDate = startingdate;
            this.duration = duration;
            this.leaveType = leavetype;
            this.employee = new Employee();
        }
        public void PrintLeave()
        {
            Console.WriteLine("Starting date : {0} ", this.startingDate.ToString());
            Console.WriteLine("Duration : {0}", this.duration);
            Console.WriteLine("Motive : {0}", this.leaveType);
        }
    }
}
