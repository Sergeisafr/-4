// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers (int num)
{
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
int sum1 = 0;
int i = 0;
{
if (num > 9)

    while (num > 0)
    {
        i = num % 10;
        
        num = num / 10;
     if (i > 0)
     sum1= sum1 + i;
      
    }

 return sum1;  
}
}
int res = SumNumbers (9012);
Console.WriteLine(res);