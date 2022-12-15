using static System.Console;
Clear();

// Choses elements of an array >= 3 symbols
string[] CreateArray(string[] array)
{
    string[] newArray = new string[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray = newArray.Append(array[i]).ToArray();
        }
    }
    return newArray;
}

// Print an array
void PrintArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write($"\"{array[i]}\"");
        if (i != array.Length - 1)
        {
            Write(", ");
        }
    }
    Write("]");
    WriteLine();
}

// Let's try
string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] newArray1 = CreateArray(array1);
string[] newArray2 = CreateArray(array2);
string[] newArray3 = CreateArray(array3);

PrintArray(newArray1);
PrintArray(newArray2);
PrintArray(newArray3);
