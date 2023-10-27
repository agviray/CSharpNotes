using System;

namespace Operators
{
  class Program 
  {
    static void Main(string[] args)
    {
      int num1 = 123, num2 = 456;
      string str1 = "abc", str2 = "def";

      // ====================================================
      // - About using basic math operators, ie: + - * /
      // ====================================================
      Console.WriteLine("--------------------");
      Console.WriteLine("Basic Math Operators");
      Console.WriteLine("--------------------");
      Console.WriteLine($"num1 + num2 = {num1+num2}");
      Console.WriteLine($"num2 - num1 = {num2-num1}");
      Console.WriteLine($"(num2 * 0) + num1 = {(num2 * 0) + num1}"); // - Expected to print 123.

      // ====================================================
      // - About increment and decrement operators.
      // ====================================================
      Console.WriteLine("---------------------------------");
      Console.WriteLine("Increment and decrement operators");
      Console.WriteLine("---------------------------------");
      int x = 22, y = 33;
      x++;
      y--;
      
      Console.WriteLine($"Declare and initalize x and y as:");
      Console.WriteLine($"int x = 22, y = 33;");
      Console.WriteLine($"Writing x++ gives us: {x}");
      Console.WriteLine($"Writing y-- gives us: {y}");
      
      // - Note that at this point, x = 23 and y = 32
      // - This is due to us incrementing x and decrementing y. See lines 24 and 25.
      // - Writing: x += y is the same as writing: x = x + y;
      Console.WriteLine($"With x incremented by 1, and y decremented 1, their current values are now: x = {x}, and y = {y}");
      Console.WriteLine($"So, if we were to write x += y, we will get a value of: {x += y}"); // - Expected result is 55.

      // ====================================================
      // - About logical operators:  && and ||
      // ====================================================
      int a = 33, b = 22;
      // - && means and
      Console.WriteLine(a > b && b >= 23); // - Expected to print False
      // - || means or
      Console.WriteLine(a > b || b <= 23); // - Expected to print True

      // ====================================================
      // - About the operators:  ?? and ??= 
      // ====================================================
      // - The ?? operator will either output the left-side operand if not null, or the right-side operand if it is null.
      string someStr = null;
      Console.WriteLine(someStr ?? "Unknown String"); // - Expected to print "Unknown String" because someStr has value of null.
      // - The ??= operator will assign the right-side operand if the left-side one is null.
      // - This operator replaces the code:
      //    if (variable is null) {
      //      variable = someValue
      //    }
      someStr ??= "New String"; // - Expected to print "New String" because someStr has value of null.
      Console.WriteLine(someStr);
    }
  }
}