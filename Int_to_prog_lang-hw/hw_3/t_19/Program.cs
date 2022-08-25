
void CheckPoly(int value) //Проверка полиндромов в пределе Int32
{
    int count = Convert.ToString(value).Length; //Щечик for (5 цифр => 2 прохода; 4 => 2)
    int vleng = count;//Кол-во цифр в числе.
    int check = 0;//Кол-во true проверок.



    if (count % 2 == 0)//Щечик for (5 цифр => 2 прохода; 4 цифры => 2)
    {
     count = count / 2;
    }
    else
    {
     count = (count - 1 ) / 2;
    }



     for (int i = 0; i < count; i++)
     {
       if (value % Convert.ToInt32(Math.Pow(10,i+1)) / Convert.ToInt32(Math.Pow(10,i)) == value % Convert.ToInt32(Math.Pow(10,vleng-i)) / Convert.ToInt32(Math.Pow(10,vleng-i-1)))
       {
        check =check + 1;
       }
     }



     if (check == count)
     {
        System.Console.WriteLine($"Число {value} является полиндромом.");
     }
     else
     {
        System.Console.WriteLine($"Число {value} НЕявляется полиндромом.");
     }
}


System.Console.Write("Введите число: ");

int value = Convert.ToInt32(Console.ReadLine());

 CheckPoly(value);
