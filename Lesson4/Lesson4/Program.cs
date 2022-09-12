//task 1 Создан метод GetFullName,принимающий на вход ФИО в разных аргументах и возвращающую объединенную строку с ФИО.
Console.WriteLine(GetFullName("Нестеров", "Владимир", "Алексеевич"));
Console.WriteLine(GetFullName("Сеницые", "Андрей", "Генадьевич"));
Console.WriteLine(GetFullName("Манилов", "Александр", "Ветальевич"));
Console.WriteLine(GetFullName("Лисичкин", "Руслан", "Максимович"));
Console.ReadLine();

static string GetFullName(string lastname, string name, string patronymic)
{
    return $"{lastname} {name} {patronymic}";
}

//task 2 принятие на входную строку набор чисел через пробел и возвращение суммы всех чисел в строке.
string output = StringOutput();
int spacereturns = linebreak(output);
Console.WriteLine(spacereturns);
Console.ReadLine();

static string StringOutput()
{
    Console.Write("Введите последовательность чисел через пробел: ");
    return Console.ReadLine();
}
static int linebreak(string output)
{
    var words = output.Split();
    int part = default;
    for (int i = 0; i < words.Length; part += int.Parse(words[i++])) ;
    return part;
}