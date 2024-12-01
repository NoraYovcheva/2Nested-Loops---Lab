namespace _03._Triangle_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int count = 1; count <= row; count++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
