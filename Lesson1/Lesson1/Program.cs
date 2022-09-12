//task 1 Создание переменной, а также вывод на экран приветствия и сегодняшней даты.
Console.Write("What's your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}, today [{DateTime.Now}]");
Console.Read();
