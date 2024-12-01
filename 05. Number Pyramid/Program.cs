namespace _05._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                    if (currentNumber > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (currentNumber > n) 
                {
                    break;
                }
            }
        }
    }
}
