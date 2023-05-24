using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-Player: with the informations: code, name, address, shirt number , position, salary.
//-	Coach: with the informations: code, name, address, position, salary, years of 

namespace Assignment1
{
    public class Human
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }

        public Human()
        {
            
        }

        public Human(int code, string name, string address, double salary, string position)
        {
            Code = code;
            Name = name;
            Address = address;
            Salary = salary;
            Position = position;
        }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Position + "\t" + Salary + "\t" + Address;
        }
        //public abstract double GetSalary();


    }
}
