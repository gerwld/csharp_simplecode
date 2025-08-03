using System.Numerics;

namespace Homework_4;

// проверка введеного числа на парное, с валидацией введеных данных + bigint.
class Program
{
    static void Main(string[] _)
    {
        
        Console.Write("Введите целое число: ");

        string cta = "Перезапустите программу и введите целое число.";
        string response = Console.ReadLine();

        void ValidateReponse(BigInteger num)
        {
            if (num % 2 == 0) Console.WriteLine($"{num} - парное число.");
            else Console.WriteLine($"{num} - непарное число.");
        }

        if (Int32.TryParse(response, out Int32 integer)) // целое
            ValidateReponse(integer);
        else if (BigInteger.TryParse(response, out BigInteger big)) // большое
            ValidateReponse(big);
        else if (double.TryParse(response, out double doub)) // c точкой
            Console.WriteLine($"{doub} - дробное число. {cta}");
        else if (response == "") Console.WriteLine($"Введено пустое значение. {cta}"); // пустое
        else Console.WriteLine($"Введено неверное значение (\"{response}\"). {cta}"); // неверное
    }
}