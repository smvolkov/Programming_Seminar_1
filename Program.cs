void NumberSquare(double number)
{
    Console.WriteLine(number * number);
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

NumberSquare(num);