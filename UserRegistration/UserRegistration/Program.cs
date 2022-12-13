namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to User Registration");
            Validation validation = new Validation();
            Console.WriteLine("enter the first name");//"Snehal"
            string firstName = Console.ReadLine();
            Console.WriteLine(validation.TestName(firstName));
        }
    }
}
