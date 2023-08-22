Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int number_two = number; // переменная для рассчета + чтоб красиво вывести
int result = 0;
if (number < 100)
{
    Console.WriteLine($"{number} -> нет");
}
else 
{
    while (number_two > 999)
    {
        number_two /= 10;
    }
    result = number_two % 10;
    Console.WriteLine($"{number} -> {result}");
}