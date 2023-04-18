/* Вывод третьей цифры заданного числа.
645   -> 5
78    -> третьей цифры нет
32679 -> 6
*/


Console.Write("Введите любое число: ");
string s = Console.ReadLine();

if (int.TryParse(s, out int c))
{
    if (c >= 100 && c < 1000)
    {
        Console.WriteLine($"Третья цифра числа {c}: {(c / 1) % 10}");
    }
    else if (c < 100){
        Console.WriteLine($"Третья цифра числа {c} отсутствует");
    }
    else if (c >= 1000 && c < 10000)
    {
        Console.WriteLine($"Третья цифра числа {c}: {(c / 10) % 10}");
    }
    else if (c >= 10000 && c < 100000)
    {
        Console.WriteLine($"Третья цифра числа {c}: {(c / 100) % 10}");
    }
    else if (c >= 100000)
    {
        Console.WriteLine($"Слишком больше число {c}");
    }
}
else
{
    Console.WriteLine("Ошибка при вводе числа");
}
