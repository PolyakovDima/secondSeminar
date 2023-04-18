// День недели.

Console.Write("Введите день недели: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    switch (number)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("День недели не является выходным");
            break;
        case 6:
        case 7:
            Console.WriteLine("День недели является выходным");
            break;
        default:
            Console.WriteLine("Вы ввели некорректный день недели.");
            break;
    }
}
else
{
    Console.WriteLine("Вы ввели не число.");
}
