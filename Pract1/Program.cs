while (true)
{
    Console.Write("Ввод операции ");
    int operation = Convert.ToInt32(Console.ReadLine());
    if (operation == 9)
    {
        break;
    }
    Console.Write("Ввод 1 числа ");
    double first_num = Convert.ToDouble(Console.ReadLine());
    double second_num;
    double result;
    switch (operation)
    {
        case 1:
            Console.Write("Ввод 2 числа ");
            second_num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(first_num + second_num);
            break;
        case 2:
            Console.Write("Ввод 2 числа ");
            second_num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(first_num - second_num);
            break;
        case 3:
            Console.Write("Ввод 2 числа ");
            second_num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(first_num * second_num);
            break;
        case 4:
            Console.Write("Ввод 2 числа ");
            second_num = Convert.ToDouble(Console.ReadLine());
            if (second_num == 0)
            {
                Console.WriteLine("Попытка деления на 0");
                break;
            }
            Console.WriteLine(first_num / second_num);
            break;
        case 5:
            Console.Write("Ввод 2 числа ");
            second_num = Convert.ToDouble(Console.ReadLine());
            result = 1;
            for (int i = 1; i <= second_num; i++)
            {
                result *= first_num;
            }
            Console.WriteLine(result);
            break;
        case 6:
            if (first_num < 0)
            {
                Console.WriteLine("Попытка получения корня отрицательного числа");
                break;
            }
            Console.WriteLine(Math.Sqrt(first_num));
            break;
        case 7:
            Console.WriteLine(first_num / 100);
            break;
        case 8:
            if (first_num < 0)
            {
                Console.WriteLine("Попытка получения факториала отрицательного числа");
                break;
            }
            else if (first_num == 0)
            {
                Console.WriteLine("0");
                break;
            }
            result = 1;
            for (int i = 1; i <= first_num; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
            break;
    }
}