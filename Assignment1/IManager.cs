using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public interface IManager
    {
        public void InputList(int size);
        public void OutputList();
        public void ChangePlayer(int code, int option, int shirtNum, double salary);
        public void SumSalary(string position);
        public void ShowMaxLuong();
        public void ShortByShirt();

    }
}
