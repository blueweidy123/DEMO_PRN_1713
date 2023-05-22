namespace OOP 
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            //KHai bao va khoi tao 1 list teacher
            List<Teacher> data = new List<Teacher>()
            {
                //new FullTime("TO1","Nguyen Van A", 4.0),
                //new PartTime("TO2","Nguyen Van B", 10),
                //new FullTime("TO3","Nguyen Van C", 1.5),
                //new FullTime("TO1","Nguyen Van z", 2.0),
                //new PartTime("TO2","Nguyen Van y", 10),
                //new PartTime("TO2","Nguyen Van Ty", 100),
                //new FullTime("TO3","Nguyen Van x", 1.5)
            };
            IManager m = new Manager(data);   

            while (true)
            {
                Console.WriteLine("========================================================");
                Console.WriteLine("1.input teacher");
                Console.WriteLine("2.list teacher");
                Console.WriteLine("3.highest salary");
                Console.WriteLine("4.number of part time > 10 slot");
                Console.WriteLine("5.total number of part time slot");
                Console.WriteLine("6.sort list salary asc");
                Console.WriteLine("7.Name start with T");
                Console.WriteLine("8.FullTime coefficient < 3");
                Console.WriteLine("9.Save to file");
                Console.WriteLine("10.Load from file");
                Console.WriteLine("========================================================");

                int option = Convert.ToInt32(Console.ReadLine());   

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter size");
                            int size = Convert.ToInt32(Console.ReadLine());
                            m.InputList(size);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("List all");
                            m.OutputList();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Highest Salary");
                            m.ListHighestSalary();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("PartTime have more than 10slot");
                            m.PtThan10();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Total slot");
                            m.TotalSlot();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Sort Salary asc");
                            m.SortBySalary();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Start With T");
                            m.NameStartWith("T");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Fulltime Coefficient < 3:");
                            m.SeparateFullTimeCoE();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Save to file:");
                            m.SaveFile();
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Load from file");
                            m.LoadFile();
                            break;
                        }
                }
            }
        }
    }
}