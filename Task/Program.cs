using static System.Console;
Clear();

WriteLine("Заполните массив через пробел");
string[] array = ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);