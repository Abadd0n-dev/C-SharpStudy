//task 1 программа, выводящая двухмерный массив по диагонали.
using System.Text;

int[,] matrix = new int[5, 5];

matrix[0, 0] = 1;
matrix[1, 1] = 1;
matrix[2, 2] = 1;
matrix[3, 3] = 1;
matrix[4, 4] = 1;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.ReadLine();

//task 2 создать из массива телефонный справочник.
var name = new string[5, 2]{{"Руслан", "+7 985 171 34 83"},{"Федор", "+7 915 343 55 61"},
                {"Александр", "sasha@mail.ru"},{"Алина", "alina@gmail.ru"},{"Андрей", "andrei@list.ru"}};
for (var i = 0; i < name.GetLength(0); i++)
{
    for (var j = 0; j < name.GetLength(1); j++)
        Console.Write(name[i, j] + " ");
    Console.WriteLine();
}
Console.ReadLine();

//task 3 вывод строки в обратном порядке.
Console.WriteLine("Введите слово");
var word = Console.ReadLine();
var reverced = new StringBuilder();
for (var i = word.Length - 1; i >= 0; i--)
    reverced.Append(word[i]);

Console.WriteLine(reverced);
Console.ReadLine();
