namespace Assignment1
{
    public class Program
    {
        //-	code, name, address, shirt number, position, salary.
        //-code, name, address, position,salary, years of
        static void Main(string[] args)
        {
            List<Human> data = new List<Human>()
            {
                new Player(1, "name", "place", 10000, "pos1", 10),
                new Player(2, "name2", "place1", 30000, "pos2", 222),
                new Player(3, "name3", "place2", 20000, "pos3", 1),
                new Player(4, "name4", "place3", 220000, "pos4", 4),
                new Player(5, "mesia", "place2", 220000, "striker", 7),
                new Player(6, "rolnadian", "place2", 120000, "striker", 44)
            };
            IManager manager = new Manager(data);
            //manager.OutputList();

            while (true)
            {
                Console.WriteLine("========================================================");
                Console.WriteLine("1.input list");
                Console.WriteLine("2.show");
                Console.WriteLine("3.change");
                Console.WriteLine("4.sum salary striker");
                Console.WriteLine("5.max salary");
                Console.WriteLine("6.sort list salary asc");
                Console.WriteLine("========================================================");

                int option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter size");
                            int size = Convert.ToInt32(Console.ReadLine());
                            manager.InputList(size);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("List all");
                            manager.OutputList();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("change");
                            Console.WriteLine("Enter code");
                            int code = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("[0]change shirt/ [1]change salary");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            if (opt == 0)
                            {
                                Console.WriteLine("Enter new shirt");
                                int shirt = Convert.ToInt32(Console.ReadLine());
                                manager.ChangePlayer(code, opt, shirt,0);
                            }
                            else
                            {
                                Console.WriteLine("Enter new salary");
                                double sala = Convert.ToDouble(Console.ReadLine());
                                manager.ChangePlayer(code, opt, 0, sala);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4.sum salary");
                            manager.SumSalary("striker");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("max");
                            manager.ShowMaxLuong();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Sort Salary asc");
                            manager.ShortByShirt();
                            break;
                        }

                }
            }
        }
    }
}