using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер: ");
        int dayNum = Convert.ToInt32(Console.ReadLine());

        string dayName;
        switch (dayNum)
        {
            case 1:
                dayName = "Понедельник";
                break;
            case 2:
                dayName = "Вторник";
                break;
            case 3:
                dayName = "Среда";
                break;
            case 4:
                dayName = "Четверг";
                break;
            case 5:
                dayName = "Пятница";
                break;
            case 6:
                dayName = "Суббота";
                break;
            case 7:
                dayName = "Воскресение";
                break;
            default:
                dayName = "Ошибка: Дня с номером " + dayNum + " не существует";
                break;
        }

        Console.WriteLine(dayName);

        Console.ReadLine();
    }
}
