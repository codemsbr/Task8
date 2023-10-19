namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User userInfo = new User("Ramazan", "Bugayev");
            string choice = "";
            do
            {
                Console.WriteLine("1.Login");
                Console.WriteLine("2.LogOut");
                Console.WriteLine("3.Exit");
                Console.Write("User Choice : ");
                choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        userInfo.Login();
                        break;
                    case "2":
                        userInfo.LogOut();
                        break;
                    case "3":
                        Console.WriteLine("You Have Logged Out of The System");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (choice != "3");
        }
    }
}