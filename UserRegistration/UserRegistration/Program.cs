using System;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to User Registration");
            Console.WriteLine("hint 1. name(first/last) 2.email ");
           
            Validation Code = new Validation();
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("enter the first name");//"Snehal"
                    string firstName = Console.ReadLine();
                    Console.WriteLine(Code.TestName(firstName));
                    Console.WriteLine("--------------");
                    Console.WriteLine("enter the last name");//"Bansod"
                    string lastName = Console.ReadLine();
                    Console.WriteLine(Code.TestName(lastName));
                    break;

                case 2:
                    Console.WriteLine("enter the Email");//"abc@xyzhg.com";
                    string Email = Console.ReadLine();
                    Console.WriteLine(Code.TestEmail(Email));
                    /*1. abc@yahoo.com, -valid
                   • 2. abc-100@yahoo.com,
                   • 3. abc.100@yahoo.com
                   • 2. abc111@abc.com,
                   • 4. abc-100@abc.net,
                   • 5. abc.100@abc.com.au
                   • 6. abc@1.com, - Invalid
                   • 7. abc@gmail.com.com
                   • 8. abc+100@gmail.com */
                    break;
            }
    }
}
