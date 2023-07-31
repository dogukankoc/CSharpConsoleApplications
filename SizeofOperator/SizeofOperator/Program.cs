using System;
namespace SizeofOperator
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //sizeof operator: Returns an int holding the size of a type* in bytes.

            Console.WriteLine($"Bool: {sizeof(bool)}");
            Console.WriteLine($"Byte: {sizeof(byte)}");
            Console.WriteLine($"Signed Byte: {sizeof(sbyte)}");
            Console.WriteLine($"Char: {sizeof(char)}");
            Console.WriteLine($"Short: {sizeof(short)}");
            Console.WriteLine($"Unsigned Short: {sizeof(ushort)}");
            Console.WriteLine($"Int: {sizeof(int)}");
            Console.WriteLine($"Unsigned Int: {sizeof(uint)}");
            Console.WriteLine($"Float: {sizeof(float)}");
            Console.WriteLine($"Long: {sizeof(long)}");
            Console.WriteLine($"Unsigned Long: {sizeof(ulong)}");
            Console.WriteLine($"Double: {sizeof(double)}");
            Console.WriteLine($"Decimal: {sizeof(decimal)}");
        }
    }
}
