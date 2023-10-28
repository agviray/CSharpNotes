// - Using top-level statements feature to simplify the program.
// - This feature eliminates the need for writing the 
//   namespace, class, and Main method entry points.
using System;
// ====================================================
// - Default Parameter Values for Functions
// ====================================================

// -------------------------------------
// Setting default params in a function
// -------------------------------------
// - Functions can have default parameter values.
// - In this example, if we just provided the name, the function
//   would run without errors. 
//    - This is because there is a default value set for the 
//      count parameter.
//    - Of course, we can also provide a value for the count parameter,
//      and the function would run accordingly.
// --------------
// Examples
// --------------
void PrintQueueCount(string name, int count=0 ) {
  Console.WriteLine($"Thanks for contacting us, {name}. There are total of {count} people in front of you.");
}

// -------------------------------------------
// Calling a function with their named params 
// -------------------------------------------
// - You can also call functions with their named functions.
//    - The benefit of doing this is that you can call the function without 
//      having to worry about adding the arguments in the same order as the
//      the function's parameters.
// --------------
// Examples
// --------------
void PrintGroceryList(int waterCount, int softDrinkCount, int sirloinCount, int chickenBreastCount) {
  Console.WriteLine("******** Drinks ********");
  Console.WriteLine($"Package of water x{waterCount}");
  Console.WriteLine($"Pack of coke ({softDrinkCount} count)");
  Console.WriteLine("********* Food *********");
  Console.WriteLine($"Sirloin steak x{sirloinCount}");
  Console.WriteLine($"Chicken breast x{chickenBreastCount}");
}

// ------------------
// Calling functions
// ------------------
// - Test with default parameters.
Console.WriteLine("---------------------------------------------");
Console.WriteLine("-------Testing with default parameters-------");
Console.WriteLine("---------------------------------------------");
Console.WriteLine();
PrintQueueCount("Allan");
PrintQueueCount("Allan", 11);
Console.WriteLine();
Console.WriteLine("---------------------------------------------");
Console.WriteLine("--------Testing with named parameters--------");
Console.WriteLine("---------------------------------------------");
PrintGroceryList(chickenBreastCount: 4, waterCount: 1, sirloinCount: 2, softDrinkCount:6);
// - Test with calling functions with named parameters.

