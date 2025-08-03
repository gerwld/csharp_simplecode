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

        
        if (Int32.TryParse(response, out Int32 integer)) // целое
        {
            if (integer % 2 == 0) Console.WriteLine($"{integer} - парное число.");
            else Console.WriteLine($"{integer} - непарное число.");
        }
        else if (BigInteger.TryParse(response, out BigInteger big)) // большое
        {
            if (integer % 2 == 0) Console.WriteLine($"{big} - парное число.");
            else Console.WriteLine($"{big} - непарное число."); 
        }
        // 2 конструкции выше можно обьединить, только ухудшит читаемость
        
        else if (double.TryParse(response, out double doub)) // c точкой
            Console.WriteLine($"{doub} - дробное число. {cta}");
        else if(response == "") Console.WriteLine($"Введено пустое значение. {cta}"); // пустое
        else Console.WriteLine($"Введено неверное значение (\"{response}\"). {cta}"); // неверное
    }
}