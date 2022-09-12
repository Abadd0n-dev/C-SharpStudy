using System.IO;

//task 1 ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
Console.WriteLine("Введите расположение файла");
var path = Console.ReadLine();
if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
{
    Console.WriteLine("Неверно указанный путь");
    return;
}

if (!path.EndsWith(".txt")) path += ".txt";
var fs = new FileStream(path, File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate);
var sw = new StreamWriter(fs);


Console.WriteLine("Введите данные для текстового файла, нажмите esc, чтобы остановиться");
sw.AutoFlush = true;
while (true)
{
    var input = Console.ReadKey();

    if (input.Key == ConsoleKey.Escape)
        break;
    if (input.Key == ConsoleKey.Enter)
    {
        sw.Write("\n");
        Console.WriteLine();
    }
    else sw.Write(input.KeyChar);
}
Console.WriteLine("Записанно");

//task 2 программа которая при старте дописывает текущее время в файл.
var sw = File.AppendText("startup.txt");
var time = DateTime.Now.ToString("HH:mm:ss tt");
sw.WriteLine(time);
Console.WriteLine($"В данный момент обновлено время {time}");

//task 3 ввод с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
const string file = "test.bin";

Console.WriteLine("Введите числа от [0..255], через пробел");
var inputl = Console.ReadLine()?.Split(' ');

var array = new byte[inputl.Length];
for (var i = 0; i < array.Length; i++)
{
    if (!byte.TryParse(inputl[i], out var number))
    {
        Console.WriteLine($"Неверное число {inputl[i]}");
        return;
    }

    array[i] = number;
}

using (var bw = new BinaryWriter(File.OpenWrite(file)))
{
    bw.Write(array);
    bw.Flush();
}

Console.WriteLine($"в файле сейчас находится {file}"); ; ;
byte[] newData;
using (var br = new BinaryReader(File.OpenRead(file)))
{
    newData = br.ReadBytes(array.Length);
}

for (var i = 0; i < newData.Length; i++)
{
    Console.Write(newData[i] + " ");
}
