
string[] CreateArray(int size)
{
    return new string[size];
}

string[] FillArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1} элемент массива ");
        array1[i] = Console.ReadLine();
    }
    return array1;
}

int ChooseElements(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] MainTask(string[] array1, string[] array2)
{
    int index = 0;
    int i = 0;
    while (i < array1.Length)
    {
        int lenght = array1[i].Length;
        if (lenght <= 3)
        {
            array2[index] = array1[i];
            index++;
        }
        i++;
    }
    return array2;
}