using System;

namespace FunctionRefAndOutParams {
  class Program {
    // ====================================================
    // - About the "ref" keyword used with params
    // ====================================================
    // - Ordinary value arguments can't be modified by the function.
    //  - This is because they are just a COPY of the original value.
    static void FunctionA(int arg1) {
      arg1 += 10;
      Console.WriteLine($"{arg1}");
    }

    // - When you pass arguments to a function by reference (using the "ref" keyword in the params), 
    //   those arguments can be modified by the function and then reflected back to the caller.
    // - Note that the ref keyword must also be used before the argument in the function call as well. 
    static void FunctionB(ref int arg1) {
      arg1+= 10;
      Console.WriteLine($"{arg1}");
    }

    // ====================================================
    // - About the "out" keyword
    // ====================================================
    // **********************************************************
    // - *** IMPORTANT - READ THIS FIRST ***
    //  - Note that using the "out" keyword is not the preferred 
    //    way to return multiple values from a function.
    //  - The preferred way to do this is by using tuples.
    // **********************************************************
    // - You can return multiple values from a function using the
    //   "out" keyword.
    // - Functions that use the "out" keyword with a param means 2 things:
    //    1) The associated param returns a value.
    //    2) The associated param is not used to supply data to the function.
    // - Note that the out keyword must also be stated in the function call.
    static void PrintUserBirthDate(string name, string month, int date, out string birthMonth, out int birthDate) {
      birthMonth = month;
      birthDate = date;
      Console.WriteLine($"Hello there, {name}. Your birth date is: ");
    }

    static void Main(string[] args) {
      int valForFuncA = 20;
      int valForFuncB = 30;
      string name = "Allan";
      string month = "October";
      int date = 21;
      string yourBirthMonth; 
      int yourBirthDate;

      // ------------------
      // Calling functions
      // ------------------
      // - FunctionA will log 30 as expected.
      // - However, the value of valForFuncA did not change. It still has
      //   the original value of 20.
      Console.WriteLine("-------------------------------");
      Console.WriteLine("-------Testing FunctionA-------");
      Console.WriteLine("-------------------------------");
      Console.WriteLine($"FunctionA logs: ");
      FunctionA(valForFuncA);
      Console.WriteLine($"However, the value of valForFuncA is still the original value of: {valForFuncA}. valForFuncA did not change.");
      Console.WriteLine("-------------------------------");
      Console.WriteLine("-------Testing FunctionB-------");
      Console.WriteLine("-------------------------------");
      Console.WriteLine($"FunctionB logs: ");
      // - The "ref" keyword must be used in the function call.
      FunctionB(ref valForFuncB);
      Console.WriteLine($"And the value of the original variable, valForFuncB, is also changed to: {valForFuncB}");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("-------Testing PrintUserBirthDate-------");
      Console.WriteLine("----------------------------------------");
      // - The "out" keyword must be used in the function call.
      PrintUserBirthDate(name, month, date, out yourBirthMonth, out yourBirthDate);
      Console.WriteLine($"{yourBirthMonth} {yourBirthDate}");
    }
  }
}