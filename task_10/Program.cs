/* Создать программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");
int number;

while (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number > 1000)
{
    Console.WriteLine("Формат числа не соответствует запросу");
}

int second = (number / 10) % 10;

Console.WriteLine($"Вторая цифра числа {number}: {second}");
