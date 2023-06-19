namespace WinForms_ADO
{
    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public string DoB { get; set; }

        public Customer()
        {
            
        }

        public Customer(string iD, string name, string adress, string gender, string doB)
        {
            ID = iD;
            Name = name;
            Adress = adress;
            Gender = gender;
            DoB = doB;
        }

    }
}