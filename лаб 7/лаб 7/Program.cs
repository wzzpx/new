using System;
using System.IO;
using System.Linq;


class program
{
    static void Main()
    {
        // Відкриття файла для читання і запису
        var input = new StreamReader("input.txt");
        var output = new StreamWriter("output.txt");

        // Читаємо всі рядки файлу input і записуємо їх
        var lines = input.ReadToEnd().Split('\n').Select(x => x.Trim()).ToArray();
        Array.Sort(lines);

        // Записуємо відсортований файл в output

        foreach(var line in lines)
        {
            output.WriteLine(line);
        }
        // Закриваємо файл
        input.Close();
        output.Close();
    }
}