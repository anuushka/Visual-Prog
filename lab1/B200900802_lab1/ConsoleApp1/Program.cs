using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "";
            int n, doorNum = 0;
            Console.Write("Haalganii dugaar - ");
            x = Console.ReadLine();

            while (!int.TryParse(x, out n))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                x = Console.ReadLine();
            }

            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 9; j++)
                    for (int k = 1; k <= 4; k++)
                    {
                        doorNum++;
                        if (doorNum == n)
                        {
                            Console.WriteLine("{0} {1} {2}", i, j, k);
                            break;
                        }
                    }
            return;
        }
    }
}
