namespace Assignment5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(GetNumber("Please enter a number."));
            int total = Sum(number);
            Console.WriteLine(total);
        }

        static string GetNumber(string s)
        {
            string? userInput = "";
            do
            {
                Console.WriteLine(s);
                userInput = Console.ReadLine();
            } while (userInput == "");
            return userInput;
        }

        static int Sum(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num + Sum(num - 1);
            }
        }
    }
}
