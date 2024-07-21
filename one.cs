{
    Console.WriteLine("Введите ваше число: ");
    int a  = Convert.ToInt32(Console.ReadLine());

    if (a < 0)
    {
        Console.WriteLine("Число отрицательное!");
    }
    else if (a == 0)
    {
        Console.WriteLine("Число равно нюль!");
    }
    else if ( a > 0 )
    {
        Console.WriteLine("Число положительное");
    }
    else
    {
        Console.WriteLine("Ошибка!");
    }
}
