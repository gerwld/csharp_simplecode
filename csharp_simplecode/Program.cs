﻿

using System.Collections.Concurrent;
using System.Globalization;
using System.Net.WebSockets;

namespace Csharp
{
    class Program
    {
        static void Main(string[] agrs)
        {
            /* типы данных
             * числовые (целочисленные), отличаются по диапазону.
             * byte, sbyte, short ushort, int, uint, long, ulong
             * в среде разработки .Net все, естественно, называется не так (Int16 итд)
             * но IDEшка подсказывает.
             * 
             * все что с U вначале не могут хранить отриц. значения
             * при этом размер их тот же (вместительность) в сравнении с типом без U.
             * НО, максимальное позитивное значение /2 от обычного типа данных без U.
             * как будто шифт индексов массива на -50%.
             *
             * числовые с плавающей точкой
             * double, - с точкой 
             * decimal  - дробь
             * float - числа с плавающей точкой (хз что это, консоли ими тестят)
             *
             * символьные
             * char - один символ в одинарных скобках
             * string - размер до посинения
             *
             * логичесние
             * bool - один байт занимает, что логично даже
             *
             * особые
             * object - может хранить в себе любой другой тип, поскольку любой тип данных
             *          в C# это по сути наследник обьекта. как с Extends по идее
             * 
             * dynamic - специфический тип C#. в отличии от object можно изменять данные внутри его
             *           после его создания на ходу.
             *
             *
             * Все типы данных в C# это не просто типы, а классы и структуры данных
             */

            int whole_simple_num, something_else; // обьявление
            whole_simple_num = 5;// инициализация
            whole_simple_num = 6; // присвоение значения переменной

            // ввод данных
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // if (!string.IsNullOrEmpty(name))
            //     Console.WriteLine("Hello," + name + "!");
            // else
            //     Console.WriteLine("Doesn't seem like a name, alr I quit.");
            
            
            // 8l приведение типов

            // string str1 = "7.5";
            // string str2 = "7.9";
            // Console.WriteLine(Convert.ToDouble(str1) + Convert.ToDouble(str2));
            // Console.WriteLine(Convert.ToInt32(str1) + Convert.ToInt32(str2));
            

            
            // 9l
            // parse tryparse

            // string str = "5";
            // int a = int.Parse(str); // Parse направлен на строки
            //
            // string str2 = "5.5"; // может придти c запятой "5,5", тогда будет Parse Exception;
            // double a2 = double.Parse(str2);
            //
            // // решение для запятой (второй параметр парс)
            // NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            // {
            //     NumberDecimalSeparator = ",",
            // };      
            //
            // string str3 = "5,5"; 
            // double a3 = double.Parse(str3, numberFormatInfo);
            // // Console.WriteLine(a3);
            //
            //
            // // работа с исключениями 
            //
            // string str4 = "5,5wbegrgeg"; // проебка unhandled exception
            // try
            // {
            //     int a4 = Convert.ToInt32(str4);
            //     Console.WriteLine(a4);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            // }
            //
            // // int a5 = Convert.ToInt32(str4); 
            // Console.WriteLine("Не падает");
            //
            //
            //
            // string s1 = "1"; 
            //
            // int num1;
            //
            // // если ексепшн будет 0 (знач. по умолчанию)
            // bool isCorrect = int.TryParse(s1, out num1);
            // if (isCorrect)
            // {
            //     Console.WriteLine(s1);
            // }
            // else
            // {
            //     Console.WriteLine("");
            // }
            
            // l10
            

        }
    }
}