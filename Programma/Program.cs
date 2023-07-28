string[] baseArray = new string[10] {"один", "1", "два", "2", "три", "3", "четыре", "4", "пять", "5"};
string[] newArray = new string[baseArray.Length];

void GetNewArray(string[] baseArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length <=3)
        {
            newArray[count] = baseArray[i];
            count++;
        }
    }
}

void PrintNewArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();
}

GetNewArray(baseArray, newArray);
PrintNewArray(newArray);