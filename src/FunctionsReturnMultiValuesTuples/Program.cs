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
      // - The auto-assigned names are: Item1, Item2, etc.
      var groceryTuple = ("water", "chicken", "broccoli");
      // - Given the groceryTuple above, if we write something like:
      //   Console.WriteLine(groceryTuple.Item1);
      //   The value of "water" will be printed to the console.
      // ==========================
      // Tuple values are mutable
      // ==========================
      // ------------
      // - Example
      // ------------
      // - Modify tuple values using dot notation.
      (string fruit01, string fruit02, string fruit03) fruitsTuple = ("apples","bananas","strawberries"); 
      fruitsTuple.fruit01 = "grapes";
      fruitsTuple.fruit03 = "watermelon";
      var veggiesTuple = ("spinach", "carrots");
      veggiesTuple.Item2 = "broccoli";

      // ======================================
      // Returning multiple values with tuples
      // ======================================
      // - Functions can work with tuples.
      // - For example, we can use tuples with functions to have said function 
      //   return multiple values.
      // ------------
      // - Example
      // ------------
      // - Here, we are using the AddAndMultply function to initialize
      //   the results tuple.
      (int, int) results = AddAndMultiply(2, 3);

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
      Console.WriteLine("------------------- Contents of fruitsTuple -------------------");
      // - fruitsTuple was modified.
      Console.WriteLine(fruitsTuple);
      Console.WriteLine();
      Console.WriteLine("------------------- Contents of veggiesTuple -------------------");
      // - veggiesTuple was modified.
      Console.WriteLine(veggiesTuple);
      Console.WriteLine();
      Console.WriteLine("------------------- Contents of results -------------------");
      // - The results tuple was initialized using the AddAndMultiply function.
      Console.WriteLine(results);
      Console.WriteLine(results.Item1);
      Console.WriteLine(results.Item2);
    }
    // - Functions can return multiple values using tuples.
    static (int, int) AddAndMultiply(int x, int y) {
      return (x + y, x * y);
    }
  }
}