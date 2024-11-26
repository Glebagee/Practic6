using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Пример использования Parse()
        string dateString1 = "2023-10-10";
        try
        {
            DateTime date1 = DateTime.Parse(dateString1);
            Console.WriteLine("Дата : " + date1.ToString("d"));
        }
        catch (FormatException)
        {
            Console.WriteLine("Недопустимый формат даты для");
        }

        // Пример использования ParseExact()
        string dateString2 = "10/10/2023";
        string format = "MM/dd/yyyy";
        try
        {
            DateTime date2 = DateTime.ParseExact(dateString2, format, CultureInfo.InvariantCulture);
            Console.WriteLine("Дата : " + date2.ToString("d"));
        }
        catch (FormatException)
        {
            Console.WriteLine("Недопустимый формат даты для ParseExact()");
        }

        // Пример использования TryParse()
        string numberString1 = "12345";
        if (int.TryParse(numberString1, out int number1))
        {
            Console.WriteLine("Число : " + number1);
        }
        else
        {
            Console.WriteLine("Не удалось преобразовать строку в число");
        }

        // Пример использования TryParseExact()
        string dateString3 = "2023-10-10T14:30:00";
        string exactFormat = "yyyy-MM-ddTHH:mm:ss";
        if (DateTime.TryParseExact(dateString3, exactFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date3))
        {
            Console.WriteLine("Дата : " + date3.ToString("f"));
        }
        else
        {
            Console.WriteLine("Не удалось преобразовать строку в дату");
        }

        
    }
}