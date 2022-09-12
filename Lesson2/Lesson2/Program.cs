//task1 запросить у пользователя, максимальную и минимальную температуру за сутки и вычислить среднюю температуру за сутки.
Console.Write("Введите, максимальную температуру: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("максимальная температура составляет " + firstValue);

Console.WriteLine("Введите, минимальную температуру: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальнуа температура составляет " + secondValue);

int result = (firstValue + secondValue) / 2;
Console.WriteLine("Средняя температура за сутки " + result);
Console.ReadLine();

//task 2 Запросить у пользователя порядковый номер текущего месяца и вывести его название.
int month = 3;
string monthTitle = "";
switch (month)
{
    case 1:
        monthTitle = "январь";
        break;
    case 2:
        monthTitle = "февраль";
        break;
    case 3:
        monthTitle = "март";
        break;
    case 4:
        monthTitle = "апрель";
        break;
    case 5:
        monthTitle = "май";
        break;
    case 6:
        monthTitle = "июнь";
        break;
    case 7:
        monthTitle = "июль";
        break;
    case 8:
        monthTitle = "август";
        break;
    case 9:
        monthTitle = "сентябрь";
        break;
    case 10:
        monthTitle = "октябрь";
        break;
    case 11:
        monthTitle = "ноябрь";
        break;
    case 12:
        monthTitle = "декабрь";
        break;
}
Console.WriteLine(monthTitle);
Console.ReadLine();

//task 3 Определить, является ли введённое пользователем число чётным.
int i;
Console.Write("Введите число:");
i = Convert.ToInt32(Console.ReadLine());
if (i % 2 == 0)
{
    Console.Write("Введено четное число");
    Console.Read();
}
else
{
    Console.Write("Введено нечетное число");
    Console.Read();
}

//task 4 Схематичное создание чека.
Console.Title = "Чек";
Console.WindowWidth = 70;
Console.WindowHeight = 40;
Console.WriteLine("{0,35}", "Пятерочка");
Console.WriteLine("{0,37}", "Кассовый чек");
Console.WriteLine("{0,20}", "Цена до скидки       Скидка      Итого");
double price = 35.99;
Console.WriteLine("Вода СВЯТОЙ ИСТОЧНИК б/г" + "{0, 15}", price);
for (int j = 0; j < 100; j++)
    Console.Write("-");
Console.WriteLine();
Console.WriteLine("ПОДЫТОГ: " + price);
int total = 35;
Console.WriteLine("ИТОГ: " + total);
Console.WriteLine("СДАЧА: " + total);
int change = 0;
Console.WriteLine("СДАЧА: " + change);
for (int h = 0; h < 100; h++)
    Console.Write("-");
Console.WriteLine();
string name = "Джафарова Сакина Вагибовна";
Console.WriteLine("Кассир: " + name + ", Продавец-кассир");
Console.WriteLine($"Дата принятия: [{DateTime.Now}]");
Console.ReadLine();
