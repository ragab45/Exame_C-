namespace Exame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q-1
            Console.WriteLine("Enter your age");
            String outage = (Console.ReadLine());
            int age;
            if(!int.TryParse(outage, out age))
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                return;
            }
            Console.WriteLine("Enter your Nationality");
            String Nationality = Console.ReadLine();
            if (age >= 18 && Nationality.Equals("Egyptian"))
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
            #endregion
        }
    }
}
