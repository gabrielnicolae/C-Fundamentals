using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Employee : Person
    {
        private DateTime dateOfEmployment;
        private double salary;
        private int availableDaysOff;
        public List<Leave> leaveList = new List<Leave>();

        public Employee(string lastname, string fistname, DateTime dateofbirth, DateTime dateofemployment, double salary, int availabledaysoff)
        {
            this.lastname = lastname;
            this.fistname = fistname;
            this.dateOfBirth = dateofbirth;
            this.dateOfEmployment = dateofemployment;
            this.salary = salary;
            this.availableDaysOff = availabledaysoff;
        }
        public Employee() : this(null, null, DateTime.MinValue, DateTime.MinValue, 0.0, 0) { }

        public void DisplayInfo()
        {
            Console.WriteLine("Nume : {0}", this.lastname);
            Console.WriteLine("Prenume : {0}", this.fistname);
            Console.WriteLine("Salariu : {0}", this.salary);
            Console.WriteLine("Numar zile disponibile : {0}", this.availableDaysOff);
        }

        private void SubstractDays(int days)
        {
            this.availableDaysOff -= days;
        }

        public void AddNewLeave(Leave leave)
        {
            leave.employee = this;
            if (leave.duration > leave.employee.availableDaysOff)
            {
                throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
            }
            else
            {
                leave.employee.SubstractDays(leave.duration);
                leaveList.Add(leave);
            }
        }
        public void Get2015Leave()
        {
            foreach (var i in leaveList)
            {
                if (i.startingDate.Year == 2015)
                {
                    i.PrintLeave();
                }
            }
        }
    }
}
