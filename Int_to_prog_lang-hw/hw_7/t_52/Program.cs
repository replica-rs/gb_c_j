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

void WrAverArray2D (int[,] array)
{
    double summ = 0;

    for (int j = 0; j < array.GetLength(array.Rank-1); j++)
    {
        summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
         summ = summ + Convert.ToDouble(array[i,j]);
        }

        summ = summ / array.GetLength(0);
        Console.WriteLine(summ);

    }
}

int[,] TempA = new int[3,4];
TempA = RndArray2D(3,4);

WrArray2D(TempA);
WrAverArray2D(TempA);