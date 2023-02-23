using System;

class Program {

  int firstNumberSelected, secondNumberSelected, newNumberAmount;
  char? firstOperatorSelected, secondOperatorSelected;

  public static bool isContinue = true;
  
  public static void Main (string[] args) 
  {

    Console.WriteLine("My Calculator");
    
    Program repeat = new Program();
    repeat.calculationSteps();
    
  }

  public void calculationSteps()
  {
    
    while (isContinue)
    {
      {

        firstNewNumber();

        secondNewNumber();

      }
      calculationContinuity();
    }
    Console.WriteLine($"\n==>> Your final answer is {newNumberAmount} <<==");
  }
  
  public void calculatingOperations ()
  {
    
    switch(firstOperatorSelected)
    {
    case '+':
      newNumberAmount = additionOperations(firstNumberSelected, secondNumberSelected);
      break;
      
    case '-':
      newNumberAmount = substractionOperations(firstNumberSelected, secondNumberSelected);
      break;
      
    case '*':
      newNumberAmount = multiplyOperations(firstNumberSelected, secondNumberSelected);
      break;
      
    case '/':
      newNumberAmount = divisionOperations(firstNumberSelected, secondNumberSelected);
      break;
    }

    Console.WriteLine ($"\n==> Your immediate answer is {newNumberAmount}");
    
  }

  public void calculationContinuity ()
  {
    switch (secondOperatorSelected)
    {
    case '+':
    case '-':
    case '*':
    case '/':
    isContinue = true;
    break;
      
    case '=':
    isContinue = false;
    break;
      
    default:
    isContinue = false;
    break;  
    }
    
  }

  public void firstNewNumber ()
  {
    if (secondNumberSelected == 0 && newNumberAmount == 0)
    {
      Console.Write ("Please enter your number ");
      firstNumberSelected = int.Parse(Console.ReadLine());

      Console.Write ("Please enter your operator: ");
      firstOperatorSelected = Convert.ToChar(Console.ReadLine());
    }
    else
    {  
      firstNumberSelected = newNumberAmount;
      firstOperatorSelected = secondOperatorSelected;
    }
  }

  public void secondNewNumber ()
  {
    Console.Write ("Please enter your number ");
    secondNumberSelected = int.Parse(Console.ReadLine());

    calculatingOperations();

    Console.Write ("Please enter your operator: ");
    secondOperatorSelected = Convert.ToChar(Console.ReadLine());
  }

  public int additionOperations (int firstNumber, int secondNumber)
  {
    return firstNumber + secondNumber;
  }

  public int substractionOperations (int firstNumber, int secondNumber)
  {
    return firstNumber - secondNumber;
  }

  public int multiplyOperations (int firstNumber, int secondNumber)
  {
    return firstNumber * secondNumber;
  }

  public int divisionOperations (int firstNumber, int secondNumber)
  {
    return firstNumber / secondNumber;
  }
  
}
