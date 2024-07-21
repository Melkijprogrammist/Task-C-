{
    Console.WriteLine("Введите первое число: ");
    double num = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    double num_2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    double num_3 = Convert.ToDouble(Console.ReadLine());

    var min = num < num_2 ? num : num_2;
        min = min < num_3 ? num_3 : min;

    Console.WriteLine($"Минимальное из чисел {num}, {num_2}, {num_3} равно {min}");
    Console.ReadLine();
}
