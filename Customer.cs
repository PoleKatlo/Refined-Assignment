

namespace WUC
{
    internal class Customer : User
    {
        internal string surname { get; set; }
        internal string plotno { get; set; }
        internal string usertype { get; set; }  
        public string Location { get; set; }
        public string Name { get;  set; }
        public double Water_Used { get; set; }  
       

      public Customer(string surname, string plotno, string usertype, string location, string name, double water_used)
        {
            this.surname = surname;
            this.plotno = plotno;
            this.usertype = usertype;
            Location = location;
            Name = name;
            this.Water_Used = water_used;
        }

        static void Main(string[] args)
        {
            Customer customer = new Customer("", "","","","",9);
            Customer.login();
        }
       
    }
}
