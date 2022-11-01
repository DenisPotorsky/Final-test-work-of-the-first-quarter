using static System.Console;
Clear();

WriteLine("Заполните массив через пробел");
string[] array = ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int NewArrayLength(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        string str = arr[i];
        int length = str.Length;
        if (length <= 3) count++;
    }
    return count;
}