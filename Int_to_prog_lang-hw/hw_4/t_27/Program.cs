int NumberSum(int value)
{
    int summ = 0;
    int count = 0;
    while(count < Convert.ToString(value).Length)
    {
    summ = summ + value % Convert.ToInt32(Math.Pow(10,count+1)) / Convert.ToInt32(Math.Pow(10,count));
    count = count + 1;
    }

    return summ;
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр числа равна: {NumberSum(number)}");