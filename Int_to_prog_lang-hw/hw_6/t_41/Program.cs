
string[] GetStrings()
{
    Console.WriteLine("Введите несколько чисел через запятую (12,32):");
    string value = Console.ReadLine();
    string[] temp = value.Split(',');

    return temp;
}

int[] StringsToNumbers( string[] value)
{
    int[] temp = new int[value.Length];
    for (int i = 0; i < value.Length; i++) 
    {
        temp[i] = Convert.ToInt32(value[i]);
    }

    return temp;
}


void GreaterTZero ( int[] value)
{
    int count = 0;

    for (int i = 0; i < value.Length; i++) 
    {
        if (value[i] > 0) 
        {
            count = count + 1;
        }
    }
    
    Console.WriteLine($"Кол-во чисел больше нуля: {count}.");
}


GreaterTZero(StringsToNumbers(GetStrings()));