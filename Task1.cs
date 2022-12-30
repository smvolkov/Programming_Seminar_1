//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

void MaxNumber(int number1, int number2)
{
    if (number1 > number2)
    {
        Console.WriteLine("Max = ", number1);
    }
    else
    {
        Console.WriteLine("Max = ", number2);
    }
}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
