using System;

namespace VariablesAndDataTypes
{
  class Program
  {
    static void Main(string[] args)
    {
      // - Declare and initialize some basic value type variables.
      bool b = true;
      char a = 'a';
      string str = "I'm a string!";
      int i = 10;
      float f = 2.0f;
      decimal d = 10.0m;

      // - Declare and initialize implicit variables.
      var x = 7;
      var y = "I'm a value.";

      // - Declare and initialize array of values.
      int[] arrOfInt = new int[5]; // - Array expecting to contain five integer values.
      string[] arrOfStrs = {"hello", "there", "user"}; // - Array of strings.
      int[] numsArr = {213, 21, 354, 6};
      // - The lines below will print each array value 
      // Array.ForEach(arrOfStrs, Console.WriteLine);
      // Array.ForEach(numsArr, Console.WriteLine);

      // - The line below will print an error because "hi" is of type, string.
      // Console.WriteLine(arrOfVals1[0] = "hi");
      
      // - The line below will also print an error because index 5 is outside the bounds of the arrOfVals1 array.
      // Console.WriteLine(arrOfVals1[5] = 5);

      object obj = null;
      // - Attempting to log obj in the console with Console.Write(obj)
      //   will print nothing, because null means "no value".

      // - Print values to console using a formatting string.
      // - 
      string name = "Allan";
      // - Prints: Hello, Allan!
      Console.WriteLine("{0}, {1}!", "Hello", name); // - Prints: Hello, Allan!

      // - Implicit conversion between types.
      int intNum = 10;
      long biggerNumber;
      biggerNumber = intNum;
      // Console.WriteLine(biggerNumber);

      // - Explicit coversion between types.
      float number_to_float = (float)intNum;
      Console.WriteLine("{0}", number_to_float);

      float fNum = 35.1f;
      int float_to_int = (int)fNum;
      Console.WriteLine("{0}", float_to_int);
    }
  }
}