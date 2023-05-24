namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button btnAsa = new Button("ASA");
            Button btnHiru = new Button("HIRU");
            Button btnBan = new Button("BAN");

            //gan su kien onclick cho 3 nut
            btnAsa.OnClick += BtnAsa_OnClick;
            btnHiru.OnClick += BtnHiru_OnClick;
            btnBan.OnClick += BtnBan_OnClick;

            //Mo phong 1 App gom 3 nut: AssemblyLoadEventArgs, HIRU, BAN
            Console.WriteLine("Hello, World!");
            while (true)
            {
                Console.WriteLine("1.Button ASA.");
                Console.WriteLine("2.Button HIRU.");
                Console.WriteLine("3.Button BAN.");
                Console.WriteLine("Please click a button");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            btnAsa.click();
                            break;
                        }
                    case 2:
                        {
                            btnHiru.click();
                            break;
                        }
                    case 3:
                        {
                            btnBan.click();
                            break;
                        }

                    default:
                        break;
                }
            }
        }

        private static void BtnBan_OnClick(string name)
        {
            Console.WriteLine("BAN clicked");
        }

        private static void BtnHiru_OnClick(string name)
        {
            Console.WriteLine("HIRU clicked");
        }

        private static void BtnAsa_OnClick(string name)
        {
            Console.WriteLine("ASA clicked");
        }
    }
}