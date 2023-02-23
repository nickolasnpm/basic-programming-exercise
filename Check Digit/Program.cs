using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    // to calculate the Check Digit

    string toCheck = "726358263582647";
    int[] arrayNumber = toCheck.Select(element => element - '0').ToArray();
    
    int[] totalMultiplyArray1 = new int[] { };
    int[] totalMultiplyArray2 = new int[] { };
    int[] totalMultiplyArray3 = new int[] { };
    int[] totalMultiplyArray4 = new int[] { };
    int[] totalMultiplyArray5 = new int[] { };

    int[] totalMultiplyArrayTotal = new int[] {};
    
    int toMultiply1 = 0, toMultiply2 = 0, toMultiply3 = 0, toMultiply4 = 0, toMultiply5 = 0;
    int  makeIt5Digit, totalMultiply1, totalMultiply2, totalMultiply3, totalMultiply4, totalMultiply5, numberToAdd;
    int totalNumberAdded1 = 0, totalNumberAdded2 = 0, totalNumberAdded3 = 0, totalNumberAdded4 = 0, totalNumberAdded5 = 0, totalNumberAddedSum = 0, totalSeparateSumDigit = 0;

    while (arrayNumber.Count() % 5 != 0)
    {
      makeIt5Digit = 0;
      arrayNumber = arrayNumber.Append(makeIt5Digit).ToArray();
    }

    for (int i = 0; i < arrayNumber.Count(); i = i+5)
    
    {
      toMultiply1 = arrayNumber[i];
      toMultiply2 = arrayNumber[i + 1];
      toMultiply3 = arrayNumber[i + 2];
      toMultiply4 = arrayNumber[i + 3];
      toMultiply5 = arrayNumber[i + 4];

      totalMultiplyArray1 = totalMultiplyArray1.Append(totalMultiply1 = toMultiply1 * 10).ToArray();
      totalMultiplyArray2 = totalMultiplyArray2.Append(totalMultiply2 = toMultiply2 * 8).ToArray();
      totalMultiplyArray3 = totalMultiplyArray3.Append(totalMultiply3 = toMultiply3 * 6).ToArray();
      totalMultiplyArray4 = totalMultiplyArray4.Append(totalMultiply4 = toMultiply4 * 4).ToArray();
      totalMultiplyArray5 = totalMultiplyArray5.Append(totalMultiply5 = toMultiply5 * 2).ToArray();

      Console.WriteLine($"{toMultiply1} => {toMultiply1} * 10 = {totalMultiply1} (A)");
      Console.WriteLine($"{toMultiply2} => {toMultiply2} * 8 = {totalMultiply2} (B)");
      Console.WriteLine($"{toMultiply3} => {toMultiply3} * 6 = {totalMultiply3} (C)");
      Console.WriteLine($"{toMultiply4} => {toMultiply4} * 4 = {totalMultiply4} (D)");
      Console.WriteLine($"{toMultiply5} => {toMultiply5} * 2 = {totalMultiply5} (E)\n");
    }

    //A
    Char operatorOrder = ' ';
    Console.Write($"A =");
    for (int i = 0; i < totalMultiplyArray1.Count(); i++)
    {
      numberToAdd = totalMultiplyArray1[i];
      totalNumberAdded1 += numberToAdd;
      Console.Write($"{operatorOrder} {numberToAdd} ");

      operatorOrder = '+';
    }
    totalMultiplyArrayTotal = totalMultiplyArrayTotal.Append(totalNumberAdded1).ToArray();
    Console.Write($"= {totalNumberAdded1}\n");

    //B
    operatorOrder = ' ';
    Console.Write($"B =");
    for (int i = 0; i < totalMultiplyArray2.Count(); i++)
    {
      numberToAdd = totalMultiplyArray2[i];
      totalNumberAdded2 += numberToAdd;
      Console.Write($"{operatorOrder} {numberToAdd} ");

      operatorOrder = '+';
    }
    totalMultiplyArrayTotal = totalMultiplyArrayTotal.Append(totalNumberAdded2).ToArray();
    Console.Write($"= {totalNumberAdded2}\n");

    //C
    operatorOrder = ' ';
    Console.Write($"C =");
    for (int i = 0; i < totalMultiplyArray3.Count(); i++)
    {
      numberToAdd = totalMultiplyArray3[i];
      totalNumberAdded3 += numberToAdd;
      Console.Write($"{operatorOrder} {numberToAdd} ");

      operatorOrder = '+';
    }
    totalMultiplyArrayTotal = totalMultiplyArrayTotal.Append(totalNumberAdded3).ToArray();
    Console.Write($"= {totalNumberAdded3}\n");

    //D
    operatorOrder = ' ';
    Console.Write($"D =");
    for (int i = 0; i < totalMultiplyArray4.Count(); i++)
    {
      numberToAdd = totalMultiplyArray4[i];
      totalNumberAdded4 += numberToAdd;
      Console.Write($"{operatorOrder} {numberToAdd} ");

      operatorOrder = '+';
    }
    totalMultiplyArrayTotal = totalMultiplyArrayTotal.Append(totalNumberAdded4).ToArray();
    Console.Write($"= {totalNumberAdded4}\n");

    //E
    operatorOrder = ' ';
    Console.Write($"E =");
    for (int i = 0; i < totalMultiplyArray5.Count(); i++)
    {
      numberToAdd = totalMultiplyArray5[i];
      totalNumberAdded5 += numberToAdd;
      Console.Write($"{operatorOrder} {numberToAdd} ");

      operatorOrder = '+';
    }
    totalMultiplyArrayTotal = totalMultiplyArrayTotal.Append(totalNumberAdded5).ToArray();
    Console.Write($"= {totalNumberAdded5}\n\n");

    //Total
    operatorOrder = ' ';
    Console.Write($"S =");
    for (int i = 0; i < totalMultiplyArrayTotal.Count(); i++)
    {
      numberToAdd = totalMultiplyArrayTotal[i];
      totalNumberAddedSum += numberToAdd;
      Console.Write($"{operatorOrder} {numberToAdd} ");

      operatorOrder = '+';
    }
    Console.Write($"= {totalNumberAddedSum}\n\n");

    int[] separateSumDigit = totalNumberAddedSum.ToString().Select(element1 => Convert.ToInt32(element1) - 48).ToArray();

    totalSeparateSumDigit = totalNumberAddedSum;
    
    while (totalSeparateSumDigit > 9)
    {
      operatorOrder = ' ';
      Console.Write($"{totalSeparateSumDigit} =");
      totalSeparateSumDigit = 0;
      for (int i = 0; i <separateSumDigit.Count(); i++)
      {
        numberToAdd = separateSumDigit[i];
        totalSeparateSumDigit +=  numberToAdd;
        Console.Write($"{operatorOrder} {numberToAdd} ");
        
        operatorOrder = '+';
      }
    Array.Clear(separateSumDigit, 0, separateSumDigit.Length);
    Console.Write($"= {totalSeparateSumDigit}\n\n");

    separateSumDigit = totalSeparateSumDigit.ToString().Select(element1 => Convert.ToInt32(element1) - 48).ToArray();
    
    }

    Console.WriteLine($"The Check Digit ofis {totalSeparateSumDigit}\n");

    Console.WriteLine($"The generated reference number is {toCheck}");
  }
} 

// Output
// The Check Digit ofis 1
// The generated reference number is 726358263582647