Console.WriteLine("Ввидите первое число");
double first_number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double second_number = Convert.ToDouble(Console.ReadLine());

if (first_number > second_number)
    Console.WriteLine($"a = {first_number}; b = {second_number}; Max = {first_number}");

else if (first_number < second_number)
    Console.WriteLine($"a = {first_number}; b = {second_number}; Max = {second_number}");

else
    Console.WriteLine($"Числа равны");
