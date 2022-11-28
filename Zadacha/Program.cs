// Из имеющегося массива строк сформировать массив строк длина которых меньше или равна 3.
Console.WriteLine("Hello, World!");
string [] str= {"Массив", "из" , "трех", "строк"};
Console.WriteLine("Исходный массив");
for (int i = 0; i < str.Length; i++)
{
    Console.Write(str[i]+" ");
}
Console.WriteLine("\n");

int count=0;
string [] result = new string [str.Length];
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length<=3)
    {
        count=count+1;
        result[i-1]=str[i];   
    }
}
Console.WriteLine(count);

Console.WriteLine("Новый массив");
for (int i = 0; i < count; i++)
{
    Console.Write(result[i]+" ");
}
Console.WriteLine("\n");
