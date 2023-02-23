using System;
using System.Linq;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    List<string> original = new List<string> { "abcde", "abc", "a" };
    
    string toSeparate, newWord = "";
    
    for (int i = 0; i < original.Count(); i++)
    {
      toSeparate = original[i];
      
      for (int j = 0; j < toSeparate.Length; j++)
      {
        newWord += toSeparate[j].ToString();
        Console.Write($"{newWord}");
      }
      Console.WriteLine("\n");
      newWord = "";
    }
  }
}

//output: 
//  aababcabcdabcde
//  aababc
//  a
