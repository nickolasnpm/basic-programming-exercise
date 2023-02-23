using System;

class Program {
  
  string? itemTypes, selectRice, selectMeat, selectVege, selectFruit, selectDrink;
  double selectCash, ricePrice, meatPrice, vegePrice, fruitPrice, drinkPrice, totalPrice, balance;

  const double RICE_PRICE = 35.00, PULUT_PRICE = 10.00, BEEF_PRICE = 15.00, PORK_PRICE = 20.00, CUCUMBER_PRICE = 5.00, CABBAGE_PRICE = 6.00, APPLE_PRICE = 10.00, ORANGE_PRICE = 8.00, WINE_PRICE = 100.00, BEER_PRICE = 20.00;
  

  public static void Main (string[] args) {

    Program process = new Program();
    
    Console.WriteLine("\nWelcome to Mydin Supermarket");

    process.types();
    
  }

  public void types () {

    Console.Write("\nWhat do you want to buy?\n\n1. Rice\n\n2. Meat\n\n3. Vegetable\n\n4. Fruit\n\n5. Drink\n\nI would like to buy ..... ");
    itemTypes = Console.ReadLine();

  switch(itemTypes?.ToLower()){
    
  case "rice":
    rice();
    break;

  case "meat":
    meat();
    break;

  case "vegetable":
    vegetable();
    break;

  case "fruit":
    fruit();
    break;

  case "drink":
    drink();
    break;

  default:
    NoSuchItem();
    types();
    break;
  }
  }

  public void rice(){
    
    Console.Write("\nPlease select your Rice\n\n\tRice\n\n\tPulut\n\nYour Main: ");
    selectRice = Console.ReadLine();

    switch(selectRice?.ToLower()){
    case "rice":
      AddedToBasketMessage("Rice");
      break;

    case "pulut":
      AddedToBasketMessage("Pulut");
      break;

    default:
      NoSuchItem();
      rice();
      break;
    }

    NextStep();

  }

  public void meat(){

    Console.Write("\nPlease select your Meat\n\n\tBeef\n\n\tPork\n\nYour Meat: ");
    selectMeat = Console.ReadLine();

    switch(selectMeat?.ToLower()){
    case "beef":
      AddedToBasketMessage("Beef");
      break;

    case "pork":
      AddedToBasketMessage("Pork");
      break;

    default:
      NoSuchItem();
      meat();
      break;
    }
    
    NextStep();
    
  }

  public void vegetable(){

    Console.Write("\nPlease select your Vegetable\n\n\tCucumber\n\n\tCabbage\n\nYour Vegetable: ");
    selectVege = Console.ReadLine();

    switch(selectVege?.ToLower()){
    case "cucumber":
      AddedToBasketMessage("Cucumber");
      break;

    case "cabbage":
      AddedToBasketMessage("Cabbage");
      break;

    default:
      NoSuchItem();
      vegetable();
      break;
    }
    
    NextStep();

  }

  public void fruit(){

    Console.Write("\nPlease select your Fruit\n\n\tApple\n\n\tOrange\n\nYour Fruit: ");
    selectFruit = Console.ReadLine();

    switch(selectFruit?.ToLower()){
    case "apple":
      AddedToBasketMessage("Apple");
      break;

    case "orange":
      AddedToBasketMessage("Orange");
      break;

    default:
      NoSuchItem();
      fruit();
      break;
    }

    NextStep();
    
  }

  public void drink(){

    Console.Write("\nPlease select your Drink\n\n\tWine\n\n\tBeer\n\nYour Drink: ");
    selectDrink = Console.ReadLine();

    switch(selectDrink?.ToLower()){
    case "wine":
      AddedToBasketMessage("Wine");
      break;

    case "beer":
      AddedToBasketMessage("Beer");
      break;

    default:
      NoSuchItem();
      drink();
      break;
    }
    
    NextStep();
    
  }
  
  public void NextStep() {
  
  Console.Write("\nDo you want to add more item? YES or NO? ");
    string yesno = Console.ReadLine();

    switch(yesno?.ToLower()){
    case "yes":
        types();
      break;

    case "no":
        payment();
      break;
      
    default:
      Console.WriteLine ("\nYou enter the wrong input");
      NextStep();
      break;
        }
    }

    public void payment(){

    Console.WriteLine($"\nYou buy...... \n\n\t {selectRice}\n\n\t {selectMeat}\n\n\t {selectVege}\n\n\t {selectFruit}\n\n\t {selectDrink}");

    cash();
    
  }

  public void cash(){

    Console.Write("\nPlease hand out your cash\n\n\t1. 10\n\n\t2. 20\n\n\t3. 50\n\n\t4. 100\n\n\t5. 200\n\nMy cash choice: ");
    
    try
      {
        selectCash = int.Parse(Console.ReadLine());
        pay();
      }
        catch(System.FormatException)
      {
        Console.WriteLine("\n\nIncorrect format of the user's input");
        cash();
      }
    
  }

  public void pay(){
    
    totalPrice = ricePrice + meatPrice + vegePrice + fruitPrice + drinkPrice;
    balance = selectCash - totalPrice;

    if(selectCash<totalPrice){
      Console.WriteLine("\nNOT ENOUGH CASH!!!");
      cash();
    }else{
      receipt();
    }
  }

  public void AddedToBasketMessage(string item)
  {
     Console.WriteLine($"\n{item} is added into the basket\n");

    switch (item.ToLower()){
      
    case "rice":
      ricePrice = RICE_PRICE;
      break;

    case "pulut":
      ricePrice = PULUT_PRICE;
      break;

    case "beef":
      meatPrice = BEEF_PRICE;
      break;

    case "pork":
      meatPrice = PORK_PRICE;
      break;

    case "cucumber":
      vegePrice = CUCUMBER_PRICE;
      break;

    case "cabbage":
      vegePrice = CABBAGE_PRICE;
      break;

    case "apple":
      fruitPrice = APPLE_PRICE;
      break;

    case "orange":
      fruitPrice = ORANGE_PRICE;
      break;

    case "wine":
      drinkPrice = WINE_PRICE;
      break;

    case "beer":
      drinkPrice = BEER_PRICE;
      break;
      
    }
    
  }

  public void NoSuchItem(){
    Console.WriteLine("\nThere is no such item. Try again");
  }

  public void receipt(){

    {
    Console.WriteLine
      ("\n##########################################"
      +"\n\n\t\t\t\t\tMYDIN"
      +"\n\tMydin Mohammad Holdings Berhad"
      +"\nPasaraya Mydin, Bandar Baru Samariang"
      +"\n\t\tTel: 0123456789 Fax: 0123456789 "
      +"\n\t\t\t\t\tRECEIPT"
      
      +"\n\n------------------------------------------"
      +"\n\nDate:                   Today"
      +"\n\nCashier:                 Saya"
      +"\n\n------------------------------------------");

    Console.WriteLine 
      ($"\nItem                   Price"
      +$"\n\n{selectRice}                     {ricePrice}"
      +$"\n{selectMeat}                     {meatPrice}"
      +$"\n{selectVege}                  {vegePrice}"
      +$"\n{selectFruit}                    {fruitPrice}"
      +$"\n{selectDrink}                     {drinkPrice}");

    Console.WriteLine
      ($"\n------------------------------------------"
      +$"\n\nItem Count"
      +$"\n\nTotal                   RM {totalPrice}"
      +$"\nCash                    RM {selectCash}"
      +$"\n\n------------------------------------------"
      +$"\n\nCHANGE                  RM {balance}"
      +$"\n\n------------------------------------------"
      +$"\n\n##########################################");
      }
    }
}