void PrintArray(string[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
    Console.WriteLine();
}

string[] firstArray = { "111", "Hi", "hello", "world", "!!", "!!!!", ":)" };
string[] responseArray = new string[firstArray.Length];
int index = 0;

for (int i = 0; i < firstArray.Length; i++)
{
    if(firstArray[i].Length <= 3)
    {
        responseArray[index] = firstArray[i];
        index ++;
    }
    
}

Console.Write("Изначальный массив данных: ");
PrintArray(firstArray);
Console.WriteLine();
Console.Write("Ответ: ");
PrintArray(responseArray);

