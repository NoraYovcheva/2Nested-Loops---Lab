namespace _04._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int estates = int.Parse(Console.ReadLine());

            //for (int floor = floors; floor >= 1; floor--)
            //{
            //    for (int room = 0; room < estates; room++)
            //    {
            //        if (floor == floors)
            //        {
            //            Console.Write($"L{floor}{estates} ");
            //        }
            //        else if (floor % 2 == 0)
            //        {
            //            Console.Write($"O{floor}{estates} ");
            //        }
            //        else
            //        {
            //            Console.Write($"A{floor}{estates} ");
            //        }

            //    }
            //    Console.WriteLine();

            //}

            for (int floor = floors; floor >= 1; floor--)
            {
                for (int room = 0; room < estates; room++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
