{
// Первый вариант
  Console.WriteLine("Введите первое число: ");
    double num = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    double num_2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    double num_3 = Convert.ToDouble(Console.ReadLine());

    if (num > num_2 && num > num_3)
            {
        Console.WriteLine($"Максимальное из чисел {num} {num_2} {num_3} , чем {num} {num_2} {num_3}.");
    }
}
// второй вариант
{
    Console.WriteLine("Введите первое число: ");
    double num = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    double num_2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    double num_3 = Convert.ToDouble(Console.ReadLine());

    var max = num;
    if (max < num_2)
    {
        Console.WriteLine($"Число {max} или {num_2} максимальное");
    }
    else if (max < num_3)
    {
        Console.WriteLine($"Число {max} или {num_3} максимальное");
    }
    Console.WriteLine($"Максимальное из чисел {num}, {num_2}, {num_3} равно {max} ");
    Console.ReadLine();
}
