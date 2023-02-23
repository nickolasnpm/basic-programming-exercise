using System;
using System.Linq;

class Program {

  string[] availableSeat = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
  
  public static string[] bookedSeat = new string[] {};
  public static bool isContinue = true;

  string? selectedSeat, displaySeatList, yesno, displayBookedSeat;
  
  public static void Main (string[] args) {

    Program repeat = new Program();
    
    Console.WriteLine ("\nChoose your seat");
    
    repeat.choosingSeat();
    
  }

  public void choosingSeat()
  {

    while (isContinue)
    {
      Console.WriteLine("\nThis is the available ticket\n\nYou can choose up to 3 seats only\n");
      seatList();
      Console.Write("\nI choose ..... ");
      selectedSeat = Console.ReadLine();

      switch(selectedSeat?.ToLower())
      {
      case "one":
      case "two":
      case "three":
      case "four":
      case "five":
      case "six":
      case "seven":
      case "eight":
      case "nine":
      case "ten":
        addToCart();
        break;

      default:
        Console.WriteLine("\nWrong Input. Please try again");
        choosingSeat();
        break;
      }
      continueConfirmation();
    }
    proceedToPayment();
  }

  public void seatList()
  {
      for (int i=0; i<availableSeat.Length; i++)
      {
        displaySeatList = availableSeat[i];
        Console.WriteLine($"\tSeat {displaySeatList}");
      }
  }

  public void addToCart()
  {

    // try any
    
    if(bookedSeat.Contains(selectedSeat))
    {
      Console.WriteLine("\nThe seat was already selected. Please select other");
      choosingSeat();
    }
    else
    {
      bookedSeat = bookedSeat.Append(selectedSeat).ToArray();
      Console.WriteLine($"\nSeat {selectedSeat} is added to the cart");
    }
    
  }

  public void continueConfirmation()
  {

    if (bookedSeat.Length < 3 )
    {
      Console.Write("\nDo you want to book another seat? [YES/NO] ");
      yesno = Console.ReadLine();
      isContinue = yesno?.ToLower() == "yes"? true: false;
    }
    else
    {
      Console.WriteLine("\nYou have reached the limit");
      isContinue = false;
    } 
  }

  public void proceedToPayment()
  {

    Console.WriteLine("\nThis is your booking");

    for (int i = 0; i<bookedSeat.Length; i++)
    {
      displayBookedSeat = bookedSeat[i];
      Console.WriteLine($"\n\tSEAT {displayBookedSeat}");
    }
    Console.WriteLine("\nPlease pay at the counter");
  }
}