using System;

class Program {
  public static void Main (string[] args) {

    //Check If the Array Contain Consecutive Elements of 1,2,3

    int[] array1 = { 1, 1, 2, 3, 1 };
    int[] array2 = { 1, 1, 2, 4, 1 };
    int[] array3 = { 1, 1, 2, 1, 2, 3 };
    
    static bool test(int[] arrayName)
    {

      for (int i = 0; i < arrayName.Length - 2; i++)
      {
        if (arrayName[i] == 1 && arrayName[i + 1] == 2 && arrayName[i + 2] == 3)
            return true;
      }
      return false;
    }

    Console.WriteLine(test(array1));
    Console.WriteLine(test(array2));
    Console.WriteLine(test(array3));

  }
}

// Output: 
// True
// False
// True

