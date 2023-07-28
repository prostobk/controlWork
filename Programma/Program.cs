string[] basearray = new string[10] {"один", "1", "два", "2", "три", "3", "четыре", "4", "пять", "5"};
string[] newarray = new string[basearray.Length];

void GetNewArray(string[] basearray, string[] newarray)
{
    int count = 0;
    for (int i = 0; i < basearray.Length; i++)
    {
        if (basearray[i].Length <=3)
        {
            newarray[count] = basearray[i];
            count++;
        }
    }
}

void PrintNewArray(string[] newarray)
{
    for (int i = 0; i < newarray.Length; i++)
    {
        Console.Write($"{newarray[i]} ");
    }
    Console.WriteLine();
}

GetNewArray(basearray, newarray);
PrintNewArray(newarray);