int FindModifiedArrLen (string [] array)
{
    // Находим длинну будующего массива, так как договорились не использовать коллекции.
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string [] ArrayModificator (string [] array)
{
    string [] modifiedArray = new string [FindModifiedArrLen(array)];
    int j = 0;
    // Добавляем элементы длинной <= 3 в отредактированный массив
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            modifiedArray[j] = array[i];
            j++;
        }
    }
    return modifiedArray;
}

string [] array1 = new string [] {"hello", "2", "world", ":-)"};
string [] array2 = new string [] {"1234", "1567", "-2", "computer science"};
string [] array3 = new string [] {"Russia", "Denmark", "Kazan"};
array1 = ArrayModificator(array1);
array2 = ArrayModificator(array2);
array3 = ArrayModificator(array3);
Console.WriteLine("[{0}]", string.Join(", ", array1));
Console.WriteLine("[{0}]", string.Join(", ", array2));
Console.WriteLine("[{0}]", string.Join(", ", array3));
