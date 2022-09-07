using System;

namespace vxodcontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tasks obj = new Tasks();
            int n = 0;
            while (true)
            {
                Console.WriteLine("Выберете номер задания:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 1 || n > 8)
                    Console.WriteLine("Ошибка ввода! От 1 до 8!");
                else break;
            }
            switch(n)
            {
                case 1:
                    obj.task1();
                    break;
                case 2:
                    obj.task2();
                    break;
                case 3:
                    obj.task3();
                    break;
                case 4:
                    obj.task4();
                    break;
                case 5:
                    obj.task5();
                    break;
                case 6:
                    obj.task6();
                    break;
                case 7:
                    obj.task7();
                    break;
                case 8:
                    obj.task8();
                    break;

            }

        }
    }
}