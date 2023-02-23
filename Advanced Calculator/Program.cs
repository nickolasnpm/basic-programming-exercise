using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    
    string[] arr;
    int startIndex = 0;
    
    System.Console.Write("String input: ");
    arr = Console.ReadLine().Split(" ");
    
    System.Console.Write("Answer = ");
    System.Console.Write(Handler().ToString("#.##"));
    
    double Handler()
    {
      Stack<double> stack = new Stack<double>();
      string currentOperator = "+";
      double totalResult = 0;
      while (startIndex < arr.Length)
      {
        if (double.TryParse(arr[startIndex], out _))
        {
          double currentNumber = double.Parse(arr[startIndex]);
          StackOperation(stack, currentNumber, currentOperator);
        }
        else if (arr[startIndex].Equals("("))
        {
          startIndex++;

          double curNum = Handler();
          StackOperation(stack, curNum, currentOperator);
        }
        else if (arr[startIndex].Equals(")"))
        {
          break;
        }
        else
        {
          currentOperator = arr[startIndex];
        }
          
        startIndex++;
      }
      while (!stack.Count.Equals(0))
      {
        totalResult += stack.Pop();
      }
    return totalResult;
    }
    
    void StackOperation(Stack<double> stack, double currentNumber, string currentOperator)
    {
      switch (currentOperator)
      {
        case "-":
          currentNumber *= -1;
          break;
        case "*":
          currentNumber *= stack.Pop();
          break;
        case "/":
          currentNumber = stack.Pop() / currentNumber;
          break;
      }
    stack.Push(currentNumber);
    }
  }
}

// input = 2 + ( 3 * ( 3 * ( 1 + ( 2 / 2 ) ) / ( 4 - 2 ) + ( 8 / 2 ) ) + 7 ) - 6
// output = 24
