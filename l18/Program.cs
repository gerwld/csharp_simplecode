namespace l18;

class Program
{

    public static bool GetCoolingStatus()
    {
        return true;
    }
    
    public static bool GetTemperature()
    {
        return true;
    }
    
    static void Main(string[] args)
    {
        // && - не проверяет второе условие, поверхностное сравнение
        // & - побитовое сравнение, всегда проверяет 2 условие
        // & и |  - для побитовых сравнений (более трудозатратно)
        
        
        if (GetCoolingStatus() || GetTemperature())
        {
            Console.WriteLine("Угроза повреждения SOC");    
        }
    }
}