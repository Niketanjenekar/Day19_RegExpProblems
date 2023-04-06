namespace Day19_RegExp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegExp problems ");
            Console.WriteLine("******************************************************************");

            Firstname_Usecase1 obj = new Firstname_Usecase1();
            Console.WriteLine("Write your FirstName ");
            string fName= Console.ReadLine();
            Console.WriteLine(obj.validatefirstName(fName));
        }
    }
}