namespace DelegateEvent
{
    public class Program
    {
        //khai bao delegate
        delegate void MyDelegate1(int a, int b);//trỏ tới 1 hàm void có 2 tham số nguyên
        delegate int MyDelegate2(int a, int b);
        delegate string MyDelegate3(string str);
        static void Main(string[] args)
        {
            //Khi chua su dung Delegate
            Console.WriteLine("Don't use delegate");
            Tong(3, 4);
            Ucln(3, 4);
            Dientich(3, 4);
            Tong(12, 4);
            Ucln(12, 4);
            Dientich(12, 4);
            
            Console.WriteLine("Use Delegate");
            //cách 1
            Console.WriteLine("c1");
            MyDelegate1 dg1 = new MyDelegate1(Tong);
            dg1 += Ucln;
            dg1 += Dientich;
            dg1(3, 4);
            dg1 -= Dientich;
            dg1(12,4);
            

            MyDelegate2 dg2 = new MyDelegate2(Hieu);
            Console.WriteLine("a-b="+ dg2(5, 4));
            //cách 2
            Console.WriteLine("c2");
            MyDelegate2 dg3 = delegate (int a, int b)
            {
                return a - b;
            };
            Console.WriteLine("a-b="+dg3(5,4));

            //Biến đổi delegate thành lambda
            Console.WriteLine("c3");
            MyDelegate2 dg4 = (int a, int b) =>
            {
                return a - b;
            };
            Console.WriteLine("a-b=" + dg4(5, 4));

            //Biến đổi delegate thành lambda
            Console.WriteLine("c4");
            MyDelegate2 dg5 = (a, b) => a + b;
            Console.WriteLine("a-b=" + dg5(5, 4));

            //một ví dụ khác về lambda
            //MyDelegate3 dg6 = (string str) => str.Substring(0, 3);
            MyDelegate3 dg6 = str => str.Substring(0, 5);
            Console.WriteLine(dg6("fpt uni"));
            
        }

        public static int Hieu(int a, int b)
        {
            return a - b;
        }

        public static void Tong(int a, int b)
        {
            Console.WriteLine("a+b=" + (a + b));
        }
        public static void Ucln(int m, int n)
        {
            while (m!=n)
            {
                if (m > n) m = m - n;
                else n = n - m;
            }
            Console.WriteLine("ucln:" + n);
        }
        public static void Dientich(int x, int y)
        {
            Console.WriteLine("dientich:" + (x * y));
        }
    }
}