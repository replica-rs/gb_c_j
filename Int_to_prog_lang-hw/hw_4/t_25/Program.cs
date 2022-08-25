double MPow(int value,int pow)
{
    int count = 0;
    double result = 1;
while (count < pow)
{
    result = result * value;
    count = count + 1;
}

return result;
}


System.Console.Write("Введите число: ");
int v1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int v2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {v1} в степени {v2} равно {MPow(v1,v2)}.");