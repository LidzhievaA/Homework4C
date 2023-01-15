// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberSum = Sum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {numberSum}");

int Sum(int num)
{
if(num<0) num *= -1;
    int sum = 0;
    for(int i = 0; num > 0; i++)
    {checked 
    {         
        int lastNum = num % 10;
        sum =  sum + lastNum; 
        num = num / 10;
    }
    }
   
    return sum;
}