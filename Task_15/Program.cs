Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());

if (number ==6 | number ==7)
{
    Console.WriteLine($"{number} -> да");
}

else 
{
    Console.WriteLine($"{number} -> нет");
}
