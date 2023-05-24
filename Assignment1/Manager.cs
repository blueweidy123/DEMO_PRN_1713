using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Manager : IManager
    {

        public List<Human> Data { get; set; }

        public Manager()
        {
            
        }

        public Manager(List<Human> data)
        {
            this.Data = data;
        }

        public void ChangePlayer(int code, int option, int shirtNum, double salary)
        {
            if (option == 0)
            {
                foreach (Human human in Data) { 
                    if (human.Code == code) {
                        if (human is Player)
                        {
                            Player player = (Player)human;  
                            player.ShirtNumber = shirtNum;
                        }
                    }
                }
            }
            else
            {
                foreach (Human human in Data)
                {
                    if (human.Code == code)
                    {
                        human.Salary    = salary;
                    }
                }
            }

        }

        public void InputList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Code");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter address");
                string addr = Console.ReadLine();
                Console.WriteLine("player[0] or coach[1]?");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Postion");
                string posi = Console.ReadLine();
                Console.WriteLine("Enter salary");
                double salary = Convert.ToDouble(Console.ReadLine());

                if (option == 0)
                {
                    Console.WriteLine("Enter shirt number");
                    int sn = Convert.ToInt32(Console.ReadLine());
                    Human p = new Player(c, name, addr, salary, posi, sn);
                    Data.Add(p);
                    
                }
                else
                {
                    Console.WriteLine("Enter years of ex ");
                    int yoe = Convert.ToInt32(Console.ReadLine());
                    Human p = new Coach(c, name, addr, salary, posi, yoe);
                    Data.Add(p);
                }
            }
        }

        public void OutputList()
        {
            foreach (Human human in Data)
            {
                Console.WriteLine(human.ToString());    
            }
        }

        public void ShortByShirt()
        {
            for (int i=0; i<Data.Count; i++)
            {
                for (int j = i+1; j < Data.Count; j++)
                {
                    if (((Player)Data[i]).ShirtNumber > ((Player)Data[j]).ShirtNumber)
                    {
                        Human p = (Player)Data[i];
                        Data[i] = Data[j];
                        Data[j] = p;

                        //Human p1 = (Player)Data[j];


                    }
                }
            }
        }

        public void ShowMaxLuong()
        {
            //Console.WriteLine("max");
            double max = 0;
            foreach(Human human in Data)
            {
                if (max < human.Salary)
                {
                    max = human.Salary;
                }
            }
            foreach(Human human in Data)
            {
                if (human.Salary == max)
                {
                    Console.WriteLine(human.ToString());
                }
            }
        }

        public void SumSalary(string position)
        {
            double sum = 0;
            foreach(Human human in Data)
            {
                if (human.Position == position)
                {
                    sum += human.Salary;
                }
            }
            Console.WriteLine("sum:"+sum);
        }
    }
}
