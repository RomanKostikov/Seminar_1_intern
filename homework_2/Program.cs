// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine());
int[] arr = new int[3]{number1,number2,number3};
int max = arr[0];
int count = 0;
while(count < 3)
{
    if(arr[count] > max)
    {
        max = arr[count];
    }
    count++;
}
Console.WriteLine(max);