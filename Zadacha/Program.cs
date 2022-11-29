// Из имеющегося массива строк сформировать массив строк длина которых меньше или равна 3.

void FillArray(string []array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}
Console.WriteLine("\n");
}

string [] ArrayCount(string[]array)
{
int count=0;
string [] result = new string [array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=3)
    {
        count=count+1;
        result[i-1]=array[i];   
    }
}
return result;
}
int ArrayLengthCount(string[]array)
{
int count=0;
string [] result = new string [array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=3)
    {
        count=count+1;
        result[i-1]=array[i];   
    }
}
return count;
}


void PrintArray(string[]array,int count)
{
for (int i = 0; i < count; i++)
{
    Console.Write(array[i]+" ");
}
Console.WriteLine("\n");
}

string [] str= {"Массив", "из" , "трех", "строк"};
Console.WriteLine("Исходный массив");
FillArray(str);
string[] newarray=ArrayCount(str);
int value=ArrayLengthCount(str);
Console.WriteLine("Новый массив");
PrintArray(newarray,value);





