double[,] RndArray2D(int value1, int value2) 
{
    Random rng = new Random();
    double[,] temp = new double[value1,value2];

    for (int i = 0; i < value1; i++)
    {
        for (int j = 0; j < value2; j++)
        {
         temp[i,j] = rng.NextDouble();
        }
    }

    return temp;
}

void WrArray2D (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(array.Rank-1); j++)
        {
         Console.Write($"array[{i},{j}]: {array[i,j]} ");
        }
        Console.WriteLine("");
    }

    
}

WrArray2D(RndArray2D(3,4));