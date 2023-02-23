using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    List<string> converted = new List<string>() { };
List<string> original = new List<string>() { };

string str= "ora-gmm-vro-!bi-n h-ktn-as - dt-aoe-md - t -typ- sI- ec-e. - ue-oa - l -lts- sf-mea-tda-ti -oia-aau-stg-ees-es -tno- hf-rha-Cge-cne--ta-tnr-lau-ey -oeo-s";
    
int orderNumber = 13;

Char toCheck;
string convertToOriginal, replaceHere;
int i, j, idx, amx = 0;

idx = 1;

for (i = 0; i < str.Length; i++)
{
    toCheck = str[i];

    if (idx % 4 != 0)
    {
        converted.Add(Convert.ToString(toCheck));
    }

    idx++;
}

for (i = 0; i < converted.Count; i++)
{
    original.Add("toReplace");
}

idx = 1;

while (amx < original.Count)
{
    for (j = 0; j < original.Count; j++)
    {
        replaceHere = original[j];

        if (original[j] != "toReplace")
        {
            idx = idx - 1;
        }

        if (idx == orderNumber)
        {

            convertToOriginal = converted[amx];
            amx++;

            original.RemoveAt(j);
            original.Insert(j, convertToOriginal);

            idx = 0;
        }

        idx++;

    }

}

Console.Write($"\nThe cyclic sort of \n\n{str} \n\nis: \n\n");

for (i = 0; i < original.Count; i++)
{
    Console.Write($"{original[i]}");
}

Console.WriteLine("");
  }
}

// Output:
// The cyclic sort of 
// ora-gmm-vro-!bi-n h-ktn-as - dt-aoe-md - t -typ- sI- ec-e. - ue-oa - l -lts- sf-mea-tda-ti -oia-aau-stg-ees-es -tno- hf-rha-Cge-cne--ta-tnr-lau-ey -oeo-s 
// is: 
// Congratulations!-If you are able to read this message means you managed to complete the advance task for this test.
