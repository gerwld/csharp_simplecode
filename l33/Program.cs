namespace l33;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int [] {10,3,5} ;

        
        for (var i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        
        
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
}