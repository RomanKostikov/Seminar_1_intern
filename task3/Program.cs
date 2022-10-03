// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int a = number * -1;
if(number < 0){
    while(number <= a){
        Console.Write(number);
        number++;
    }
}
else{
    while(a <= number)
    {
        Console.Write(a);
        a++;
    }
}