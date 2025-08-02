namespace Homework_3;

class Program
{
    static void Main(string[] args)
    {
        
        // конвертер валют

        double USDToEUR = 0.86;
        double USDToPLN = 3.69;
        double USD;
        int current = 0;

        Console.WriteLine("Введите сумму в USD");

        USD = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите валюту\t (введите '1' для EUR, '2' для PLN)");
        current = int.Parse(Console.ReadLine());
        if (current == 1)
            Console.WriteLine(USD + " USD в EUR = " + USDToEUR * USD + "€");
        else if (current == 2)
            Console.WriteLine(USD + " USD в PLN = " + USDToPLN * USD + "zł");
        else
            Console.WriteLine("Выбрано неверную валюту, введенное значение: " + current);
        
    }
}