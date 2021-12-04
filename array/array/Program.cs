using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int[,] matris1 = new int[3, 3];
            int[,] matris2 = new int[3, 3];
            int[,] matris3 = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Matris1[{0},{1}]=", i + 1, j + 1);
                    matris1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Matris2[{0},{1}]=", i + 1, j + 1);
                    matris2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine(" *** Matris 1 ***");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris1[i, j] + "    ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(" *** Matris 2 ***");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris2[i, j] + "    ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris3[i, j] = matris1[i, j] + matris2[i, j];
                }
            }

            Console.WriteLine("*** Matris3(TOPLAM MATRİS) ***");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris3[i,j] + "    ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
