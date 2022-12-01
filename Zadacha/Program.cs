// Из имеющегося массива строк сформировать массив строк длина которых меньше или равна 3.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("\n");
}

string[] CheckArray(string[] array)
{
    int count = 0;
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {

            result[count] = array[i];
            count = count + 1;
        }
    }
    return result;
}

int CheckCount(string[] array)
{
    int count = 0;
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count = count + 1;
        }
    }
    return count;
}

string[] FillNewArray(string[] array, int count)
{
    string[] NewArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        NewArray[i] = array[i];
    }
    return NewArray;
}



string[] str = { "Массив", "из", "трех", "строк", "'элементы", "0", "124" };
Console.WriteLine("Исходный массив");
PrintArray(str);
string [] ArrayMiddle = CheckArray(str);
int value = CheckCount(str);
string [] NewArray = FillNewArray(ArrayMiddle, value);
Console.WriteLine("Новый массив");
PrintArray(NewArray);





