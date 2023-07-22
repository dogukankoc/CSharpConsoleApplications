using System;
using System.Reflection;
//I wanted to show  the default values ​​of the Value and Reference Types

namespace DefaultKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNumber = default;
            Console.WriteLine($"Integer default value = {intNumber}\n");

            //Value Data Types
            Console.WriteLine($"byte: {default(byte)}");
            Console.WriteLine($"int: {default(int)}");
            Console.WriteLine($"short: {default(short)}");
            Console.WriteLine($"long: {default(long)}");
            Console.WriteLine($"float: {default(float)}");
            Console.WriteLine($"double: {default(double)}");
            Console.WriteLine($"decimal {default(decimal)}");
            Console.WriteLine($"bool: {default(bool)}"); //false
            Console.WriteLine($"char: {default(char)}"); // \u0000 => char default value is a null character
            Console.WriteLine("char: \u0000"); // Char default value 
            Console.WriteLine($"enum: {default(A)}"); // default E(0) = 0
            Console.WriteLine($"enum: {default(B)}"); // E(0) = Example

            //Reference Data Types
            Console.WriteLine($"\nstring: {default(string)}"); //null
            Console.WriteLine($"object: {default(object)}"); //null
            Console.WriteLine($"dynamic: {default(dynamic)}"); //null
            Console.WriteLine($"array: {default(Array)}"); //null
            Console.WriteLine($"Delegate: {default(Delegate)}"); //null
            Console.WriteLine($"Pointer: {default(Pointer)}\n"); //null

            if (default(char) == null)
            {
                Console.WriteLine("Char type is null"); //Unreachable code
            }
            else
            {
                Console.WriteLine("Char type is not null");
            }

            if (default(string) == null)
            {
                Console.WriteLine("String type is null");
            }
            else
            {
                Console.WriteLine("String type is not null"); //Unreachable code
            }

            if (default(object) == null)
            {
                Console.WriteLine("Object type is null");
            }

            if (default(dynamic) == null)
            {
                Console.WriteLine("Dynamic type is null");
            }

            if (default(Array) == null)
            {
                Console.WriteLine("Array type is null");
            }
            if (default(Delegate) == null)
            {
                Console.WriteLine("Delegate type is null");
            }

            if (default(Pointer) == null)
            {
                Console.WriteLine("Pointer type is null");
            }

            if (default(Enum) == null)
            {
                Console.WriteLine("Enum type is null");
            }
        }
        enum A
        {
            Foo = 1, Bar = 2, Baz = 3, Quux = 4
        }
        enum B
        {
            Foo = 1, Bar = 2, Baz = 3, Quux = 4, Example = 0
        }
    }
}
