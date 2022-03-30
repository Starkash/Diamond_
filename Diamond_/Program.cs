using System;

namespace Diamond_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of layer");
            int A = int.Parse(Console.ReadLine());
            for (int i = 1; i <=A; i++)
            {
                for (int j = 1; j <= A - i; j++)

                    Console.Write(" ");
                for (int m = 1; m <=2 * i -1; m++)
                    Console.Write("*");
                Console.WriteLine();

            }

            for (int k = A-1; k >= 1; k--)
            {
                for (int j = 1; j <= A - k; j++)

                    Console.Write(" ");
                for (int m = 1; m <= 2 * k - 1; m++)
                    Console.Write("*");
                Console.WriteLine();




            }






            Console.WriteLine();
        }
    }
}
