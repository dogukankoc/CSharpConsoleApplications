using System;
using System.Collections.Generic;
using System.Drawing;

namespace TypeofOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gets System.Type object for a type

            Console.WriteLine(typeof(Program));
            Console.WriteLine(typeof(List<>));
            Console.WriteLine(typeof(IDisposable));
            Console.WriteLine(typeof(Point));
            Console.WriteLine(typeof(Rectangle));
            Console.WriteLine(typeof(DateTime));
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(float));
            Console.WriteLine(typeof(double));
            Console.WriteLine(typeof(decimal)); 
            Console.WriteLine(typeof(string));
            Console.WriteLine(typeof(uint));
            Console.WriteLine(typeof(ulong));
            Console.WriteLine(typeof(long));
            Console.WriteLine(typeof(sbyte));
            Console.WriteLine(typeof(short));
            Console.WriteLine(typeof(ushort));
            Console.WriteLine(typeof(byte));
            Console.WriteLine(typeof(char));
            Console.WriteLine(typeof(bool));
        }
    }
}
