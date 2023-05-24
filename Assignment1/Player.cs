using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //    -	code, name, address, shirt number, position, salary.
    //-code, name, address, position,salary, years of
    public class Player : Human
    {
        public int ShirtNumber { get; set; }

        public Player()
        {
            
        }

        public Player(int code, string name, string address, double salary, string position, int shirt) : base(code, name, address, salary, position)
        {
            ShirtNumber = shirt;
        }

        public override string? ToString()
        {
            return base.ToString() + "\t"+ShirtNumber;
        }
    }
}
