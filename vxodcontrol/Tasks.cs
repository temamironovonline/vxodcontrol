using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vxodcontrol
{
    internal class Tasks
    {
        public void task1()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Pow(a, b);
            Console.WriteLine(c);
            Console.WriteLine();
        }

        public void task2()
        {
                Console.WriteLine("Введите точку начала гипотенузы по координате Х:");
                int x3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите точку начала гипотенузы по координате Y:");
                int y3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите точку конца гипотенузы по координате Х:");
                int x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите точку конца гипотенузы по координате Y:");
                int y2 = Convert.ToInt32(Console.ReadLine());

                int x1 = x3;
                int y1 = y2;
                double mod = (x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1);
                double s = (1 / 2) * Math.Abs(mod);

                Console.WriteLine($"Коррдинаты последней точки равны: ({x1};{y1}). Площадь равна {s}");
                int a = y3 - y1;
                int b = x2 - x1;
                double c = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                double p = a + b + c;
                Console.WriteLine($"Длина стороны a = {a}, длина стороны b = {b}, длины стороны с = {c}. Периметр равен {p}");

        }
        public void task3()
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == a%3)
                Console.WriteLine($"Остаток одинаковый! Остаток: {a}");
            else Console.WriteLine($"Остаток не одинаковый! Остаток при делении на 2: {a%2}, остаток при делении на 3: {a%3}" );
            Console.WriteLine();
        }

        public void task4()
        {
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; a > 0; i++)
            {
                Console.WriteLine(a%10);
                a/=10;

            }
            Console.WriteLine();
        }

        public void task5()
        {
            Console.WriteLine("Задание 5");

            Console.WriteLine("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((1 + Math.Sin(Math.Sqrt(x + 1))) / (Math.Cos(12 * y - 4)));
            Console.WriteLine();
            
        }

        public void task6()
        {
            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите количество чисел: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i < n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];

            }
            for(int i =0;i<n;i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine($"{array[i]} и индекс {i+1}");
                }
            }
        }

        public void task7()
        {
            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 1;
            double b = 2;
            double c = 0;
            for (int i = 0; i < n; i++)
            {
                c = c + a / b;
                a = b;
                b++;
            }
            Console.WriteLine(c);
        }

        public void task8()
        {
            Console.WriteLine("Введите результат первого пловца: ");
            double resultFirst = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите результат второго пловца: ");
            double resultSecond = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите результат третьего пловца: ");
            double resultThird = Convert.ToDouble(Console.ReadLine());

            if (resultFirst > resultSecond && resultFirst > resultThird)
                Console.WriteLine($"Первый пловец победитель!");
            if (resultSecond > resultFirst && resultSecond > resultThird)
                Console.WriteLine("Второй пловец победитель!");
            if (resultThird > resultFirst && resultThird > resultSecond)
                Console.WriteLine("Третий пловец победитель!");
            if (resultFirst == resultSecond && resultFirst == resultThird)
                Console.WriteLine("У всех одинаковый результат!");
            if (resultFirst == resultSecond && resultFirst != resultThird && resultThird < resultFirst)
                Console.WriteLine("Первое место делят первый и второй пловец!");
            if (resultFirst != resultSecond && resultFirst == resultThird && resultSecond < resultFirst)
                Console.WriteLine("Первое место делят первый и третий пловец!");
            if (resultSecond == resultThird && resultSecond != resultFirst && resultFirst < resultSecond)
                Console.WriteLine("Первое место делят второй и третий пловец!");
        }
        
    }
}
