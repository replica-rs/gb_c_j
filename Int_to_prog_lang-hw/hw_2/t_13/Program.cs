int value = Convert.ToInt32(Console.ReadLine());

if (value / 100 == 0)
{
Console.WriteLine($"Число {value} меньше 100.");
}
else
{
Console.WriteLine($"Третья с конца цифра числа {value} это {(value % 1000)/ 100}.");
}


