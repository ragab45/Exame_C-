namespace Exame
{
    internal class Program
    {

        #region Q-1
        //Console.WriteLine("Enter your age");
        //String outage = (Console.ReadLine());
        //int age;
        //if(!int.TryParse(outage, out age))
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid age.");
        //    return;
        //}
        //Console.WriteLine("Enter your Nationality");
        //String Nationality = Console.ReadLine();
        //if (age >= 18 && Nationality.Equals("Egyptian"))
        //{
        //    Console.WriteLine("You are eligible to vote");
        //}
        //else
        //{
        //    Console.WriteLine("You are not eligible to vote");
        //}
        #endregion
        #region  Q-2
        //    static double? Calculator(double num1, double num2, char operation)
        //    {
        //        switch (operation)
        //        {
        //            case '+': return num1 + num2;
        //            case '-': return num1 - num2;
        //            case '*': return num1 * num2;
        //            case '/': return num2 != 0 ? num1 / num2 : null;
        //            default: return null;
        //        }
        //    }

        //    static void Main()
        //    {
        //        Console.Write("Enter the first number: ");
        //        double n1 = double.Parse(Console.ReadLine());

        //        Console.Write("Enter the second number: ");
        //        double n2 = double.Parse(Console.ReadLine());

        //        Console.Write("Enter the operator (+ - * /): ");
        //        char operation = Console.ReadKey().KeyChar;
        //        Console.WriteLine();

        //        var result = Calculator(n1, n2, operation);
        //        if (result.HasValue)
        //            Console.WriteLine($"Result: {result}");
        //        else
        //            Console.WriteLine("Invalid operation or division by zero.");
        //    }
        //}

        #endregion
        #region  Q-3

       
        static void printMultiplicationTable(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Table {i}");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {

            Console.Write("Enter the number of tables: ");
            int n = int.Parse(Console.ReadLine());
            printMultiplicationTable(n);
        }
    }
}
#endregion







