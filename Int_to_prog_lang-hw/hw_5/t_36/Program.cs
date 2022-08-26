int[] RndArray() //Массив случайных чисел (-99,99) длинной:4.
{
    Random rng = new Random();
    int[] temp = new int[4];

    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = rng.Next(-99,99);
    }

    return temp;
}

void WriteArray(int[] varray)
{
    System.Console.Write("Массив: [ ");

    int count = 0;

    while(count < varray.Length)  // Вывод чисел массива.
    {
        System.Console.Write($"{varray[count]} ");
        count = count + 1;
    }

    int summ = 0;
    
    count = 1;
    while(count < varray.Length)   //Сумма элементов, на нечетных позициях.
    {
        summ = summ + varray[count];
        count = count + 2;
    }

     System.Console.WriteLine($"]. Сумма элементов, на нечетных позициях: {summ}");
}

WriteArray(RndArray());