using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //    -	code, name, address, shirt number, position, salary.
    //-code, name, address, position,salary, years of
    public class Coach : Human
    {
        public int yearsOf { get; set; }

        public Coach()
        {
            
        }

        public Coach(int code, string name, string address, double salary, string position, int year) : base(code, name, address, salary, position)
        {
            yearsOf = year;
        }
    }
}
