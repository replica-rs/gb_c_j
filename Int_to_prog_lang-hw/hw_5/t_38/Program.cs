int[] RndArray() //Массив случайных чисел (0,99) длинной:5.
{
    Random rng = new Random();
    int[] temp = new int[5];

    for (int i = 0; i < temp.Length; i++) 
    {
        temp[i] = rng.Next(0,99);
    }

    return temp;
}

void WriteArray(int[] varray)
{

    System.Console.Write("Массив: [ ");

    int count = 0;

    while(count < varray.Length) // Вывод чисел массива.
    {
        System.Console.Write($"{varray[count]} ");
        count = count + 1;
    }
    
    System.Console.WriteLine($"].");






    int min = varray[0];
    int max = varray[0];
        count = 0;

    while(count < varray.Length) //Поиск минимального и максимального значений.
    {
        if(min > varray[count])
        {
           min = varray[count];
        }
        if(max < varray[count])
        {
           max = varray[count];
        }
        count = count + 1;
    }

    System.Console.WriteLine($"Разница между min({min}) и max({max}) равна: {max-min}");
}

WriteArray(RndArray());