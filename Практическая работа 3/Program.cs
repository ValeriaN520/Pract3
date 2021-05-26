using System;

namespace Практическая3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");//Задание 1
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int min = 100;
            int y = 0;
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(a[i]) < min)
                {
                    min = Math.Abs(a[i]);
                    y = i;
                }
            }
            Console.WriteLine($"Индекс минимального элемента = {y}");
            Console.WriteLine("Задание 2"); //Задание 2
            Console.WriteLine("Введите размер массива");
            int z = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[z];
            string p = "";
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < z; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < x.Length; i++)
            {
                bool s = false;
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[i] == x[j] && i != j)
                    {
                        s = true;
                    }
                }
                if (!s)
                {
                    p += x[i] + " ";
                }
            }
            Console.WriteLine($"Уникальные элементы = { p}");
            Console.WriteLine("Задание 3");//Задание 3
            Console.WriteLine("Введите размер массива");
            int h = Convert.ToInt32(Console.ReadLine());
            int[] o = new int[h];
            Console.WriteLine("Введите элементы массива");
            for (int u = 0; u < h; u++)
            {
                o[u] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Итоговый массив: ");
            for (int j = 0; j < o.Length; j++)
            {
                    Console.Write( o[j] + "  ");
            }
            Console.WriteLine("\nМассив без отрицательных чисел: ");
            for (int j = 0; j < o.Length; j++)
            {
                if (o[j] >= 0)
                {
                    Console.Write(o[j] + "  ");
                }
            }
        }
    }
}