void PrintArray(string[] arr)
{
    foreach (string element in arr)
    {
        Console.Write($"'{element}' ");
    }
    Console.WriteLine();
}

string[] array = { "hello", "2", "world", ":-)" };

Console.Write($"input array is "); PrintArray(array);

string[] ArrayMethod(string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        string temp = array[i];
        if (temp.Length <= 3) newArray[i] = temp;
    }
    return newArray;
}

string[] newArray = ArrayMethod(array);
newArray = newArray.Where(x => x != null).ToArray(); 
Console.Write($"output array is "); PrintArray(newArray);
