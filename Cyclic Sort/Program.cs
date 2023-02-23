using System;
using System.Linq;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    ﻿
    List<string> stringArray1 = new List<string>() { };
    List<string> stringArray2 = new List<string>() { };

string numberAlphabet;

Char convertToArray;
int i, placeToInsert, idx = 1, flag = 0, amx = 1;

bool isContinue = true;
      
string str = "1JD7H47FH2KD9G4";
int numberOrder = 13;

for (int j = 0; j < str.Count(); j++)
{
    convertToArray = str[j];
    stringArray1.Add(Convert.ToString(convertToArray));

}

while (isContinue)
{

    for (i = 0; i < stringArray1.Count; i++)
    {
        numberAlphabet = stringArray1[i];

        if (idx == numberOrder)
        {

            if (i == stringArray1.Count() - 1)
            {
                idx = 0;
            }
            else
            {
                idx = 1;
            }

            if (stringArray2.Count < str.Length)
            {
                stringArray2.Add(numberAlphabet);
                stringArray1.RemoveAt(i);
            }

        }

        if (stringArray1.Count < 1)
        {
            flag = 1;
            break;
        }

        idx++;
    }

    if (flag == 1)
    {
        isContinue = false;
    }

}

Console.Write($"\nThe cyclic sort of {str} (With Number Order = {numberOrder}) is: ");

for (i = 0; i < stringArray2.Count; i++)
{
    Console.Write($"{stringArray2[i]}");

    amx++;

    if (amx % 4 == 0)
    {
        placeToInsert = i + 1;
        stringArray2.Insert(placeToInsert, "-");
    }
}
Console.WriteLine("");

  }
}

// Output: 
// The cyclic sort of 1JD7H47FH2KD9G4 (With Number Order = 13) is: 9K2-D4D-7JG-14F-H7H-