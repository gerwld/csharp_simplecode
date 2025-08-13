namespace l32;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray; // хранит ссылку как js
        myArray = new int[5] {1,2,3,4,5}; // heap, чистится само garbage collector
        myArray = new int[] {1,2,3,4,5}; // можно не указывать кол-во
        myArray = new int[] {1,2,3,4,5}; // можно не указывать кол-во

        int[] en = Enumerable.Repeat(5, 10).ToArray();
        int[] en2 = Enumerable.Range(2, 5).ToArray();
        
        

        myArray[0] = 5;

        Console.WriteLine(myArray[0]);
        
        
        
    }
}