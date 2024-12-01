namespace _07._Sum_of_Digits_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();

            while (input != "End")
            {
                int num = int.Parse(input);
                int sum = 0;

                while (num > 0)
                {
                    int lastDigits = num % 10;
                    sum += lastDigits;
                    num /= 10;
                }
                    Console.WriteLine($"Sum of digits = {sum}");

                    input = Console.ReadLine();    
            }
           
            Console.WriteLine("Goodbye");
        }
    }
}
