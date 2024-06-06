using System;
using System.Globalization;

class TimeConverter
{
    static void Main()
    {
        Console.WriteLine("Введите время в 12-часовом формате (например, 07:45 PM):");
        string time12 = Console.ReadLine();
        DateTime dateTime12 = DateTime.ParseExact(time12, "hh:mm tt", CultureInfo.InvariantCulture);
        string time24 = dateTime12.ToString("HH:mm");
        Console.WriteLine($"Время в 24-часовом формате: {time24}");

        Console.WriteLine("Введите время в 24-часовом формате (например, 19:45):");
        string time24Input = Console.ReadLine();
        DateTime dateTime24 = DateTime.ParseExact(time24Input, "HH:mm", CultureInfo.InvariantCulture);
        string time12Output = dateTime24.ToString("hh:mm tt");
        Console.WriteLine($"Время в 12-часовом формате: {time12Output}");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadLine();
    }
}
