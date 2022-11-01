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

string[] FillingNewArray(string[] array, int len)
{
    int index = 0;
    string[] newArr = new string[len];
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        int length = str.Length;
        if (length <= 3)
        {
            newArr[index] = array[i];
            index++;
        }
    }
    return newArr;
}