using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistration validation = new UserRegistration();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the User Registration validation program");
                Console.WriteLine("Enter the validation to be executed : \n 1. First Name \n 2. Last Name \n 3. Email ID \n 4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(validation.ValidateFirstName("Naveen"));
                        break;
                    case 2:
                        Console.WriteLine(validation.ValidateLastName("Veera"));
                        break;
                    case 3:
                        Console.WriteLine(validation.ValidateEmail("naveen.veera@bridgelabz.co.in"));
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}