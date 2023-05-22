using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    internal class StringDemo
    {
        public StringDemo()
        {
            //string str = "string viet thuong";
            //String Str1 = new string("String viet hoa");

            Console.WriteLine("nhap string");
            String s = Console.ReadLine();
            string[] a = s.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i].Trim();
                a[i] = char.ToUpper(a[i][0]) + a[i].Substring(1);
            }

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i].Trim();
            }

            Console.WriteLine("first name: " + a[a.Length-1].Trim());
            Console.Write("surname: ");
            for (int i = 1; i < a.Length-1; i++)
            {
                //Console.Write("[" + a[i].Trim() + "] ");
                Console.Write(a[i].Trim());
            }
            Console.WriteLine("");
            Console.WriteLine("last name: " + a[0].Trim());
        }

    }
}
