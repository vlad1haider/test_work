using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = null; // Ошибка: список не инициализирован

        // Попытка добавить элемент в null-список
        names.Add("Alice");

        Console.WriteLine("Программа завершена");
    }
}
