double[] RndArray() //Массив случайных чисел (100,999) длинной от 3 до 5.
{
    Random rng = new Random();
    double[] temp = new double[rng.Next(3,5)];

    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = rng.Next(100,999);
    }

    return temp;
}


void WriteArray(double[] varray)
{
    System.Console.Write("Массив: [ ");

    int count = 0;

    while(count < varray.Length) // Вывод чисел массива.
    {
        System.Console.Write($"{varray[count]} ");
        count = count + 1;
    }

    int EvenN = 0;
    
    for (int i = 0; i < varray.Length; i++) // Кол-ва четных чисел.
    {
        if (varray[i] % 2 == 0)
        {
            EvenN = EvenN + 1;
        }
    }

     System.Console.WriteLine($"]. Кол-во четных чисел: {EvenN}");
}

WriteArray(RndArray());
