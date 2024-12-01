namespace _06._Travel_Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double neededBudget = double.Parse(Console.ReadLine());
                double collectSum = 0;
                while (neededBudget > collectSum)
                {
                    collectSum += double.Parse(Console.ReadLine());
                    Console.WriteLine($"Collected: {collectSum:F2}");
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
