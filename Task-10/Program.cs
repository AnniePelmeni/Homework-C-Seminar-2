Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int firstDigit = number / 100;
int secondDigit = (number - firstDigit * 100) / 10;

Console.WriteLine($"{number} -> {secondDigit}");