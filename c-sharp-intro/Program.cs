using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // this is a comment
        /*
         * this is a multiline comment
         */
        /// -- this a an xml documentation comment

        // variable declaration -- camelCase is defualt
        // type varaibleNameCamelCase = assignment;
        int age = 36;
        const string name = "Weston Bailey";
        Console.WriteLine($"name: {name}, age {age}");
        // circle back to ToString method for output

        /*
         * types
         * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types
         * https://www.w3schools.com/cs/cs_data_types.php
         * VALUE TYPES -- stored directly in the stack
         * value types can be copied using the assignemnt operator
         * REFERNCE TYPES -- stored on the heap as a reference to the memory address
         * copied refernce types create another reference to the object at the same memory address
         */

        // Value types
        int myNum = 5;
        long myLong = 100L;
        double myDouble = 2.71828D;
        float myFloat = 3.14F;
        // chars use single quotes
        char myLetter = 'H';
        bool myBool = false;
        // strings use double quotes 
        string myText = "Hello!";
        Console.WriteLine($"myNum: {myNum}, myLong: {myLong}, myDouble: {myDouble}, myFloat: {myFloat}, myLetter: {myLetter}, myBool: {myBool}, myText: {myText}");

        // Type Casting Value types
        // implicit casting to larger types
        // char -> int -> long -> float -> double
        char myChar = 'W';
        double implicitCastDouble = myChar;
        Console.WriteLine($"Implicit Cast Double {implicitCastDouble}");
        // explicit casting from larger types/smaller types
        // double -> float -> long -> int -> char
        double doubleToCast = 87D;
        char explicitCastChar = (char)doubleToCast;
        Console.WriteLine($"explicitCastChar {explicitCastChar}");
        // does it work the other way?
        char castLargerChar = 'B';
        double explicitLargerDouble = (double)castLargerChar;
        Console.WriteLine($"explicitLargerDouble {explicitLargerDouble}");
        // language builtins for type casting using Convert.Type()
        // Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int), Convert.ToInt64 (long)
        char convertedChar = Convert.ToChar(111L);
        Console.WriteLine(convertedChar);
    }
}