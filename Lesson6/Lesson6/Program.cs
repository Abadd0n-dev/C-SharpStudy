using System.Diagnostics;

//task 1 вывод на экран запущенные процессы и позволяет завершить указанный процесс.
Console.WriteLine("\tTask Manager");
while (true)
{
    Console.Clear();
    Process[] processes = Process.GetProcesses();

    for (int i = 0; i < processes.Length; i++)
    {

        Console.WriteLine($"ID: \t{processes[i].Id} \tName: \t{processes[i].ProcessName}");

    }

    Console.Write("Enter the name of the process you want to remove: ");
    string name = Console.ReadLine();

    try
    {
        processes.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
        Console.WriteLine($"{name} deleted!");
    }
    catch (InvalidOperationException)
    {
        Console.WriteLine($"Process {name} not found!");
    }
    Console.ReadKey();
}
