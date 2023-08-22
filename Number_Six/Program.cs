Console.WriteLine("Введите целое/дробное число");
double number = Convert.ToDouble(Console.ReadLine()); // грубая проверка являится ли строка числом
string str_number = Convert.ToString(number); // перевод числа в строку
char [] array = new char[str_number.Length]; //создание символьного массива
int count  = 0; // счетчик
for (int i = 0; i < str_number.Length; i++) // цикл перевода в строку в символьный массив
{
    array[i] = str_number[i];
    if (array[i] >= '0' && array[i] <= '9')
    {
        count += 1;
    }
    // проверка по символам в таблице символом идет порядо от 0 до 9  
    //и если символ поподает в этот промежуток то мы к сетчику прибовляем единичку
}
Console.WriteLine($"Количиство цифр в числе -> {count}"); // вывод на экран
