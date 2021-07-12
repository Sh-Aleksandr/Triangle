using System;

namespace Triangle_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(height -i, i+1);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.ReadLine();
            }
        }
    }
}
