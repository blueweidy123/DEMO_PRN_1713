using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Manager : IManager
    {

        public List<Teacher> Data { get; set; }

        public Manager()
        {

        }

        public Manager(List<Teacher> data)
        {
            this.Data = data;
        }

        public void InputList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Code");
                string code = Console.ReadLine();
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("FullTime[0] or PartTime[1]?");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 0)
                {
                    Console.WriteLine("Enter He so");
                    double heso = Convert.ToDouble(Console.ReadLine());
                    Teacher T = new FullTime(code, name, heso);
                    Data.Add(T);
                }
                else
                {
                    Console.WriteLine("Enter Slot");
                    int slot = Convert.ToInt32(Console.ReadLine());
                    Teacher T = new PartTime(code, name, slot);
                    Data.Add(T);
                }
            }
        }

        public void OutputList()
        {
            foreach (Teacher t in Data)
            {
                Console.WriteLine(t);
            }
        }

        public void ListHighestSalary()
        {
            double maxSalary = Data[0].GetSalary();
            foreach (Teacher t in Data)
            {
                if (maxSalary <= t.GetSalary())
                {
                    maxSalary = t.GetSalary();
                }
            }
            foreach (Teacher th in Data)
            {
                if (maxSalary == th.GetSalary())
                {
                    Console.WriteLine(th.ToString());
                }
            }

        }

        public void PtThan10()
        {
            int slotCount = 0;
            foreach (Teacher t in Data)
            {
                if (t is PartTime)
                {
                    PartTime pt = (PartTime)t;
                    if (pt.Slot > 10)
                    {
                        slotCount++;
                    }
                }
            }
            Console.WriteLine("number of pt have > 10slot:" + slotCount);
        }

        public void TotalSlot()
        {
            int slotCount = 0;
            foreach (Teacher t in Data)
            {
                if (t is PartTime)
                {
                    PartTime pt = (PartTime)t;
                    slotCount += pt.Slot;
                }
            }
            Console.WriteLine("Total number of slot:" + slotCount);
        }

        public void SortBySalary()
        {
            Data = Data.OrderBy(o => o.GetSalary()).ToList();
        }

        public void NameStartWith(string input)
        {
            foreach (Teacher t in Data)
            {
                string[] nameParts = t.Name.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = nameParts[nameParts.Length - 1];

                if (firstName.StartsWith('T'))
                {
                    Console.WriteLine(t.ToString());
                }
            }

        }

        public void SeparateFullTimeCoE()
        {
            foreach (Teacher t in Data)
            {
                if (t is FullTime)
                {
                    FullTime fullTime = (FullTime)t;
                    if (fullTime.Heso < 3)
                    {
                        string[] nameParts = t.Name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine($"{fullTime.Code}\t{nameParts[0]}\t{nameParts[nameParts.Length - 1]}\t{fullTime.Heso}\t{fullTime.GetSalary()}");
                    }
                }
            }
        }

        public void SaveFile()
        {
            try
            {
                //string fileName = "E:\\..\\..\\..\\data.txt";
                string fileName = "..\\..\\..\\data.txt";
                //Cach 1
                //StreamWriter sw = new StreamWriter(fileName);
                //sw.WriteLine("Cach 2");
                //sw.Close();

                //Cach2
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach (Teacher t in Data)
                    {
                        if (t is FullTime)
                        {
                            sw.WriteLine(t.ToString() + "\t0");
                        }
                        else
                        {
                            sw.WriteLine(t.ToString() + "\t1");
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Save failded:" + e.Message);
            }
        }

        public void LoadFile()
        {
            Data.Clear();
            try
            {
                string fileName = "..\\..\\..\\data.txt";
                //Cach 1
                //StreamWriter sw = new StreamWriter(fileName);
                //sw.WriteLine("Cach 2");
                //sw.Close();

                //Cach2
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        line = line.Trim();
                        if (!string.IsNullOrEmpty(line))
                        {

                            string[] s = line.Split("\t");
                            if (s.Length == 4)
                            {
                                string code = s[0];
                                if (checkCode(Data, code))
                                {
                                    line = sr.ReadLine();
                                    continue;
                                }
                                string name = s[1];
                                double salary = Convert.ToDouble(s[2]);
                                if (s[3].Equals("0"))
                                {
                                    double heso = salary / 2000000;
                                    Teacher T = new FullTime(code, name, heso);
                                    Data.Add(T);
                                }
                                else
                                {
                                    int slot = (int)salary / 100000;
                                    Teacher T = new PartTime(code, name, slot);
                                    Data.Add(T);
                                }
                            }
                        }
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Load failded:" + e.Message);
            }
        }

        private bool checkCode(List<Teacher> data, string code)
        {
            foreach (Teacher Teacher in data)
            {
                if (Teacher.Code.Equals(code))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
