// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB <= 0)
Console.WriteLine("Введено некорректное число В");

else
{
int resultNumber = Degree(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {resultNumber}");
}

int Degree(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numA;
    }
    return result;
}

