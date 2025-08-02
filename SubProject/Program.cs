namespace SubProject;

class Program
{
    static void Main(string[] args)
    {
        // cреднее арифметическое (без валидации)
        double firstValue, secondValue;

        Console.WriteLine("Введите число 1");
        firstValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число 2");
        secondValue = double.Parse(Console.ReadLine());

        double result = (firstValue + secondValue) / 2;

        Console.WriteLine("Среднее арифметическое суммы 2 чисел = " + result);

    }
}