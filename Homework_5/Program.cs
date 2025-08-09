namespace Homework_5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        int evenCount = 0;
        int unevenCount = 0;
        
        int i = 0;
        while (i < number)
        {
            i++;
            if (i % 2 == 0) evenCount++;
            else unevenCount++;
        }

        Console.WriteLine($"Число {number} содержит в себе: {evenCount} парных и {unevenCount} непарных чисел.");
    }
}