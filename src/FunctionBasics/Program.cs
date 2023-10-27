// - Using top-level statements feature to simplify the program.
// - This feature eliminates the need for writing the 
//   namespace, class, and Main method entry points.
using System;

// ====================================================
// - Function Basics in C#
// ====================================================
// - Functions are used to group re-usable code in a single 
//   unit that can be customized with parameters.

// - General form of a function definition:
/*

return_type function_name(optional parameter list) {
  body of function goes here
}

--------------
return_type
--------------
- Functions may/may not return a value. The return_type refers to 
  the data type of the value that the function returns.
- If the function does not return anything, then the return_type 
  is void
--------------
function_name
--------------
- The function_name refers to the actual name of the function.
// -------------------------
// optional parameter list
// -------------------------
// - If there are paramters defined in the function, they must have
//   an an identified type.

*/

// --------------
// Examples
// --------------
// - This is a function that adds two whole numbers, then returns the result.
int a = 1, b = 2;
int AddWholeNums(int x, int y) {
  // int result = x + y;
  return x + y;
}

// - This is a function that just prints a greeting in the console.
string name = "Allan";
void GreetUser(string userName) {
  Console.WriteLine($"Hello there, {userName}!");
}

Console.WriteLine($"{AddWholeNums(a, b)}");
GreetUser(name);