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

      // - The line below will return an error because "hi" is of type, string.
      // Console.WriteLine(arrOfVals1[0] = "hi");
      
      // - The line below will also return an error because index 5 is outside the bounds of the arrOfVals1 array.
      // Console.WriteLine(arrOfVals1[5] = 5);

      object obj = null;
      // - Attempting to log obj in the console with Console.Write(obj)
      //   will return nothing, because null means "no value".
    }
  }
}