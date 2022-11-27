using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WUC;
// this class have methods that allow user to create username and password
//it will authenicate username entered and password and give access to application
internal class User : Display
{
    // inherited from class display so that method processor from display can be easily called

    public static void login()
    {

        User log = new User();
        string[] user_name = new string[1];
        string[] pass_word = new string[1];
        // created to temporariy store username and password created
        Decision_Menus program_Menus = new Decision_Menus();
       //object created in order to access loginmenu

        int option;
        option = program_Menus.Loginmenu();
       // method loginmenu returns integer which is stored in option
       
    

     

        if (option == 2)
        {
            for (int i = 0; i < user_name.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Create Username");
                user_name[i] = Console.ReadLine();

                string writeText = user_name[i];
                File.WriteAllText("Username.txt", user_name[i]);
                
                //username is stored in a file 
            }


            for (int i = 0; i < pass_word.Length; i++)
            {
                Console.WriteLine("Create A Strong Password");
                pass_word[i] = Console.ReadLine();

                string writeText = user_name[i];
                File.WriteAllText("Password.txt", pass_word[i]);
               
                // password is stored into a file

            }


            Console.WriteLine(">>You Have Successfully Signed Up :)");
            Console.Write(">>Press Enter To Continue");
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.Clear();

            login();
            //user can choose to login
        }


        if (option == 1)
        {
            /* exception is used to handle error if there is no username and password stored in the file 
               user will asked to create them first*/

            try
            {
                Console.Clear();
                string readtext = File.ReadAllText("Username.txt");

                Console.WriteLine("Enter Username");

                string username = Console.ReadLine();

                if (username == readtext)
                {


                    string readtext1 = File.ReadAllText("Password.txt");

                    Console.WriteLine("Enter Password");
                    string password = Console.ReadLine();

                    if (password == readtext1)

                    {

                        string alert = ("login success " + DateTime.Now + Environment.NewLine);

                        File.AppendAllText("Login History.txt", alert);
                        log.processor();

                    }
                    else
                    {

                        string alert = ("login Failed " + DateTime.Now + Environment.NewLine);
                        File.WriteAllText("Login History.txt", alert);
                        Console.WriteLine("Invalid Password");

                        Console.Write(">>Press Enter To Try Again");
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        Console.Clear();
                        login();
                    }


                }
                else
                {
                    string alert = ("login Failed " + DateTime.Now + Environment.NewLine);

                    File.AppendAllText("Login History.txt", alert);


                    Console.WriteLine("Invalid Username");
                    Console.Write(">>Press Enter To Try Again");
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    Console.Clear();

                    login();

                }


            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Please SignUp First!!");
                Console.WriteLine(">>>Press Enter");

                Console.Read();
                Console.Clear();
                login();
            }


        }
        else if (option == 3)
        {
            Console.Clear();
            Console.WriteLine("Exit Application");
            Console.WriteLine("1.YES");
            Console.WriteLine("2.NO");
            int choice = (Convert.ToInt32(Console.ReadLine()));
            if (choice == 1)
            {
                Environment.Exit(0);
            }
            else if (choice == 2)//return to menu
            {
                Console.Clear();
                login();
            }
        }
        else if (option == 0 || option != 1 && option != 2 && option != 3)// if user enter invalid character
        {
            Console.Clear();
            login();

        }
       
    }

}

                


