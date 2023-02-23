using System;
using System.Linq;

class Program {

  public static bool isContinue = true;
  public static string[] productCart = new string[] {};

  string[] Decoration = {"vase", "table", "chair", "fan"};
  string[] Food = {"snack", "cake", "biscuit", "fruit"};
  
  string? selectedProduct, yesno, choosenCategory, productToBuy;
  
  public static void Main (string[] args) 
  {

    Program shopNow = new Program();
    
    Console.WriteLine ("\nHello Shoppers! Welcome to Nickolas Website");
    
    shopNow.homePage();

  }

  public void homePage ()
  {

    while (isContinue)
    {
      Console.WriteLine($"\nHere are our product:\n");
      decoList();
      foodList();
      Console.Write("\nCategory\n\nYour selection ......");
      selectedProduct = Console.ReadLine();
      
      switch(selectedProduct?.ToLower())
      {
      case "vase":
      case "table":
      case "chair":
      case "fan":
      case "snack":
      case "cake":
      case "biscuit":
      case "fruit":
        addedToCart();
        break;

      case "category":
        mainCategory();
        break;

      default:
        wrongInput();
        homePage();
        break;      
      }
      ContinueConfirmation();      
    }
    proceedToPayment();
  }

  public void mainCategory()
  {

    Console.Write("\nHere are our categories\n\n1. Decoration\n2. Food\n\nCancel\n\nYour selection ..... ");
    choosenCategory = Console.ReadLine();
    
    switch(choosenCategory?.ToLower()){

    case "decoration":
      decoCategory();
      break;

    case "food":
      foodCategory();
      break;

    default:
      wrongInput();
      homePage();
      break; 
    }
  }

  public void decoList ()
  {
    foreach (string decotypes in Decoration) 
    {
      Console.WriteLine(decotypes);
    }   
  }

  public void foodList ()
  {
    foreach (string foodtypes in Food)
    {
      Console.WriteLine(foodtypes);
    }
  }

  public void decoCategory()
  {
    while(isContinue)
    {
    Console.WriteLine($"\nHere are our deco products\n");
    decoList();
    Console.Write("\n\nYour selection ......");
    selectedProduct = Console.ReadLine();

    switch(selectedProduct?.ToLower())
    {
    case "vase":
    case "table":
    case "chair":
    case "fan":
      addedToCart();
      break;
    default:
      wrongInput();
      homePage();
      break;
    }
    ContinueConfirmation();
    }
    proceedToPayment();  
  }

  public void foodCategory()
  {
    while(isContinue){

    Console.Write($"\nHere are our food products\n");
    foodList();
    Console.Write("\n\nYour selection ......");
    selectedProduct = Console.ReadLine();

    switch(selectedProduct?.ToLower())
    {
    case "snack":
    case "cake":
    case "biscuit":
    case "fruit":
      addedToCart();
      break;
    default:
      wrongInput();
      homePage();
      break;
    }
    ContinueConfirmation();
    }
    proceedToPayment();
  }

  public void ContinueConfirmation()
  {
    if(productCart.Length < 3)
    {
      
      Console.Write("\nDo you add more product? [YES/NO]");
      yesno = Console.ReadLine();
      isContinue = yesno?.ToLower() == "yes"? true: false;
      
    }
    else
    {
      Console.WriteLine("\nYou have reached the limit");
      isContinue = false;
    }
  }

  public void addedToCart()
  {
    productCart = productCart.Append(selectedProduct).ToArray();
    Console.WriteLine($"\n{selectedProduct} is added to the cart");
  }

  public void wrongInput()
  {
    Console.WriteLine("\nYou enter the wrong input.Try again");
  }

  public void proceedToPayment()
  {
    Console.WriteLine("\nHere is your selection: ");

    for (int i = 0; i < productCart.Count(); i++)
        {
            productToBuy=productCart[i];
            int numbering=i+1;
            Console.WriteLine($"\n\t{numbering}. {productToBuy}");
        }
            Console.WriteLine("\nPlease pay at the counter");
  }
}

