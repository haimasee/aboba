// See https://aka.ms/new-console-template for more information


Console.WriteLine("Введите номер игры от 1 до 4: ");
Console.WriteLine("1. Угадай число");
Console.WriteLine("2. Табличка умножения");
Console.WriteLine("3. Вывод делителей числа");
Console.WriteLine("4. Выход с программы");

string number = Console.ReadLine();

switch (number)
{
    case "1":
        static int GetRandom(int num)
        {
            Random rnd = new Random();
            int value = rnd.Next(1, num);
            return value;
        }
        {
            int min = 0;
            int max = 100;
            int num = GetRandom(max);
            for (int i = 1; i < 100; i++)
            {
                Console.Write($"Угадайте число от 1 до {max}? - Попытка {i}: ");
                string sNum = Console.ReadLine();
                if (int.TryParse(sNum, out min) && min <= max)
                {
                    if (min == num)
                    {
                        Console.WriteLine("Вы угодали! Правильное число " + num);
                        break;
                    }
                    if (min < num)
                    {
                        Console.WriteLine("Было близок, но надо больше");
                    }
                    if (min > num)
                        Console.WriteLine("Блииизко, но надо меньше");

                }
                else
                {
                    Console.WriteLine("Нужно вводить число от 1 до " + max);
                }

            }
            if (min != num)
                Console.WriteLine("Вы не угодали число!");
            Console.ReadKey();
        }
        break;

    case "2":
        int a, j;
        for (a = 1; a < 10; a++)
            for (j = 1; j < 10; j++)
            {
                Console.Write(a * j);
                Console.Write(j != 9 ? ' ' : '\n');
            }
        break;

    case "3":
        Console.Write("Введите число ");
        int num2 = int.Parse(Console.ReadLine());
        for (int x = 1; x <= num2; x++)
            if (num2 % x == 0)
                Console.WriteLine("Число {0} делится без остатка на {1}", num2, x);

        Console.ReadKey();
        break;
}