using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IManager
    {
        public void InputList(int size);
        public void OutputList();
        public void ListHighestSalary();
        public void PtThan10();
        public void TotalSlot();
        public void SortBySalary();
        public void NameStartWith(string input);
        public void SeparateFullTimeCoE();
        public void SaveFile();
        public void LoadFile();

    }
}
