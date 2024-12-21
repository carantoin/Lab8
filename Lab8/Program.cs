/*Console.WriteLine("Введите первую дату (формат dd.MM.yyyy):");
string date1String = Console.ReadLine();

Console.WriteLine("Введите вторую дату (формат dd.MM.yyyy):");
string date2String = Console.ReadLine();

try
{
    DateTime date1 = DateTime.ParseExact(date1String, "dd.MM.yyyy", null);
    DateTime date2 = DateTime.ParseExact(date2String, "dd.MM.yyyy", null);

    if (date1 > date2)
    {
        Console.WriteLine($"Первая дата {date1:dd.MM.yyyy} позднее чем вторая {date2:dd.MM.yyyy}");
    }
    else if (date2 > date1)
    {
        Console.WriteLine($"Вторая дата {date2:dd.MM.yyyy} позднее чем первая {date1:dd.MM.yyyy}");
    }
    else
    {
        Console.WriteLine($"Даты {date1:dd.MM.yyyy} одинаковые.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Неверный формат даты.  Пожалуйста, используйте формат dd.MM.yyyy.");
}*/

DateTime startTime = DateTime.Now;
double declaredBatteryLifeHours = 4.5;

Console.WriteLine("Введите время включения ноутбука (формат HH:mm):");
string startTimeInput = Console.ReadLine();

Console.WriteLine("Введите заявленное время работы от батареи (в часах):");
string declaredLifeInput = Console.ReadLine();

if (double.TryParse(declaredLifeInput, out declaredBatteryLifeHours) && DateTime.TryParseExact(startTimeInput, "HH:mm", null, System.Globalization.DateTimeStyles.None, out startTime))
{
    TimeSpan elapsedTime = DateTime.Now - startTime;
    double elapsedHours = elapsedTime.TotalHours;
    double remainingHours = declaredBatteryLifeHours - elapsedHours;

    if (remainingHours < 0)
    {
        Console.WriteLine("Батарея разряжена!");
    }
    else
    {
        int remainingMinutes = (int)(remainingHours * 60);


        Console.WriteLine($"Время работы от батареи: {elapsedHours:F2} часов");
        Console.WriteLine($"Осталось до полного разряда: {remainingMinutes} минут");
    }

}
else
{
    Console.WriteLine("Ошибка ввода. Проверьте корректность формата времени и чисел.");
}