
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