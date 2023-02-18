// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] > ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] > ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

using static System.Console;
Clear();

WriteLine("====UNIT TESTS====");
string[] testArray1 = { "hello", "2", "world", ":-)" };
string[] testArray2 = { "1234", "1567", "-2", "computer science" };
string[] testArray3 = { "Russia", "Denmark", "Kazan" };
PrintArray(testArray1);
WriteLine();
PrintArray(WorkTheArray(testArray1));
WriteLine();

PrintArray(testArray2);
WriteLine();
PrintArray(WorkTheArray(testArray2));
WriteLine();

PrintArray(testArray3);
WriteLine();
PrintArray(WorkTheArray(testArray3));
WriteLine();

void PrintArray(string[] inArray)
{
    if(inArray.Length == 0)
    {
        WriteLine("No suitable elements");
    }
    else
    {
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}");
    }
}

string[] WorkTheArray(string[] inArray)
{
    string[] resultArray = new string[inArray.Length];
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            resultArray[count] = inArray[i];
            count += 1;
        }
    }
    return resultArray = resultArray[..^(inArray.Length - count)];
}