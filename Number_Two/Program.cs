Console.WriteLine("Ввидите 1 число");
double first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите 2 число");
double second_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите 3 число");
double third_number = Convert.ToInt32(Console.ReadLine());
if(first_number > second_number)
{
    if(first_number > third_number)
        Console.WriteLine($"{first_number} Максимальное число");
    else
        Console.WriteLine($"{third_number} Максимальное число");
}
else if (first_number < second_number)
{
    if(second_number > third_number)
        Console.WriteLine($"{second_number} Максимальное число");
    else
        Console.WriteLine($"{third_number} Максимальное число");
}
else
{
    Console.WriteLine("Числа равны");
}