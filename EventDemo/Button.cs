using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    //lop nay xay dung nen 1 nut
    public class Button
    {
        
        public string Name { get; set; }
        public Button()
        {

        }

        public Button(string name)
        {
            Name = name;
        }

        //xay dung ham mo phong nhan nut
        public void click()
        {
            //kick hoat su kien nhan nut
            if (OnClick != null)
            {
                OnClick(Name);
            }
            else
            {
                Console.WriteLine("Chua gan su kien cho button "+Name);
            }
        }

        //tao su kien nhan nut cho 1 button
        public delegate void handle(string name);
        public event handle OnClick;//su kien xay ra khi nhan nut
    }
}
