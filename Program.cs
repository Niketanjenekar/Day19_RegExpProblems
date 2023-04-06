namespace Day19_RegExp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegExp problems ");
            Console.WriteLine("******************************************************************");
            //UseCase1
            Firstname_Usecase1 obj = new Firstname_Usecase1();
            Console.WriteLine("Write your FirstName ");
            string fName= Console.ReadLine();
            Console.WriteLine(obj.validatefirstName(fName));

            Console.WriteLine("***********************************************************************");
            //UseCase2
            Lastname_Usecase2 obj2 = new Lastname_Usecase2();
            Console.WriteLine("Write your LastName ");
            string lName = Console.ReadLine();
            Console.WriteLine(obj2.validatelastName(lName));

            

        }
    }
}