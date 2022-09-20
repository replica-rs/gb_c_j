// Метод поворота двумерного массива на 90 градусов.

bool[,] array2D = new bool[4,4] { { false, false, false, false },
                                  { true, false, false, false },
                                  { true, false, false, false },
                                  { true, true, false, false } 
                                  };

bool[,] RotateArray(bool[,] valueA)
{

    bool[,] tempA = new bool[4,4];  //0.0 -> 0.3  1.1 -> 1.2  2.2 -> 2.1  3.3 -> 3.0

    for (int i = 0; i < 4; i++) 
    {
        for (int j = 0; j < 4; j++) 
     {
        tempA[i,j] = valueA[Math.Abs(i-3),Math.Abs(j-3)];
     }
    }

    return tempA;
}

void WriteArray2D(bool[,] valueA)
{
    for (int i = 0; i < 4; i++) 
    {
        for (int j = 0; j < 4; j++) 
     {
        if (valueA[i,j])
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(".");
        }
     }

Console.WriteLine("");

    }
}

Console.WriteLine("Исходный 2D массив:");
Console.WriteLine("");
WriteArray2D(array2D);

Console.WriteLine("");

Console.WriteLine("После поворота на 90:");
Console.WriteLine("");
WriteArray2D(RotateArray(array2D));