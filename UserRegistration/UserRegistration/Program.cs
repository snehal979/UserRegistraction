using System;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to User Registration");
            Console.WriteLine("hint 1. name(first/last) 2.email 3.Mobile number 4.Password 5.User Registration with lambda");
            try
            {

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
                    case 3:
                        Console.WriteLine(Code.TestMobile("915335335353"));
                        break;
                    case 4:
                        Console.WriteLine("Enter the password");//"snehalndsS."
                        string passWord = Console.ReadLine();
                        Console.WriteLine(Code.TestPassword(passWord));
                        break;
                    case 5:
                        Console.WriteLine("Lambda Expression");
                        Console.WriteLine("hint 1. name(first/last) 2.email 3.password 4.phone number");
                        int value = Convert.ToInt16(Console.ReadLine());
                        switch (value)
                        {
                            case 1:
                                Console.WriteLine("enter the first name");
                                string input = Console.ReadLine();
                                bool result = Code.ValidationFirstName(input);
                                Result(result);
                                break;
                            case 2:
                                Console.WriteLine("enter the last name");
                                string lastname = Console.ReadLine();
                                bool result1 = Code.ValidationLasttName(lastname);
                                Result(result1);
                                break;
                            case 3:
                                Console.WriteLine("enter the Email");
                                string email = Console.ReadLine();
                                bool result2 = Code.ValidationEmail(email);
                                Result(result2);
                                break;
                            case 4:
                                Console.WriteLine("Enter the password");
                                string Password = Console.ReadLine();
                                bool result3 = Code.ValidationPassword(Password);
                                Result(result3);
                                break;
                            case 5:
                                Console.WriteLine("enter the phone number");
                                string mobile = Console.ReadLine();
                                bool result4 = Code.ValidationMobile(mobile);
                                Result(result4);
                                break;

                        }

                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
         public static void Result(bool results)
            {

                if (results == true)
                {
                    Console.WriteLine("Validation succusesfully");
                }
                else
                {
                    Console.WriteLine("Invalid ");
                }
            }
    }
}
