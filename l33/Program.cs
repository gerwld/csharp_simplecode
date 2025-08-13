namespace l33;

class Program
{
    static void Main(string[] args)
    {
        int length = 5;
        int[] array = new int[length];
        
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите число {i}/{length}: ");
            String resp = Console.ReadLine();

            
            Int32.TryParse(resp, out Int32 integer);

            Console.WriteLine(integer);

            if (integer != 0 || resp == "0")
            {
                array[i] = integer;
            }
            else throw new Exception($"Введено неверное значение \"{resp}\". Прекращение работы.");
        }

        Console.Write($"Вы заполнили массив: {{{String.Join(", ", array)}}}.");
    }
}