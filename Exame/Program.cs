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


//        static void printMultiplicationTable(int number)
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"Table {i}");
//                for (int j = 1; j <= 10; j++)
//                {
//                    Console.WriteLine($"{i} x {j} = {i * j}");
//                }
//                Console.WriteLine();
//            }

//        }
//        static void Main(string[] args)
//        {

//            Console.Write("Enter the number of tables: ");
//            int n = int.Parse(Console.ReadLine());
//            printMultiplicationTable(n);
//        }
//    }
//}
#endregion

#region  Q-4
//        static bool IsPrime(int num)
//        {
//            if (num <= 1) return false;
//            for (int i = 2; i <= Math.Sqrt(num); i++)
//                if (num % i == 0) return false;
//            return true;
//        }

//        static void Main()
//        {
//            Console.Write("Enter how many numbers: ");
//            int size = int.Parse(Console.ReadLine());

//            int[] arr = new int[size];

//            Console.WriteLine("Enter the numbers:");
//            for (int i = 0; i < size; i++)
//                arr[i] = int.Parse(Console.ReadLine());

//            int count = 0;
//            foreach (var num in arr)
//            {
//                if (IsPrime(num))
//                    count++;
//            }

//            Console.WriteLine($"Prime numbers count: {count}");
//        }
//    }
//}
#endregion
#region  Q-5
//        static void Main()
//        {
//            int[] numbers = new int[10];

//            Console.WriteLine("Enter 10 numbers:");
//            for (int i = 0; i < 10; i++)
//            {
//                Console.Write($"Number {i + 1}: ");
//                numbers[i] = int.Parse(Console.ReadLine());
//            }

//            int max = numbers[0];
//            int index = 0;

//            for (int i = 1; i < numbers.Length; i++)
//            {
//                if (numbers[i] > max)
//                {
//                    max = numbers[i];
//                    index = i;
//                }
//            }

//            Console.WriteLine($"Max value is {max} at index {index}");
//        }
//    }
//}

#endregion
#region  Q-6
//        static bool IsPalindrome(string word)
//        {
//            string lower = word.ToLower();
//            char[] reversed = lower.ToCharArray();
//            Array.Reverse(reversed);

//            return lower == new string(reversed);
//        }

//        static void Main()
//        {
//            Console.Write("Enter a word: ");
//            string input = Console.ReadLine();

//            if (IsPalindrome(input))
//                Console.WriteLine("The word is a palindrome.");
//            else
//                Console.WriteLine("The word is not a palindrome.");
//        }
//    }
//}
#endregion
#region  Q-7
//        static double? Divide(int? a, int? b)
//        {
//            if (a.HasValue && b.HasValue && b != 0)
//                return (double)a / b;
//            else
//                return null;
//        }

//        static void Main()
//        {
//            int? num1 = 10;
//            int? num2 = 2;

//            var result = Divide(num1, num2);

//            if (result != null)
//                Console.WriteLine("Result: " + result);
//            else
//                Console.WriteLine("Can't divide.");
//        }
//    }
//}
#endregion
#region  Q-8
//        static int SumEven(int[] arr)
//        {
//            int sum = 0;
//            foreach (int num in arr)
//            {
//                if (num % 2 == 0)
//                    sum += num;
//            }
//            return sum;
//        }

//        static void Main()
//        {
//            int[] numbers = { 1, 2, 3, 4, 5, 6 };
//            Console.WriteLine("Sum of even numbers: " + SumEven(numbers));
//        }
//    }
//}
#endregion
#region  Q-9
//        static void Main()
//        {
//            for (int i = 1; i <= 5; i++)
//            {
//                Console.Write($"Enter score for student {i}: ");
//                int score = int.Parse(Console.ReadLine());

//                string grade = score switch
//                {
//                    >= 90 => "A",
//                    >= 80 => "B",
//                    >= 70 => "C",
//                    >= 60 => "D",
//                    < 60 => "F",
//                    _ => "invalid"
//                };

//                Console.WriteLine("Grade: " + grade);
//            }
//        }
//    }
//}
#endregion

#region  Q-10
        
    static double? GetAverage(int?[] scores)
        {
            int sum = 0;
            int count = 0;

            foreach (var score in scores)
            {
                if (score.HasValue)
                {
                    sum += score.Value;
                    count++;
                }
            }

            if (count == 0)
                return null;

            return (double)sum / count;
        }

        static void Main()
        {
            int?[] scores = { 80, null, 90, 100, null };
            var avgerage = GetAverage(scores);

            if (avgerage != null)
                Console.WriteLine("Average: " + avgerage);
            else
                Console.WriteLine("No valid scores.");
        }
    }
}

#endregion



