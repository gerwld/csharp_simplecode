namespace Homework_2;

class Program
{
    static void Main(string[] args)
    {
        // cреднее арифметическое (без валидации)
        double firstValue, secondValue, thirdValue;

        Console.WriteLine("Введите число 1");
        firstValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число 2");
        secondValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число 3");
        thirdValue = double.Parse(Console.ReadLine());

        double sumResult = (firstValue + secondValue + thirdValue);
        double multResult = (firstValue * secondValue * thirdValue);

        Console.WriteLine("Сумма 3 чисел = " + sumResult);
        Console.WriteLine("Произведение 3 чисел = " + multResult);

        // Console.WriteLine("Среднее арифметическое суммы 3 чисел = " + result);
    }
}