using System;

class Program {

  string a = " PEPSI", b = " COKE", c = " 100 PLUS", d = " RED BULL";
  string? drinkChoosen, firstDrink,secondDrink, yesno;
  
  public static void Main (string[] args) 
  {

    Program repeat = new Program();

    Console.WriteLine ("\nWelcome to my Vending Machine\n\nWhat do you like to buy?");

    repeat.itemSelection();

  }

  public void itemSelection ()
  {

    availableDrink();
    firstDrink = drinkChoosen;
    
    switch(firstDrink?.ToLower())
    {
    
    case "pepsi":
    case "coke":
    case "100 plus":
    case "red bull":
      addedToCart(firstDrink);
      moreSelection(); //go to second selection
      break;

    default:
      noSuchItem();
      break;
    } // item 1 switch
      
  }

  public void moreSelection()
  {
    
    Console.Write("\nDo you want another drink? YES or NO? ");
    yesno = Console.ReadLine();

    switch (yesno?.ToLower())
    {
    case "yes":

      availableDrink();
      secondDrink = drinkChoosen;

      switch(secondDrink?.ToLower())
    {
    
    case "pepsi":
    case "coke":
    case "100 plus":
    case "red bull":
      addedToCart(secondDrink);
      payTwoDrink(); // proceed to payment for two drink
      break;

    default:
      noSuchItem();
      break;
    } //item 2 switch
      
      break;

    case "no":

      payOneDrink();
      break;

    default:
      Console.WriteLine("\nYou enter the wrong input. Try again");
      break;
    } //yes no switch
    
  }

  public void availableDrink()
  {

    Console.Write($"\nThis is our available drinks\n\n\t{a} \n\n\t{b} \n\n\t{c} \n\n\t{d}\n\nYour choice is: ");
    drinkChoosen = Console.ReadLine();
    
  }

  public void noSuchItem()
  {
    Console.WriteLine ("\nThere is no such item. Try again");
    itemSelection();
  }

  public void addedToCart(string drinkselected)
  {
    Console.WriteLine($"\n{drinkselected.ToUpper()} is added to the cart");
    
  }

  public void payAtCounter()
  {
    Console.WriteLine ("\nPlease pay at the counter");
  }

  public void payOneDrink()
  {
    Console.WriteLine ($"\nYou choose only one {firstDrink}");
      payAtCounter();
  }
  
  public void payTwoDrink()
  {
      Console.WriteLine ("\n#########################################");
    
    if (firstDrink == secondDrink) 
    {
        Console.WriteLine ($"\nYour choose two {firstDrink}");
    }
    else
    {
       Console.WriteLine ($"\nYour choose one {firstDrink} and one {secondDrink}");
    }
      payAtCounter();
    
  }
}
