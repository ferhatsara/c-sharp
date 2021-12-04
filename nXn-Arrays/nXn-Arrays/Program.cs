using System;

namespace nXn_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Write("Satır değeri gir:");
            int satir = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sutun değeri gir: ");
            int sutun = int.Parse(Console.ReadLine());

            int[,] matris = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("matris[{0},{1}]=", i + 1, j + 1);
                    matris[i, j] = Convert.ToInt16(Console.ReadLine());

                }
            }

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(matris[i, j]+"     ");
                    

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
