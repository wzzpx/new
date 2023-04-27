using System;
using System.Text;



namespace ConsoleApp
{
    class Program
    {
        enum AccountingSystem
        {
            Підприємство1С = 1,
            SAP_Business_One,
            Oracle_Financials
        }

        enum LogisticSystem
        {
            SAP_Extended_Warehouse_Management = 4,
            Oracle_Transportation_Management,
            Manhattan_SCALE
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Перелік програмних продуктів:");

            Console.WriteLine($"{(int)AccountingSystem.Підприємство1С} - 1С:Підприємство ");
            Console.WriteLine($"{(int)AccountingSystem.SAP_Business_One} - SAP Business One ");
            Console.WriteLine($"{(int)AccountingSystem.Oracle_Financials} - Oracle Financials ");
            Console.WriteLine($"{(int)LogisticSystem.SAP_Extended_Warehouse_Management} - SAP Extended Warehouse Management ");
            Console.WriteLine($"{(int)LogisticSystem.Oracle_Transportation_Management} - Oracle Transportation Management ");
            Console.WriteLine($"{(int)LogisticSystem.Manhattan_SCALE} -  Manhattan SCALE ");

            Console.WriteLine("Введіть номери програмних продуктів, які бажаєте придбати (відокремлені комами):");
            string input = Console.ReadLine();

            string[] productNumbers = input.Split(',');

            Console.WriteLine("Прізвище та ім'я автора програми: Бобко Роман");

            Console.WriteLine("Список обраних систем для автоматизації обліку:");
            foreach (string number in productNumbers)
            {
                int productNumber = int.Parse(number.Trim());
                if (Enum.IsDefined(typeof(AccountingSystem), productNumber))
                {
                    Console.WriteLine(((AccountingSystem)productNumber).ToString());
                }
            }

            Console.WriteLine("Список обраних систем для управління логістикою:");
            foreach (string number in productNumbers)
            {
                int productNumber = int.Parse(number.Trim());
                if (Enum.IsDefined(typeof(LogisticSystem), productNumber))
                {
                    Console.WriteLine(((LogisticSystem)productNumber).ToString());
                }
            }

            Console.ReadLine();
        }
    }
} 