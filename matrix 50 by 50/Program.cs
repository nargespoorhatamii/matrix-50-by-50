using System;
namespace project
{
    class test
    {
        public static void Main()
        {
            int[,] a = new int[50, 50];
            Console.WriteLine("miane:");
            Calc(a);
        }
        private static void Calc(int[,] a)
        {



            for (int i = 1; i <= 48; i++)
            {
                for (int j = 1; j <= 48; j++)
                {
                    a[i, j] = ((a[i - 1, j - 1] + a[i, j] + a[i + 1, j + 1]) / 3);

                }


            }
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {

                    Console.WriteLine(a[i, j]);
                }
            }
        }
    }
}