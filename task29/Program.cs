// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.WriteLine("Введите значение наименьшего элемента массива: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение наибольшего элемента массива: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(8, minNumber, maxNumber);
PrintArray(array);


int[] CreateArray(int size, int minNum, int maxNum)
{
int[] arr = new int[size]; 

Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
        arr[i] = rnd.Next(minNum, maxNum);
}
return arr;
}

void PrintArray(int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
Console.Write(arr[i] + " " );
}
Console.Write("]");
}


