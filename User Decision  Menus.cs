using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WUC
{
    internal  class Decision_Menus
    {
       public int Loginmenu()
        {
            // to be used in user class
            Console.WriteLine("Water Utilities Corporation");
            Console.WriteLine(">>Choose Option");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("3.Exit");
            Console.Write("Enter Choice>>");
            int option;
            try
            {
                option = Convert.ToInt32(Console.ReadLine());

            }
            catch
            { 
                return 0;
            }
            return option;
        }



     public  int menuoption()
        {
            // to be used in Display class
            Console.Clear();
            Console.WriteLine(">>SYSTEM MENU");
            Console.WriteLine("1.Calculate Bill");
            Console.WriteLine("2.View Bill Records");
            Console.WriteLine("3.View Login History");
            Console.WriteLine("4.Exit");
            Console.Write("Enter Choice>>>>");
            
            int option;
            try
            {
                option = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                return 0;
            }
            return option;
        }
        public string stars()
        {
            return "*******************************************************";
        }
       public string starz()
        {
            return "**********************************";
        }

    }
}
