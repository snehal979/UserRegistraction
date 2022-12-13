namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to User Registration");
            Validation Code = new Validation();
            Console.WriteLine("enter the first name");//"Snehal"
            string firstName = Console.ReadLine();
            Console.WriteLine(Code.TestName(firstName));
            Console.WriteLine("--------------");
            //uc2
            Console.WriteLine("enter the last name");//"Bansod"
            string lastName = Console.ReadLine();
            Console.WriteLine(Code.TestName(lastName));
        }
    }
}
