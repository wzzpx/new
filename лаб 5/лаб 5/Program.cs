using System;
using System.Text;

public class Program
{
    enum AccountingSoftware
    {
        Software1,
        Software2,
        Software3
    }

    enum LogisticsSoftware
    {
        Software4,
        Software5,
        Software6
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Список програмних продуктів:");

        Console.WriteLine($"{(int)AccountingSoftware.Software1} - 1С: Бухгалтерія 1");
        Console.WriteLine($"{(int)AccountingSoftware.Software2} - Місто 2");
        Console.WriteLine($"{(int)AccountingSoftware.Software3} - ВЕСТА 3");

        Console.WriteLine($"{(int)LogisticsSoftware.Software4} - SAP 4");
        Console.WriteLine($"{(int)LogisticsSoftware.Software5} - Oracle Transportation Management 5");
        Console.WriteLine($"{(int)LogisticsSoftware.Software6} - Manhattan SCALE 6");

        Console.WriteLine();

        Console.WriteLine("Введіть номери програмних продуктів, які бажаєте придбати (відокремлюйте їх комами):");
        string input = Console.ReadLine();

        string[] selectedProducts = input.Split(',');

        Console.WriteLine("Програмні продукти для обліку:");
        foreach (string product in selectedProducts)
        {
            if (Enum.IsDefined(typeof(AccountingSoftware), Convert.ToInt32(product)))
            {
                Console.WriteLine("- " + (AccountingSoftware)Convert.ToInt32(product));
            }
        }

        Console.WriteLine("Програмні продукти для логістики:");
        foreach (string product in selectedProducts)
        {
            if (Enum.IsDefined(typeof(LogisticsSoftware), Convert.ToInt32(product)))
            {
                Console.WriteLine("- " + (LogisticsSoftware)Convert.ToInt32(product));
            }
        }

        Console.WriteLine("Автор програми: [Бобко Роман]");
    }
}
