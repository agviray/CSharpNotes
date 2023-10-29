using System;

namespace FunctionsReturnMultiValuesTuples {
  class Program {
    // ========================================================
    // Using tuples to return multiple values from a function 
    // ========================================================

    // **********************************************************
    // *** IMPORTANT - READ THIS FIRST ***
    // - Tuples are grouped values added in C# 7
    // - Note that tuple usage is the preferred way to return
    //   multiple values from a function.
    // **********************************************************
    // =============================
    // About Tuples - General Info
    // =============================
    // 1) Tuples are grouped values.
    // 2) You can use tuples to return multiple values from a function.
    // 3) Tuples are mutable, meaning you can modify them after they
    //    are created/initialized.
    static void Main(string[] args) {
      // ========================
      // Initializing Tuples
      // ========================
      // ------------
      // - Example 1
      // ------------
      // - When we initialize a tuple this way, we are also assigning names 
      //   to the its values.
      // - This means we can access a given value via dot notation like so:
      //  - Console.WriteLine(tuple1.website); will print "www.allanviray.com",
      //    and so on.
      var tuple1 = (firstName: "Allan", lastName: "Viray", website: "www.allanviray.com");

      // ------------
      // - Example 2
      // ------------
      // - Similar to the tuple1 example.
      (int year, string month) tuple2 = (2023, "October");
      
      // ------------
      // - Example 3
      // ------------
      // - If we don't specify names for the values, C# will automatically specify
      //   default names for us.
      var groceryTuple = ("water", "chicken", "broccoli");

      // Tuple values are mutable

      // - Access the values contained in a tuple by referencing their names via
      //   dot notation.
      Console.WriteLine();
      Console.WriteLine("------------------- Contents of tuple1 -------------------");
      Console.WriteLine(tuple1.firstName);
      Console.WriteLine(tuple1.lastName);
      Console.WriteLine(tuple1.website);
      Console.WriteLine();
      Console.WriteLine("------------------- Contents of tuple2 -------------------");
      Console.WriteLine(tuple2.year);
      Console.WriteLine(tuple2.month);
      Console.WriteLine();
      Console.WriteLine("------------------- Contents of groceryTuple -------------------");
      // - We did not specify names for tuple3, but C# still does if for us, automatically.
      // - C# will auto-assign names: Item1, Item2 etc, if we did not do it ourselves.
      Console.WriteLine(groceryTuple.Item1);
      Console.WriteLine(groceryTuple.Item2);
      Console.WriteLine(groceryTuple.Item3);
      Console.WriteLine();
    }
  }
}