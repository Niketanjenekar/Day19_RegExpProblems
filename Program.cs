namespace Day19_RegExp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegExp problems ");
            //Console.WriteLine("******************************************************************");
            ////UseCase1
            //Firstname_Usecase1 obj = new Firstname_Usecase1();
            //Console.WriteLine("Write your FirstName ");
            //string fName= Console.ReadLine();
            //Console.WriteLine(obj.validatefirstName(fName));

            //Console.WriteLine("***********************************************************************");
            ////UseCase2
            //Lastname_Usecase2 obj2 = new Lastname_Usecase2();
            //Console.WriteLine("Write your LastName ");
            //string lName = Console.ReadLine();
            //Console.WriteLine(obj2.validatelastName(lName));

            //Console.WriteLine("***************************************************************************");
            ////UseCase3
            //EmailID_USecase3 obj3 = new EmailID_USecase3();
            //Console.WriteLine("Please Enter your Email-Id");
            //string emaiID= Console.ReadLine();
            //Console.WriteLine(obj3.validateEmailId(emaiID));

            //Console.WriteLine("***************************************************************************");
            ////UseCase4
            //MobileNumber_Usecase4 obj4 = new MobileNumber_Usecase4();
            //Console.WriteLine("Please Enter your Mobile Number");
            //string mobilenumber = Console.ReadLine();
            //Console.WriteLine(obj4.validatemobileNumber(mobilenumber));

            //Console.WriteLine("*****************************************************************************");
            ////Usecase5
            //Password_USecase5_Rule1 obj5 = new Password_USecase5_Rule1();
            //Console.WriteLine("Please enter your Password ");
            //string password = Console.ReadLine();
            //Console.WriteLine(obj5.validatePassword(password));

            //Console.WriteLine("**********************************************************************************");
            ////Usecase6
            // Password_Usecase6_Rule2 obj6 = new Password_Usecase6_Rule2();
            //Console.WriteLine("Please enter your Password ");
            //string password = Console.ReadLine();
            //Console.WriteLine(obj6.validatePassword(password));

            Console.WriteLine("**********************************************************************************");
            //usecase7
            Password_Usecase7_Rule3 obj7 = new Password_Usecase7_Rule3();
            Console.WriteLine("Please enter your Password ");
            string password = Console.ReadLine();
            Console.WriteLine(obj7.validatePassword(password));

        }
    }
}