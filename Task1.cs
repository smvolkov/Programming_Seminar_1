//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

// void MaxNumber(int number1, int number2)
// {
//     if (number1 > number2)
//     {
//         Console.WriteLine($"Max = {number1}");
//     }
//     else
//     {
//         Console.WriteLine($"Max = {number2}");
//     }
// }

// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// MaxNumber(num1, num2);

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

void MaxNumberOf3(int number1, int number2, int number3)
{
    int max = number1;
    
    if (number2 > max) max = number2;
    if (number3 > max) max = number3;

    Console.WriteLine($"Max = {max}");
}

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

MaxNumberOf3(num1, num2, num3);

