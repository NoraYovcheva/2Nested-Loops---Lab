namespace _08._Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int number = startNumber; number <= endNumber; number++)
            {
                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
