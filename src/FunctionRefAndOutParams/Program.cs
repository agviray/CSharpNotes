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

    // - When you pass arguments to a function by reference, those 
    //   arguments can be modified by the function and then reflected
    //   back to the caller.
    static void FunctionB(ref int arg1) {
      arg1+= 10;
      Console.WriteLine($"{arg1}");
    }
    static void Main(string[] args) {
      int valForFuncA = 20;
      int valForFuncB = 30;

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
      FunctionB(ref valForFuncB);
      Console.WriteLine($"And the value of the original variable, valForFuncB, is also changed to: {valForFuncB}");
    }
  }
}