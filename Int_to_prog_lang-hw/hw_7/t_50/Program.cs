int[,] RndArray2D(int value1, int value2) 
{
    Random rng = new Random();
    int[,] temp = new int[value1,value2];

    for (int i = 0; i < value1; i++)
    {
        for (int j = 0; j < value2; j++)
        {
         temp[i,j] = rng.Next(-9,9);
        }
    }

    return temp;
}

void WrArray2D (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(array.Rank-1); j++)
        {
         Console.Write($"array[{i},{j}]:{array[i,j]} ");
        }
        Console.WriteLine("");
    }

    
}

void PrintValue (int[,] array)
{
    string[] temp = Console.ReadLine().Split(',');
    int i = Convert.ToInt32(temp[0]);
    int j = Convert.ToInt32(temp[1]);

    Console.WriteLine(array[i,j]);
}

int[,] TempA = new int[3,4];
TempA = RndArray2D(3,4);

WrArray2D(TempA);
Console.WriteLine("Введите позиции числа в массиве через запятую [i,j]:");
PrintValue(TempA);