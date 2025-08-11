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
        while (i < number) // сначала проверяет, потом выполняет
        {
            i++;
            if (i % 2 == 0) evenCount++;
            else unevenCount++;
        }

        do
        {
            i++;
            if (i % 2 == 0) evenCount++;
            else unevenCount++;
        } while (i < number); // сначала выполняет, потом проверяет

        for (;;)
        {
            Console.WriteLine("for is working");   
            System.Threading.Thread.Sleep(300);
            break;
        }

        int iv = 0;
        for (; iv < 3; iv++)
        {
            Console.WriteLine("for_1: " + iv);
        }
        for (; iv < 5; iv++)
        {
            Console.WriteLine("for_2: " + iv);
        }
        
        for (int il = 0, nil = 5; il < 3; il++, nil--)
        {
            Console.WriteLine($"for_3: il - {il}, nil - {nil}");
        }
        

        Console.WriteLine($"Число {number} содержит в себе: {evenCount} парных и {unevenCount} непарных чисел.");
    }
}