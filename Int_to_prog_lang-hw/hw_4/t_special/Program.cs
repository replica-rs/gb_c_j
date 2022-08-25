int[] RndA3NS2(int value)
{
    int[] temp = new int[value];
    Random rng = new Random();

    for (int i = 0; i < value-1; i++)
    {
        if (rng.Next(2) >= 1)
        {
            temp[i] = 1;
        }
        else
        {
            temp[i] = 0;
        }
    }

    return temp;
}

void WriteA3NS2(int[] value)
{
    int count = 0;
    while(count < value.Length)
    {
        System.Console.Write($"{value[count]} ");
        count = count + 1;
    }
    System.Console.WriteLine("");
}

System.Console.Write("Введите число: ");
int v1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Массив со случайными числами 0,1 с заданной длинной: ");
WriteA3NS2(RndA3NS2(v1));

//*********************************************************

double NS2ToNS10 (int value)
{
  double temp = 0;
  int count = 3;
  int result = 3;

  while(count > 0)
  {
    temp = temp + Math.Pow(2,count) * (value % Math.Pow(10,count+1) / Math.Pow(10,count));
    count = count - 1;
  }

  result = Convert.ToInt32(temp - 0.5);
  return result;
};

System.Console.Write("Введите 4-х битное число в 2-й сист.счис. (1001): ");
int v2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Введенное число в 10-й системе равно: {NS2ToNS10 (v2)}");

//*********************************************************

void NS10ToNSn8 (int v1,int v2)//Перевод из 10 системы в от 2й до 8й системы.
{
 int temp = 0;
 temp = v1;
 string str = "";

 while(temp > v2 )
 {
  str = str + (temp % v2);
  temp = temp / v2;
 }
 str = str + temp;

 string strr = "";
for (int i = str.Length-1; i >= 0; i--)
{
 strr = strr + str[i];
}

 System.Console.WriteLine($"Число {v1} в {v2}-й сист.счис. равно: {strr}");
}

System.Console.Write("Введите число в 10-й сист.счис.: ");
int v3 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите кратность сист.счис до 8-й для преобразования: ");
int v4 = Convert.ToInt32(System.Console.ReadLine());


NS10ToNSn8(v3,v4);