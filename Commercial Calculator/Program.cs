using System;
using System.Collections.Generic;
using System.Linq;

class Program {

  public static void Main(String[] args){

    List<double> numberList = new();
    string? currentOperator = "+";
    bool isContinue = true;
    double totalResult = 0;
    int idx = 1;
    
    while (isContinue)
    {
      Console.Write($"Enter your input {idx}: ");
      double input = double.Parse(Console.ReadLine());

      Operation(input, currentOperator);

      Console.Write("\nEnter operator: ");
      currentOperator = Console.ReadLine();

      isContinue = checkIfTerminate(currentOperator);

      idx++;
    }

    while (numberList.Count() != 0)
    {
      int numPosition = GetLastIndexPosition();
      totalResult = totalResult + numberList[numPosition];
      RemoveLastIndexList(numPosition);
    }

    Console.Write("Your answer is = ");
    Console.Write(totalResult.ToString("0.00"));


    void Operation(double currentNumber, string currentOperator)
    {
      int numPosition = GetLastIndexPosition();
      switch (currentOperator)
      {
        case "-":
            currentNumber = -1 * currentNumber;
            break;
        case "*":
            currentNumber = currentNumber * numberList[numPosition];
            RemoveLastIndexList(numPosition);
            break;
        case "/":
            currentNumber = numberList[numPosition] / currentNumber;
            RemoveLastIndexList(numPosition);
            break;
      }
      numberList.Add(currentNumber);

    }

    bool checkIfTerminate(string currentOperator)
    {
      if (currentOperator != "+" && currentOperator != "-" && currentOperator != "*" && currentOperator != "/")
        return false;
      
      return true;
    }

    int GetLastIndexPosition()
    {
      return numberList.Count() - 1;  
    }

    void RemoveLastIndexList(int numPosition)
    {
      numberList.RemoveAt(numPosition); 
    }
    
  } 
}
