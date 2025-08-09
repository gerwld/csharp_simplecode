namespace l22;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        int limit = int.Parse(Console.ReadLine());
        while (counter < limit)
        {
            counter++;
            Console.WriteLine(counter);
        }

    }
}