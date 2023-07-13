Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number / 100 == 0)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}

if (number / 100 >= 1 & number / 100 < 10)
{
    int firstDigit = number / 100;
    int thirdDigit = (number - firstDigit * 100) % 10;
    Console.WriteLine($"{number} -> {thirdDigit}");
}

if (number / 100 >= 10)
{
    int x = number / 10;
    while (x > 999)
    {
        x = x / 10;
    }
    int firstDigit = x / 100;
    int thirdDigit = (x - firstDigit * 100) % 10;
    Console.WriteLine($"{number} -> {thirdDigit}");
}