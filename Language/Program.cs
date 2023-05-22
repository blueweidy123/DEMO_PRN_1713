
using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace Language
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }
        static void Menu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("1 chanle");
            Console.WriteLine("2 duoi 3");
            Console.WriteLine("3 snt");
            Console.WriteLine("4 n snt");
            Console.WriteLine("5 demo string");
            Console.WriteLine("6 list");
            Console.WriteLine("=================================");
            Console.WriteLine("nhap choice:");
            int choice;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("nhap sai dinh dang, moi nhap lai");
                return;
            }

            switch (choice)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("nhap n:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Chanle(n);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("nhap n:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Duoi3(n);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("nhap n:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Snt(n);
                        break;
                    } 
                case 4:
                    {
                        Console.WriteLine("nhap n:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Nsnt(n);
                        break;
                    }
                case 5:
                    {
                        StringDemo sd = new StringDemo();
                        break;
                    }
                case 6:
                    {
                        Demolist();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private static void Demolist()
        {
            List<String> nameList = new List<String>()
            {
                //"Nguyen Van Ty",
                //"Le Quang Hung",
                //"Trinh Thanh Tung",
                //"Nguyen Van A",
                //"Le Quang B",
                //"Trinh Thanh C",
                //"ten < 6",
                //"th an"
            };



            //co ai ho nguyen k, neu co hien ten
            Console.WriteLine("=================================");
            Console.WriteLine("Nguoi ho nguyen:") ;
            foreach (string name in nameList)
            {
                string[] nameParts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string lastName = nameParts[0];

                if (lastName.Equals("Nguyen"))
                {
                    Console.WriteLine(name);
                }
            }
            //tong so ky tu trong ten nguoi co so ky tu <6
            Console.WriteLine("=================================");
            Console.WriteLine("nguoi ten < 6 ky tu:");
            foreach (string name in nameList)
            {
                string nameWithoutSpaces = name.Replace(" ", "");

                if (nameWithoutSpaces.Length < 6)
                {
                    Console.WriteLine(name);
                }
            }
            //nguoi co ten bat dau "T"
            Console.WriteLine("=================================");
            Console.WriteLine("Nguoi ten t:");
            foreach (string name in nameList)
            {
                string[] nameParts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = nameParts[nameParts.Length - 1];

                if (firstName.StartsWith('T'))
                {
                    Console.WriteLine(name);
                }
            }
            //Ten dai nhat
            Console.WriteLine("=================================");
            Console.WriteLine("nguoi ten dai nhat");
            List<String> longestNames = new List<String>();
            int longest = 0;
            foreach (string name in nameList)
            {
                if (longest <= name.Trim().Length)
                {
                    longest = name.Trim().Length;
                }
            }
            foreach (string name in nameList)
            {

                if (name.Trim().Length == longest)
                {
                    Console.WriteLine(name);
                }
            }


        }

        static void Chanle(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("chan");
            }
            else
            {
                Console.WriteLine("le");
            }
        }
        static void Duoi3(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 10 == 3)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine("");
        }
        static void Snt(int n)
        {
            if (IsPrime(n))
            {
                Console.WriteLine("is prime");
            }
            else
            {
                Console.WriteLine("is not prime");
            }
        }
        static void Nsnt(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + ", ");
                }
            }
        }


        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n==2)
            {
                return true;
            }
            for (int i =2; i<n/2;i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }

     
}